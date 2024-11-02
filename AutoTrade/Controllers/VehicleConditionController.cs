using AutoTrade.Model;
using AutoTrade.Services;
using Microsoft.AspNetCore.Mvc;
using Request;
using SearchObject;

namespace Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VehicleConditionController : BaseCRUDController<VehicleCondition, BaseSerachObject, VehicleConditionUpsertRequest, VehicleConditionUpsertRequest>
    {
        public VehicleConditionController(IVehicleConditionService service) : base(service)
        {
        }
    }
}