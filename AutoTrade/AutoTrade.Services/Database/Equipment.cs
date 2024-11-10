namespace Database
{
    public class Equipment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<AutomobileAdEquipment> AutomobileAdEquipments { get; set; } = new List<AutomobileAdEquipment>();
    }
}