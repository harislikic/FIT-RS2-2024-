namespace Database
{
    public partial class PaymentTransaction
    {
        public int Id { get; set; }
        public string? PaymentId { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
        public int? AutomobileAdId { get; set; }
        public AutomobileAd? AutomobileAd { get; set; } 
    }
}