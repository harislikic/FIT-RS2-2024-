using AutoTrade.Services.Database;
using Database;
using MapsterMapper;
using Request;
using SearchObject;

namespace AutoTrade.Services
{
    public class CarBrandService : BaseCRUDService<Model.CarBrand, BaseSerachObject, CarBrand, CarBrandUpsertRequest, CarBrandUpsertRequest>, ICarBrandService
    {
        public CarBrandService(AutoTradeContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override IQueryable<CarBrand> AddInclude(IQueryable<CarBrand> query, BaseSerachObject? search = null, bool includeDetails = false, bool includeDoneAds = false)
        {
            return query.OrderBy(x => x.Name);
        }
    }
}