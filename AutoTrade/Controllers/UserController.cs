using AutoTrade.Model;
using AutoTrade.Services;
using Microsoft.AspNetCore.Mvc;

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
    public List<User> GetUsers()
    {
        return _service.Get();
    }

}