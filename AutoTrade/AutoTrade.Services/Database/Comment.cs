using AutoTrade.Services.Database;

namespace Database
{
    public partial class Comment
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int? AutomobileAdId { get; set; }
        public AutomobileAd AutomobileAd { get; set; }
    }
}