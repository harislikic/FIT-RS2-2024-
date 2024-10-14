using AutoTrade.Model;

namespace AutoTrade.Services
{
    public class UserService : IUserService
    {

        public List<User> List = new List<User>(){
            new User(){
                Id = 1,
                UserName = "Haris123"
            }
        };

        public List<User> Get()
        {
           return List;
        }

    }
}