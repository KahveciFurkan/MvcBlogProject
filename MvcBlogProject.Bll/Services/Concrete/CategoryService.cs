using AutoMapper;
using MvcBlogProject.Bll.Services.Abstract;
using MvcBlogProject.Dal.Entities;
using MvcBlogProject.Dal.UnitOfWorks;
using MvcBlogProject.Shared.DTOs.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcBlogProject.Bll.Services.Concrete
{
    internal class CategoryService : ICategoryService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public CategoryService(IUnitOfWork unitOfWork,IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public async Task<List<CategoryDto>> GetAllCategoriesNonDeleted()
        {
            var categories =await unitOfWork.GetRepository<Category>().GetAllAsync(x=>!x.IsDeleted);
            var map = mapper.Map<List<CategoryDto>>(categories);
            return map;
        }
    }
}
