using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MvcBlogProject.Dal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcBlogProject.Dal.Configuration
{
	public class UserConfig : IEntityTypeConfiguration<AppUser>
	{
		public void Configure(EntityTypeBuilder<AppUser> builder)
		{
            builder.HasKey(u => u.Id);

          
            // Indexes for "normalized" username and email, to allow efficient lookups
            builder.HasIndex(u => u.NormalizedUserName).HasName("UserNameIndex").IsUnique();
            builder.HasIndex(u => u.NormalizedEmail).HasName("EmailIndex");

            // Maps to the AspNetUsers table
            builder.ToTable("AspNetUsers");


            builder.Property(u => u.ConcurrencyStamp).IsConcurrencyToken();

            builder.Property(u => u.UserName).HasMaxLength(100);
            builder.Property(u => u.NormalizedUserName).HasMaxLength(256);
            builder.Property(u => u.Email).HasMaxLength(100);
            builder.Property(u => u.NormalizedEmail).HasMaxLength(256);


            builder.HasMany<IdentityUserRole<int>>().WithOne().HasForeignKey(ur => ur.UserId).IsRequired();

            //builder.HasMany(x => x.Articles)
            //       .WithOne(x => x.User)
            //       .HasForeignKey(x => x.UserId)
            //       .OnDelete(DeleteBehavior.Cascade);

            //builder.HasOne(x => x.Image)
            //       .WithMany(x => x.Users)
            //       .HasForeignKey(x => x.ImageId)
            //       .OnDelete(DeleteBehavior.Cascade);

            var superadmin = new AppUser
            {
                Id = 1,
                UserName = "superadmin@gmail.com",
                NormalizedEmail = "SUPERADMIN@GMAIL.COM",
                Email = "superadmin@gmail.com",
                NormalizedUserName = "SUPERADMIN@GMAIL.COM",
                PhoneNumber = "1234567890",
                FirstName = "Eren",
                LastName = "Kartal",
                ImageId = 1,
                PhoneNumberConfirmed = true,
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString()
                
            };
            superadmin.PasswordHash = CreatePasswordHash(superadmin, "123456");

            var admin = new AppUser
            {
                Id = 2,
                UserName = "admin@gmail.com",
                NormalizedEmail = "ADMIN@GMAIL.COM",
                Email = "admin@gmail.com",
                NormalizedUserName = "ADMIN@GMAIL.COM",
                PhoneNumber = "1234567870",
                FirstName = "Umut",
                LastName = "Öncel",
                ImageId = 2,
                PhoneNumberConfirmed = false,
                EmailConfirmed = false,
                SecurityStamp = Guid.NewGuid().ToString()
            };
            admin.PasswordHash = CreatePasswordHash(admin, "123456");

            builder.HasData(superadmin, admin);
        }
        private string CreatePasswordHash(AppUser user,string password)
        {
            var psHasher = new PasswordHasher<AppUser>();
            return psHasher.HashPassword(user, password);
        }
	}
}
