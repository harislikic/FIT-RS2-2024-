using System.ComponentModel;

namespace SearchObject
{
    public class BaseSerachObject
    {
        [DefaultValue(0)]
        public int? Page { get; set; }
        [DefaultValue(25)]
        public int? PageSize { get; set; }
    }
}