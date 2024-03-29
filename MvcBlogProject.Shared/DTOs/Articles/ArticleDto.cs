﻿using MvcBlogProject.Dal.Entities;
using MvcBlogProject.Shared.DTOs.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcBlogProject.Shared.DTOs.Articles
{
    public class ArticleDto
    {
        public int Id { get; set; }
        public string ArticleName { get; set; }
        public string Content { get; set; }
        public CategoryDto Category { get; set; }
        public Image Image { get; set; }
        public int? ViewCount { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public bool IsDeleted { get; set; }
    }
}
