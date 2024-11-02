using AutoTrade.Services.Database;
using Database;
using MapsterMapper;
using Request;
using SearchObject;

namespace AutoTrade.Services
{
    public class FuelTypeService : BaseCRUDService<Model.FuelType, BaseSerachObject, FuelType, FuelTypeUpsertRequest, FuelTypeUpsertRequest>, IFuelTypeService
    {
        public FuelTypeService(AutoTradeContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}