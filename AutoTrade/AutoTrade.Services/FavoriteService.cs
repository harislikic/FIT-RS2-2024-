using AutoTrade.Services.Database;
using Database;
using MapsterMapper;
using Microsoft.EntityFrameworkCore;
using Request;
using SearchObject;

namespace AutoTrade.Services
{
    public class FavoriteService : BaseCRUDService<Model.Favorite, BaseSerachObject, Favorite, FavoriteUpsertRequst, FavoriteUpsertRequst>, IFavoriteService
    {
        public FavoriteService(AutoTradeContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override IQueryable<Favorite> AddInclude(IQueryable<Favorite> query, BaseSerachObject? search = null)
        {
            return query.Include(x => x.User).ThenInclude(a => a.AutomobileAds);
        }
    }
}