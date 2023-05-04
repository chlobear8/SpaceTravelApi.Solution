using System.Collections.Generic;
namespace SpaceTravel.Models

{
  public class Destination
  {
    public int DestinationId { get; set; }

    public string Name { get; set; }

    public string Price { get; set; }

    public string Url { get; set; }
    
    public List<BookingDestination> JoinEntities { get; }
  }
}