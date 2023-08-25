using Microsoft.Extensions.DependencyInjection;
using MvcBlog.Bll.Services.Concrete;
using MvcBlogProject.Bll.Services.Abstract;
using MvcBlogProject.Dal.Concrete;

namespace MvcBlogProject.Bll.Services.Concrete
{
    public static class EfContextBll
    {
        public static IServiceCollection AddScopedBll(this IServiceCollection services)
        {
            services.AddScopedDAL()
                .AddScoped<IArticleService, ArticleService>();
            return services;
        }
    }
}
