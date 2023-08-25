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
	public class UserRepo : IUserRepo
	{
		private readonly UserManager<AppUser> _userManager;
        public UserRepo(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        public async Task Create(AppUser entity)
		{
			await _userManager.CreateAsync(entity);
		}

		public async Task Delete(AppUser entity)
		{
			await _userManager.DeleteAsync(entity);
		}

		public async Task<IEnumerable<AppUser>> GetAll()
		{
			return _userManager.Users.ToList();
		}

		public async Task<AppUser> GetByIdAsync(int id)
		{
			
			return await _userManager.FindByIdAsync(id.ToString());
		}

		public async Task Update(AppUser entity)
		{
			await _userManager.UpdateAsync(entity);
		}
	}
}
