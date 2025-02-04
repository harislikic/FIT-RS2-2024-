using System;
using System.Collections.Generic;
using Database;

namespace AutoTrade.Services.Database
{
    public static class DefaultCommentData
    {
        public static IEnumerable<Comment> Comments
        {
            get => new List<Comment>()
            {
                // Audi A3 2018 (AutomobileAdId = 1)
                new Comment { Id = 1, Content = "Izgleda odlično! Ima li servisnu knjižicu?", CreatedAt = DateTime.UtcNow, UserId = 2, AutomobileAdId = 1 },
                new Comment { Id = 2, Content = "Može li zamjena za Passat?", CreatedAt = DateTime.UtcNow, UserId = 3, AutomobileAdId = 1 },

                // Audi A3 S-Line (AutomobileAdId = 2)
                new Comment { Id = 3, Content = "Predivan auto! Kakvo je stanje felgi?", CreatedAt = DateTime.UtcNow, UserId = 1, AutomobileAdId = 2 },
                new Comment { Id = 4, Content = "Da li je moguće probna vožnja?", CreatedAt = DateTime.UtcNow, UserId = 4, AutomobileAdId = 2 },

                // Audi A4 B8 Karavan (AutomobileAdId = 3)
                new Comment { Id = 5, Content = "Super ponuda! Kada je zadnji put zamijenjen ulje i filteri?", CreatedAt = DateTime.UtcNow, UserId = 5, AutomobileAdId = 3 },
                new Comment { Id = 6, Content = "Je li kilometraža tačna?", CreatedAt = DateTime.UtcNow, UserId = 6, AutomobileAdId = 3 },

                // Audi A5 (AutomobileAdId = 4)
                new Comment { Id = 7, Content = "Fantastičan auto! Kakvo je stanje enterijera?", CreatedAt = DateTime.UtcNow, UserId = 3, AutomobileAdId = 4 },
                new Comment { Id = 8, Content = "Mogu li dobiti više slika unutrašnjosti?", CreatedAt = DateTime.UtcNow, UserId = 7, AutomobileAdId = 4 },

                // Audi A6 (AutomobileAdId = 5)
                new Comment { Id = 9, Content = "Top model! Da li je registrovan?", CreatedAt = DateTime.UtcNow, UserId = 8, AutomobileAdId = 5 },
                new Comment { Id = 10, Content = "Koliko je star akumulator?", CreatedAt = DateTime.UtcNow, UserId = 9, AutomobileAdId = 5 },

                // BMW E60 (AutomobileAdId = 6)
                new Comment { Id = 11, Content = "Odličan BMW! Koliko troši goriva u prosjeku?", CreatedAt = DateTime.UtcNow, UserId = 10, AutomobileAdId = 6 },
                new Comment { Id = 12, Content = "Ima li problema sa motorom?", CreatedAt = DateTime.UtcNow, UserId = 1, AutomobileAdId = 6 },

                // Citroen DS5 (AutomobileAdId = 7)
                new Comment { Id = 13, Content = "Citroen izgleda moćno! Kakvo je stanje guma?", CreatedAt = DateTime.UtcNow, UserId = 2, AutomobileAdId = 7 },
                new Comment { Id = 14, Content = "Je li prva boja na vozilu?", CreatedAt = DateTime.UtcNow, UserId = 3, AutomobileAdId = 7 },

                // Fiat Punto (AutomobileAdId = 8)
                new Comment { Id = 15, Content = "Punto je odlično gradsko auto! Ima li servisna evidencija?", CreatedAt = DateTime.UtcNow, UserId = 4, AutomobileAdId = 8 },
                new Comment { Id = 16, Content = "Koliko je prešao od zadnje izmjene ulja?", CreatedAt = DateTime.UtcNow, UserId = 5, AutomobileAdId = 8 },

                // Golf 4 (AutomobileAdId = 9)
                new Comment { Id = 17, Content = "Ovaj Golf izgleda kao da je očuvan! Kakvo je stanje limarije?", CreatedAt = DateTime.UtcNow, UserId = 6, AutomobileAdId = 9 },
                new Comment { Id = 18, Content = "Ima li klima?", CreatedAt = DateTime.UtcNow, UserId = 7, AutomobileAdId = 9 },

                // Golf 6 GTD (AutomobileAdId = 10)
                new Comment { Id = 19, Content = "Perfektan auto! Ima li mogućnost kupovine na rate?", CreatedAt = DateTime.UtcNow, UserId = 8, AutomobileAdId = 10 },
                new Comment { Id = 20, Content = "Koliko je star akumulator?", CreatedAt = DateTime.UtcNow, UserId = 9, AutomobileAdId = 10 },

                // Golf 7 (AutomobileAdId = 11)
                new Comment { Id = 21, Content = "Odličan Golf! Da li je uvoz ili kupljen kod nas?", CreatedAt = DateTime.UtcNow, UserId = 10, AutomobileAdId = 11 },
                new Comment { Id = 22, Content = "Jesi li radio veliki servis?", CreatedAt = DateTime.UtcNow, UserId = 1, AutomobileAdId = 11 },

                // Polo 2006 (AutomobileAdId = 21)
                new Comment { Id = 23, Content = "Odlična cijena za Polo! Kakvo je stanje sjedala?", CreatedAt = DateTime.UtcNow, UserId = 2, AutomobileAdId = 21 },
                new Comment { Id = 24, Content = "Ima li hrđe na rubovima?", CreatedAt = DateTime.UtcNow, UserId = 3, AutomobileAdId = 21 },

                // Tiguan (AutomobileAdId = 28)
                new Comment { Id = 25, Content = "Tiguan izgleda odlično! Je li redovno održavan?", CreatedAt = DateTime.UtcNow, UserId = 4, AutomobileAdId = 28 },
                new Comment { Id = 26, Content = "Koliko troši na otvorenoj cesti?", CreatedAt = DateTime.UtcNow, UserId = 5, AutomobileAdId = 28 },

                // Renault Scenic (AutomobileAdId = 24)
                new Comment { Id = 27, Content = "Scenic je idealan za porodicu! Kakvo je stanje zadnjih sjedišta?", CreatedAt = DateTime.UtcNow, UserId = 6, AutomobileAdId = 24 },
                new Comment { Id = 28, Content = "Koliko traje registracija?", CreatedAt = DateTime.UtcNow, UserId = 7, AutomobileAdId = 24 },

                // Skoda Octavia (AutomobileAdId = 26)
                new Comment { Id = 29, Content = "Odlična Skoda! Može li se pogledati u Sarajevu?", CreatedAt = DateTime.UtcNow, UserId = 8, AutomobileAdId = 26 },
                new Comment { Id = 30, Content = "Koliko su stare gume?", CreatedAt = DateTime.UtcNow, UserId = 9, AutomobileAdId = 26 },

                // WV bora (AutomobileAdId = 27)
                 new Comment { Id = 31, Content = "Koliko su stare gume?", CreatedAt = DateTime.UtcNow, UserId = 1, AutomobileAdId = 27 },

                  // Tiguan (AutomobileAdId = 28)
                new Comment { Id = 33, Content = "Koliko su stare gume, jel ima i zimske?", CreatedAt = DateTime.UtcNow, UserId = 2, AutomobileAdId = 28 }
            };
        }
    }
}
