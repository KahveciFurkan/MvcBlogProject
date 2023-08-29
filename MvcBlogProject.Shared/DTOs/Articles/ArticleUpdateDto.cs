using Microsoft.AspNetCore.Http;
using MvcBlogProject.Dal.Entities;
using MvcBlogProject.Shared.DTOs.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcBlogProject.Shared.DTOs.Articles
{
    public class ArticleUpdateDto
    {
        public int Id { get; set; }
        public string ArticleName { get; set; }
        public string Content { get; set; }
        public int CategoryId { get; set; }
        public Image Image { get; set; }
        public IFormFile? photo { get; set; }
        public IList<CategoryDto> Categories { get; set; }
    }
}
