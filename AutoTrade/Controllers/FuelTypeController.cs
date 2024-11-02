using AutoTrade.Model;
using AutoTrade.Services;
using Microsoft.AspNetCore.Mvc;
using Request;
using SearchObject;

namespace Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FuelTypeController : BaseCRUDController<FuelType, BaseSerachObject, FuelTypeUpsertRequest, FuelTypeUpsertRequest>
    {
        public FuelTypeController(IFuelTypeService service) : base(service)
        {
        }
    }
}