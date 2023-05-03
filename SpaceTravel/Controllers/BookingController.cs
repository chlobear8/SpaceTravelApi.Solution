using Microsoft.AspNetCore.Mvc;
using SpaceTravel.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;

namespace SpaceTravel.Controllers
{
  public class BookingController : Controller
  {
    private readonly SpaceTravelContext _db;

    public BookingController(SpaceTravelContext db)
    {
      _db = db;
    }

    // public ActionResult Index()
    // {
    //   string userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
    //   ApplicationUser currentUser = await _userManager.FindByIdAsync(userId);
    //   List<Booking> userBookings = _db.Bookings
    //                           .Where(entry => entry.User.Id == currentUser.Id)
    //                           .ToList();
    //   return View(userBookings);
    // }
    public IActionResult Index()
    {
      // Get the booking information from your database
      Booking booking = _db.Bookings.Include(b => b.JoinEntities).FirstOrDefault();

      // Pass the booking object as the model to the view
      return View(booking);
    }

  }
}