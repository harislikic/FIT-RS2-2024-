
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
    public class CantonController : BaseCRUDController<Canton, BaseSerachObject, CantonUpsertRequest, CantonUpsertRequest>
    {
        public CantonController(ICantonService service) : base(service)
        {
        }
    }
}