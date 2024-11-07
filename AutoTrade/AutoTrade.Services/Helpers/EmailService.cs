using System.Linq;
using System.Net.Mail;
using Database;
using MimeKit;
using MailKit.Net.Smtp;
using AutoTrade.Services;
using AutoTrade.Services.Database;
using System.Threading.Tasks;

namespace Helpers
{
    public class EmailService
    {
        private readonly AutoTradeContext _context;

        public EmailService(AutoTradeContext context)
        {
            _context = context;
        }


        public async Task SendProductNotificationEmail(AutomobileAd notification)
        {

            var user = _context.Users.FirstOrDefault();

            if (user != null)
            {
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("AutoTrade App", "creatus.xoxo@gmail.com"));
                message.To.Add(new MailboxAddress(user.FirstName, user.Email));
                message.Subject = "New Product Added: " + notification.Title;

                message.Body = new TextPart("plain")
                {
                    Text = $"A new Ad has been added!\n\n" +
                           $"Ad: {notification.Title}\n" +
                           $"Description: {notification.Description}\n" +
                           $"Date: {notification.DateOFadd}\n" +
                           $"Status: {notification.Status}\n"
                };

                using (var client = new MailKit.Net.Smtp.SmtpClient())
                {
    
                    await client.ConnectAsync("smtp.gmail.com", 587, MailKit.Security.SecureSocketOptions.StartTls);
                    await client.AuthenticateAsync("creatus.xoxo@gmail.com", "xtha tujy jsbg sdll");

                
                    await client.SendAsync(message);
                    await client.DisconnectAsync(true);
                }
            }
        }
    }
}
