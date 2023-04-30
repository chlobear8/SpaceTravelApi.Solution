Richelle -- 
Chloe - BUGFIX/ last nights work broke. Added AI generated images and working on getting them in a column style on the left side. Sizing needs to be done. Would like for container to be clickable and route to reviews
Mike - WIP destinations detail view, shows images. Looked into identity/scaffolding for future BUGFIX
Najma - WIP hovering over image for book now/rather than a button
      - Added distance (from earth to destination)

Note to Richelle-- nothing new is pushed since we are all still working on some bugs. Mostly all CSS based stuff so nothing to crazy going on <3

# Notes/ ToDo:

## Splash Page:
Layout
Implementing an API for random space photo
Nav Bar adjustments (less blasé)
Styling

## Destinations:
Clickable images-
link to details for said location (possibly implementing api)
  -- distance from earth to destination
Stretch goal-- generate some cool ai images like vegas on mars etc for cool photos

## Identity-
authorization and login/register
many-to-many databases: like, one user can have many destinations

## Book a trip
will take to page displaying price, dates etc
Stretch goal: make a prize wheel that creates a trip for you.


using Microsoft.EntityFrameworkCore;
using SpaceTravel.Models;
using RestSharp;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Identity;

//using SpaceTravel.Keys;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<SpaceTravelContext>(
                  dbContextOptions => dbContextOptions
                    .UseMySql(
                      builder.Configuration["ConnectionStrings:DefaultConnection"], ServerVersion.AutoDetect(builder.Configuration["ConnectionStrings:DefaultConnection"]
                    )
                  )
                );

builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
          .AddEntityFrameworkStores<SpaceTravelContext>()
          .AddDefaultTokenProviders();



var app = builder.Build();

// // Configure the HTTP request pipeline.
// app.Environment.IsDevelopment();


//     app.UseExceptionHandler("/Home/Error");
//     // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
//     app.UseHsts();


app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();


//<!-- <Project Sdk="Microsoft.NET.Sdk.Web">

  <PropertyGroup>
    <TargetFramework>net6.0</TargetFramework>
    <!-- <Nullable>enable</Nullable> -->
    <ImplicitUsings>enable</ImplicitUsings>
    <UserSecretsId>aspnet-SpaceTravel-0ef87a7f-1365-49ef-9022-56e7068d6bd2</UserSecretsId>
  </PropertyGroup>

  <ItemGroup>
    <None Update="app.db" CopyToOutputDirectory="PreserveNewest" ExcludeFromSingleFile="true" />
  </ItemGroup>

  <ItemGroup>
    <PackageReference Include="Microsoft.AspNetCore.Identity.EntityFrameworkCore" Version="6.0.0" />
    <PackageReference Include="Microsoft.EntityFrameworkCore.SqlServer" Version="6.0.0" />
    <PackageReference Include="Microsoft.EntityFrameworkCore.Tools" Version="6.0.0" />
    <PackageReference Include="Microsoft.VisualStudio.Web.CodeGeneration.Design" Version="6.0.0" />
    <PackageReference Include="Newtonsoft.Json" Version="13.0.2" />
    <PackageReference Include="Pomelo.EntityFrameworkCore.MySql" Version="6.0.0" />
    <PackageReference Include="RestSharp" Version="108.0.3" />
  </ItemGroup>

</Project> -->


