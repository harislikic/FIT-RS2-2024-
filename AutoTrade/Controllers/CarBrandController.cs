using AutoTrade.Model;
using AutoTrade.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Request;
using SearchObject;

namespace Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarBrandController : BaseCRUDController<CarBrand, BaseSerachObject, CarBrandUpsertRequest, CarBrandUpsertRequest>
    {
        public CarBrandController(ICarBrandService service) : base(service)
        {
        }
    }
}