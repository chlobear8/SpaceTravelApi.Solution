using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using SpaceTravel.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;

namespace SpaceTravel.Controllers
{
  public class DestinationController : Controller
  {
    private readonly SpaceTravelContext _db;

    public DestinationController(SpaceTravelContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Destination> model = _db.Destinations.ToList();
      return View(model);
    }

    public async Task<IActionResult> Details(int? id)
    {
      if (id == null)
      {
        return NotFound();
      }

      var destination = await _db.Destinations
          .FirstOrDefaultAsync(m => m.DestinationId == id);
      if (destination == null)
      {
        return NotFound();
      }

      return View(destination);
    }

    public ActionResult AddBooking(int id)
    {
      Destination thisDestination = _db.Destinations.FirstOrDefault(destination => destination.DestinationId == id);
      ViewBag.BookingId = new SelectList(_db.Bookings, "BookingId", "Description");
      return View(thisDestination);
    }

    [HttpPost]
    public ActionResult AddBooking(Destination destination, int bookingId)
    {
#nullable enable
      BookingDestination? joinEntity = _db.BookingDestinations.FirstOrDefault(join => (join.BookingId == bookingId && join.DestinationId == destination.DestinationId));
#nullable disable
      if (joinEntity == null && bookingId != 0)
      {
        _db.BookingDestinations.Add(new BookingDestination() { DestinationId = destination.DestinationId, BookingId = bookingId });
        _db.SaveChanges();
      }
      return RedirectToAction("Details", new { id = destination.DestinationId });
    }


    public IActionResult Spinner()
    {
      return View();
    }

  }
}
