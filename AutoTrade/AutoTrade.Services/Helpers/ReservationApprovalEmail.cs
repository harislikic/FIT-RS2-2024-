using AutoTrade.Services.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MimeKit;
using System;
using System.Threading.Tasks;

namespace Helpers
{
    public class ReservationApprovalEmail
    {
        private readonly AutoTradeContext _context;
        private readonly ILogger<ReservationApprovalEmail> _logger;

        public ReservationApprovalEmail(AutoTradeContext context, ILogger<ReservationApprovalEmail> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task SendReservationApprovalEmail(int reservationId)
        {
            try
            {
                _logger.LogInformation($"[Email Servis] Dohvaćam podatke o rezervaciji sa ID={reservationId}");

                // 1️⃣ Dohvatanje rezervacije iz baze
                var reservation = await _context.Reservations
                    .Include(u => u.User).ThenInclude(x => x.City)
                    .Include(a => a.AutomobileAd)
                    .FirstOrDefaultAsync(r => r.Id == reservationId);

                if (reservation == null)
                {
                    _logger.LogWarning($"[UPOZORENJE] Rezervacija sa ID={reservationId} ne postoji.");
                    return;
                }

                if (reservation.User == null)
                {
                    _logger.LogWarning($"[UPOZORENJE] Korisnik ne postoji za rezervaciju ID={reservationId}.");
                    return;
                }

                var email = reservation.User.Email;
                if (string.IsNullOrEmpty(email))
                {
                    _logger.LogWarning($"[UPOZORENJE] Email adresa nedostaje za korisnika: {reservation.User.FirstName}");
                    return;
                }

                _logger.LogInformation($"[Email Servis] Pripremam email za korisnika: {reservation.User.FirstName} ({email})");

                // 2️⃣ Kreiranje email poruke
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("AutoTrade App", "creatus.xoxo@gmail.com"));
                message.To.Add(new MailboxAddress(reservation.User.FirstName, email));
                message.Subject = $"Rezervacija odobrena: {reservation.AutomobileAd.Title}";

                message.Body = new TextPart("plain")
                {
                    Text = $"Poštovani {reservation.User.FirstName},\n\n" +
                           $"Vaša rezervacija je odobrena!\n\n" +
                           $"📌 Detalji rezervacije:\n" +
                           $"🚗 Vozilo: {reservation.AutomobileAd.Title}\n" +
                           $"👤 Ime korisnika: {reservation.User.FirstName}\n" +
                           $"📍 Lokacija automobila: {reservation.User.City.Title}\n" +
                           $"📞 Kontakt telefon: {reservation.User.PhoneNumber}\n" +
                           $"📅 Datum rezervacije: {reservation.ReservationDate}\n" +
                           $"✅ Status rezervacije: {reservation.Status}\n\n" +
                           $"Hvala što koristite Vroom aplikaciju!"
                };

                _logger.LogInformation($"[Email Servis] Pokušavam poslati email na {email}...");

                // 3️⃣ Slanje email-a
                try
                {
                    using (var client = new MailKit.Net.Smtp.SmtpClient())
                    {
                        _logger.LogInformation($"[Email Servis] Povezujem se na SMTP server...");

                        await client.ConnectAsync("smtp.gmail.com", 587, MailKit.Security.SecureSocketOptions.StartTls);
                        _logger.LogInformation($"[Email Servis] Autentifikacija sa SMTP serverom...");

                        await client.AuthenticateAsync("creatus.xoxo@gmail.com", "xtha tujy jsbg sdll");
                        _logger.LogInformation($"[Email Servis] Slanje email-a na {email}...");

                        await client.SendAsync(message);
                        await client.DisconnectAsync(true);

                        _logger.LogInformation($"✅ [USPJEH] Email uspješno poslan na {email}");
                    }
                }
                catch (Exception emailEx)
                {
                    _logger.LogError($"❌ [GREŠKA] Neuspjelo slanje email-a na {email}: {emailEx}");
                }

            }
            catch (Exception ex)
            {
                _logger.LogError($"❌ [GREŠKA] Neočekivana greška u SendReservationApprovalEmail za rezervaciju ID={reservationId}: {ex.Message}");
            }
        }
    }
}
