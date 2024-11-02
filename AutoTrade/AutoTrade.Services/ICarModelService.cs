using Database;
using Request;
using SearchObject;

namespace AutoTrade.Services
{
    public interface ICarModelService : ICRUDService<Model.CarModel,BaseSerachObject,CarModelUpsertRequest,CarModelUpsertRequest>
    {
    }
}