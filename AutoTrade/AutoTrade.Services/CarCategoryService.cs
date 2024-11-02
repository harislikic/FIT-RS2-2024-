using AutoTrade.Services.Database;
using Database;
using MapsterMapper;
using Request;
using SearchObject;

namespace AutoTrade.Services
{
    public class CarCategoryService : BaseCRUDService<Model.CarCategory, BaseSerachObject, CarCategory, CarCategoryUpsertRequest, CarCategoryUpsertRequest>, ICarCategoryService
    {
        public CarCategoryService(AutoTradeContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}