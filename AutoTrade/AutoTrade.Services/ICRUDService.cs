using AutoTrade.Services;
using SearchObject;

namespace Database
{
    public interface ICRUDService<TModel, TSearch, TInsert, TUpdate> : IService<TModel, TSearch> where TModel : class where TSearch : BaseSerachObject
    {

        TModel Insert(TInsert request);

        TModel Update(int id, TUpdate request);
    }
}