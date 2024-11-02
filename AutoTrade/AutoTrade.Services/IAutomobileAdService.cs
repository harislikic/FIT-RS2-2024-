using Database;
using Request;
using SearchObject;

namespace AutoTrade.Services
{
    public interface IAutomobileAdService : ICRUDService<Model.AutomobileAd,AutomobileAdSearchObject,AutomobileAdInsertRequst,AutomobileUpdateRequest>
    {
    }
}