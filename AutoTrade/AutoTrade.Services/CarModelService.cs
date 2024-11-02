using AutoTrade.Services.Database;
using Database;
using MapsterMapper;
using Request;
using SearchObject;

namespace AutoTrade.Services
{
    public class CarModelService : BaseCRUDService<Model.CarModel, BaseSerachObject, CarModel, CarModelUpsertRequest, CarModelUpsertRequest>, ICarModelService
    {
        public CarModelService(AutoTradeContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}