using AutoTrade.Model;
using AutoTrade.Services;
using Microsoft.AspNetCore.Mvc;
using Request;
using SearchObject;

namespace Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FavoriteController : BaseCRUDController<Favorite, BaseSerachObject, FavoriteUpsertRequst, FavoriteUpsertRequst>
    {
        public FavoriteController(IFavoriteService service) : base(service)
        {
        }
    }
}