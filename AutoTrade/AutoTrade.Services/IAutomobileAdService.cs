using Database;
using Request;
using SearchObject;

namespace AutoTrade.Services
{
    public interface IAutomobileAdService : ICRUDService<Model.AutomobileAd, AutomobileAdSearchObject, AutomobileAdInsertRequst, AutomobileUpdateRequest>
    {
        Model.AutomobileAd MarkAsDone(int id);

        List<Model.AutomobileAd> Recommend(int id);

        Model.AutomobileAd Update(int id, Model.AutomobileAd user);
    }
}