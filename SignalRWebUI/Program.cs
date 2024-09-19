using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using SignalR.DataAccessLayer.Concrete;
using SignalR.EntityLayer.Entities;

var builder = WebApplication.CreateBuilder(args);

// Proje seviyesinde Authentication 1.Adım
var requireAuthorizePolicy = new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build();



// Add services to the container.

builder.Services.AddDbContext<SignalRContext>();
builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<SignalRContext>();

builder.Services.AddHttpClient();

// Proje seviyesinde Authentication 2.Adım
builder.Services.AddControllersWithViews(opt =>
{
	opt.Filters.Add(new AuthorizeFilter(requireAuthorizePolicy));
});

// Proje seviyesinde Authentication 3.Adım Login Path gösterme
builder.Services.ConfigureApplicationCookie(opts =>
{
	opts.LoginPath = "/Login/Index";
});



var app = builder.Build();


// ErrorPage yönlendirme
app.UseStatusCodePages(async  x =>
{
    if (x.HttpContext.Response.StatusCode == 404)
    {
        x.HttpContext.Response.Redirect("/Error/NotFound404Page/");
    }
});

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication(); // 4.Adım
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
