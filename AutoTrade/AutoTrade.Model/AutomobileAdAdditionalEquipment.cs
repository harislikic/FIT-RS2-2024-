namespace AutoTrade.Model
{
    public partial class AutomobileAdAdditionalEquipment
    {
        public int AutomobileAdId { get; set; }
        public AutomobileAd AutomobileAd { get; set; }

        public int AdditionalEquipmentId { get; set; }
        public AdditionalEquipment AdditionalEquipment { get; set; }
    }
}