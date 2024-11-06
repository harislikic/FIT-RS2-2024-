using AutoTrade.Model;
using AutoTrade.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SearchObject;


namespace AutoTrader.Controllers;
[ApiController]
[Route("[controller]")]
//[Authorize]
public class BaseController<TModel, TSerach> : ControllerBase where TSerach : BaseSerachObject
{

    protected IService<TModel, TSerach> _service;
    public BaseController(IService<TModel, TSerach> service)
    {
        _service = service;
    }

    [HttpGet]
    public virtual PagedResult<TModel> GetList([FromQuery] TSerach serachObject)
    {
        return _service.GetPaged(serachObject);
    }

    [HttpGet("{id}")]
    public virtual TModel GetById(int id)
    {
        return _service.GetById(id);
    }

}