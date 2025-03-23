using Database;
using Request;
using SearchObject;

namespace AutoTrade.Services
{
    public interface IMoodTrackerService : ICRUDService<Model.MoodTracker, MoodTrackerSerachObject, MoodTrackerUpsertRequest, MoodTrackerUpsertRequest>
    {
    }
}