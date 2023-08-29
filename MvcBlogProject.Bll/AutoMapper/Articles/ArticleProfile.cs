using AutoMapper;
using MvcBlogProject.Dal.Entities;
using MvcBlogProject.Shared.DTOs.Articles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcBlogProject.Bll.AutoMapper.Articles
{
    public class ArticleProfile : Profile
    {
        public ArticleProfile()
        {
            CreateMap<ArticleDto,Article>().ReverseMap();
            CreateMap<ArticleUpdateDto,Article>().ReverseMap();
            CreateMap<ArticleUpdateDto,ArticleDto>().ReverseMap();
            CreateMap<ArticleAddDto,Article>().ReverseMap();
        }
    }

}
