using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcBlog.ResultMessages;
using MvcBlogProject.Bll.Helpers.Images;
using MvcBlogProject.Bll.Services.Abstract;
using MvcBlogProject.Dal.Entities;
using MvcBlogProject.Dal.Enums;
using MvcBlogProject.Dal.UnitOfWorks;
using MvcBlogProject.Shared.DTOs.Articles;
using MvcBlogProject.Shared.DTOs.Categories;
using MvcBlogProject.Shared.DTOs.Users;
using NToastNotify;
using System.Data;
using static MvcBlog.ResultMessages.Messages;

namespace MvcBlog.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserController : Controller
    {
        private readonly UserManager<AppUser> userManager;
        private readonly IUserService userService;
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;
        private readonly IImageHelper imageHelper;
        private readonly RoleManager<AppRole> roleManager;
        private readonly SignInManager<AppUser> signInManager;
        private readonly IToastNotification toastNotification;


        public UserController(UserManager<AppUser> userManager, IUserService userService, IMapper mapper, IUnitOfWork unitOfWork, IImageHelper imageHelper, RoleManager<AppRole> roleManager, SignInManager<AppUser> signInManager, IToastNotification toastNotification)
        {
            this.userManager = userManager;
            this.userService = userService;
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
            this.imageHelper = imageHelper;
            this.roleManager = roleManager;
            this.signInManager = signInManager;
            this.toastNotification = toastNotification;

        }
        public async Task<IActionResult> Index()
        {
            var result = await userService.GetAllUsersWithRoleAsync();
            return View(result);
        }
        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var roles = await userService.GetAllRolesAsync();
            return View(new UserAddDto { Roles = roles });
        }
        [HttpPost]
        public async Task<IActionResult> Add(UserAddDto userAddDto)
        {
            var map = mapper.Map<AppUser>(userAddDto);
            var roles = await userService.GetAllRolesAsync();
            if (ModelState.IsValid)
            {
                var result = await userService.CreateUserAsync(userAddDto);
                if (result.Succeeded)
                {
                    toastNotification.AddSuccessToastMessage(Messages.User.Add(userAddDto.Email));
                    return RedirectToAction("Index", "User", new { Area = "Admin" });
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                    return View(new UserAddDto { Roles = roles });
                }
            }
            return View(new UserAddDto { Roles = roles });
        }
        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            var user = await userService.GetAppUserByIdAsync(id);

            var roles = await userService.GetAllRolesAsync();

            var map = mapper.Map<UserUpdateDto>(user);
            map.Roles = roles;
            return View(map);
        }
        [HttpPost]
        public async Task<IActionResult> Update(UserUpdateDto userUpdateDto)
        {
            var user = await userService.GetAppUserByIdAsync(userUpdateDto.Id);
            if (user != null)
            {

                var roles = await userService.GetAllRolesAsync();
                if (ModelState.IsValid)
                {
                    mapper.Map(userUpdateDto, user);
                    user.UserName = userUpdateDto.Email;
                    user.SecurityStamp = Guid.NewGuid().ToString();
                    var result = await userService.UpdateUserAsync(userUpdateDto);
                    if (result.Succeeded)
                    {
                        toastNotification.AddSuccessToastMessage(Messages.User.Update(userUpdateDto.Email));
                        return RedirectToAction("Index", "User", new { Area = "Admin" });
                    }
                    else
                    {
                        foreach (var item in result.Errors)
                        {
                            ModelState.AddModelError("", item.Description);
                        }
                        return View(new UserUpdateDto { Roles = roles });
                    }
                }

            }

            return NotFound();
        }
        public async Task<IActionResult> Delete(int id)
        {

            var result = await userService.DeleteUserAsync(id);
            if (result.result.Succeeded)
            {
                toastNotification.AddSuccessToastMessage(Messages.User.Delete(result.email));
                return RedirectToAction("Index", "User", new { Area = "Admin" });
            }
            else
            {
                foreach (var item in result.result.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }

            }
            return NotFound();
        }
        [HttpGet]
        public async Task<IActionResult> Profile()
        {
            var profile = await userService.GetUserProfileAsync();
            return View(profile);
        }
        [HttpPost]
        public async Task<IActionResult> Profile(UserProfileDto userProfileDto)
        {
            if (ModelState.IsValid)
            {
                var result = await userService.UserProfileUpdateAsync(userProfileDto);
                if (result)
                {
                    toastNotification.AddSuccessToastMessage("Güncelleme işlemi tamamlandı");
                    return RedirectToAction("Index", "User", new { Area = "Admin" });
                }
                else
                {
                    var profile = await userService.GetUserProfileAsync();
                    toastNotification.AddErrorToastMessage("Güncelleme işlemi tamamlanamadı");
                    return View(profile);
                }
            }
            else
                return NotFound();
        }
    }
}
