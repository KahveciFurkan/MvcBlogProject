using Microsoft.EntityFrameworkCore;
using MvcBlogProject.Dal.Configuration;
using MvcBlogProject.Dal.Entities;

namespace MvcBlogProject.Dal.Concrete.Context
{
    public class StandartContext :DbContext
	{
        public StandartContext()
        {
            
        }
        public StandartContext(DbContextOptions<StandartContext> opt) : base(opt) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ArticleConfig());
            modelBuilder.ApplyConfiguration(new CategoryConfig());
            modelBuilder.ApplyConfiguration(new ImageConfig());
                        
        }

        public virtual DbSet<Article> Articles { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Image> Images { get; set; }
    }
}
