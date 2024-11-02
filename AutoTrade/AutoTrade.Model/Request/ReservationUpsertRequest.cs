namespace Request
{
    public class ReservationUpsertRequest
    {
        public DateTime ReservationDate { get; set; }
        public int? UserId { get; set; }
        public int? AutomobileAdId { get; set; }
    }
}