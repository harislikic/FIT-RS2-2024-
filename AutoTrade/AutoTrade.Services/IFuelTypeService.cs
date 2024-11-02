using Database;
using Request;
using SearchObject;

namespace AutoTrade.Services
{
    public interface IFuelTypeService : ICRUDService<Model.FuelType, BaseSerachObject, FuelTypeUpsertRequest, FuelTypeUpsertRequest>
    {
    }
}