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
    }
}