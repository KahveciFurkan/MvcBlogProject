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
	public class UserRoleConfig : IEntityTypeConfiguration<IdentityUserRole<int>>
	{
		public void Configure(EntityTypeBuilder<IdentityUserRole<int>> builder)
		{
            builder.HasKey(r => new { r.UserId, r.RoleId });

            // Maps to the AspNetUserRoles table
            builder.ToTable("AspNetUserRoles");

			builder.HasData(new IdentityUserRole<int>
			{
				UserId = 1,
				RoleId = 1
			},
			new IdentityUserRole<int>
			{
				UserId = 2,
				RoleId = 2
			});
		}
	}
}
