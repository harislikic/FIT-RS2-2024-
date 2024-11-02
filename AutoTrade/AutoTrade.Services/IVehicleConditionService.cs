using AutoTrade.Model;
using Database;
using Request;
using SearchObject;

namespace AutoTrade.Services
{
    public interface IVehicleConditionService : ICRUDService<Model.VehicleCondition,BaseSerachObject,VehicleConditionUpsertRequest,VehicleConditionUpsertRequest>
    {
    }
}