namespace Database
{
    public partial class AdditionalEquipment
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<AutomobileAdAdditionalEquipment> AutomobileAdAdditionalEquipments { get; set; }
    }
}