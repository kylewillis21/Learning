using BethanysPieShop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileSystemGlobbing.Internal.Patterns;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IPieRepository, PieRepository>();

builder.Services.AddScoped<IShoppingCart, ShoppingCart>(sp => ShoppingCart.GetCart(sp));
builder.Services.AddSession();
builder.Services.AddHttpContextAccessor();

builder.Services.AddControllersWithViews(); // Services
builder.Services.AddDbContext<BethanysPieShopDbContext>(options =>
{
    options.UseSqlServer(
        builder.Configuration["ConnectionStrings:BethanysPieShopDbContextConnection"]);
});


var app = builder.Build();

app.UseStaticFiles(); // Middleware
app.UseSession();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage(); // Middleware
}

app.MapDefaultControllerRoute();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=home}/{action=index}/{id?}");
DbInitializer.Seed(app);
app.Run();
