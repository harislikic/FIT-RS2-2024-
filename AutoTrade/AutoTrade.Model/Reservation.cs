namespace AutoTrade.Model
{
    public partial class Reservation
    {

        public int Id { get; set; }
        public DateTime ReservationDate { get; set; }

        public int? UserId { get; set; }
        public User User { get; set; }

        public int? AutomobileAdId { get; set; }

    }
}