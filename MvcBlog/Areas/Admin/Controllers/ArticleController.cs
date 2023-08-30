using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using MvcBlog.ResultMessages;
using MvcBlogProject.Bll.FluentValidations;
using MvcBlogProject.Bll.Services.Abstract;
using MvcBlogProject.Dal.Entities;
using MvcBlogProject.Shared.DTOs.Articles;
using NToastNotify;

namespace MvcBlog.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ArticleController : Controller
    {
        private readonly IArticleService articleService;
        private readonly ICategoryService categoryService;
        private readonly IMapper mapper;
        private readonly IValidator<Article> validator;
        private readonly IToastNotification toastNotification;

        public ArticleController(IArticleService articleService,ICategoryService categoryService,IMapper mapper,IValidator<Article> validator,IToastNotification toastNotification)
        {
            this.articleService = articleService;
            this.categoryService = categoryService;
            this.mapper = mapper;
            this.validator = validator;
            this.toastNotification = toastNotification;
        }
        [HttpGet]
        public  async Task<IActionResult> Index()
        {
            var articles = await articleService.GetAllArticleWithCategoryNonDeletedAsync();
            return View(articles);
        }
        [HttpGet]
        public async Task<IActionResult> DeletedArticle()
        {
            var articles = await articleService.GetAllDeletedArticles();
            return View(articles);
        }
        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var categories = await categoryService.GetAllCategoriesNonDeleted();
            return View(new ArticleAddDto { Categories=categories});
        }
        [HttpPost]
        public async Task<IActionResult> Add(ArticleAddDto articleAddDto)
        {
            var map = mapper.Map<Article>(articleAddDto);
            var result = await validator.ValidateAsync(map);

            if (result.IsValid)
            {
                await articleService.CreateArticleAsync(articleAddDto);
                toastNotification.AddSuccessToastMessage(Messages.Article.Add(articleAddDto.ArticleName));
                return RedirectToAction("Index", "Article", new { Area = "Admin" });
            }
            else
            {
                result.AddToModelState(this.ModelState);
            }

            

            var categories = await categoryService.GetAllCategoriesNonDeleted();
            return View(new ArticleAddDto { Categories = categories });
        }
        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            var article = await articleService.GetArticleWithCategoryNonDeletedAsync(id);
            var categories = await categoryService.GetAllCategoriesNonDeleted();

            var articleUpdateDto = mapper.Map<ArticleUpdateDto>(article);
            articleUpdateDto.Categories = categories;

            return View(articleUpdateDto);
     
        }
        [HttpPost]
        public async Task<IActionResult> Update(ArticleUpdateDto articleUpdateDto)
        {
            var map = mapper.Map<Article>(articleUpdateDto);
            var result = await validator.ValidateAsync(map);
            if (result.IsValid)
            {
               var title = await articleService.UpdateArticleAsync(articleUpdateDto);
                toastNotification.AddInfoToastMessage(Messages.Article.Update(title));
            }
            else
            {
                result.AddToModelState(this.ModelState);
            }
            
            var categories = await categoryService.GetAllCategoriesNonDeleted();
;
            articleUpdateDto.Categories = categories;

            return RedirectToAction("Index");

        }
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var title =await articleService.SafeDeleteArticleAsync(id);
            toastNotification.AddWarningToastMessage(Messages.Article.Delete(title));
            return RedirectToAction("Index","Article",new {Area="Admin"});

        }
        [HttpGet]
        public async Task<IActionResult> UndoDelete(int id)
        {
            var title = await articleService.UndoDeleteArticleAsync(id);
            toastNotification.AddWarningToastMessage(Messages.Article.UndoDelete(title));
            return RedirectToAction("Index", "Article", new { Area = "Admin" });

        }
    }
}
