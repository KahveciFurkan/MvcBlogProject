using AutoMapper;
using Microsoft.AspNetCore.Http;
using MvcBlogProject.Bll.FluentValidations;
using MvcBlogProject.Bll.Helpers.Images;
using MvcBlogProject.Bll.Services.Abstract;
using MvcBlogProject.Dal.Entities;
using MvcBlogProject.Dal.UnitOfWorks;
using MvcBlogProject.Shared.DTOs.Articles;
using MvcBlogProject.Shared.DTOs.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace MvcBlogProject.Bll.Services.Concrete
{
    internal class CategoryService : ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IImageHelper _imageHelper;
        private readonly ClaimsPrincipal _user;

        public CategoryService(IUnitOfWork unitOfWork,IMapper mapper, IHttpContextAccessor httpContextAccessor, IImageHelper imageHelper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
            _imageHelper = imageHelper;
            _user = httpContextAccessor.HttpContext.User;
        }
        public async Task<List<CategoryDto>> GetAllCategoriesNonDeleted()
        {
            var categories =await _unitOfWork.GetRepository<Category>().GetAllAsync(x=>!x.IsDeleted);
            var map = _mapper.Map<List<CategoryDto>>(categories);
            return map;
        }
        public async Task<string> CreateCategoryAsync(CategoryAddDto categoryAddDto)
        {
            var email = _user.GetLoggedInEmail();
            Category category = new Category()
            {
                Name = categoryAddDto.Name,
                CreatedBy = email
                
            };
            await _unitOfWork.GetRepository<Category>().AddAsync(category);
            await _unitOfWork.SaveAsync();
            return category.Name;
        }
        public async Task<Category> GetCategoryById(int id)
        {
            var category = await _unitOfWork.GetRepository<Category>().GetByIdAsync(id);
            return category;
        }
        public async Task<string> UpdateCategoryAsync(CategoryUpdateDto categoryUpdateDto)
        {
            var email = _user.GetLoggedInEmail();
            var category = await _unitOfWork.GetRepository<Category>().GetAsync(x => !x.IsDeleted && x.Id == categoryUpdateDto.Id);
            
            category.Name = categoryUpdateDto.Name;
            category.ModifiedBy = email;
            category.ModifiedDate = DateTime.Now;


            await _unitOfWork.GetRepository<Category>().UpdateAsync(category);
            await _unitOfWork.SaveAsync();

            return category.Name;
            return category.Name;
        }

        public async Task<string> SafeDeleteArticleAsync(int id)
        {
            var category = await _unitOfWork.GetRepository<Category>().GetByIdAsync(id);
            category.IsDeleted = true;
            category.DeletedDate = DateTime.Now;
            category.DeletedBy = _user.GetLoggedInEmail();

            await _unitOfWork.GetRepository<Category>().UpdateAsync(category);
            await _unitOfWork.SaveAsync();
            return category.Name;
        }
    }
}
