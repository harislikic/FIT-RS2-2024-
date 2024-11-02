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
    public class CarCategoryController : BaseCRUDController<CarCategory, BaseSerachObject, CarCategoryUpsertRequest, CarCategoryUpsertRequest>
    {
        public CarCategoryController(ICarCategoryService service) : base(service)
        {
        }
    }
}