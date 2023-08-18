using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Online_Store.Domain;
using Online_Store.Interfaces;
using Online_Store.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<ApplicationDbContext>(option =>
option.UseSqlServer(builder.Configuration.GetConnectionString("mycon")));
builder.Services.AddIdentity<IdentityUser,IdentityRole>(option =>
option.SignIn.RequireConfirmedAccount =false
).AddEntityFrameworkStores<ApplicationDbContext>();


builder.Services.AddTransient<ICategory, CategoryServices>();
builder.Services.AddTransient<ISubCategory, SubCategoryServices>();
builder.Services.AddTransient<IProduct, ProductServices>();

var app = builder.Build();

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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
