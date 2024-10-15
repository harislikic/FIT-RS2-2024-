using AutoTrade.Model;
using AutoTrade.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Storage;
using Request;

namespace AutoTrader.Controllers;
[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{

    protected IUserService _service;
    public UserController(IUserService service)
    {
        _service = service;
    }

    [HttpGet]
    public List<AutoTrade.Model.User> GetUsers()
    {
        return _service.Get();
    }

    [HttpPost]
    public AutoTrade.Model.User Insert([FromForm] UserInsertRequest request)
    {
        return _service.Insert(request);
    }

    [HttpPut("{id}")]
    public AutoTrade.Model.User Update(int id, UserUpdateRequest request)
    {
        return _service.Update(id, request);
    }

}