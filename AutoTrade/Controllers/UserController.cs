using AutoTrade.Model;
using AutoTrade.Services;
using AutoTrader.Services.Helpers;
using Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.JsonPatch;
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
        // Dohvati korisnika iz baze
        var user = _service.GetById(id);
        if (user == null)
        {
            return NotFound("User not found.");
        }

        // Ažuriraj samo polja koja su poslana u zahtevu
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

        if (request.ProfilePicture != null && request.ProfilePicture.Length > 0)
        {
            // Otpremi novu sliku
            user.ProfilePicture = FileUploadHelper.UploadProfilePicture(request.ProfilePicture);
        }

        // Ažuriraj korisnika u bazi
        _service.Update(id, user);



        return Ok(user);
    }




}