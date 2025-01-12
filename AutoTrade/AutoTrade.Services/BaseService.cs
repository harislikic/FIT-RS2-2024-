using AutoTrade.Model;
using AutoTrade.Services.Database;
using Database;
using MapsterMapper;
using Microsoft.EntityFrameworkCore;
using SearchObject;
using AutomobileAd = Database.AutomobileAd;

namespace AutoTrade.Services
{
    public abstract class BaseService<TModel, TSearch, TDbEntity> : IService<TModel, TSearch> where TSearch : BaseSerachObject where TDbEntity : class where TModel : class
    {
        public AutoTradeContext Context { get; set; }

        public IMapper Mapper { get; set; }

        public BaseService(AutoTradeContext context, IMapper mapper)
        {
            Context = context;
            Mapper = mapper;
        }

        public Model.PagedResult<TModel> GetPaged(TSearch search)
        {
            List<TModel> result = new List<TModel>();

            var query = Context.Set<TDbEntity>().AsQueryable();

            query = AddInclude(query, search);
            query = AddFilter(search, query);

            int count = query.Count();

            if (search?.Page.HasValue == true && search?.PageSize.HasValue == true)
            {
                query = query.Skip(search.Page.Value * search.PageSize.Value)
                  .Take(search.PageSize.Value);
            }

            var list = query.ToList();

            result = Mapper.Map(list, result);

            Model.PagedResult<TModel> pagedResult = new Model.PagedResult<TModel>();

            pagedResult.Data = result;
            pagedResult.Count = count;

            return pagedResult;

        }

        public TModel GetById(int id)
        {
            var query = Context.Set<TDbEntity>().AsQueryable();
            bool isAutomobileAd = typeof(TDbEntity) == typeof(AutomobileAd);

            query = AddInclude(query, null, true, isAutomobileAd);

            var entity = query.FirstOrDefault(e => EF.Property<int>(e, "Id") == id);

            if (entity != null)
            {
                IncrementViewCountIfAutomobileAd(entity);
                Context.SaveChanges();
                return Mapper.Map<TModel>(entity);
            }
            else
            {
                return null;
            }
        }

        protected void IncrementViewCountIfAutomobileAd(TDbEntity entity)
        {
            if (entity is AutomobileAd automobileAd)
            {
                automobileAd.ViewsCount++;
                Context.SaveChanges();
            }
        }

        public virtual IQueryable<TDbEntity> AddInclude(IQueryable<TDbEntity> query, TSearch? search = null, bool includeDetails = false, bool includeDoneAds = false)
        {
            return query;
        }
        public virtual IQueryable<TDbEntity> AddFilter(TSearch search, IQueryable<TDbEntity> query)
        {
            return query;
        }



    }
}