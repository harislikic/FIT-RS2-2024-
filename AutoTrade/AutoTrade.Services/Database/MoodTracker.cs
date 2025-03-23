

using AutoTrade.Services.Database;

namespace Database
{
    public class MoodTracker
    {

        public int Id { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
        public string Mood { get; set; }
        public string Description { get; set; }
        public DateTime MoodDate { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}