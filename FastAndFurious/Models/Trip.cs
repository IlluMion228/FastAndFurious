using FastAndFurious.Models;

namespace FastAndFurious.Models
{
    public class Trip
    {
        public int TripId { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }

        public int DriverId { get; set; }
        public Driver Driver { get; set; }

        public string StartLocation { get; set; }
        public string EndLocation { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public decimal Tariff { get; set; }

        public ICollection<Payment> Payments { get; set; }
        public ICollection<TripRoute> TripRoutes { get; set; }
    }
}
