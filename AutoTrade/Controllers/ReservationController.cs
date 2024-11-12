using AutoTrade.Model;
using AutoTrade.Services;
using AutoTrade.Services.Database;
using Mapster;
using MapsterMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Request;
using SearchObject;

namespace Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class ReservationController : BaseCRUDController<Reservation, BaseSerachObject, ReservationUpsertRequest, ReservationUpsertRequest>
    {

        private readonly AutoTradeContext _context;
        public ReservationController(IReservationService service, AutoTradeContext context) : base(service)
        {
            _context = context;
        }

        [HttpGet("automobile/{automobileAdId}")]
        public async Task<ActionResult> GetReservationsForAutomobile(int automobileAdId, int page = 1, int pageSize = 25)
        {
            page = page <= 0 ? 1 : page;
            pageSize = pageSize <= 0 || pageSize > 100 ? 25 : pageSize;

            var reservations = await _context.Reservations
                .Where(r => r.AutomobileAdId == automobileAdId)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .Select(r => new
                {
                    r.Id,
                    r.ReservationDate,
                    r.UserId,
                    User = new
                    {
                        r.User.Id,
                        r.User.UserName,
                        r.User.ProfilePicture
                    }
                     ,r.AutomobileAdId,
                })
                .ToListAsync();

            return Ok(new
            {
                count = await _context.Reservations.CountAsync(r => r.AutomobileAdId == automobileAdId),
                data = reservations
            });
        }



    }
}