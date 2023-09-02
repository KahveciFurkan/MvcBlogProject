using Microsoft.AspNetCore.Mvc;

using MvcBlog.Models;
using MvcBlogProject.Bll.Services.Abstract;
using MvcBlogProject.Shared.DTOs.Articles;
using System.Diagnostics;
using System.Drawing.Printing;

namespace MvcBlog.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
        private readonly IArticleService articleService;

        public HomeController(ILogger<HomeController> logger,IArticleService articleService)
		{
			_logger = logger;
            this.articleService = articleService;
        }

		public async Task<IActionResult> Index(int? categoryId, int currentpage = 1, int pageSize = 3, bool isAscending = false)
		{
			var articles = await articleService.GetAllByPagingAsync(categoryId,currentpage,pageSize,isAscending);

			return View(articles);
		}

		public async Task<IActionResult> Hakkımızda(int? categoryId, int currentpage = 1, int pageSize = 3, bool isAscending = false)
		{
            var articles = await articleService.GetAllByPagingAsync(categoryId, currentpage, pageSize, isAscending);
            return View(articles);
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
        public async Task<IActionResult> Detail(int id)
        {
            var article = await articleService.GetArticleWithCategoryNonDeletedAsync(id);
			return View(article);
        }
    }
}