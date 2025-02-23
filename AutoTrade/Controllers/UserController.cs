using AutoTrade.Model;
using AutoTrade.Services;
using Controllers;
using MapsterMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Request;
using SerachObject;

namespace AutoTrader.Controllers;
[ApiController]
[Route("[controller]")]
public class UserController : BaseCRUDController<User, UserSearchObject, UserInsertRequest, UserUpdateRequest>
{

    protected IUserService _service;
    private readonly IMapper _mapper;
    public UserController(IUserService service, IMapper mapper) : base(service)
    {
        _service = service;
        _mapper = mapper;
    }

    [HttpPost]
    [AllowAnonymous]
    public override User Insert([FromForm] UserInsertRequest request)
    {
        return _service.Insert(request);
    }

    [HttpPost("login")]
    public User Login(LoginRequest request)
    {
        return (_service as IUserService).Login(request);
    }

    [HttpPost("login/admin")]
    public User LoginAdmin(LoginRequest request)
    {
        return (_service as IUserService).LoginAdmin(request);
    }


    [HttpPost("admin")]
    public IActionResult InsertAdmin([FromForm] UserInsertRequest request)
    {
        try
        {
            var addedUser = _service.InsertAdmin(request);
            return Ok(new
            {
                message = "Admin created successfully.",
                user = addedUser
            });
        }
        catch (Exception ex)
        {
            return BadRequest(new
            {
                message = ex.Message
            });
        }
    }



    [HttpPatch("{id}")]
    public IActionResult Patch(int id, [FromForm] UserUpdateRequest request)
    {

        var user = _service.GetById(id);
        if (user == null)
        {
            return NotFound("User not found.");
        }

        if (!string.IsNullOrWhiteSpace(request.FirstName))
            user.FirstName = request.FirstName;

        if (!string.IsNullOrWhiteSpace(request.LastName))
            user.LastName = request.LastName;

        if (!string.IsNullOrWhiteSpace(request.PhoneNumber))
            user.PhoneNumber = request.PhoneNumber;

        if (!string.IsNullOrWhiteSpace(request.Adress))
            user.Adress = request.Adress;

        if (!string.IsNullOrWhiteSpace(request.Gender))
            user.Gender = request.Gender;

        if (request.DateOfBirth.HasValue)
            user.DateOfBirth = request.DateOfBirth.Value;

        if (request.CityId.HasValue)
            user.CityId = request.CityId.Value;

        if (request.CityId.HasValue && request.CityId.Value > 0)
        {
            var cityEntity = _service.GetCityById(request.CityId.Value);

            if (cityEntity == null)
            {
                return BadRequest("Invalid CityId, city not found.");
            }

            user.CityId = cityEntity.Id;
            user.City = _mapper.Map<City>(cityEntity);
        }


        if (request.ProfilePicture != null && request.ProfilePicture.Length > 0)
        {

            user.ProfilePicture = FileUploadHelper.UploadProfilePicture(request.ProfilePicture);
        }
        _service.Update(id, user);

        return Ok(user);
    }




}