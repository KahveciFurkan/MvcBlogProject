using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using MvcBlogProject.Dal.Entities;
using MvcBlogProject.Shared.DTOs.Users;
using MailKit.Net.Smtp;

namespace MvcBlog.Areas.User.Controllers
{
    [Area("User")]
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            this.userManager = userManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserRegisterDto userRegisterDto)
        {

            if(ModelState.IsValid)
            {
                Random random = new Random();
                int code;
                code = random.Next(100000, 1000000);

				AppUser appUser = new AppUser()
                {
                    FirstName = userRegisterDto.FirstName,
                    LastName = userRegisterDto.LastName,
                    Email = userRegisterDto.Email,
                    UserName = userRegisterDto.UserName,
                    //RoleId = 3,
                    ConfirmCode = code

                };
                var result = await userManager.CreateAsync(appUser,userRegisterDto.Password);
                if(result.Succeeded)
                {
                    MimeMessage mimeMessage = new MimeMessage();
                    MailboxAddress mailboxAddress = new MailboxAddress("Blog Sitesi", "khvc71@gmail.com");
                    MailboxAddress mailboxto = new MailboxAddress("User", appUser.Email);

                    mimeMessage.From.Add(mailboxAddress);
                    mimeMessage.To.Add(mailboxto);
                    var bodybuilder = new BodyBuilder();
                    bodybuilder.TextBody = "Kayıt işlemini gerçekleştirmek için onay kodunuz" + code;
                    mimeMessage.Body =bodybuilder.ToMessageBody();

                    mimeMessage.Subject = "Onay kodu";


					SmtpClient smtpClient = new SmtpClient();   

                    
					smtpClient.Connect("smtp.gmail.com", 587, false);
                    smtpClient.Authenticate("khvc71@gmail.com", "bavdekkmwyxnxwvb");
                    smtpClient.Send(mimeMessage);
                    smtpClient.Disconnect(true);

                    TempData["Mail"] = userRegisterDto.Email;

					return RedirectToAction("Index,ConfirmMail");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }
            return View();
        }
    }
}
