using Database;
using Request;
using SearchObject;

namespace AutoTrade.Services
{
    public interface IEquipmentService : ICRUDService<Model.Equipment,BaseSerachObject,EquipmentUpsertRequst,EquipmentUpsertRequst>
    {
    }
}