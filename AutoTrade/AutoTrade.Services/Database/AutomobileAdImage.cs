namespace Database
{
    public partial class AutomobileAdImage
    {
        public int Id { get; set; }
        public int? AutomobileAdId { get; set; }
        public AutomobileAd AutomobileAd { get; set; }
        public string ImageUrl { get; set; }
    }
}