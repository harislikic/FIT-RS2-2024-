namespace AutoTrade.Services.Database
{
    public partial class Canton
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public ICollection<City> Cities { get; set; }
    }
}