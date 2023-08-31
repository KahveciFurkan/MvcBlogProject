using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MvcBlogProject.Bll.FluentValidations;
using MvcBlogProject.Bll.Helpers.Images;
using MvcBlogProject.Bll.Services.Abstract;
using MvcBlogProject.Dal.Entities;
using MvcBlogProject.Dal.Enums;
using MvcBlogProject.Dal.UnitOfWorks;
using MvcBlogProject.Shared.DTOs.Users;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace MvcBlogProject.Bll.Services.Concrete
{
    public class UserService : IUserService
    {
        private readonly IMapper mapper;
        private readonly IHttpContextAccessor httpContext;
        private readonly IUnitOfWork unitOfWork;
        private readonly UserManager<AppUser> userManager;
        private readonly RoleManager<AppRole> roleManager;
        private readonly SignInManager<AppUser> signInManager;
        private readonly IImageHelper imageHelper;
        private readonly ClaimsPrincipal _user;

        public UserService(IMapper mapper, IHttpContextAccessor httpContext, IUnitOfWork unitOfWork, UserManager<AppUser> userManager, RoleManager<AppRole> roleManager, SignInManager<AppUser> signInManager, IImageHelper imageHelper)
        {
            this.mapper = mapper;
            this.httpContext = httpContext;
            this.unitOfWork = unitOfWork;
            this.userManager = userManager;
            this.roleManager = roleManager;
            this.signInManager = signInManager;
            this.imageHelper = imageHelper;
            _user = httpContext.HttpContext.User;
        }

        public async Task<IdentityResult> CreateUserAsync(UserAddDto userAddDto)
        {
            var map = mapper.Map<AppUser>(userAddDto);
            map.UserName = userAddDto.Email;
            var result = await userManager.CreateAsync(map, string.IsNullOrEmpty(userAddDto.Password) ? "" : userAddDto.Password);
            if (result.Succeeded)
            {
                var findrole = await roleManager.FindByIdAsync(userAddDto.RoleId.ToString());
                await userManager.AddToRoleAsync(map, findrole.ToString());
                return result;
            }
            else
            {
                return result;
            }

        }

        public async Task<(IdentityResult result, string? email)> DeleteUserAsync(int id)
        {
            var user = await GetAppUserByIdAsync(id);
            var result = await userManager.DeleteAsync(user);
            if (result.Succeeded)
            {
                return (result, user.Email);
            }
            else { return (result, null); }
        }

        public async Task<List<AppRole>> GetAllRolesAsync()
        {
            return await roleManager.Roles.ToListAsync();
        }

        public async Task<List<UserDto>> GetAllUsersWithRoleAsync()
        {
            var users = await userManager.Users.ToListAsync();
            var map = mapper.Map<List<UserDto>>(users);

            foreach (var item in map)
            {
                var finduser = await userManager.FindByIdAsync(item.Id.ToString());
                var role = string.Join("", await userManager.GetRolesAsync(finduser));

                item.Role = role;
            }
            return map;
        }

        public async Task<AppUser> GetAppUserByIdAsync(int id)
        {
            return await userManager.FindByIdAsync(id.ToString());
        }

        public async Task<UserProfileDto> GetUserProfileAsync()
        {


            var userId = _user.GetLoggedInUserId();

            var user = await GetAppUserByIdAsync(userId); //giriş yapan kullanıcıyı çektik

            var map = mapper.Map<UserProfileDto>(user); //user ı UserProfileDTO ya eşledik



            return map;
            //var userId = _user.GetLoggedInUserId();
            //var user = await GetAppUserByIdAsync(userId);
            //var getUserWithImage = await unitOfWork.GetRepositoryApp<AppUser>.GetAsync(x => x.Id == userId/*,x=>x.image*/);
            //var map = mapper.Map<UserProfileDto>(getUserWithImage);
            ////map.Image.FileName = getUserWithImage.Image.FileName;

        }

        public async Task<string> GetUserRoleAsync(AppUser user)
        {
            return string.Join("", await userManager.GetRolesAsync(user));
        }

        public async Task<IdentityResult> UpdateUserAsync(UserUpdateDto userUpdateDto)
        {
            var user = await GetAppUserByIdAsync(userUpdateDto.Id);
            var userRole = await GetUserRoleAsync(user);
            var result = await userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                await userManager.RemoveFromRoleAsync(user, userRole);
                var findrole = await roleManager.FindByIdAsync(userUpdateDto.RoleId.ToString());
                await userManager.AddToRoleAsync(user, findrole.Name);
                return result;
            }
            else
                return result;
        }
        private async Task<int> UploadImageForUser(UserProfileDto userProfileDto)
        {
            var userEmail = _user.GetLoggedInEmail();
            var imageUpload = await imageHelper.Upload($"{userProfileDto.FirstName}{userProfileDto.LastName}", userProfileDto.photo, ImageType.User);
            Image image = new Image()
            {
                FileName = imageUpload.FullName,
                FileType = userProfileDto.photo.ContentType,
                CreatedBy = userEmail
            };
            await unitOfWork.GetRepository<Image>().AddAsync(image);

            return image.Id;
        }
        public async Task<bool> UserProfileUpdateAsync(UserProfileDto userProfileDto)
        {
            var userId = _user.GetLoggedInUserId();
            var user = await GetAppUserByIdAsync(userId);

            var isverified = await userManager.CheckPasswordAsync(user, userProfileDto.CurrentPassword);
            if (isverified && userProfileDto.NewPassword != null)
            {
                var result = await userManager.ChangePasswordAsync(user, userProfileDto.CurrentPassword, userProfileDto.NewPassword);
                if (result.Succeeded)
                {
                    await userManager.UpdateSecurityStampAsync(user);
                    await signInManager.SignOutAsync();
                    await signInManager.PasswordSignInAsync(user, userProfileDto.NewPassword, true, false);

                    mapper.Map(userProfileDto, user);
                    if (userProfileDto.photo != null)
                    {
                        user.ImageId = await UploadImageForUser(userProfileDto);
                    }


                    await userManager.UpdateAsync(user);
                    await unitOfWork.SaveAsync();

                    return true;
                }
                else
                {
                    return false;
                }

            }
            else if (isverified)
            {
                await userManager.UpdateSecurityStampAsync(user);
                mapper.Map(userProfileDto, user);

                if (userProfileDto.photo != null)
                {
                    user.ImageId = await UploadImageForUser(userProfileDto);
                }
                await userManager.UpdateAsync(user);
                await unitOfWork.SaveAsync();

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
