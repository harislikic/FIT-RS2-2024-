using AutoTrade.Services.Database;
using Microsoft.EntityFrameworkCore;
using MimeKit;

namespace Helpers
{
    public class ReservationApprovalEmail
    {
        private readonly AutoTradeContext _context;

        public ReservationApprovalEmail(AutoTradeContext context)
        {
            _context = context;
        }

        public async Task SendReservationApprovalEmail(int reservationId)
        {

            var reservation = await _context.Reservations.Include(u => u.User).Include(a => a.AutomobileAd)
                .FirstOrDefaultAsync(r => r.Id == reservationId);

            if (reservation != null)
            {

                var user = reservation.User;

                if (user != null)
                {
                    var message = new MimeMessage();
                    message.From.Add(new MailboxAddress("AutoTrade App", "creatus.xoxo@gmail.com"));
                    message.To.Add(new MailboxAddress(user.FirstName, user.Email));
                    message.Subject = "Reservation Approved: " + reservation.AutomobileAd.Title;

                    message.Body = new TextPart("plain")
                    {
                        Text = $"Your reservation has been approved!\n\n" +
                               $"Reservation Details:\n" +
                               $"Car: {reservation.AutomobileAd.Title}\n" +
                               $"PhoneNumber: {reservation.AutomobileAd.User.PhoneNumber}\n" +
                               $"Reservation Date: {reservation.ReservationDate}\n" +
                               $"Reservation Status: {reservation.Status}\n\n" +
                               $"You can now proceed with the next steps. Thank you for using AutoTrade!"
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
}