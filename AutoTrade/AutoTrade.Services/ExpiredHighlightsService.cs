using Microsoft.EntityFrameworkCore;
using AutoTrade.Services.Database;

public class ExpiredHighlightsService : BackgroundService
{
    private readonly IServiceScopeFactory _scopeFactory;

    public ExpiredHighlightsService(IServiceScopeFactory scopeFactory)
    {
        _scopeFactory = scopeFactory;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            using (var scope = _scopeFactory.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<AutoTradeContext>();

                Console.WriteLine("🔄 Ažuriranje highlight oglasa...");

                int affectedRows = await context.AutomobileAds
                    .Where(a => a.IsHighlighted == true && a.HighlightExpiryDate != null && a.HighlightExpiryDate < DateTime.UtcNow)
                    .ExecuteUpdateAsync(setters => setters.SetProperty(a => a.IsHighlighted, false));


                await Task.Delay(TimeSpan.FromMinutes(60), stoppingToken);
            }
        }
    }
}
