namespace FastAndFurious.Models
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public int TripId { get; set; }
        public Trip Trip { get; set; }

        public DateTime PaymentDate { get; set; }
        public decimal Amount { get; set; }
        public string PaymentMethod { get; set; }
    }
}
