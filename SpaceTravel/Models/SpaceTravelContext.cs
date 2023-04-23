using Microsoft.EntityFrameworkCore;

namespace SpaceTravel.Models
{
  public class SpaceTravelContext : DbContext
  {
    public DbSet<Destination> Destination { get; set; }
  }

  protected override void OnModelCreating(ModelBuilder builder)
  {
    builder.Entity<Destination>()
      .HasData(
        new Destination { DestinationId = 1, Name = "Carina Nebula", Url = "" , Price = "$1,295"},
        new Destination { DestinationId = 2, Name = "Helix Nebula", Url = "" , Price = "$1,495"},
        new Destination { DestinationId = 3, Name = "Carina Nebula", Url = "" , Price = "$1,295"},
        new Destination { DestinationId = 4, Name = "Carina Nebula", Url = "" , Price = "$1,295"},
        new Destination { DestinationId = 5, Name = "Carina Nebula", Url = "" , Price = "$1,295"},
        new Destination { DestinationId = 6, Name = "Carina Nebula", Url = "" , Price = "$1,295"},

      );
  }
}