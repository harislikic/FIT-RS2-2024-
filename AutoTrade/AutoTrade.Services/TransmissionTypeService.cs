using AutoTrade.Services.Database;
using Database;
using MapsterMapper;
using Request;
using SearchObject;

namespace AutoTrade.Services
{
    public class TransmissionTypeService : BaseCRUDService<Model.TransmissionType, BaseSerachObject, TransmissionType, TransmissionTypeUpsertRequest, TransmissionTypeUpsertRequest>, ITransmissionTypeService
    {
        public TransmissionTypeService(AutoTradeContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}