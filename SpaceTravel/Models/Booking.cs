using System;
using System.Collections.Generic;

namespace SpaceTravel.Models
{
  public class Booking
  {
    public int BookingId { get; set; }

    public string BookingDate { get; set; }

    public ApplicationUser User { get; set; }
    
    public List<BookingDestination> JoinEntities { get; set;}

  }
}