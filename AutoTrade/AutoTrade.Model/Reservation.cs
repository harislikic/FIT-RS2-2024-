namespace AutoTrade.Model
{
    public partial class Reservation
    {

        public int Id { get; set; }
        public DateTime ReservationDate { get; set; }
        public User? User { get; set; }
        public AutomobileAd? AutomobileAd { get; set; }
        public string Status { get; set; }

    }
}