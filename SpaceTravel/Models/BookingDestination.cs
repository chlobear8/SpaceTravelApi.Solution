namespace SpaceTravel.Models
{
    public class BookingDestination
    {
        public int BookingDestinationId { get; set; }
        public int BookingId { get; set; }
        public Booking Booking { get; set; }
        public int DestinationId { get; set; }
        public Destination Destination { get; set; }
    }
}