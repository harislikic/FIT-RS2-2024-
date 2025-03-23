namespace SearchObject
{
    public class MoodTrackerSerachObject : BaseSerachObject
    {
        public string? FullNameQuery { get; set; }
        public int? userId { get; set; }
        public string? Mood { get; set; }
        public string? MoodStartDate { get; set; }
        public string? MoodEndDate { get; set; }
    }
}