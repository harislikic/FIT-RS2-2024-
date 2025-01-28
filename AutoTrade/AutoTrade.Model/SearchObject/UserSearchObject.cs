using System.ComponentModel;
using SearchObject;

namespace SerachObject
{
    public class UserSearchObject : BaseSerachObject
    {
        public string? FirstNameGTE { get; set; }
        public string? LastNameeGTE { get; set; }
        public string? UserName { get; set; }
        public string? OrderBy { get; set; }
        public bool? IsAdmin { get; set; }


    }
}