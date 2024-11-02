using Database;
using Request;
using SearchObject;

namespace AutoTrade.Services
{
    public interface IFavoriteService : ICRUDService<Model.Favorite, BaseSerachObject, FavoriteUpsertRequst, FavoriteUpsertRequst>
    {
    }
}