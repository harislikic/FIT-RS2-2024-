using AutoTrade.Model;
using AutoTrade.Services;
using AutoTrade.Services.Database;
using Microsoft.AspNetCore.Mvc;
using Request;
using SearchObject;

namespace Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AutomobileAdController : BaseCRUDController<AutomobileAd, AutomobileAdSearchObject, AutomobileAdInsertRequst, AutomobileUpdateRequest>
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
        public async Task<IActionResult> HighlightOglas(int id ,[FromBody] HighlightAdRequest request)
        {
            var entity = await _context.AutomobileAds.FindAsync(id);
            if (entity == null) return NotFound();

            entity.IsHighlighted = true;
            entity.HighlightExpiryDate = DateTime.Now.AddDays(request.HighlightDays);

            await _context.SaveChangesAsync();
            return Ok(new { success = true });
        }
    }
}
