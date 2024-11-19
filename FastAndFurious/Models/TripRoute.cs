namespace FastAndFurious.Models
{
    public class TripRoute
    {
        public int TripId { get; set; }
        public Trip Trip { get; set; }

        public int RouteId { get; set; }
        public Route Route { get; set; }
    }
}
