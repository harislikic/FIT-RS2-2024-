using Database;
using Request;
using SearchObject;

namespace AutoTrade.Services
{
    public interface ICityService : ICRUDService<Model.City, BaseSerachObject, CityUpsertRequest, CityUpsertRequest>
    {
    }
}