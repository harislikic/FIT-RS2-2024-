using AutoTrade.Model;
using Database;
using Request;
using SerachObject;

namespace AutoTrade.Services
{
    public interface IUserService : ICRUDService<Model.User, UserSearchObject, UserInsertRequest, UserUpdateRequest>
    {
        Model.User Login(string username, string password);
    }
}