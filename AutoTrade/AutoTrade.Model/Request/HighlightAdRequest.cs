namespace Request
{
    public class HighlightAdRequest
    {
        public int HighlightDays { get; set; }

        public decimal? Amount { get; set; }
        public string? PaymentId { get; set; }
    }
}