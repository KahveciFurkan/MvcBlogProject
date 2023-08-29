using MvcBlogProject.Dal.Entities;
using MvcBlogProject.Shared.DTOs.Articles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcBlogProject.Bll.Services.Abstract
{
    public interface IArticleService
    {
        Task<List<ArticleDto>> GetAllArticleWithCategoryNonDeletedAsync();
        Task CreateArticleAsync(ArticleAddDto articleAddDto);
    }
}
