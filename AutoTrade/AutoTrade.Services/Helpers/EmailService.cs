using Database;
using MimeKit;
using AutoTrade.Services.Database;
using Microsoft.EntityFrameworkCore;

namespace Helpers
{
    public class EmailService
    {
        private readonly AutoTradeContext _context;

        public EmailService(AutoTradeContext context)
        {
            _context = context;
        }

        public async Task SendReservationApprovalEmail(int reservationId)
        {

            var reservation = await _context.Reservations
                .Include(r => r.AutomobileAd).Include(x => x.User)
                .FirstOrDefaultAsync(r => r.Id == reservationId);

            if (reservation != null && reservation.User != null)
            {
                var user = reservation.User;
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("AutoTrade App", "creatus.xoxo@gmail.com"));
                message.To.Add(new MailboxAddress(user.FirstName, user.Email));
                message.Subject = "Reservation Approved: " + reservation.AutomobileAd.Title;

  
                message.Body = new TextPart("plain")
                {
                    Text = $"Poštovani {user.FirstName},\n\n" +
                           $"Vaša rezervacija za {reservation.AutomobileAd.Title} je odobrena!\n\n" +
                           $"Detalji Rezervacije:\n" +
                           $"- Auto: {reservation.AutomobileAd.Title}\n" +
                           $"- Datum rezervacije: {reservation.ReservationDate:dd.MM.yyyy}\n\n" +
                           "Hvala vam što koristite AutoTrade App.\n\n" +
                           "Sve najbolje,\n" +
                           "AutoTrade Tim"
                };

                // Pošalji email koristeći SMTP klijent
                using (var client = new MailKit.Net.Smtp.SmtpClient())
                {
                    await client.ConnectAsync("smtp.gmail.com", 587, MailKit.Security.SecureSocketOptions.StartTls);
                    await client.AuthenticateAsync("creatus.xoxo@gmail.com", "xtha tujy jsbg sdll");
                    await client.SendAsync(message);
                    await client.DisconnectAsync(true);
                }
            }
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
