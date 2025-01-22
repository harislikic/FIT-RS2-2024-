using AutoTrade.Model;
using AutoTrade.Services;
using AutoTrade.Services.Database;
using EasyNetQ;
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
                .Where(r => r.AutomobileAdId == automobileAdId)
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
        public async Task<ActionResult> GetUserReservations(int userId, string? status = null, int page = 1, int pageSize = 25)
        {
            page = page <= 0 ? 1 : page;
            pageSize = pageSize <= 0 || pageSize > 100 ? 25 : pageSize;

            var query = _context.Reservations
                  .Include(x => x.AutomobileAd)
                  .ThenInclude(x => x.Images)
                  .Include(r => r.User)
                  .Where(r => r.AutomobileAd.UserId == userId);

            if (!string.IsNullOrEmpty(status))
            {
                query = query.Where(r => r.Status == status);
            }

            var reservations = await query
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
              r.AutomobileAd.Title,
              r.AutomobileAd.Price,
              FirstImage = r.AutomobileAd.Images
                  .Select(img => img.ImageUrl)
                  .FirstOrDefault()
          })
          .ToListAsync();

            return Ok(new
            {
                count = await _context.Reservations.CountAsync(r => r.UserId == userId),
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
                // await _reservationApprovalEmail.SendReservationApprovalEmail(reservationId);

                //rabit mq slanje maila

                var bus = RabbitHutch.CreateBus("host=localhost");
                await bus.PubSub.PublishAsync(new ReservationNotification { ReservationId = reservationId });

                // var emailService = new EmailService(_context);
                // await emailService.SendReservationApprovalEmail(reservationId);

                return Ok(new { message = "Reservation approved and email sent." });

            }

            return BadRequest("Reservation is not in pending status and cannot be approved.");
        }

        public class ReservationNotification
        {
            public int ReservationId { get; set; }
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