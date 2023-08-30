using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcBlog.ResultMessages;
using MvcBlogProject.Dal.Entities;
using MvcBlogProject.Shared.DTOs.Categories;
using MvcBlogProject.Shared.DTOs.Users;
using NToastNotify;
using System.Data;

namespace MvcBlog.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserController : Controller
    {
        private readonly UserManager<AppUser> userManager;
        private readonly IMapper mapper;
        private readonly RoleManager<AppRole> roleManager;
        private readonly IToastNotification toastNotification;

        public UserController(UserManager<AppUser> userManager,IMapper mapper,RoleManager<AppRole> roleManager, IToastNotification toastNotification)
        {
            this.userManager = userManager;
            this.mapper = mapper;
            this.roleManager = roleManager;
            this.toastNotification = toastNotification;
        }
        public async Task<IActionResult> Index()
        {
            var users = await userManager.Users.ToListAsync();
            var map = mapper.Map<List<UserDto>>(users);

            foreach (var item in map)
            {
                var finduser = await userManager.FindByIdAsync(item.Id.ToString());
                var role = string.Join("", await userManager.GetRolesAsync(finduser));

                item.Role = role;
            }
            return View(map);
        }
        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var roles = await roleManager.Roles.ToListAsync();
            return View(new UserAddDto { Roles=roles});
        }
        [HttpPost]
        public async Task<IActionResult> Add(UserAddDto userAddDto)
        {
            var map =  mapper.Map<AppUser>(userAddDto);
            var roles = await roleManager.Roles.ToListAsync();
            if (ModelState.IsValid)
            {
                map.UserName = userAddDto.Email;
                var result = await userManager.CreateAsync(map,string.IsNullOrEmpty( userAddDto.Password) ? "" : userAddDto.Password);
                if (result.Succeeded)
                {
                    var findrole = await roleManager.FindByIdAsync(userAddDto.RoleId.ToString());
                    await userManager.AddToRoleAsync(map,findrole.ToString());
                    toastNotification.AddSuccessToastMessage(Messages.User.Add(userAddDto.Email));
                    return RedirectToAction("Index", "User", new { Area = "Admin" });
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                    return View(new UserAddDto { Roles = roles});
                }
            }
            return View(new UserAddDto { Roles = roles });
        }
        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            var user = await userManager.FindByIdAsync(id.ToString());

            var roles = await roleManager.Roles.ToListAsync();

            var map =mapper.Map<UserUpdateDto>(user);
            map.Roles = roles;
            return View(map);
        }
        [HttpPost]
        public async Task<IActionResult> Update(UserUpdateDto userUpdateDto)
        {
            var user = await userManager.FindByIdAsync(userUpdateDto.Id.ToString());
            if(user != null)
            {
                var userRole = string.Join("", await userManager.GetRolesAsync(user));
                var roles = await roleManager.Roles.ToListAsync();
                if(ModelState.IsValid)
                {
                    mapper.Map(userUpdateDto, user);
                    user.UserName = userUpdateDto.Email;
                    user.SecurityStamp = Guid.NewGuid().ToString();
                    var result = await userManager.UpdateAsync(user);
                    if(result.Succeeded)
                    {
                        await userManager.RemoveFromRoleAsync(user, userRole);
                        var findrole = await roleManager.FindByIdAsync(userUpdateDto.RoleId.ToString());
                        await userManager.AddToRoleAsync(user, findrole.Name);
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
            var user = await userManager.FindByIdAsync(id.ToString());
            var result = await userManager.DeleteAsync(user);
            if(result.Succeeded)
            {
                toastNotification.AddSuccessToastMessage(Messages.User.Delete(user.Email));
                return RedirectToAction("Index", "User", new { Area = "Admin" });
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
                
            }
            return NotFound();
        }
    }
}
