using Microsoft.AspNetCore.Identity;
using MvcBlogProject.Dal.Abstract;
using MvcBlogProject.Dal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcBlogProject.Dal.Concrete.Repositories.IdentityRepo
{
	public class RoleRepo : IRoleRepo
	{
		private readonly RoleManager<AppRole> _roleManager;
        public RoleRepo(RoleManager<AppRole> roleManager)
        {
            _roleManager = roleManager;
        }
        public async Task Create(AppRole entity)
		{
			await _roleManager.CreateAsync(entity);
		}

		public async Task Delete(AppRole entity)
		{
			await _roleManager.DeleteAsync(entity);
		}

		public async Task<IEnumerable<AppRole>> GetAll()
		{
			return _roleManager.Roles.ToList();
		}

		public async Task<AppRole> GetByIdAsync(int id)
		{
			return await _roleManager.FindByIdAsync(id.ToString());
		}

		public async Task Update(AppRole entity)
		{
			await _roleManager.UpdateAsync(entity);
		}
	}
}
