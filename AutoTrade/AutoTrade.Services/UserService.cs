using AutoTrade.Model;
using AutoTrade.Services.Database;

namespace AutoTrade.Services
{
    public class UserService : IUserService
    {

        public AutoTradeContext Context { get; set; }

        public UserService(AutoTradeContext context)
        {
            Context = context;
        }

        public List<Model.User> Get()
        {
            var list = Context.Users.ToList();
            var result = new List<Model.User>();

            list.ForEach(item =>
            {
                result.Add(new Model.User()
                {
                    Id = item.Id,
                    UserName = item.UserName
                });
            });

            return result;
        }

    }
}