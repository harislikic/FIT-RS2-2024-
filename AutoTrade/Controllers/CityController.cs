using AutoTrade.Model;
using AutoTrade.Services;
using Database;
using Microsoft.AspNetCore.Mvc;
using Request;
using SearchObject;

namespace Controllers
{

    [ApiController]
    [Route("[controller]")]

    public class CityController : BaseCRUDController<City, BaseSerachObject, CityUpsertRequest, CityUpsertRequest>
    {
        public CityController(ICityService service) : base(service)
        {
        }
    }
}