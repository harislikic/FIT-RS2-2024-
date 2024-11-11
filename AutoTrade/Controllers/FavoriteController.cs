using AutoTrade.Model;
using AutoTrade.Services;
using AutoTrade.Services.Database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Request;
using SearchObject;

namespace Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FavoriteController : ControllerBase
    {

        private readonly AutoTradeContext _context;

        public FavoriteController(IFavoriteService service, AutoTradeContext context)
        {
            _context = context;
        }

        [HttpGet("{userId}")]
        public async Task<ActionResult> GetFavorites(int userId, int page = 1, int pageSize = 25)
        {

            if (page <= 0) page = 1;
            if (pageSize <= 0 || pageSize > 100) pageSize = 25;


            var totalCount = await _context.Favorites
                .Where(f => f.UserId == userId)
                .CountAsync();


            var favorites = await _context.Favorites
                .Where(f => f.UserId == userId)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .Include(f => f.AutomobileAd.Images)
                .Select(f => f.AutomobileAd)
                .ToListAsync();


            return Ok(new
            {
                count = totalCount,
                data = favorites
            });
        }


        [HttpPost]
        public async Task<ActionResult> AddFavorite(int userId, int automobilId)
        {
            if (await _context.Favorites.AnyAsync(f => f.UserId == userId && f.AutomobileAdId == automobilId))
            {
                return BadRequest("This automobilAd is already in favorites list.");
            }

            var favorite = new Database.Favorite
            {
                UserId = userId,
                AutomobileAdId = automobilId
            };

            _context.Favorites.Add(favorite);
            await _context.SaveChangesAsync();

            return Ok("Sucessefuly added");
        }

        [HttpDelete]
        public async Task<ActionResult> RemoveFavorite(int userId, int automobilId)
        {
            var favorite = await _context.Favorites
                .FirstOrDefaultAsync(f => f.UserId == userId && f.AutomobileAdId == automobilId);

            if (favorite == null)
            {
                return NotFound("Automobilad is not founded in favorites list.");
            }

            _context.Favorites.Remove(favorite);
            await _context.SaveChangesAsync();

            return Ok("AutomobilAd is removed from favorites list.");
        }
    }
}