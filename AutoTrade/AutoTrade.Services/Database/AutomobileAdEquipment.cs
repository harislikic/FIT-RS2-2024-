namespace Database
{
    public class AutomobileAdEquipment
    {
        public int AutomobileAdId { get; set; }
        public AutomobileAd AutomobileAd { get; set; }

        public int EquipmentId { get; set; }
        public Equipment Equipment { get; set; }
    }
}