namespace Database
{
    public partial class TransmissionType
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<AutomobileAd> AutomobileAds { get; set; }
    }
}