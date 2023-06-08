var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews(); // Services

var app = builder.Build();

app.UseStaticFiles(); // Middleware

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage(); // Middleware
}

app.MapDefaultControllerRoute();

app.Run();
