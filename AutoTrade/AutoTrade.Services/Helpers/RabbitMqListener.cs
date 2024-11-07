using EasyNetQ;
using System;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Helpers;
using Database;

public class RabbitMqListener
{
    private readonly IServiceScopeFactory _serviceScopeFactory;

    public RabbitMqListener(IServiceScopeFactory serviceScopeFactory)
    {
        _serviceScopeFactory = serviceScopeFactory;
    }

    public void StartListening()
    {
        var bus = RabbitHutch.CreateBus("host=localhost");

        bus.PubSub.Subscribe<AutomobileAd>("automobileAdSubscription", async notification =>
        {
            using (var scope = _serviceScopeFactory.CreateScope()) // Create a new scope
            {
                var emailService = scope.ServiceProvider.GetRequiredService<EmailService>();
                try
                {
                    // Call the email service to send the email notification
                    await emailService.SendProductNotificationEmail(notification);
                }
                catch (Exception ex)
                {
                    // Log the error if something goes wrong
                    Console.WriteLine($"Error sending email: {ex.Message}");
                }
            }
        });
    }
}
