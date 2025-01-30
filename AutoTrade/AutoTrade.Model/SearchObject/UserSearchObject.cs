using System.ComponentModel;
using SearchObject;

namespace SerachObject
{
    public class UserSearchObject : BaseSerachObject
    {

        public string? FullNameQuery {get ; set;}
        public string? UserName { get; set; }
        public string? OrderBy { get; set; }
        public bool? IsAdmin { get; set; }

    }
}