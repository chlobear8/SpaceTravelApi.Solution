using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SpaceTravel.Models;

namespace SpaceTravel.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _db;

    public HomeController(ILogger<HomeController> db)
    {
        _db = db;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
