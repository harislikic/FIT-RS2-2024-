using AutoTrade.Model;
using Request;
using SerachObject;

namespace AutoTrade.Services
{
    public interface IUserService : IService<User, UserSearchObject>
    {
        // PagedResult<Model.User> Get(UserSearchObject serachObject);

        // Model.User Insert(UserInsertRequest request);

        // Model.User Update(int id, UserUpdateRequest request);
    }
}