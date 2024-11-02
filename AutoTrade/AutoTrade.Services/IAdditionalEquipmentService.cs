using AutoTrade.Model;
using Database;
using Request;
using SearchObject;

namespace AutoTrade.Services
{
    public interface IAdditionalEquipmentService : ICRUDService<Model.AdditionalEquipment,BaseSerachObject,AdditionalEquipmentUpsertRequst,AdditionalEquipmentUpsertRequst>
    {
    }
}