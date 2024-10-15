using Request;

namespace AutoTrade.Services
{
    public interface IUserService
    {
        List<Model.User> Get();

        Model.User Insert(UserInsertRequest request);

        Model.User Update(int id, UserUpdateRequest request);
    }
}