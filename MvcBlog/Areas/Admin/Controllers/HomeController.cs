﻿using Microsoft.AspNetCore.Mvc;
using MvcBlogProject.Bll.Services.Abstract;

namespace MvcBlog.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly IArticleService articleService;

        public HomeController(IArticleService articleService)
        {
            this.articleService = articleService;
        }
        public async Task<IActionResult> Index()
        {
            var articles = await articleService.GetAllArticleAsync();
            return View(articles);
        }
    }
}