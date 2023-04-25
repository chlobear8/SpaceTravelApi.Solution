using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SpaceTravel.Models;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

namespace SpaceTravel.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        List<ImageModel> images = GetImages();
        return View(images);
    }

    [HttpPost]
    public IActionResult Index(int imageId)
    {
        List<ImageModel> images = GetImages();
        ImageModel image = images.FirstOrDefault(p => p.Id == imageId);
        if (image != null)
        {
            image.IsSelected = true;
            ViewBag.Base64String = "data:image/png;base64" + Convert.ToBase64String(image.Data, 0, image.Data.Length);
        }
        return View(images);
    }

    private List<ImageModel> GetImages()
    {
        string query = "SELECT * FROM tblFiles";
        List<ImageModel> images = new List<ImageModel>();
        string constr = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        using (SqlConnection con = new SqlConnection(constr))
        {
            using (SqlCommand cmd = new SqlCommand(query))
            {
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                con.Open();
                using (SqlDataReader sdr = cmd.ExecuteReader())
                {
                    while (srd.Read())
                    {
                        images.Add(new ImageModel
                        {
                            Id = Convert.ToInt32(sdr["Id"]),
                            Name = sdr["Name"].ToString(),
                            ContentType = sdr["ContentType"].ToString(),
                            Data = (byte[])sdr["Data"]
                        });
                    }
                }
                con.Close();
            }
            return images;
        }
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
