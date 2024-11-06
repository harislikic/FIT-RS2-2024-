using AutoTrade.Model;
using AutoTrade.Services;
using Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Request;
using SerachObject;

namespace AutoTrader.Controllers;
[ApiController]
[Route("[controller]")]
public class UserController : BaseCRUDController<User, UserSearchObject, UserInsertRequest, UserUpdateRequest>
{

    protected IUserService _service;
    public UserController(IUserService service) : base(service)
    {
        _service = service;
    }

    [HttpPost]
    [AllowAnonymous]
    public override User Insert([FromForm] UserInsertRequest request)
    {
        return _service.Insert(request);
    }

    [HttpPost("login")]
    public User Login(string username, string password)
    {
        return (_service as IUserService).Login(username,password);
    }

}