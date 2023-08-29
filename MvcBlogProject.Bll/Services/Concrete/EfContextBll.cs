using Microsoft.Extensions.DependencyInjection;
using MvcBlog.Bll.Services.Concrete;
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
                .AddScoped<ICategoryService, CategoryService>();

            services.AddAutoMapper(assembly);

            return services;
        }
    }
}
