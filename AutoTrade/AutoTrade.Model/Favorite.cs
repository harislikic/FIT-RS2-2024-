namespace AutoTrade.Model
{
    public partial class Favorite
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public User User { get; set; }
        public int? AutomobileAdId { get; set; }

    }
}