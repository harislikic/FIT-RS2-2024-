using EasyNetQ;
using Helpers;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace AutoTrade.EmailSubscriber
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly IBus _bus;
        private readonly IServiceScopeFactory _scopeFactory;

        public Worker(ILogger<Worker> logger, IBus bus, IServiceScopeFactory scopeFactory)
        {
            _logger = logger;
            _bus = bus;
            _scopeFactory = scopeFactory;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation("EmailSubscriber Worker started. Subscribing to RabbitMQ...");

            await _bus.PubSub.SubscribeAsync<ReservationApproved>("autoTradeEmailSub", async message =>
            {
                _logger.LogInformation($"Received message: ReservationId={message.ReservationId}, Email={message.Email}");

                // Create a new scope for each message
                using var scope = _scopeFactory.CreateScope();

                // ✅ Resolve ReservationApprovalEmail instead of IMailService
                var emailService = scope.ServiceProvider.GetRequiredService<ReservationApprovalEmail>();

                // ✅ Call the correct method
                await emailService.SendReservationApprovalEmail(message.ReservationId);

            }, cancellationToken: stoppingToken);

            // Wait indefinitely
            await Task.Delay(Timeout.Infinite, stoppingToken);
        }
    }
    

    public class ReservationApproved
    {
        public int ReservationId { get; set; }
        public string? Email { get; set; }
    }
}
