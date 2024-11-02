using AutoTrade.Services.Database;
using Database;
using MapsterMapper;
using Request;
using SearchObject;

namespace AutoTrade.Services
{
    public class AdditionalEquipmentService : BaseCRUDService<Model.AdditionalEquipment, BaseSerachObject, AdditionalEquipment, AdditionalEquipmentUpsertRequst, AdditionalEquipmentUpsertRequst>, IAdditionalEquipmentService
    {
        public AdditionalEquipmentService(AutoTradeContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}