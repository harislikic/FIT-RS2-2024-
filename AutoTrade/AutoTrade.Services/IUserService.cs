using AutoTrade.Model;
using Database;
using Request;
using SerachObject;

namespace AutoTrade.Services
{
    public interface IUserService : ICRUDService<Model.User, UserSearchObject, UserInsertRequest, UserUpdateRequest>
    {
        Model.User Login(LoginRequest request);

        Model.User LoginAdmin(LoginRequest request);

        Model.User Update(int id, Model.User user);

        Model.User InsertAdmin(UserInsertRequest request);

        Database.City GetCityById(int cityId);
    }
}