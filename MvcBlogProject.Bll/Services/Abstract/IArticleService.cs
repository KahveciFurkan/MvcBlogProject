﻿using MvcBlogProject.Dal.Entities;
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
        Task<List<ArticleDto>> GetAllDeletedArticles();
        Task CreateArticleAsync(ArticleAddDto articleAddDto);
        Task<ArticleDto> GetArticleWithCategoryNonDeletedAsync(int id);
        Task<string> UpdateArticleAsync(ArticleUpdateDto articleUpdateDto);
        Task<string> SafeDeleteArticleAsync(int id);
        Task<string> UndoDeleteArticleAsync(int id);
        Task<ArticleListDto> GetAllByPagingAsync(int? categoryId, int currentpage = 1, int pageSize = 3, bool isAscending = false);
    }
}
