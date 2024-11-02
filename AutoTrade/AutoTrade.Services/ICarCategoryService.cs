using Database;
using Request;
using SearchObject;

namespace AutoTrade.Services
{
    public interface ICarCategoryService : ICRUDService<Model.CarCategory,BaseSerachObject,CarCategoryUpsertRequest,CarCategoryUpsertRequest>
    {
    }
}