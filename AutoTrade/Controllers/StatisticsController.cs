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
            var fiveYearsAgo = DateTime.UtcNow.AddYears(-10);

            var totalAutomobileAds = await _context.AutomobileAds.CountAsync();
            var totalUsers = await _context.Users.CountAsync(u => !u.IsAdmin);
            var usersRegisteredLastFiveYear = await _context.Users.CountAsync(u => u.CreatedAt >= fiveYearsAgo && !u.IsAdmin);
            var totalComments = await _context.Comments.CountAsync();


            var automobilesPerCity = await _context.AutomobileAds
                .GroupBy(a => a.User.City.Title)
                .Select(g => new
                {
                    City = g.Key,
                    AutomobileCount = g.Count()
                })
                .ToListAsync();


            var mostFavoritedCars = await _context.Favorites
                .GroupBy(f => f.AutomobileAdId)
                .Select(g => new
                {
                    AutomobileAdId = g.Key,
                    FavoriteCount = g.Count()
                })
                .OrderByDescending(g => g.FavoriteCount)
                .Take(10)
                .ToListAsync();

            var mostFavoritedCarDetails = await _context.AutomobileAds
                .Where(a => mostFavoritedCars.Select(m => m.AutomobileAdId).Contains(a.Id))
                .Select(a => new
                {
                    a.Id,
                    a.Title,
                    a.Price,
                    a.CarBrand
                })
                .ToListAsync();

            var favoriteCarsWithDetails = mostFavoritedCars
                .Select(f => new
                {
                    f.AutomobileAdId,
                    f.FavoriteCount,
                    Details = mostFavoritedCarDetails.FirstOrDefault(a => a.Id == f.AutomobileAdId)
                });

         
            var totalAutomobileViews = await _context.AutomobileAds.SumAsync(a => (int?)a.ViewsCount) ?? 0;

         
            var highlightedCars = await _context.AutomobileAds.CountAsync(a => a.IsHighlighted == true);

            var statistics = new
            {
                TotalAutomobileAds = totalAutomobileAds,
                TotalUsers = totalUsers,
                UsersRegisteredLastFiveYear = usersRegisteredLastFiveYear,
                TotalComments = totalComments,
                AutomobilesPerCity = automobilesPerCity,
                MostFavoritedCars = favoriteCarsWithDetails,
                TotalAutomobileViews = totalAutomobileViews,
                HighlightedCars = highlightedCars
            };

            return Ok(statistics);
        }
    }
}
