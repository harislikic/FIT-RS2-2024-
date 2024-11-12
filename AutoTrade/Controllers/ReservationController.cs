using AutoTrade.Model;
using AutoTrade.Services;
using AutoTrade.Services.Database;
using Helpers;
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
        private readonly ReservationApprovalEmail _reservationApprovalEmail;
        public ReservationController(IReservationService service, AutoTradeContext context, ReservationApprovalEmail reservationApprovalEmail) : base(service)
        {
            _context = context;
            _reservationApprovalEmail = reservationApprovalEmail;
        }

        [HttpGet("automobile/{automobileAdId}")]
        public async Task<ActionResult> GetReservationsForAutomobile(int automobileAdId, int page = 1, int pageSize = 25)
        {
            page = page <= 0 ? 1 : page;
            pageSize = pageSize <= 0 || pageSize > 100 ? 25 : pageSize;

            var reservations = await _context.Reservations
                .Where(r => r.AutomobileAdId == automobileAdId && r.Status == "Approved")
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
                     ,
                    r.AutomobileAdId,
                })
                .ToListAsync();

            return Ok(new
            {
                count = await _context.Reservations.CountAsync(r => r.AutomobileAdId == automobileAdId),
                data = reservations
            });
        }


        [HttpGet("user/{userId}/reservations")]
        public async Task<ActionResult> GetUserReservations(int userId, int page = 1, int pageSize = 25)
        {
            page = page <= 0 ? 1 : page;
            pageSize = pageSize <= 0 || pageSize > 100 ? 25 : pageSize;

            var reservations = await _context.Reservations
                .Where(r => r.AutomobileAd.UserId == userId)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .Select(r => new
                {
                    r.Id,
                    r.ReservationDate,
                    r.Status,
                    r.UserId,
                    User = new
                    {
                        r.User.Id,
                        r.User.UserName,
                        r.User.ProfilePicture
                    },
                    r.AutomobileAdId,
                    r.AutomobileAd.Title
                })
                .ToListAsync();

            return Ok(new
            {
                count = await _context.Reservations.CountAsync(r => r.AutomobileAd.UserId == userId),
                data = reservations
            });
        }


        [HttpPost("approve/{reservationId}")]
        public async Task<ActionResult> ApproveReservation(int reservationId)
        {
            var reservation = await _context.Reservations
                .FirstOrDefaultAsync(r => r.Id == reservationId);

            if (reservation == null)
            {
                return NotFound("Reservation not found.");
            }

            if (reservation.Status == "Pending")
            {
                reservation.Status = "Approved";
                await _context.SaveChangesAsync();
                await _reservationApprovalEmail.SendReservationApprovalEmail(reservationId);

                return Ok(new { message = "Reservation approved and email sent." });

            }

            return BadRequest("Reservation is not in pending status and cannot be approved.");
        }


        [HttpPost("reject/{reservationId}")]
        public async Task<ActionResult> RejectReservation(int reservationId)
        {
            var reservation = await _context.Reservations
                .FirstOrDefaultAsync(r => r.Id == reservationId);

            if (reservation == null)
            {
                return NotFound("Reservation not found.");
            }

            if (reservation.Status == "Pending")
            {
                reservation.Status = "Rejected";
                await _context.SaveChangesAsync();
                return Ok(new { message = "Reservation rejected." });
            }

            return BadRequest("Reservation is not in pending status and cannot be rejected.");
        }



    }
}