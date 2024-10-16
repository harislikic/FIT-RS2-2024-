using AutoTrade.Model;
using SearchObject;

namespace AutoTrade.Services
{
    public interface IService<TModel, TSearch> where TSearch : BaseSerachObject
    {
        public PagedResult<TModel> GetPaged(TSearch serach);

        public TModel GetById(int id);

    }
}