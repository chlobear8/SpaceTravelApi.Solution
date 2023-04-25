
using Microsoft.EntityFrameworkCore;
using SpaceTravel.Models;
using RestSharp;
//using SpaceTravel.Keys;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");


builder.Services.AddDbContext<SpaceTravelContext>(
                  dbContextOptions => dbContextOptions
                    .UseMySql(
                      builder.Configuration["ConnectionStrings:DefaultConnection"], ServerVersion.AutoDetect(builder.Configuration["ConnectionStrings:DefaultConnection"]
                    )
                  )
                );


builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.Environment.IsDevelopment();


    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();


app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();