using AutoTrade.Services.Database;
using MapsterMapper;
using Request;
using SearchObject;

namespace AutoTrade.Services
{
    public class CantonService : BaseCRUDService<Model.Canton, BaseSerachObject, Database.Canton, CantonUpsertRequest, CantonUpsertRequest>, ICantonService
    {
        public CantonService(AutoTradeContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}