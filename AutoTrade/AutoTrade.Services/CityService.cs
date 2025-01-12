using AutoTrade.Services.Database;
using MapsterMapper;
using Microsoft.EntityFrameworkCore;
using Request;
using SearchObject;

namespace AutoTrade.Services
{
    public class CityService : BaseCRUDService<Model.City, BaseSerachObject, Database.City, CityUpsertRequest, CityUpsertRequest>, ICityService
    {
        public CityService(AutoTradeContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override IQueryable<City> AddInclude(IQueryable<City> query, BaseSerachObject? search = null, bool includeDetails = false, bool includeDoneAds = false)
        {
            return query.Include(x => x.Canton);
        }

    }
}