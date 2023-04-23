using Microsoft.EntityFrameworkCore;

namespace SpaceTravel.Models
{
  public class SpaceTravelContext : DbContext
  {
    public DbSet<Destination> Destination { get; set; }
  
    public SpaceTravelContext(DbContextOptions<SpaceTravelContext> options) : base(options)
    {
    }
    
  protected override void OnModelCreating(ModelBuilder builder)
  {
    builder.Entity<Destination>()
      .HasData(
        new Destination { DestinationId = 1, Name = "Carina Nebula", Url = "dfhdfj" , Price = "$1,295"},
        new Destination { DestinationId = 2, Name = "Helix Nebula", Url = "https://images.nasa.gov/details/PIA09178" , Price = "$1,495"},
        new Destination { DestinationId = 3, Name = "Mars", Url = "dhhhf" , Price = "$1,095"},
        new Destination { DestinationId = 4, Name = "Neptune ", Url = "https://images.nasa.gov/details/PIA01492" , Price = "$2,295"},
        new Destination { DestinationId = 5, Name = "Aurora Australis", Url = "https://images.nasa.gov/details/iss029e008433" , Price = "$1,895"},
        new Destination { DestinationId = 6, Name = "Carina Nebula2", Url = "dsgsdg" , Price = "$1,495"}

      );
    }
  }
}