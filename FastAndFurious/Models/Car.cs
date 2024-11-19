using FastAndFurious.Models;

namespace FastAndFurious.Models
{
    public class Car
    {
        public int CarId { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string PlateNumber { get; set; }

        public int DriverId { get; set; }
        public Driver Driver { get; set; }
    }
}
