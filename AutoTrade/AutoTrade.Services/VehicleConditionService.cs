using AutoTrade.Services.Database;
using Database;
using MapsterMapper;
using Request;
using SearchObject;

namespace AutoTrade.Services
{
    public class VehicleConditionService : BaseCRUDService<Model.VehicleCondition, BaseSerachObject, VehicleCondition, VehicleConditionUpsertRequest, VehicleConditionUpsertRequest>, IVehicleConditionService
    {
        public VehicleConditionService(AutoTradeContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}