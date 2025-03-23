namespace Request
{
    public class MoodTrackerUpsertRequest
    {
        public int UserId { get; set; }
        public string Mood { get; set; }
        public string Description { get; set; }
        public DateTime MoodDate { get; set; }
    }
}