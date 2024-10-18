using AutoTrade.Model;
using AutoTrade.Services;
using Controllers;
using Microsoft.AspNetCore.Mvc;
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
    public override User Insert([FromForm] UserInsertRequest request)
    {
        return _service.Insert(request);
    }

}