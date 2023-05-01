using System.Collections.Generic;

namespace SpaceTravel.Models
{
  public class Profile
  {
    public int ProfileId { get; set; }
    public string Name { get; set; }
    public ApplicationUser User { get; set; }
    public List<Destination> Destinations { get; set; }
  }
}