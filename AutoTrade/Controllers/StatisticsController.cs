using AutoTrade.Services.Database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AutoTrade.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatisticsController : ControllerBase
    {
        private readonly AutoTradeContext _context;

        public StatisticsController(AutoTradeContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetStatistics()
        {
            var totalAutomobileAds = await _context.AutomobileAds.CountAsync();
            var totalUsers = await _context.Users
            .Where(u => !u.IsAdmin)
            .CountAsync();

            var totalComments = await _context.Comments.CountAsync();

            var automobilesPerCity = await _context.AutomobileAds
                .GroupBy(a => a.User.City.Title)
                .Select(g => new
                {
                    City = g.Key,
                    AutomobileCount = g.Count()
                })
                .ToListAsync();

            var mostFavoritedCar = await _context.Favorites
                .GroupBy(f => f.AutomobileAdId)
                .Select(g => new
                {
                    AutomobileAdId = g.Key,
                    FavoriteCount = g.Count()
                })
                .OrderByDescending(g => g.FavoriteCount)
                .FirstOrDefaultAsync();

            var mostFavoritedCarDetails = mostFavoritedCar != null
                ? await _context.AutomobileAds
                    .Where(a => a.Id == mostFavoritedCar.AutomobileAdId)
                    .Select(a => new { a.Title, a.Price })
                    .FirstOrDefaultAsync()
                : null;

            var commentPerAutomobileAd = await _context.Comments
                .GroupBy(c => c.AutomobileAdId)
                .Select(g => new
                {
                    AutomobileAdId = g.Key,
                    CommentCount = g.Count()
                })
                .ToListAsync();

            var highlightedCars = await _context.AutomobileAds.CountAsync(a => a.IsHighlighted == true);




            var statistics = new
            {
                TotalAutomobileAds = totalAutomobileAds,
                TotalUsers = totalUsers,
                TotalComments = totalComments,
                AutomobilesPerCity = automobilesPerCity,
                MostFavoritedCar = new
                {
                    mostFavoritedCar?.AutomobileAdId,
                    mostFavoritedCar?.FavoriteCount,
                    mostFavoritedCarDetails
                },
                HighlightedCars = highlightedCars
            };

            return Ok(statistics);
        }
    }
}
