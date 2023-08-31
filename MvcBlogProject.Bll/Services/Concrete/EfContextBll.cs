using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using MvcBlog.Bll.Services.Concrete;
using MvcBlogProject.Bll.FluentValidations;
using MvcBlogProject.Bll.Helpers.Images;
using MvcBlogProject.Bll.Services.Abstract;
using MvcBlogProject.Dal.Concrete;
using System.Reflection;

namespace MvcBlogProject.Bll.Services.Concrete
{
    public static class EfContextBll
    {
        public static IServiceCollection AddScopedBll(this IServiceCollection services)
        {
            var assembly = Assembly.GetExecutingAssembly();


            services.AddScopedDAL()
                .AddScoped<IArticleService, ArticleService>()
                .AddScoped<ICategoryService, CategoryService>()
                .AddScoped<IUserService, UserService>()
                .AddScoped<IImageHelper, ImageHelper>()
                .AddSingleton<IHttpContextAccessor,HttpContextAccessor>();

            services.AddAutoMapper(assembly);

            services.AddControllersWithViews().AddFluentValidation(opt =>
            {
                opt.RegisterValidatorsFromAssemblyContaining<ArticleValidator>();
                opt.DisableDataAnnotationsValidation = true;
                opt.ValidatorOptions.LanguageManager.Culture = new System.Globalization.CultureInfo("tr");
            });

            return services;
        }
    }
}
