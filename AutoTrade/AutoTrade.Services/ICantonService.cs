using Database;
using Request;
using SearchObject;

namespace AutoTrade.Services
{
    public interface ICantonService : ICRUDService<Model.Canton,BaseSerachObject,CantonUpsertRequest,CantonUpsertRequest>
    {
    }
}