using Microsoft.EntityFrameworkCore;
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
                    services.AddDbContext<AutoTradeContext>(options =>
                {
                    var connectionString = hostContext.Configuration.GetConnectionString("AutoTrade");
                    options.UseSqlServer(connectionString);
                });

                    services.AddSingleton<IBus>(_ =>
                    {
                        var rabbitHost = Environment.GetEnvironmentVariable("RABBITMQ_HOST") ?? "localhost";
                        var username = Environment.GetEnvironmentVariable("RABBITMQ_USERNAME") ?? "guest";
                        var password = Environment.GetEnvironmentVariable("RABBITMQ_PASSWORD") ?? "guest";
                        var virtualHost = Environment.GetEnvironmentVariable("RABBITMQ_VIRTUALHOST") ?? "/";

                        var connString =
                            $"host={rabbitHost};virtualHost={virtualHost};username={username};password={password}" +
                            ";requestedHeartbeat=60;timeout=60;publisherConfirms=true;persistentMessages=true;prefetchcount=1";

                        return RabbitHutch.CreateBus(connString);
                    });

                    services.AddScoped<ReservationApprovalEmail>();

                    services.AddHostedService<Worker>();
                })
                .Build();



            await host.RunAsync();
        }
    }
}