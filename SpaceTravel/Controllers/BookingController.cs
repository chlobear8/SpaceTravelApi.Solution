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

    public IActionResult Index()
    {
      // Get the booking information from your database
      Booking booking = _db.Bookings.Include(b => b.JoinEntities).FirstOrDefault();

      // Pass the booking object as the model to the view
      return View(booking);
    }
    public IActionResult BookFlight(int destinationId)
    {
    Destination destination = _db.Destinations.FirstOrDefault(d => d.DestinationId == destinationId);
    if (destination == null)
    {
        return NotFound();
    }

    Booking booking = new Booking();
    booking.JoinEntities = new List<BookingDestination>();
    booking.JoinEntities.Add(new BookingDestination { Destination = destination });

    return View("Create", booking);
    }

    [HttpPost]
    public async Task<IActionResult> Create(Booking booking)
    {
        if (ModelState.IsValid)
        {
            _db.Bookings.Add(booking);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        // If the model state is not valid, redisplay the form with validation errors
        return View(booking);
    }

        public ActionResult AddDestination(int id)
    {
      Booking thisBooking = _db.Bookings.FirstOrDefault(booking => booking.BookingId == id);
      ViewBag.BookingId = new SelectList(_db.Bookings, "BookingId", "Description");
      return View(thisBooking);
    }

    [HttpPost]
    public ActionResult AddDestination(Booking booking, int destinationId)
    {
#nullable enable
      BookingDestination? joinEntity = _db.BookingDestinations.FirstOrDefault(join => (join.DestinationId == destinationId && join.BookingId == booking.BookingId));
#nullable disable
      if (joinEntity == null && booking.BookingId != 0)
      {
        _db.BookingDestinations.Add(new BookingDestination() { BookingId = booking.BookingId, DestinationId = destinationId });
        _db.SaveChanges();
      }
      return RedirectToAction("Details", new { id = booking.BookingId });
    }
  }
}