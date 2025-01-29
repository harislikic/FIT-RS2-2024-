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
            [FromQuery] int? month
           )
        {

            var query = _context.PaymentTransactions.AsQueryable();

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

                .Select(t => new
                {
                    TransactionId = t.Id,
                    PaymentId = t.PaymentId,
                    Amount = t.Amount,
                    Currency = t.Currency,
                    Status = t.Status,
                    CreatedAt = t.CreatedAt,
                    UpdatedAt = t.UpdatedAt,

                })
                .ToListAsync();

            var response = new
            {
                TotalRecords = totalRecords,
                TotalAmount = totalAmount,
                Transactions = transactions
            };

            return Ok(response);
        }
    }
}
