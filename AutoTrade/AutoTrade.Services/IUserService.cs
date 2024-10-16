using Request;
using SerachObject;

namespace AutoTrade.Services
{
    public interface IUserService
    {
        List<Model.User> Get(UserSearchObject serachObject);

        Model.User Insert(UserInsertRequest request);

        Model.User Update(int id, UserUpdateRequest request);
    }
}