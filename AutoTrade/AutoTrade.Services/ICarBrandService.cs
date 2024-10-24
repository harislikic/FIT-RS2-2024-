using Database;
using Request;
using SearchObject;

namespace AutoTrade.Services
{
    public interface ICarBrandService : ICRUDService<Model.CarBrand, BaseSerachObject, CarBrandUpsertRequest, CarBrandUpsertRequest>
    {
    }
}