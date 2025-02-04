using System;
using System.Collections.Generic;
using Database;

namespace AutoTrade.Services.Database
{
    public static class DefaultReservationData
    {
        public static IEnumerable<Reservation> Reservations
        {
            get => new List<Reservation>()
            {
                // ================= AutomobileAdId = 1 (ID: 1..5) =================
                new Reservation { 
                    Id = 1, 
                    ReservationDate = new DateTime(DateTime.UtcNow.Year, DateTime.UtcNow.Month, 2),
                    UserId = 1, 
                    AutomobileAdId = 1, 
                    Status = "Approved" 
                },
                new Reservation { 
                    Id = 2, 
                    ReservationDate = new DateTime(DateTime.UtcNow.Year, DateTime.UtcNow.Month, 4),
                    UserId = 2, 
                    AutomobileAdId = 1, 
                    Status = "Approved" 
                },
                new Reservation { 
                    Id = 3, 
                    ReservationDate = DateTime.UtcNow.AddDays(3), 
                    UserId = 3, 
                    AutomobileAdId = 1, 
                    Status = "Pending" 
                },
                new Reservation { 
                    Id = 4, 
                    ReservationDate = DateTime.UtcNow.AddDays(5), 
                    UserId = 4, 
                    AutomobileAdId = 1, 
                    Status = "Pending" 
                },
                new Reservation { 
                    Id = 5, 
                    ReservationDate = DateTime.UtcNow.AddDays(7), 
                    UserId = 5, 
                    AutomobileAdId = 1, 
                    Status = "Pending" 
                },

                // ================= AutomobileAdId = 2 (ID: 6..10) =================
                new Reservation { 
                    Id = 6, 
                    ReservationDate = new DateTime(DateTime.UtcNow.Year, DateTime.UtcNow.Month, 7),
                    UserId = 6, 
                    AutomobileAdId = 2, 
                    Status = "Approved" 
                },
                new Reservation { 
                    Id = 7, 
                    ReservationDate = new DateTime(DateTime.UtcNow.Year, DateTime.UtcNow.Month, 10),
                    UserId = 7, 
                    AutomobileAdId = 2, 
                    Status = "Approved" 
                },
                new Reservation { 
                    Id = 8, 
                    ReservationDate = DateTime.UtcNow.AddDays(3), 
                    UserId = 8, 
                    AutomobileAdId = 2, 
                    Status = "Pending" 
                },
                new Reservation { 
                    Id = 9, 
                    ReservationDate = DateTime.UtcNow.AddDays(5), 
                    UserId = 9, 
                    AutomobileAdId = 2, 
                    Status = "Pending" 
                },
                new Reservation { 
                    Id = 10, 
                    ReservationDate = DateTime.UtcNow.AddDays(7), 
                    UserId = 10, 
                    AutomobileAdId = 2, 
                    Status = "Pending" 
                },

                // ================= AutomobileAdId = 3 (ID: 11..15) =================
                new Reservation { 
                    Id = 11, 
                    ReservationDate = new DateTime(DateTime.UtcNow.Year, DateTime.UtcNow.Month, 12),
                    UserId = 1, 
                    AutomobileAdId = 3, 
                    Status = "Approved" 
                },
                new Reservation { 
                    Id = 12, 
                    ReservationDate = new DateTime(DateTime.UtcNow.Year, DateTime.UtcNow.Month, 15),
                    UserId = 2, 
                    AutomobileAdId = 3, 
                    Status = "Approved" 
                },
                new Reservation { 
                    Id = 13, 
                    ReservationDate = DateTime.UtcNow.AddDays(3), 
                    UserId = 3, 
                    AutomobileAdId = 3, 
                    Status = "Pending" 
                },
                new Reservation { 
                    Id = 14, 
                    ReservationDate = DateTime.UtcNow.AddDays(5), 
                    UserId = 4, 
                    AutomobileAdId = 3, 
                    Status = "Pending" 
                },
                new Reservation { 
                    Id = 15, 
                    ReservationDate = DateTime.UtcNow.AddDays(7), 
                    UserId = 5, 
                    AutomobileAdId = 3, 
                    Status = "Pending" 
                },

                // ================= AutomobileAdId = 4 (ID: 16..20) =================
                new Reservation { 
                    Id = 16, 
                    ReservationDate = new DateTime(DateTime.UtcNow.Year, DateTime.UtcNow.Month, 18),
                    UserId = 6, 
                    AutomobileAdId = 4, 
                    Status = "Approved" 
                },
                new Reservation { 
                    Id = 17, 
                    ReservationDate = new DateTime(DateTime.UtcNow.Year, DateTime.UtcNow.Month, 20),
                    UserId = 7, 
                    AutomobileAdId = 4, 
                    Status = "Approved" 
                },
                new Reservation { 
                    Id = 18, 
                    ReservationDate = DateTime.UtcNow.AddDays(3), 
                    UserId = 8, 
                    AutomobileAdId = 4, 
                    Status = "Pending" 
                },
                new Reservation { 
                    Id = 19, 
                    ReservationDate = DateTime.UtcNow.AddDays(5), 
                    UserId = 9, 
                    AutomobileAdId = 4, 
                    Status = "Pending" 
                },
                new Reservation { 
                    Id = 20, 
                    ReservationDate = DateTime.UtcNow.AddDays(7), 
                    UserId = 10, 
                    AutomobileAdId = 4, 
                    Status = "Pending" 
                },

                // ================= AutomobileAdId = 5 (ID: 21..25) =================
                new Reservation { 
                    Id = 21, 
                    ReservationDate = new DateTime(DateTime.UtcNow.Year, DateTime.UtcNow.Month, 22),
                    UserId = 1, 
                    AutomobileAdId = 5, 
                    Status = "Approved" 
                },
                new Reservation { 
                    Id = 22, 
                    ReservationDate = new DateTime(DateTime.UtcNow.Year, DateTime.UtcNow.Month, 25),
                    UserId = 2, 
                    AutomobileAdId = 5, 
                    Status = "Approved" 
                },
                new Reservation { 
                    Id = 23, 
                    ReservationDate = DateTime.UtcNow.AddDays(3), 
                    UserId = 3, 
                    AutomobileAdId = 5, 
                    Status = "Pending" 
                },
                new Reservation { 
                    Id = 24, 
                    ReservationDate = DateTime.UtcNow.AddDays(5), 
                    UserId = 4, 
                    AutomobileAdId = 5, 
                    Status = "Pending" 
                },
                new Reservation { 
                    Id = 25, 
                    ReservationDate = DateTime.UtcNow.AddDays(7), 
                    UserId = 5, 
                    AutomobileAdId = 5, 
                    Status = "Pending" 
                },

                // ================= AutomobileAdId = 6 (ID: 26..30) =================
                new Reservation { 
                    Id = 26, 
                    ReservationDate = new DateTime(DateTime.UtcNow.Year, DateTime.UtcNow.Month, 27),
                    UserId = 6, 
                    AutomobileAdId = 6, 
                    Status = "Approved" 
                },
                new Reservation { 
                    Id = 27, 
                    ReservationDate = new DateTime(DateTime.UtcNow.Year, DateTime.UtcNow.Month, 28),
                    UserId = 7, 
                    AutomobileAdId = 6, 
                    Status = "Approved" 
                },
                new Reservation { 
                    Id = 28, 
                    ReservationDate = DateTime.UtcNow.AddDays(3), 
                    UserId = 8, 
                    AutomobileAdId = 6, 
                    Status = "Pending" 
                },
                new Reservation { 
                    Id = 29, 
                    ReservationDate = DateTime.UtcNow.AddDays(5), 
                    UserId = 9, 
                    AutomobileAdId = 6, 
                    Status = "Pending" 
                },
                new Reservation { 
                    Id = 30, 
                    ReservationDate = DateTime.UtcNow.AddDays(7), 
                    UserId = 10, 
                    AutomobileAdId = 6, 
                    Status = "Pending" 
                },

                // ================= AutomobileAdId = 7 (ID: 31..35) =================
                new Reservation { 
                    Id = 31, 
                    ReservationDate = new DateTime(DateTime.UtcNow.Year, DateTime.UtcNow.Month, 2),
                    UserId = 1, 
                    AutomobileAdId = 7, 
                    Status = "Approved" 
                },
                new Reservation { 
                    Id = 32, 
                    ReservationDate = new DateTime(DateTime.UtcNow.Year, DateTime.UtcNow.Month, 4),
                    UserId = 2, 
                    AutomobileAdId = 7, 
                    Status = "Approved" 
                },
                new Reservation { 
                    Id = 33, 
                    ReservationDate = DateTime.UtcNow.AddDays(3), 
                    UserId = 3, 
                    AutomobileAdId = 7, 
                    Status = "Pending" 
                },
                new Reservation { 
                    Id = 34, 
                    ReservationDate = DateTime.UtcNow.AddDays(5), 
                    UserId = 4, 
                    AutomobileAdId = 7, 
                    Status = "Pending" 
                },
                new Reservation { 
                    Id = 35, 
                    ReservationDate = DateTime.UtcNow.AddDays(7), 
                    UserId = 5, 
                    AutomobileAdId = 7, 
                    Status = "Pending" 
                },

                // ================= AutomobileAdId = 8 (ID: 36..40) =================
                new Reservation { 
                    Id = 36, 
                    ReservationDate = new DateTime(DateTime.UtcNow.Year, DateTime.UtcNow.Month, 7),
                    UserId = 6, 
                    AutomobileAdId = 8, 
                    Status = "Approved" 
                },
                new Reservation { 
                    Id = 37, 
                    ReservationDate = new DateTime(DateTime.UtcNow.Year, DateTime.UtcNow.Month, 10),
                    UserId = 7, 
                    AutomobileAdId = 8, 
                    Status = "Approved" 
                },
                new Reservation { 
                    Id = 38, 
                    ReservationDate = DateTime.UtcNow.AddDays(3), 
                    UserId = 8, 
                    AutomobileAdId = 8, 
                    Status = "Pending" 
                },
                new Reservation { 
                    Id = 39, 
                    ReservationDate = DateTime.UtcNow.AddDays(5), 
                    UserId = 9, 
                    AutomobileAdId = 8, 
                    Status = "Pending" 
                },
                new Reservation { 
                    Id = 40, 
                    ReservationDate = DateTime.UtcNow.AddDays(7), 
                    UserId = 10, 
                    AutomobileAdId = 8, 
                    Status = "Pending" 
                },

                // ================= AutomobileAdId = 9 (ID: 41..45) =================
                new Reservation { 
                    Id = 41, 
                    ReservationDate = new DateTime(DateTime.UtcNow.Year, DateTime.UtcNow.Month, 12),
                    UserId = 1, 
                    AutomobileAdId = 9, 
                    Status = "Approved" 
                },
                new Reservation { 
                    Id = 42, 
                    ReservationDate = new DateTime(DateTime.UtcNow.Year, DateTime.UtcNow.Month, 15),
                    UserId = 2, 
                    AutomobileAdId = 9, 
                    Status = "Approved" 
                },
                new Reservation { 
                    Id = 43, 
                    ReservationDate = DateTime.UtcNow.AddDays(3), 
                    UserId = 3, 
                    AutomobileAdId = 9, 
                    Status = "Pending" 
                },
                new Reservation { 
                    Id = 44, 
                    ReservationDate = DateTime.UtcNow.AddDays(5), 
                    UserId = 4, 
                    AutomobileAdId = 9, 
                    Status = "Pending" 
                },
                new Reservation { 
                    Id = 45, 
                    ReservationDate = DateTime.UtcNow.AddDays(7), 
                    UserId = 5, 
                    AutomobileAdId = 9, 
                    Status = "Pending" 
                },

                // ================= AutomobileAdId = 10 (ID: 46..50) =================
                new Reservation { 
                    Id = 46, 
                    ReservationDate = new DateTime(DateTime.UtcNow.Year, DateTime.UtcNow.Month, 18),
                    UserId = 6, 
                    AutomobileAdId = 10, 
                    Status = "Approved" 
                },
                new Reservation { 
                    Id = 47, 
                    ReservationDate = new DateTime(DateTime.UtcNow.Year, DateTime.UtcNow.Month, 20),
                    UserId = 7, 
                    AutomobileAdId = 10, 
                    Status = "Approved" 
                },
                new Reservation { 
                    Id = 48, 
                    ReservationDate = DateTime.UtcNow.AddDays(3), 
                    UserId = 8, 
                    AutomobileAdId = 10, 
                    Status = "Pending" 
                },
                new Reservation { 
                    Id = 49, 
                    ReservationDate = DateTime.UtcNow.AddDays(5), 
                    UserId = 9, 
                    AutomobileAdId = 10, 
                    Status = "Pending" 
                },
                new Reservation { 
                    Id = 50, 
                    ReservationDate = DateTime.UtcNow.AddDays(7), 
                    UserId = 10, 
                    AutomobileAdId = 10, 
                    Status = "Pending" 
                },

                // ================= AutomobileAdId = 11 (ID: 51..55) =================
                new Reservation { 
                    Id = 51, 
                    ReservationDate = new DateTime(DateTime.UtcNow.Year, DateTime.UtcNow.Month, 22),
                    UserId = 1, 
                    AutomobileAdId = 11, 
                    Status = "Approved" 
                },
                new Reservation { 
                    Id = 52, 
                    ReservationDate = new DateTime(DateTime.UtcNow.Year, DateTime.UtcNow.Month, 25),
                    UserId = 2, 
                    AutomobileAdId = 11, 
                    Status = "Approved" 
                },
                new Reservation { 
                    Id = 53, 
                    ReservationDate = DateTime.UtcNow.AddDays(3), 
                    UserId = 3, 
                    AutomobileAdId = 11, 
                    Status = "Pending" 
                },
                new Reservation { 
                    Id = 54, 
                    ReservationDate = DateTime.UtcNow.AddDays(5), 
                    UserId = 4, 
                    AutomobileAdId = 11, 
                    Status = "Pending" 
                },
                new Reservation { 
                    Id = 55, 
                    ReservationDate = DateTime.UtcNow.AddDays(7), 
                    UserId = 5, 
                    AutomobileAdId = 11, 
                    Status = "Pending" 
                },

                // ================= AutomobileAdId = 12 (ID: 56..60) =================
                new Reservation { 
                    Id = 56, 
                    ReservationDate = new DateTime(DateTime.UtcNow.Year, DateTime.UtcNow.Month, 27),
                    UserId = 6, 
                    AutomobileAdId = 12, 
                    Status = "Approved" 
                },
                new Reservation { 
                    Id = 57, 
                    ReservationDate = new DateTime(DateTime.UtcNow.Year, DateTime.UtcNow.Month, 28),
                    UserId = 7, 
                    AutomobileAdId = 12, 
                    Status = "Approved" 
                },
                new Reservation { 
                    Id = 58, 
                    ReservationDate = DateTime.UtcNow.AddDays(3), 
                    UserId = 8, 
                    AutomobileAdId = 12, 
                    Status = "Pending" 
                },
                new Reservation { 
                    Id = 59, 
                    ReservationDate = DateTime.UtcNow.AddDays(5), 
                    UserId = 9, 
                    AutomobileAdId = 12, 
                    Status = "Pending" 
                },
                new Reservation { 
                    Id = 60, 
                    ReservationDate = DateTime.UtcNow.AddDays(7), 
                    UserId = 10, 
                    AutomobileAdId = 12, 
                    Status = "Pending" 
                },

                // ================= AutomobileAdId = 13 (ID: 61..65) =================
                new Reservation { 
                    Id = 61, 
                    ReservationDate = new DateTime(DateTime.UtcNow.Year, DateTime.UtcNow.Month, 2),
                    UserId = 1, 
                    AutomobileAdId = 13, 
                    Status = "Approved" 
                },
                new Reservation { 
                    Id = 62, 
                    ReservationDate = new DateTime(DateTime.UtcNow.Year, DateTime.UtcNow.Month, 4),
                    UserId = 2, 
                    AutomobileAdId = 13, 
                    Status = "Approved" 
                },
                new Reservation { 
                    Id = 63, 
                    ReservationDate = DateTime.UtcNow.AddDays(3), 
                    UserId = 3, 
                    AutomobileAdId = 13, 
                    Status = "Pending" 
                },
                new Reservation { 
                    Id = 64, 
                    ReservationDate = DateTime.UtcNow.AddDays(5), 
                    UserId = 4, 
                    AutomobileAdId = 13, 
                    Status = "Pending" 
                },
                new Reservation { 
                    Id = 65, 
                    ReservationDate = DateTime.UtcNow.AddDays(7), 
                    UserId = 5, 
                    AutomobileAdId = 13, 
                    Status = "Pending" 
                },

                // ================= AutomobileAdId = 14 (ID: 66..70) =================
                new Reservation { 
                    Id = 66, 
                    ReservationDate = new DateTime(DateTime.UtcNow.Year, DateTime.UtcNow.Month, 7),
                    UserId = 6, 
                    AutomobileAdId = 14, 
                    Status = "Approved" 
                },
                new Reservation { 
                    Id = 67, 
                    ReservationDate = new DateTime(DateTime.UtcNow.Year, DateTime.UtcNow.Month, 10),
                    UserId = 7, 
                    AutomobileAdId = 14, 
                    Status = "Approved" 
                },
                new Reservation { 
                    Id = 68, 
                    ReservationDate = DateTime.UtcNow.AddDays(3), 
                    UserId = 8, 
                    AutomobileAdId = 14, 
                    Status = "Pending" 
                },
                new Reservation { 
                    Id = 69, 
                    ReservationDate = DateTime.UtcNow.AddDays(5), 
                    UserId = 9, 
                    AutomobileAdId = 14, 
                    Status = "Pending" 
                },
                new Reservation { 
                    Id = 70, 
                    ReservationDate = DateTime.UtcNow.AddDays(7), 
                    UserId = 10, 
                    AutomobileAdId = 14, 
                    Status = "Pending" 
                },

                // ================= AutomobileAdId = 15 (ID: 71..75) =================
                new Reservation { 
                    Id = 71, 
                    ReservationDate = new DateTime(DateTime.UtcNow.Year, DateTime.UtcNow.Month, 12),
                    UserId = 1, 
                    AutomobileAdId = 15, 
                    Status = "Approved" 
                },
                new Reservation { 
                    Id = 72, 
                    ReservationDate = new DateTime(DateTime.UtcNow.Year, DateTime.UtcNow.Month, 15),
                    UserId = 2, 
                    AutomobileAdId = 15, 
                    Status = "Approved" 
                },
                new Reservation { 
                    Id = 73, 
                    ReservationDate = DateTime.UtcNow.AddDays(3), 
                    UserId = 3, 
                    AutomobileAdId = 15, 
                    Status = "Pending" 
                },
                new Reservation { 
                    Id = 74, 
                    ReservationDate = DateTime.UtcNow.AddDays(5), 
                    UserId = 4, 
                    AutomobileAdId = 15, 
                    Status = "Pending" 
                },
                new Reservation { 
                    Id = 75, 
                    ReservationDate = DateTime.UtcNow.AddDays(7), 
                    UserId = 5, 
                    AutomobileAdId = 15, 
                    Status = "Pending" 
                },

                // ================= AutomobileAdId = 16 (ID: 76..80) =================
                new Reservation { 
                    Id = 76, 
                    ReservationDate = new DateTime(DateTime.UtcNow.Year, DateTime.UtcNow.Month, 18),
                    UserId = 6, 
                    AutomobileAdId = 16, 
                    Status = "Approved" 
                },
                new Reservation { 
                    Id = 77, 
                    ReservationDate = new DateTime(DateTime.UtcNow.Year, DateTime.UtcNow.Month, 20),
                    UserId = 7, 
                    AutomobileAdId = 16, 
                    Status = "Approved" 
                },
                new Reservation { 
                    Id = 78, 
                    ReservationDate = DateTime.UtcNow.AddDays(3), 
                    UserId = 8, 
                    AutomobileAdId = 16, 
                    Status = "Pending" 
                },
                new Reservation { 
                    Id = 79, 
                    ReservationDate = DateTime.UtcNow.AddDays(5), 
                    UserId = 9, 
                    AutomobileAdId = 16, 
                    Status = "Pending" 
                },
                new Reservation { 
                    Id = 80, 
                    ReservationDate = DateTime.UtcNow.AddDays(7), 
                    UserId = 10, 
                    AutomobileAdId = 16, 
                    Status = "Pending" 
                },

                // ================= AutomobileAdId = 17 (ID: 81..85) =================
                new Reservation { 
                    Id = 81, 
                    ReservationDate = new DateTime(DateTime.UtcNow.Year, DateTime.UtcNow.Month, 22),
                    UserId = 1, 
                    AutomobileAdId = 17, 
                    Status = "Approved" 
                },
                new Reservation { 
                    Id = 82, 
                    ReservationDate = new DateTime(DateTime.UtcNow.Year, DateTime.UtcNow.Month, 25),
                    UserId = 2, 
                    AutomobileAdId = 17, 
                    Status = "Approved" 
                },
                new Reservation { 
                    Id = 83, 
                    ReservationDate = DateTime.UtcNow.AddDays(3), 
                    UserId = 3, 
                    AutomobileAdId = 17, 
                    Status = "Pending" 
                },
                new Reservation { 
                    Id = 84, 
                    ReservationDate = DateTime.UtcNow.AddDays(5), 
                    UserId = 4, 
                    AutomobileAdId = 17, 
                    Status = "Pending" 
                },
                new Reservation { 
                    Id = 85, 
                    ReservationDate = DateTime.UtcNow.AddDays(7), 
                    UserId = 5, 
                    AutomobileAdId = 17, 
                    Status = "Pending" 
                },

                // ================= AutomobileAdId = 18 (ID: 86..90) =================
                new Reservation { 
                    Id = 86, 
                    ReservationDate = new DateTime(DateTime.UtcNow.Year, DateTime.UtcNow.Month, 27),
                    UserId = 6, 
                    AutomobileAdId = 18, 
                    Status = "Approved" 
                },
                new Reservation { 
                    Id = 87, 
                    ReservationDate = new DateTime(DateTime.UtcNow.Year, DateTime.UtcNow.Month, 28),
                    UserId = 7, 
                    AutomobileAdId = 18, 
                    Status = "Approved" 
                },
                new Reservation { 
                    Id = 88, 
                    ReservationDate = DateTime.UtcNow.AddDays(3), 
                    UserId = 8, 
                    AutomobileAdId = 18, 
                    Status = "Pending" 
                },
                new Reservation { 
                    Id = 89, 
                    ReservationDate = DateTime.UtcNow.AddDays(5), 
                    UserId = 9, 
                    AutomobileAdId = 18, 
                    Status = "Pending" 
                },
                new Reservation { 
                    Id = 90, 
                    ReservationDate = DateTime.UtcNow.AddDays(7), 
                    UserId = 10, 
                    AutomobileAdId = 18, 
                    Status = "Pending" 
                },

                // ================= AutomobileAdId = 19 (ID: 91..95) =================
                new Reservation { 
                    Id = 91, 
                    ReservationDate = new DateTime(DateTime.UtcNow.Year, DateTime.UtcNow.Month, 2),
                    UserId = 1, 
                    AutomobileAdId = 19, 
                    Status = "Approved" 
                },
                new Reservation { 
                    Id = 92, 
                    ReservationDate = new DateTime(DateTime.UtcNow.Year, DateTime.UtcNow.Month, 4),
                    UserId = 2, 
                    AutomobileAdId = 19, 
                    Status = "Approved" 
                },
                new Reservation { 
                    Id = 93, 
                    ReservationDate = DateTime.UtcNow.AddDays(3), 
                    UserId = 3, 
                    AutomobileAdId = 19, 
                    Status = "Pending" 
                },
                new Reservation { 
                    Id = 94, 
                    ReservationDate = DateTime.UtcNow.AddDays(5), 
                    UserId = 4, 
                    AutomobileAdId = 19, 
                    Status = "Pending" 
                },
                new Reservation { 
                    Id = 95, 
                    ReservationDate = DateTime.UtcNow.AddDays(7), 
                    UserId = 5, 
                    AutomobileAdId = 19, 
                    Status = "Pending" 
                },

                // ================= AutomobileAdId = 20 (ID: 96..100) =================
                new Reservation { 
                    Id = 96, 
                    ReservationDate = new DateTime(DateTime.UtcNow.Year, DateTime.UtcNow.Month, 7),
                    UserId = 6, 
                    AutomobileAdId = 20, 
                    Status = "Approved" 
                },
                new Reservation { 
                    Id = 97, 
                    ReservationDate = new DateTime(DateTime.UtcNow.Year, DateTime.UtcNow.Month, 10),
                    UserId = 7, 
                    AutomobileAdId = 20, 
                    Status = "Approved" 
                },
                new Reservation { 
                    Id = 98, 
                    ReservationDate = DateTime.UtcNow.AddDays(3), 
                    UserId = 8, 
                    AutomobileAdId = 20, 
                    Status = "Pending" 
                },
                new Reservation { 
                    Id = 99, 
                    ReservationDate = DateTime.UtcNow.AddDays(5), 
                    UserId = 9, 
                    AutomobileAdId = 20, 
                    Status = "Pending" 
                },
                new Reservation { 
                    Id = 100, 
                    ReservationDate = DateTime.UtcNow.AddDays(7), 
                    UserId = 10, 
                    AutomobileAdId = 20, 
                    Status = "Pending" 
                },

                // ================= AutomobileAdId = 21 (ID: 101..105) =================
                new Reservation { 
                    Id = 101, 
                    ReservationDate = new DateTime(DateTime.UtcNow.Year, DateTime.UtcNow.Month, 12),
                    UserId = 1, 
                    AutomobileAdId = 21, 
                    Status = "Approved" 
                },
                new Reservation { 
                    Id = 102, 
                    ReservationDate = new DateTime(DateTime.UtcNow.Year, DateTime.UtcNow.Month, 15),
                    UserId = 2, 
                    AutomobileAdId = 21, 
                    Status = "Approved" 
                },
                new Reservation { 
                    Id = 103, 
                    ReservationDate = DateTime.UtcNow.AddDays(3), 
                    UserId = 3, 
                    AutomobileAdId = 21, 
                    Status = "Pending" 
                },
                new Reservation { 
                    Id = 104, 
                    ReservationDate = DateTime.UtcNow.AddDays(5), 
                    UserId = 4, 
                    AutomobileAdId = 21, 
                    Status = "Pending" 
                },
                new Reservation { 
                    Id = 105, 
                    ReservationDate = DateTime.UtcNow.AddDays(7), 
                    UserId = 5, 
                    AutomobileAdId = 21, 
                    Status = "Pending" 
                },

                // ================= AutomobileAdId = 22 (ID: 106..110) =================
                new Reservation { 
                    Id = 106, 
                    ReservationDate = new DateTime(DateTime.UtcNow.Year, DateTime.UtcNow.Month, 18),
                    UserId = 6, 
                    AutomobileAdId = 22, 
                    Status = "Approved" 
                },
                new Reservation { 
                    Id = 107, 
                    ReservationDate = new DateTime(DateTime.UtcNow.Year, DateTime.UtcNow.Month, 20),
                    UserId = 7, 
                    AutomobileAdId = 22, 
                    Status = "Approved" 
                },
                new Reservation { 
                    Id = 108, 
                    ReservationDate = DateTime.UtcNow.AddDays(3), 
                    UserId = 8, 
                    AutomobileAdId = 22, 
                    Status = "Pending" 
                },
                new Reservation { 
                    Id = 109, 
                    ReservationDate = DateTime.UtcNow.AddDays(5), 
                    UserId = 9, 
                    AutomobileAdId = 22, 
                    Status = "Pending" 
                },
                new Reservation { 
                    Id = 110, 
                    ReservationDate = DateTime.UtcNow.AddDays(7), 
                    UserId = 10, 
                    AutomobileAdId = 22, 
                    Status = "Pending" 
                },

                // ================= AutomobileAdId = 23 (ID: 111..115) =================
                new Reservation { 
                    Id = 111, 
                    ReservationDate = new DateTime(DateTime.UtcNow.Year, DateTime.UtcNow.Month, 22),
                    UserId = 1, 
                    AutomobileAdId = 23, 
                    Status = "Approved" 
                },
                new Reservation { 
                    Id = 112, 
                    ReservationDate = new DateTime(DateTime.UtcNow.Year, DateTime.UtcNow.Month, 25),
                    UserId = 2, 
                    AutomobileAdId = 23, 
                    Status = "Approved" 
                },
                new Reservation { 
                    Id = 113, 
                    ReservationDate = DateTime.UtcNow.AddDays(3), 
                    UserId = 3, 
                    AutomobileAdId = 23, 
                    Status = "Pending" 
                },
                new Reservation { 
                    Id = 114, 
                    ReservationDate = DateTime.UtcNow.AddDays(5), 
                    UserId = 4, 
                    AutomobileAdId = 23, 
                    Status = "Pending" 
                },
                new Reservation { 
                    Id = 115, 
                    ReservationDate = DateTime.UtcNow.AddDays(7), 
                    UserId = 5, 
                    AutomobileAdId = 23, 
                    Status = "Pending" 
                },

                // ================= AutomobileAdId = 24 (ID: 116..120) =================
                new Reservation { 
                    Id = 116, 
                    ReservationDate = new DateTime(DateTime.UtcNow.Year, DateTime.UtcNow.Month, 27),
                    UserId = 6, 
                    AutomobileAdId = 24, 
                    Status = "Approved" 
                },
                new Reservation { 
                    Id = 117, 
                    ReservationDate = new DateTime(DateTime.UtcNow.Year, DateTime.UtcNow.Month, 28),
                    UserId = 7, 
                    AutomobileAdId = 24, 
                    Status = "Approved" 
                },
                new Reservation { 
                    Id = 118, 
                    ReservationDate = DateTime.UtcNow.AddDays(3), 
                    UserId = 8, 
                    AutomobileAdId = 24, 
                    Status = "Pending" 
                },
                new Reservation { 
                    Id = 119, 
                    ReservationDate = DateTime.UtcNow.AddDays(5), 
                    UserId = 9, 
                    AutomobileAdId = 24, 
                    Status = "Pending" 
                },
                new Reservation { 
                    Id = 120, 
                    ReservationDate = DateTime.UtcNow.AddDays(7), 
                    UserId = 10, 
                    AutomobileAdId = 24, 
                    Status = "Pending" 
                },

                // ================= AutomobileAdId = 25 (ID: 121..125) =================
                new Reservation { 
                    Id = 121, 
                    ReservationDate = new DateTime(DateTime.UtcNow.Year, DateTime.UtcNow.Month, 2),
                    UserId = 1, 
                    AutomobileAdId = 25, 
                    Status = "Approved" 
                },
                new Reservation { 
                    Id = 122, 
                    ReservationDate = new DateTime(DateTime.UtcNow.Year, DateTime.UtcNow.Month, 4),
                    UserId = 2, 
                    AutomobileAdId = 25, 
                    Status = "Approved" 
                },
                new Reservation { 
                    Id = 123, 
                    ReservationDate = DateTime.UtcNow.AddDays(3), 
                    UserId = 3, 
                    AutomobileAdId = 25, 
                    Status = "Pending" 
                },
                new Reservation { 
                    Id = 124, 
                    ReservationDate = DateTime.UtcNow.AddDays(5), 
                    UserId = 4, 
                    AutomobileAdId = 25, 
                    Status = "Pending" 
                },
                new Reservation { 
                    Id = 125, 
                    ReservationDate = DateTime.UtcNow.AddDays(7), 
                    UserId = 5, 
                    AutomobileAdId = 25, 
                    Status = "Pending" 
                },

                // ================= AutomobileAdId = 26 (ID: 126..130) =================
                new Reservation { 
                    Id = 126, 
                    ReservationDate = new DateTime(DateTime.UtcNow.Year, DateTime.UtcNow.Month, 7),
                    UserId = 6, 
                    AutomobileAdId = 26, 
                    Status = "Approved" 
                },
                new Reservation { 
                    Id = 127, 
                    ReservationDate = new DateTime(DateTime.UtcNow.Year, DateTime.UtcNow.Month, 10),
                    UserId = 7, 
                    AutomobileAdId = 26, 
                    Status = "Approved" 
                },
                new Reservation { 
                    Id = 128, 
                    ReservationDate = DateTime.UtcNow.AddDays(3), 
                    UserId = 8, 
                    AutomobileAdId = 26, 
                    Status = "Pending" 
                },
                new Reservation { 
                    Id = 129, 
                    ReservationDate = DateTime.UtcNow.AddDays(5), 
                    UserId = 9, 
                    AutomobileAdId = 26, 
                    Status = "Pending" 
                },
                new Reservation { 
                    Id = 130, 
                    ReservationDate = DateTime.UtcNow.AddDays(7), 
                    UserId = 10, 
                    AutomobileAdId = 26, 
                    Status = "Pending" 
                },

                // ================= AutomobileAdId = 27 (ID: 131..135) =================
                new Reservation { 
                    Id = 131, 
                    ReservationDate = new DateTime(DateTime.UtcNow.Year, DateTime.UtcNow.Month, 12),
                    UserId = 1, 
                    AutomobileAdId = 27, 
                    Status = "Approved" 
                },
                new Reservation { 
                    Id = 132, 
                    ReservationDate = new DateTime(DateTime.UtcNow.Year, DateTime.UtcNow.Month, 15),
                    UserId = 2, 
                    AutomobileAdId = 27, 
                    Status = "Approved" 
                },
                new Reservation { 
                    Id = 133, 
                    ReservationDate = DateTime.UtcNow.AddDays(3), 
                    UserId = 3, 
                    AutomobileAdId = 27, 
                    Status = "Pending" 
                },
                new Reservation { 
                    Id = 134, 
                    ReservationDate = DateTime.UtcNow.AddDays(5), 
                    UserId = 4, 
                    AutomobileAdId = 27, 
                    Status = "Pending" 
                },
                new Reservation { 
                    Id = 135, 
                    ReservationDate = DateTime.UtcNow.AddDays(7), 
                    UserId = 5, 
                    AutomobileAdId = 27, 
                    Status = "Pending" 
                },

                // ================= AutomobileAdId = 28 (ID: 136..140) =================
                new Reservation { 
                    Id = 136, 
                    ReservationDate = new DateTime(DateTime.UtcNow.Year, DateTime.UtcNow.Month, 18),
                    UserId = 6, 
                    AutomobileAdId = 28, 
                    Status = "Approved" 
                },
                new Reservation { 
                    Id = 137, 
                    ReservationDate = new DateTime(DateTime.UtcNow.Year, DateTime.UtcNow.Month, 20),
                    UserId = 7, 
                    AutomobileAdId = 28, 
                    Status = "Approved" 
                },
                new Reservation { 
                    Id = 138, 
                    ReservationDate = DateTime.UtcNow.AddDays(3), 
                    UserId = 8, 
                    AutomobileAdId = 28, 
                    Status = "Pending" 
                },
                new Reservation { 
                    Id = 139, 
                    ReservationDate = DateTime.UtcNow.AddDays(5), 
                    UserId = 9, 
                    AutomobileAdId = 28, 
                    Status = "Pending" 
                },
                new Reservation { 
                    Id = 140, 
                    ReservationDate = DateTime.UtcNow.AddDays(7), 
                    UserId = 10, 
                    AutomobileAdId = 28, 
                    Status = "Pending" 
                }
            };
        }
    }
}
