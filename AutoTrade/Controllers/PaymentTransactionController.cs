using AutoTrade.Services.Database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PaymentTransactionController : ControllerBase
    {
        private readonly AutoTradeContext _context;

        public PaymentTransactionController(AutoTradeContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<object>>> GetAllTransactions(
            [FromQuery] int? year, 
            [FromQuery] int? month,
            [FromQuery] int pageNumber = 1, 
            [FromQuery] int pageSize = 25)
        {
            if (pageNumber < 1 || pageSize < 1)
            {
                return BadRequest("Page number and page size must be greater than 0.");
            }

            var query = _context.PaymentTransactions
                .Include(t => t.AutomobileAd)
                .AsQueryable();

            if (year.HasValue)
            {
                query = query.Where(t => t.CreatedAt.Year == year.Value);
            }

            if (month.HasValue)
            {
                query = query.Where(t => t.CreatedAt.Month == month.Value);
            }

            var totalRecords = await query.CountAsync();
            var totalAmount = await query.SumAsync(t => t.Amount);
            
            var transactions = await query
                .OrderByDescending(t => t.CreatedAt)
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .Select(t => new
                {
                    TransactionId = t.Id,
                    PaymentId = t.PaymentId,
                    Amount = t.Amount,
                    Currency = t.Currency,
                    Status = t.Status,
                    CreatedAt = t.CreatedAt,
                    UpdatedAt = t.UpdatedAt,
                    AutomobileAd = t.AutomobileAd != null ? new
                    {
                        t.AutomobileAd.Id,
                        t.AutomobileAd.Title
                    } : null
                })
                .ToListAsync();

            var response = new
            {
                TotalRecords = totalRecords,
                TotalAmount = totalAmount,
                PageNumber = pageNumber,
                PageSize = pageSize,
                TotalPages = (int)Math.Ceiling(totalRecords / (double)pageSize),
                Transactions = transactions
            };

            return Ok(response);
        }
    }
}
