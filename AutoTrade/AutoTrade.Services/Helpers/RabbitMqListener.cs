using EasyNetQ;
using System;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Helpers;
using Database;
using static Controllers.ReservationController;

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

        bus.PubSub.Subscribe<ReservationNotification>("reservationApprovalSubscription", async notification =>
        {
            using (var scope = _serviceScopeFactory.CreateScope()) // Create a new scope
            {
                var emailService = scope.ServiceProvider.GetRequiredService<EmailService>();
                try
                {
                    // Call the email service to send the email notification
                    //await emailService.SendProductNotificationEmail(notification);
                    await emailService.SendReservationApprovalEmail(notification.ReservationId);
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
