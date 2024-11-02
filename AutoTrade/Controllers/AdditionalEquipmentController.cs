using AutoTrade.Model;
using AutoTrade.Services;
using Microsoft.AspNetCore.Mvc;
using Request;
using SearchObject;

namespace Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AdditionalEquipmentController : BaseCRUDController<AdditionalEquipment, BaseSerachObject, AdditionalEquipmentUpsertRequst, AdditionalEquipmentUpsertRequst>
    {
        public AdditionalEquipmentController(IAdditionalEquipmentService service) : base(service)
        {
        }
    }
}