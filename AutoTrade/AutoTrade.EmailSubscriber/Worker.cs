using EasyNetQ;
using Helpers;


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

            try
            {
                if (_bus != null)
                {
                    await _bus.PubSub.SubscribeAsync<ReservationApproved>("autoTradeEmailSub", async message =>
                    {
                        _logger.LogInformation($"Received message: ReservationId={message.ReservationId}, Email={message.Email}");

                        using var scope = _scopeFactory.CreateScope();
                        var emailService = scope.ServiceProvider.GetRequiredService<ReservationApprovalEmail>();

                        await emailService.SendReservationApprovalEmail(message.ReservationId);
                    }, cancellationToken: stoppingToken);
                }
                else
                {
                    _logger.LogWarning("⚠️ RabbitMQ bus is null. Skipping subscription.");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "❌ Failed to subscribe to RabbitMQ. The worker will continue running.");
            }

            await Task.Delay(Timeout.Infinite, stoppingToken);
        }

    }


    public class ReservationApproved
    {
        public int ReservationId { get; set; }
        public string? Email { get; set; }
    }
}
