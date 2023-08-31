using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using MvcBlogProject.Bll.Describers;
using MvcBlogProject.Bll.Services.Concrete;
using MvcBlogProject.Dal.Concrete.Context;
using MvcBlogProject.Dal.Entities;
using NToastNotify;

var builder = WebApplication.CreateBuilder(args);

//var assembly = Assembly.GetExecutingAssembly();
// Add services to the container.
builder.Services.AddScopedBll();
builder.Services.AddSession();
builder.Services.AddControllersWithViews().AddNToastNotifyToastr(new ToastrOptions()
{
	PositionClass=ToastPositions.TopRight,
	TimeOut=3000
});

//builder.Services.AddScopedDAL();
//builder.Services.AddStDAL();








builder.Services.AddIdentity<AppUser, AppRole>(opt =>
{
	opt.Password.RequireNonAlphanumeric = false;
	opt.Password.RequireLowercase = false;
	opt.Password.RequireUppercase = false;
})
	.AddRoleManager<RoleManager<AppRole>>()
	.AddEntityFrameworkStores<AppIdentityContext>()
	.AddErrorDescriber<CustomIdentityErrorDescriber>()
	.AddDefaultTokenProviders();

builder.Services.ConfigureApplicationCookie(config =>
{
	config.LoginPath = new PathString("/Admin/Auth/Login");
	config.LogoutPath = new PathString("/Admin/Auth/Logout");
	config.Cookie = new CookieBuilder
	{
		Name = "MvcBlog",
		HttpOnly = true,
		SameSite = SameSiteMode.Strict,
		SecurePolicy = CookieSecurePolicy.SameAsRequest
	};
	config.SlidingExpiration = true;
	config.ExpireTimeSpan = TimeSpan.FromDays(7);
	config.AccessDeniedPath = new PathString("/Admin/Auth/AccessDenied");
});




var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseNToastNotify();
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseSession();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapAreaControllerRoute(
        name: "Admin",
        areaName: "Admin",
        pattern: "Admin/{Controller=Home}/{action=Index}/{id?}"
        );
    endpoints.MapDefaultControllerRoute();
});
//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
