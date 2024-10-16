namespace AutoTrade.Model
{
    public partial class City
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Canton Canton { get; set; }
    }
}