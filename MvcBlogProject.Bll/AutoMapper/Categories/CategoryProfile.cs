using AutoMapper;
using MvcBlogProject.Dal.Entities;
using MvcBlogProject.Shared.DTOs.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcBlogProject.Bll.AutoMapper.Categories
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<CategoryDto,Category>().ReverseMap();
            CreateMap<CategoryAddDto,Category>().ReverseMap();
            CreateMap<CategoryUpdateDto,Category>().ReverseMap();
        }
    }
}
