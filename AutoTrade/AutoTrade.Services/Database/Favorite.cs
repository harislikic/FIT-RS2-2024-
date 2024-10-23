using AutoTrade.Services.Database;

namespace Database
{
    public partial class Favorite
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public User User { get; set; }
        public int? AutomobileAdId { get; set; }
        public AutomobileAd AutomobileAd { get; set; }
    }
}