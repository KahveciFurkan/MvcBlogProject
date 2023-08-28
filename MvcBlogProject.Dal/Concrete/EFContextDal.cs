using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcBlogProject.Dal.Abstract;
using MvcBlogProject.Dal.Concrete.Context;
using MvcBlogProject.Dal.Concrete.Repositories.IdentityRepo;
using MvcBlogProject.Dal.Concrete.Repositories.StandartRepo;
using MvcBlogProject.Dal.Entities;
using MvcBlogProject.Dal.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcBlogProject.Dal.Concrete
{
	public static class EFContextDal
	{
		public static IServiceCollection AddScopedDAL(this IServiceCollection services)
		{
			services.AddDbContext<StandartContext>(opt =>
			{
				string standartCon = "Server=DESKTOP-JM5LJD8\\SQL2022;Database=MvcBlogDb;Trusted_Connection = True";
				opt.UseSqlServer(standartCon).UseLazyLoadingProxies();
			});
			services.AddDbContext<AppIdentityContext>(opt =>
				{
					string idenityCon = "Server=DESKTOP-JM5LJD8\\SQL2022;Database=MvcBlogIdentityDb;Trusted_Connection = True";
					opt.UseSqlServer(idenityCon).UseLazyLoadingProxies();
				})
				.AddScoped<IUnitOfWork,UnitOfWork>()
				.AddScoped<IArticleRepo, ArticleRepo>()
				.AddScoped<IUserRepo, UserRepo>()
				.AddScoped<IRoleRepo, RoleRepo>();

			services.AddIdentityCore<AppUser>().AddRoles<AppRole>().AddEntityFrameworkStores<AppIdentityContext>();

			return services;
		}
	}
}
