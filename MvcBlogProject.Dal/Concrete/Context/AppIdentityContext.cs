using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MvcBlogProject.Dal.Configuration;
using MvcBlogProject.Dal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace MvcBlogProject.Dal.Concrete.Context
{
	public class AppIdentityContext : IdentityDbContext<AppUser,AppRole,int>
	{
        public AppIdentityContext(DbContextOptions<AppIdentityContext> opt) : base(opt) 
        {
            
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

	}
}
