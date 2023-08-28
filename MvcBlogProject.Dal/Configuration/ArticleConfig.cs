using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MvcBlogProject.Dal.Entities;

namespace MvcBlogProject.Dal.Configuration
{
    public class ArticleConfig : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x=>x.Id)
                   .IsRequired()
                   .UseIdentityColumn(1,1);

            builder.Property(x => x.ArticleName)
                   .IsRequired()
                   .HasMaxLength(80);

            builder.Property(x => x.Content)
                   .IsRequired()
                   .HasMaxLength(400);

            builder.HasOne(x => x.Category)
                   .WithMany(x => x.Articles)
                   .HasForeignKey(x => x.CategoryId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(x => x.Image)
                   .WithMany(x => x.Articles)
                   .HasForeignKey(x => x.ImageId);


            //builder.HasOne(x => x.User)
            //       .WithMany(x => x.Articles)
            //       .HasForeignKey(x => x.UserId)
            //       .OnDelete(DeleteBehavior.Cascade);

            builder.HasData(new Article
            {
                Id = 1,
                ArticleName = "THİS",
                Content = "There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable. If you are going to use a passage of Lorem Ipsum, you need to be sure there isn't anything embarrassing hidden in the middle of text.",
                ViewCount = 15,
                UserId = 1,
                CategoryId = 1,
                ImageId = 1,
                CreatedBy = "Admin",
                CreatedDate = DateTime.Now,
            },
            new Article
            {
                Id = 2,
                ArticleName = "IS",
                Content = "There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable. If you are going to use a passage of Lorem Ipsum, you need to be sure there isn't anything embarrassing hidden in the middle of text.",
                ViewCount = 10,
                UserId = 2,
                CategoryId = 1,
                ImageId = 1,
                CreatedBy = "Admin",
                CreatedDate = DateTime.Now,
            },
            new Article
            {
                Id = 3,
                ArticleName = "MINE",
                Content = "There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable. If you are going to use a passage of Lorem Ipsum, you need to be sure there isn't anything embarrassing hidden in the middle of text.",
                ViewCount = 10,
                UserId = 2,
                CategoryId = 1,
                ImageId = 1,
                CreatedBy = "Admin",
                CreatedDate = DateTime.Now,
            });
        }
    }
}
