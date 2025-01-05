using AutoTrade.Model;
using AutoTrade.Services;
using AutoTrade.Services.Database;
using Database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Request;
using SearchObject;

namespace Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AutomobileAdController : BaseCRUDController<AutoTrade.Model.AutomobileAd, AutomobileAdSearchObject, AutomobileAdInsertRequst, AutomobileUpdateRequest>
    {
        private readonly IAutomobileAdService _automobileAdService;

        private AutoTradeContext _context;

        public AutomobileAdController(IAutomobileAdService service, AutoTradeContext context) : base(service)
        {
            _automobileAdService = service;
            _context = context;
        }

        [HttpPut("mark-as-done/{id}")]
        public IActionResult MarkAsDone(int id)
        {
            try
            {
                var updatedAd = _automobileAdService.MarkAsDone(id);
                return Ok(updatedAd);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }


        [HttpPost("api/highlight-ad")]
        public async Task<IActionResult> HighlightOglas(int id, [FromBody] HighlightAdRequest request)
        {
            var entity = await _context.AutomobileAds.FindAsync(id);
            if (entity == null) return NotFound();



            if (entity.HighlightExpiryDate.HasValue && entity.HighlightExpiryDate.Value > DateTime.Now)
            {
                entity.HighlightExpiryDate = entity.HighlightExpiryDate.Value.AddDays(request.HighlightDays);
            }
            else
            {
                entity.HighlightExpiryDate = DateTime.Now.AddDays(request.HighlightDays);
            }
            entity.IsHighlighted = true;

            var transaction = new PaymentTransaction
            {
                Amount = request.Amount.Value,
                Currency = "USD",
                Status = "success", // Status će biti ažuriran nakon Stripe webhook-a
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
                AutomobileAdId = id
            };
            _context.PaymentTransactions.Add(transaction);
            await _context.SaveChangesAsync();


            return Ok(new
            {
                success = true,

                transactionId = transaction.Id
            });
        }

        [HttpGet("user-ads/{userId}")]
        public async Task<IActionResult> GetAdsByUser(int userId, int page = 1, int pageSize = 25)
        {
            try
            {
                if (page <= 0) page = 1;
                if (pageSize <= 0 || pageSize > 100) pageSize = 25;

                var totalCount = await _context.AutomobileAds
                    .Where(ad => ad.UserId == userId)
                    .CountAsync();

                var userAds = await _context.AutomobileAds
                    .Where(ad => ad.UserId == userId)
                    .Include(ad => ad.Images)
                    .Skip((page - 1) * pageSize)
                    .Take(pageSize)
                    .ToListAsync();

                if (userAds == null || !userAds.Any())
                {
                    return NotFound($"No ads found for user with ID {userId}");
                }

                return Ok(new
                {
                    count = totalCount,
                    data = userAds
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

    }
}
