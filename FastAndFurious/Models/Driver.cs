namespace FastAndFurious.Models
{
    public class Driver
    {
        public int DriverId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string LicenseNumber { get; set; }
        public bool IsActive { get; set; }
        public decimal Rating { get; set; }

        public ICollection<Car> Cars { get; set; }
    }
}
