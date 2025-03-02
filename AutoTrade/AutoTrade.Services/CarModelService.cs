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

        public override IQueryable<CarModel> AddInclude(IQueryable<CarModel> query, BaseSerachObject? search = null, bool includeDetails = false, bool includeDoneAds = false)
        {
            return query.OrderBy(x => x.Name);
        }
    }
}