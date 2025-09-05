using Microsoft.EntityFrameworkCore;
using StudentMvcApp.Data.Models;
using StudentMvcApp.Services;

var builder = WebApplication.CreateBuilder(args);

// Add DbContext
builder.Services.AddDbContext<StudentDbContext>(options =>
    options.UseSqlite("Data Source=../students.db"));

// Register Service Layer
builder.Services.AddScoped<IStudentService, StudentService>();

builder.Services.AddControllersWithViews();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

app.UseStaticFiles();
app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Students}/{action=Index}/{id?}");

app.Run();
