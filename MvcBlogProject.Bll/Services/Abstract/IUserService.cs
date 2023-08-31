using Microsoft.AspNetCore.Identity;
using MvcBlogProject.Dal.Entities;
using MvcBlogProject.Shared.DTOs.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcBlogProject.Bll.Services.Abstract
{
    public interface IUserService
    {
        Task<List<UserDto>> GetAllUsersWithRoleAsync(); 
        Task<List<AppRole>> GetAllRolesAsync();
        Task<IdentityResult> CreateUserAsync(UserAddDto userAddDto);
        Task<IdentityResult> UpdateUserAsync(UserUpdateDto userUpdateDto);
        Task<(IdentityResult result,string? email)> DeleteUserAsync(int id);

        Task<AppUser> GetAppUserByIdAsync(int id);
        Task<string> GetUserRoleAsync(AppUser user);

        Task<UserProfileDto> GetUserProfileAsync();
        Task<bool> UserProfileUpdateAsync(UserProfileDto userProfileDto);
    }
}
