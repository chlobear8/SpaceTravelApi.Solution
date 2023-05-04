using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SpaceTravel.Models;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace SpaceTravel.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _db;

    private readonly string _apikey;

    public HomeController(ILogger<HomeController> db, IConfiguration configuration)
    {
        _db = db;
        _apikey = configuration["NASA"];
    }

    [HttpGet]
    public IActionResult Index()
    {
        var allPictures = NASA.GP(_apikey);
        var nasar = new NASA();
        nasar.Url = allPictures;
        var x = new List<NASA>();
        x.Add(nasar);
        return View(x);
    }

    public IActionResult Privacy()
    {
        return View();
    }
}
