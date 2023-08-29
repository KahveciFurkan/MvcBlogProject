using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using MvcBlogProject.Dal.Enums;
using MvcBlogProject.Shared.DTOs.Images;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcBlogProject.Bll.Helpers.Images
{
    public class ImageHelper : IImageHelper
    {
        private readonly string wwwroot;
        private readonly IWebHostEnvironment env;
        private const string imgFolder = "images";
        private const string articleImagesFolder = "article-images";
        private const string UsersImageFolder = "user-images";

        public ImageHelper(IWebHostEnvironment env)
        {
            this.env = env;
            wwwroot = env.WebRootPath;
        }
        private string ReplaceInvalidChars(string fileName)
        {
            return fileName.Replace("İ", "I")
                 .Replace("ı", "i")
                 .Replace("Ğ", "G")
                 .Replace("ğ", "g")
                 .Replace("Ü", "U")
                 .Replace("ü", "u")
                 .Replace("ş", "s")
                 .Replace("Ş", "S")
                 .Replace("Ö", "O")
                 .Replace("ö", "o")
                 .Replace("Ç", "C")
                 .Replace("ç", "c")
                 .Replace("é", "")
                 .Replace("!", "")
                 .Replace("'", "")
                 .Replace("^", "")
                 .Replace("+", "")
                 .Replace("%", "")
                 .Replace("/", "")
                 .Replace("(", "")
                 .Replace(")", "")
                 .Replace("=", "")
                 .Replace("?", "")
                 .Replace("_", "")
                 .Replace("*", "")
                 .Replace("æ", "")
                 .Replace("ß", "")
                 .Replace("@", "")
                 .Replace("€", "")
                 .Replace("<", "")
                 .Replace(">", "")
                 .Replace("#", "")
                 .Replace("$", "")
                 .Replace("½", "")
                 .Replace("{", "")
                 .Replace("[", "")
                 .Replace("]", "")
                 .Replace("}", "")
                 .Replace(@"\", "")
                 .Replace("|", "")
                 .Replace("~", "")
                 .Replace("¨", "")
                 .Replace(",", "")
                 .Replace(";", "")
                 .Replace("`", "")
                 .Replace(".", "")
                 .Replace(":", "")
                 .Replace(" ", "");
        }
        public void Delete(string imagename)
        {
            var fileToDelete = Path.Combine($"{wwwroot}/{imgFolder}/{imagename}");
            if (File.Exists(fileToDelete))
            {
                File.Delete(fileToDelete);
            }
        }

        public async Task<ImageUploadedDto> Upload(string name, IFormFile formFile,ImageType imageType ,string folderName = null)
        {
            folderName ??= imageType == ImageType.User ? UsersImageFolder : articleImagesFolder;

            if(!Directory.Exists($"{wwwroot}/{imgFolder}/{folderName}"))
            {
                Directory.CreateDirectory($"{wwwroot}/{imgFolder}/{folderName}");
            }
               

            string oldFileName =Path.GetFileNameWithoutExtension(formFile.FileName);
            string fileExtension = Path.GetExtension(formFile.FileName);

            name = ReplaceInvalidChars(name);

            DateTime dateTime = DateTime.Now;

            string newFileName = $"{name}_{dateTime.Millisecond}{fileExtension}";

            var path = Path.Combine($"{wwwroot}/{imgFolder}/{folderName}", newFileName);

            await using var stream = new FileStream(path,FileMode.Create,FileAccess.Write,FileShare.None,1024*1024,useAsync:false);
            await formFile.CopyToAsync(stream);
            await stream.FlushAsync();

            string message = imageType == ImageType.User
                ? $"{newFileName} isimli kullanıcı resmi başarı ile eklemiştir."
                : $"{newFileName} isimli makale resmi başarı ile eklemiştir.";

            return new ImageUploadedDto()
            {
                FullName = $"{folderName}/{newFileName}"
            };
        }
    }
}
