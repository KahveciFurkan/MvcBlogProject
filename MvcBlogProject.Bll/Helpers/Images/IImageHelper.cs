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
    public interface IImageHelper
    {
        Task<ImageUploadedDto> Upload(string name, IFormFile formFile,ImageType imageType ,string folderName = null);
        void Delete(string imagename);
    }
}
