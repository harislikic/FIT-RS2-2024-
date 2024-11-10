using AutoTrade.Services.Database;
using Database;
using MapsterMapper;
using Request;
using SearchObject;

namespace AutoTrade.Services
{
    public class EquipmentService : BaseCRUDService<Model.Equipment, BaseSerachObject, Equipment, EquipmentUpsertRequst, EquipmentUpsertRequst>, IEquipmentService
    {
        public EquipmentService(AutoTradeContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}