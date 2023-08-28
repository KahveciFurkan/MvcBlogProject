
using AutoMapper;
using MvcBlogProject.Bll.Services.Abstract;
using MvcBlogProject.Dal.Entities;
using MvcBlogProject.Dal.UnitOfWorks;
using MvcBlogProject.Shared.DTOs.Articles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcBlog.Bll.Services.Concrete
{
    public class ArticleService : IArticleService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper mapper;

        public ArticleService(IUnitOfWork unitOfWork,IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public async Task<List<ArticleDto>> GetAllArticleAsync()
        {
            var articles = await _unitOfWork.GetRepository<Article>().GetAllAsync();
            var map = mapper.Map<List<ArticleDto>>(articles);
            return map;

        }
    }
}
