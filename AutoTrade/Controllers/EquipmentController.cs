using AutoTrade.Model;
using AutoTrade.Services;
using Microsoft.AspNetCore.Mvc;
using Request;
using SearchObject;

namespace Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class EquipmentController : BaseCRUDController<Equipment, BaseSerachObject, EquipmentUpsertRequst, EquipmentUpsertRequst>
    {
        public EquipmentController(IEquipmentService service) : base(service)
        {
        }
    }
}