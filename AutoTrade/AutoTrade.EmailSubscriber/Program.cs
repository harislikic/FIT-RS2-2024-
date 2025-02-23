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

                    services.AddSingleton<IBus>(sp =>
                     {
                         var config = hostContext.Configuration;
                         var rabbitHost = config["RabbitMQ:Host"] ?? "rabbitmq";
                         var username = config["RabbitMQ:Username"] ?? "guest";
                         var password = config["RabbitMQ:Password"] ?? "guest";
                         var virtualHost = config["RabbitMQ:VirtualHost"] ?? "/";
                    
                         var connString = $"host={rabbitHost};virtualHost={virtualHost};username={username};password={password}" +
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