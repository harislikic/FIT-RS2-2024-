namespace AutoTrade.Model
{
    public class PagedResult<T>
    {
        public int? Count { get; set; }

        public IList<T> Data { get; set; }
    }
}