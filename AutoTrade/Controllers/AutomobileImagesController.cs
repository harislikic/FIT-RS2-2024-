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

        [HttpDelete("delete-images")]
        public IActionResult DeleteImages([FromBody] List<int> imageIds)
        {
            if (imageIds == null || !imageIds.Any())
            {
                return BadRequest("No image IDs provided.");
            }

            var imagesToDelete = _context.AutomobileAdImages
                .Where(image => imageIds.Contains(image.Id))
                .ToList();

            if (!imagesToDelete.Any())
            {
                return NotFound("No images found for the provided IDs.");
            }

            _context.AutomobileAdImages.RemoveRange(imagesToDelete);
            _context.SaveChanges();

            return Ok(new { Message = "Images deleted successfully." });
        }
    }
}