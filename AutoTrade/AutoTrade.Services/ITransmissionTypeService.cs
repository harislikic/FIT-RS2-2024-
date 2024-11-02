using Database;
using Request;
using SearchObject;

namespace AutoTrade.Services
{
    public interface ITransmissionTypeService : ICRUDService<Model.TransmissionType, BaseSerachObject, TransmissionTypeUpsertRequest, TransmissionTypeUpsertRequest>
    {
    }
}
