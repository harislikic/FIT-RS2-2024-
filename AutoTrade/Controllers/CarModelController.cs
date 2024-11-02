using AutoTrade.Model;
using AutoTrade.Services;
using Microsoft.AspNetCore.Mvc;
using Request;
using SearchObject;

namespace Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarModelController : BaseCRUDController<CarModel, BaseSerachObject, CarModelUpsertRequest, CarModelUpsertRequest>
    {
        public CarModelController(ICarModelService service) : base(service)
        {
        }
    }
}