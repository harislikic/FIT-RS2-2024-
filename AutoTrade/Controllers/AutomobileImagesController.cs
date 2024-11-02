using AutoTrade.Services.Database;
using Microsoft.AspNetCore.Mvc;

namespace Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AutomobileImagesController : ControllerBase
    {
        private readonly AutoTradeContext _context;

        public AutomobileImagesController(AutoTradeContext context)
        {
            _context = context;
        }

        [HttpGet("{automobileAdId}")]
        public ActionResult<IEnumerable<string>> GetImagesByAutomobileAdId(int automobileAdId)
        {
            var images = _context.AutomobileAdImages
                .Where(image => image.AutomobileAdId == automobileAdId)
                .Select(image => image.ImageUrl)
                .ToList();

            if (!images.Any())
            {
                return NotFound();
            }

            return Ok(images);
        }
    }
}