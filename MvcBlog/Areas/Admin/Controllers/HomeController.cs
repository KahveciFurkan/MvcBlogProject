using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MvcBlogProject.Bll.Services.Abstract;
using MvcBlogProject.Dal.Entities;
using System.Security.Claims;
using static MvcBlog.ResultMessages.Messages;

namespace MvcBlog.Areas.Admin.Controllers
{

    [Area("Admin")]
    [Authorize]
    public class HomeController : Controller
    {
        private readonly IArticleService articleService;


        public HomeController(IArticleService articleService)
        {
            this.articleService = articleService;

        }
        public async Task<IActionResult> Index()
        {
            var articles = await articleService.GetAllArticleWithCategoryNonDeletedAsync();
            return View(articles);
        }
    }
}
