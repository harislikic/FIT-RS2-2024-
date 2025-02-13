using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using EasyNetQ;
using Helpers;
using AutoTrade.Services.Database;

namespace AutoTrade.EmailSubscriber
{
    public static class Program
    {
        public static async Task Main(string[] args)
        {
            var host = Host.CreateDefaultBuilder(args)
                .ConfigureServices((hostContext, services) =>
                {
                    // 1) Registruj DbContext
                    services.AddDbContext<AutoTradeContext>(options =>
                    {
                        // Tvoj connection string
                        options.UseSqlServer("Data Source=127.0.0.1;Initial Catalog=AutoTrade;User ID=SA;Password=MyPass@word");
                    });

                    // 2) Registruj RabbitMQ (IBus)
                    services.AddSingleton<IBus>(_ =>
                    {
                        // (Ovo je primer, prilagodi ako je localhost umesto rabbitmq)
                        var rabbitHost = Environment.GetEnvironmentVariable("RABBITMQ_HOST") ?? "localhost";
                        var username = Environment.GetEnvironmentVariable("RABBITMQ_USERNAME") ?? "guest";
                        var password = Environment.GetEnvironmentVariable("RABBITMQ_PASSWORD") ?? "guest";
                        var virtualHost = Environment.GetEnvironmentVariable("RABBITMQ_VIRTUALHOST") ?? "/";

                        var connString =
                            $"host={rabbitHost};virtualHost={virtualHost};username={username};password={password}" +
                            ";requestedHeartbeat=60;timeout=60;publisherConfirms=true;persistentMessages=true;prefetchcount=1";

                        return RabbitHutch.CreateBus(connString);
                    });

                    // 3) Registruj ReservationApprovalEmail kao Scoped (NE Singleton!)
                    services.AddScoped<ReservationApprovalEmail>();

                    // 4) Registruj Worker (BackgroundService) - on ostaje Singleton
                    services.AddHostedService<Worker>();
                })
                .Build();

            // using (var scope = host.Services.CreateScope())
            // {
            //     var emailService = scope.ServiceProvider.GetRequiredService<ReservationApprovalEmail>();

            //     // TESTIRAJ SLANJE EMAILA
            //     await emailService.SendReservationApprovalEmail(32);
            // }

            await host.RunAsync();
        }
    }
}
