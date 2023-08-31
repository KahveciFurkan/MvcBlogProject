using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MvcBlogProject.Dal.Entities;
using MvcBlogProject.Shared.DTOs.Users;

namespace MvcBlog.Areas.Admin.ViewComponents
{
    public class DashBoardHeaderViewComponent :ViewComponent
    {
        private readonly UserManager<AppUser> userManager;
        private readonly IMapper mapper;

        public DashBoardHeaderViewComponent(UserManager<AppUser> userManager,IMapper  mapper)
        {
            this.userManager = userManager;
            this.mapper = mapper;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var loggedInUser = await userManager.GetUserAsync(HttpContext.User); 
            var map = mapper.Map<UserDto>(loggedInUser);

            var role = string.Join("", await userManager.GetRolesAsync(loggedInUser));

            map.Role = role;

            return View(map);
        }
    }
}
