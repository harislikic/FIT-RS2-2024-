using AutoTrade.Model;
using AutoTrade.Services;
using Microsoft.AspNetCore.Mvc;
using Request;
using SearchObject;

namespace Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TransmissionTypeController : BaseCRUDController<TransmissionType, BaseSerachObject, TransmissionTypeUpsertRequest, TransmissionTypeUpsertRequest>
    {
        public TransmissionTypeController(ITransmissionTypeService service) : base(service)
        {
        }
    }
}