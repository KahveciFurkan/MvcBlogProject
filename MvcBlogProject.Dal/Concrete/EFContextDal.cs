using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcBlogProject.Dal.Abstract;
using MvcBlogProject.Dal.Concrete.Context;
using MvcBlogProject.Dal.Concrete.Repositories.IdentityRepo;
using MvcBlogProject.Dal.Concrete.Repositories.StandartRepo;
using MvcBlogProject.Dal.Entities;
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
				string standartCon = "";
				opt.UseSqlServer(standartCon);
			})
				.AddDbContext<AppIdentityContext>(opt =>
				{
					string idenityCon = "";
					opt.UseSqlServer(idenityCon);
				})
				.AddScoped<IArticleRepo, ArticleRepo>()
				.AddScoped<IUserRepo, UserRepo>()
				.AddScoped<IRoleRepo, RoleRepo>();

			services.AddIdentityCore<AppUser>().AddRoles<AppRole>().AddEntityFrameworkStores<AppIdentityContext>();

			return services;
		}
	}
}
