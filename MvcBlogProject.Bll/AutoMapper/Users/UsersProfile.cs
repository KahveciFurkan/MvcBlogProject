using AutoMapper;
using MvcBlogProject.Dal.Entities;
using MvcBlogProject.Shared.DTOs.Categories;
using MvcBlogProject.Shared.DTOs.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcBlogProject.Bll.AutoMapper.Users
{
    internal class UsersProfile : Profile
    {
        public UsersProfile()
        {
            CreateMap<AppUser,UserDto>().ReverseMap();
            CreateMap<AppUser,UserAddDto>().ReverseMap();
            CreateMap<AppUser,UserUpdateDto>().ReverseMap();
            CreateMap<AppUser,UserProfileDto>().ReverseMap();

        }
    
    }
}
