using BethanysPieShop.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<ICategoryRepository, MockCategoryRepository>();
builder.Services.AddScoped<IPieRepository, MockPieRepository>();

builder.Services.AddControllersWithViews(); // Services

var app = builder.Build();

app.UseStaticFiles(); // Middleware

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage(); // Middleware
}

app.MapDefaultControllerRoute();

app.Run();
