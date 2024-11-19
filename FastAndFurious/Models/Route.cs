using FastAndFurious.Models;

namespace FastAndFurious.Models
{
    public class Route
    {
        public int RouteId { get; set; }
        public string Name { get; set; }
        public double Distance { get; set; }

        public ICollection<TripRoute> TripRoutes { get; set; }
    }
}
