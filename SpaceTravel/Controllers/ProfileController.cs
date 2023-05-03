using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using SpaceTravel.Models;
using System.Collections.Generic;
using System.Linq;

namespace SpaceTravel.Controllers
{
    public class ProfileController : Controller
    {
        private readonly SpaceTravelContext _db;

        public ProfileController(SpaceTravelContext db)
        {
            _db = db;
        }

        public ActionResult Index()
        {
            List<Destination> model = _db.Destination.ToList();
            return View(model);
        }
    }
}