using AutoTrade.Services.Database;
using Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MimeKit;

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

                var reservation = await _context.Reservations.Include(x => x.User)
                    .Include(a => a.AutomobileAd).ThenInclude(x => x.User).ThenInclude(x => x.City)
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

                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("Vroom App", "creatus.xoxo@gmail.com"));
                message.To.Add(new MailboxAddress(reservation.User.FirstName, email));
                message.Subject = $"Rezervacija odobrena: {reservation.AutomobileAd.Title}";

                message.Body = new TextPart("html")
                {
                    Text = GenerateReservationEmailBody(reservation)
                };


                _logger.LogInformation($"[Email Servis] Pokušavam poslati email na {email}...");

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



        private string GenerateReservationEmailBody(Reservation reservation)
        {
            return $@"
        <html>
        <head>
        <style>
            body {{
                font-family: Arial, sans-serif;
                line-height: 1.6;
                color: #333;
            }}
            .container {{
                max-width: 600px;
                margin: 0 auto;
                padding: 20px;
                border: 1px solid #ddd;
                border-radius: 8px;
                background-color: #f9f9f9;
            }}
            h2 {{
                color: #2c3e50;
                text-align: center;
            }}
            .details {{
                background-color: #fff;
                padding: 15px;
                border-radius: 8px;
                box-shadow: 0px 2px 5px rgba(0, 0, 0, 0.1);
            }}
            .details p {{
                margin: 8px 0;
            }}
            .highlight {{
                color: #e74c3c;
                font-weight: bold;
            }}
            .footer {{
                text-align: center;
                margin-top: 20px;
                font-size: 12px;
                color: #888;
                     }}
         </style>
             </head>
             <body>
                 <div class='container'>
                     <h2>🚗 Rezervacija odobrena!</h2>
                     <p>Poštovani <b>{reservation.User.FirstName} {reservation.User.LastName}</b>,</p>
                     <p>Vaša rezervacija je uspešno odobrena! 🎉</p>

                     <div class='details'>
                         <p><b>📌 Detalji rezervacije:</b></p>
                         <p><b>🚗 Vozilo:</b> <span class='highlight'>{reservation.AutomobileAd.Title}</span></p>
                         <p><b>👤 Vlasnik oglasa:</b> {reservation.AutomobileAd.User.FirstName} {reservation.AutomobileAd.User.LastName}</p>
                         <p><b>📍 Lokacija automobila:</b> {reservation.AutomobileAd.User.City.Title}</p>
                         <p><b>📞 Kontakt telefon:</b> {FormatPhoneNumber(reservation.AutomobileAd.User.PhoneNumber)}</p>          
                         <p><b>📅 Datum rezervacije:</b> {reservation.ReservationDate:dd.MM.yyyy}</p>
                         <p><b>✅ Status rezervacije:</b> {reservation.Status}</p>
                     </div>

                     <p class='footer'>Hvala što koristite Vroom aplikaciju! 🚗✨</p>
                 </div>
        </body>
        </html>";
        }

        private string FormatPhoneNumber(string phoneNumber)
        {
            if (string.IsNullOrEmpty(phoneNumber) || phoneNumber.Length < 6)
                return phoneNumber;

            if (phoneNumber.Length == 9)
                return $"{phoneNumber[..3]}-{phoneNumber[3..6]}-{phoneNumber[6..]}";

            if (phoneNumber.Length == 10)
                return $"{phoneNumber[..3]}-{phoneNumber[3..6]}-{phoneNumber[6..]}";

            return phoneNumber;
        }

    }
}
