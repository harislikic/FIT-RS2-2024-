// using System;
// using System.Collections.Generic;
// using Database;

// namespace AutoTrade.Services.Database
// {
//     public static class DefaultReservationDataShort
//     {
//         public static IEnumerable<Reservation> Reservations
//         {
//             get
//             {
//                 // Da bismo bili sigurni da "Approved" padne u tekući mjesec:
//                 int year  = DateTime.UtcNow.Year;
//                 int month = DateTime.UtcNow.Month;
//                 DateTime now = DateTime.UtcNow;

//                 // Pseudonasumični dani u mjesecu koje koristimo za "Approved" rezervacije
//                 // ciklično uzimamo po 2 dana za svaku novu grupu (AutomobileAdId).
//                 int[] randomDays = new[] { 2, 4, 7, 10, 12, 15, 18, 20, 22, 25, 27, 28 };

//                 // Pomoćna funkcija: za i-tu grupu (1-based) vratiti 2 "random" dana
//                 int Day1(int i) => randomDays[(2 * (i - 1)) % randomDays.Length];
//                 int Day2(int i) => randomDays[(2 * (i - 1) + 1) % randomDays.Length];

//                 // Koji UserId dobijamo za "globalni redni broj" (1-based) rezervacije.
//                 // Ovdje rotiramo vrijednosti 1..10.
//                 int GetUserId(int globalNo) 
//                     => ((globalNo - 1) % 10) + 1;

//                 var list = new List<Reservation>(140);

//                 // Ukupno 28 oglasa
//                 // Za svaki oglas => 5 rezervacija (2 Approved + 3 Pending)
//                 // => 28 * 5 = 140 rezervacija
//                 int globalId = 1; // Id rezervacije kreće od 1

//                 for (int autoId = 1; autoId <= 28; autoId++)
//                 {
//                     // Izračunaj koji "random" dan u mjesecu ide za Approved
//                     int d1 = Day1(autoId);
//                     int d2 = Day2(autoId);

//                     // -- 2 Approved (različiti datumi unutar trenutnog mjeseca) --
//                     // Rezervacija A
//                     list.Add(new Reservation
//                     {
//                         Id = globalId,
//                         ReservationDate = new DateTime(year, month, d1),
//                         UserId = GetUserId(globalId),
//                         AutomobileAdId = autoId,
//                         Status = "Approved"
//                     });
//                     globalId++;

//                     // Rezervacija B
//                     list.Add(new Reservation
//                     {
//                         Id = globalId,
//                         ReservationDate = new DateTime(year, month, d2),
//                         UserId = GetUserId(globalId),
//                         AutomobileAdId = autoId,
//                         Status = "Approved"
//                     });
//                     globalId++;

//                     // -- 3 Pending (za +3, +5 i +7 dana od "sad") --
//                     list.Add(new Reservation
//                     {
//                         Id = globalId,
//                         ReservationDate = now.AddDays(3),
//                         UserId = GetUserId(globalId),
//                         AutomobileAdId = autoId,
//                         Status = "Pending"
//                     });
//                     globalId++;

//                     list.Add(new Reservation
//                     {
//                         Id = globalId,
//                         ReservationDate = now.AddDays(5),
//                         UserId = GetUserId(globalId),
//                         AutomobileAdId = autoId,
//                         Status = "Pending"
//                     });
//                     globalId++;

//                     list.Add(new Reservation
//                     {
//                         Id = globalId,
//                         ReservationDate = now.AddDays(7),
//                         UserId = GetUserId(globalId),
//                         AutomobileAdId = autoId,
//                         Status = "Pending"
//                     });
//                     globalId++;
//                 }

//                 return list;
//             }
//         }
//     }
// }
