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
        new Destination { DestinationId = 1, Name = "Carina Nebula", Url = "https://images-assets.nasa.gov/image/carina_nebula/carina_nebula~medium.jpg" , Price = "$1,295"},
        new Destination { DestinationId = 2, Name = "Helix Nebula", Url = "https://images-assets.nasa.gov/image/PIA09178/PIA09178~medium.jpg" , Price = "$1,495"},
        new Destination { DestinationId = 3, Name = "Mars", Url = "https://images-assets.nasa.gov/image/PIA21041/PIA21041~small.jpg" , Price = "$1,095"},
        new Destination { DestinationId = 4, Name = "Neptune ", Url = "https://images-assets.nasa.gov/image/PIA01492/PIA01492~medium.jpg" , Price = "$2,295"},
        new Destination { DestinationId = 5, Name = "Blazar Black Hole", Url = "https://images-assets.nasa.gov/image/PIA20912/PIA20912~small.jpg" , Price = "$1,895"},
        new Destination { DestinationId = 6, Name = "Crab Nebula", Url = "https://images-assets.nasa.gov/image/PIA21474/PIA21474~small.jpg" , Price = "$1,495"}

      );
    }
  }
}