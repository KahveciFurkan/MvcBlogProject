using Microsoft.EntityFrameworkCore;
using MvcBlogProject.Dal.Configuration;
using MvcBlogProject.Dal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MvcBlogProject.Dal.Concrete.Context
{
	public class StandartContext :DbContext
	{
        public StandartContext()
        {
            
        }
        public StandartContext(DbContextOptions<StandartContext> opt) : base(opt) { }

        public virtual DbSet<Article> Articles { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Image> Images { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ArticleConfig());
            modelBuilder.ApplyConfiguration(new CategoryConfig());
            modelBuilder.ApplyConfiguration(new ImageConfig());
                        
        }


    }
}
