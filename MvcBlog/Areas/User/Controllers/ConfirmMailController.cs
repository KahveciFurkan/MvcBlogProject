using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MvcBlog.Areas.User.ViewModels;
using MvcBlogProject.Dal.Entities;

namespace MvcBlog.Areas.User.Controllers
{
	[Area("User")]
	public class ConfirmMailController : Controller
	{
		private readonly UserManager<AppUser> userManager;

		public ConfirmMailController(UserManager<AppUser> userManager)
        {
			this.userManager = userManager;
		}
        [HttpGet]
		public IActionResult Index()
		{
			var value = TempData["Mail"];
			ViewBag.x = value;
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> Index(ConfirmMailViewModel confirmMailViewModel)
		{
			var user = await userManager.FindByEmailAsync(confirmMailViewModel.Email);
			if (user.ConfirmCode == confirmMailViewModel.ConfirmCode)
			{
				return RedirectToAction("Index", "Home");
			}
			return View();
		}
	}
}
