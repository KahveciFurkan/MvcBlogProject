
using AutoMapper;
using Microsoft.AspNetCore.Http;
using MvcBlogProject.Bll.FluentValidations;
using MvcBlogProject.Bll.Helpers.Images;
using MvcBlogProject.Bll.Services.Abstract;
using MvcBlogProject.Dal.Entities;
using MvcBlogProject.Dal.Enums;
using MvcBlogProject.Dal.UnitOfWorks;
using MvcBlogProject.Shared.DTOs.Articles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace MvcBlog.Bll.Services.Concrete
{
    public class ArticleService : IArticleService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper mapper;
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly IImageHelper imageHelper;
        private readonly ClaimsPrincipal _user;

        public ArticleService(IUnitOfWork unitOfWork,IMapper mapper,IHttpContextAccessor httpContextAccessor,IImageHelper imageHelper)
        {
            _unitOfWork = unitOfWork;
            this.mapper = mapper;
            this.httpContextAccessor = httpContextAccessor;
            this.imageHelper = imageHelper;
            _user = httpContextAccessor.HttpContext.User;
        }

        public async Task CreateArticleAsync(ArticleAddDto articleAddDto)
        {

            var imageUpload = await imageHelper.Upload(articleAddDto.ArticleName, articleAddDto.photo, ImageType.Post);
            Image image = new Image()
            {
                FileName=imageUpload.FullName,
                FileType=articleAddDto.photo.ContentType,
                CreatedBy=_user.GetLoggedInEmail()
            };
            await _unitOfWork.GetRepository<Image>().AddAsync(image);


            var article = new Article()
            {
                UserId= _user.GetLoggedInUserId(),
                ArticleName = articleAddDto.ArticleName,
                Content = articleAddDto.Content,
                CategoryId = articleAddDto.CategoryId,
                Image=image,
                ImageId=image.Id,
                CreatedBy = _user.GetLoggedInEmail()
                
            };

            await _unitOfWork.GetRepository<Article>().AddAsync(article);
            await _unitOfWork.SaveAsync();
        }

        public async Task<List<ArticleDto>> GetAllArticleWithCategoryNonDeletedAsync()
        {
            var articles = await _unitOfWork.GetRepository<Article>().GetAllAsync(x=>!x.IsDeleted,x=>x.Category);
            var map = mapper.Map<List<ArticleDto>>(articles);
            return map;

        }
        public async Task<ArticleDto> GetArticleWithCategoryNonDeletedAsync(int id)
        {
            var article = await _unitOfWork.GetRepository<Article>().GetAsync(x => !x.IsDeleted && x.Id ==id, x => x.Category,i=>i.Image);
            var map = mapper.Map<ArticleDto>(article);
            return map;

        }
        public async Task<string> UpdateArticleAsync(ArticleUpdateDto articleUpdateDto)
        { 
            var email = _user.GetLoggedInEmail();
            var article = await _unitOfWork.GetRepository<Article>().GetAsync(x => !x.IsDeleted && x.Id == articleUpdateDto.Id, x => x.Category);


            if(articleUpdateDto.photo != null)
            {
                imageHelper.Delete(articleUpdateDto.photo.FileName);

                var imageUpload = await imageHelper.Upload(articleUpdateDto.ArticleName, articleUpdateDto.photo, ImageType.Post);
                Image image = new Image()
                {
                    FileName=imageUpload.FullName,
                    FileType=articleUpdateDto.photo.ContentType,
                    ModifiedBy=email
                };
                await _unitOfWork.GetRepository<Image>().AddAsync(image);
                article.ImageId = image.Id;
                article.Image = image;
            }
            
            article.ArticleName = articleUpdateDto.ArticleName;
            article.Content = articleUpdateDto.Content;
            //if(article.Image == null)
            //{
            //    article.Image = articleUpdateDto.Image;
            //}           
            article.CategoryId = articleUpdateDto.CategoryId;            
            article.ModifiedDate = DateTime.Now;
            article.ModifiedBy = email;

            await _unitOfWork.GetRepository<Article>().UpdateAsync(article);
            await _unitOfWork.SaveAsync();

            return article.ArticleName;
        }
        public async Task<string> SafeDeleteArticleAsync(int id)
        {
            var article = await _unitOfWork.GetRepository<Article>().GetByIdAsync(id);
            article.IsDeleted = true;
            article.DeletedDate = DateTime.Now;
            article.DeletedBy=_user.GetLoggedInEmail();

            await _unitOfWork.GetRepository<Article>().UpdateAsync(article);
            await _unitOfWork.SaveAsync();
            return article.ArticleName;
        }

        public async Task<List<ArticleDto>> GetAllDeletedArticles()
        {
            var articles = await _unitOfWork.GetRepository<Article>().GetAllAsync(x => x.IsDeleted, x => x.Category);
            var map = mapper.Map<List<ArticleDto>>(articles);
            return map;
        }

        public async Task<string> UndoDeleteArticleAsync(int id)
        {
            var article = await _unitOfWork.GetRepository<Article>().GetByIdAsync(id);
            article.IsDeleted = false;
            article.DeletedDate = null;
            article.DeletedBy = null;

            await _unitOfWork.GetRepository<Article>().UpdateAsync(article);
            await _unitOfWork.SaveAsync();
            return article.ArticleName;
        }
    }
}
