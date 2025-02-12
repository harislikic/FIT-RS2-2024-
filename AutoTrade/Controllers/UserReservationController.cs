using AutoTrade.Model;
using AutoTrade.Services.Database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Controllers
{
    [ApiController]
    [Route("user-reservations")]
    public class UserReservationController : ControllerBase
    {
        private readonly AutoTradeContext _context;

        public UserReservationController(AutoTradeContext context)
        {
            _context = context;
        }

        [HttpGet("{userId}")]
        public async Task<ActionResult> GetUserReservationsOnOtherCars(int userId, int page = 1, int pageSize = 25)
        {
            page = page <= 0 ? 1 : page;
            pageSize = pageSize <= 0 || pageSize > 100 ? 25 : pageSize;

            var query = _context.Reservations
                .Include(r => r.AutomobileAd)
                .ThenInclude(a => a.User)
                .Where(r => r.UserId == userId)
                .Where(r => r.AutomobileAd.UserId != userId);

            var reservations = await query
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .Select(r => new
                {
                    r.Id,
                    r.ReservationDate,
                    r.Status,
                    r.UserId,
                    Automobile = new
                    {
                        r.AutomobileAd.Id,
                        r.AutomobileAd.Title,
                        r.AutomobileAd.Price,
                        FirstImage = r.AutomobileAd.Images
                            .Select(img => img.ImageUrl)
                            .FirstOrDefault(),
                        User = new
                        {
                            r.AutomobileAd.User.Id,
                            r.AutomobileAd.User.UserName,
                            r.AutomobileAd.User.ProfilePicture
                        }
                    }
                })
                .ToListAsync();

            return Ok(new
            {
                count = await query.CountAsync(),
                data = reservations
            });
        }
    }
}
