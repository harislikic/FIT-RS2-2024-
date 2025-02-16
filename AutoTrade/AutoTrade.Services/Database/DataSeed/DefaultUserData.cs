using AutoTrader.Services.Helpers;

namespace AutoTrade.Services.Database
{
    public static class DefaultUserData
    {
        public static IEnumerable<User> Users
        {
            get
            {
                var users = new List<User>()
                {
                    new User
                    {
                        Id = 1,
                        UserName = "admin",
                        FirstName = "admin",
                        LastName = "admin",
                        Email = "vroomapp@gmail.com",
                        PhoneNumber = "062123456",
                        Adress = "Trg Slobode",
                        Gender = "M",
                        IsAdmin = true,
                        DateOfBirth = new DateTime(1990, 5, 15),
                        CreatedAt = new DateTime(2023, 5, 15),
                        ProfilePicture = "/uploads/profilePictures/harisSlika.jpg",
                        CityId = 83
                    },
                    new User
                    {
                        Id = 2,
                        UserName = "haris",
                        FirstName = "haris",
                        LastName = "likic",
                        Email = "haris.likic@hotmail.com",
                        PhoneNumber = "063654321",
                        Adress = "Bosanska ulica 1",
                        Gender = "M",
                        IsAdmin = true,
                        DateOfBirth = new DateTime(1985, 8, 25),
                        CreatedAt = new DateTime(2022, 8, 10),
                        ProfilePicture = "/uploads/profilePictures/samirSlika.jpg",
                        CityId = 83
                    },
                    new User
                    {
                        Id = 3,
                        UserName = "user123",
                        FirstName = "Amila",
                        LastName = "Hodžić",
                        Email = "amila@gmail.com",
                        PhoneNumber = "061987654",
                        Adress = "Plivski vodopad",
                        Gender = "Z",
                        IsAdmin = false,
                        DateOfBirth = new DateTime(1995, 3, 10),
                        CreatedAt = new DateTime(2021, 12, 25),
                        ProfilePicture = "/uploads/profilePictures/userSlika.jpg",
                        CityId = 83
                    },
                    new User
                    {
                        Id = 4,
                        UserName = "user2",
                        FirstName = "Adnan",
                        LastName = "Šarić",
                        Email = "adnan@gmail.com",
                        PhoneNumber = "064112233",
                        Adress = "Njegoševa ulica 10",
                        Gender = "Z",
                        IsAdmin = false,
                        DateOfBirth = new DateTime(1992, 11, 20),
                        CreatedAt = new DateTime(2020, 3, 5),
                        ProfilePicture = "/uploads/profilePictures/user2Slika.jpg",
                        CityId = 31
                    },
                    new User
                    {
                        Id = 5,
                        UserName = "user3",
                        FirstName = "Lejla",
                        LastName = "Halilović",
                        Email = "lejla@gmail.com",
                        PhoneNumber = "065223344",
                        Adress = "Alije Hodžića 7",
                        Gender = "F",
                        IsAdmin = false,
                        DateOfBirth = new DateTime(1998, 7, 5),
                        CreatedAt = new DateTime(2019, 6, 30),
                        ProfilePicture = "/uploads/profilePictures/user3Slika.jpg",
                        CityId = 50
                    },
                     new User
                    {
                        Id = 6,
                        UserName = "user4",
                        FirstName = "User",
                        LastName = "Test",
                        Email = "user4@gmail.com",
                        PhoneNumber = "060112233",
                        Adress = "Trg mladih",
                        Gender = "M",
                        IsAdmin = false,
                        DateOfBirth = new DateTime(1995, 12, 25),
                        CreatedAt = new DateTime(2018, 11, 20),
                        ProfilePicture = "/uploads/profilePictures/user4Slika.jpg",
                        CityId = 60
                    },
                    new User
                    {
                        Id = 7,
                        UserName = "cbale",
                        FirstName = "Christian",
                        LastName = "Bale",
                        Email = "christian@gmail.com",
                        PhoneNumber = "060445566",
                        Adress = "Ferhadija 1",
                        Gender = "M",
                        IsAdmin = false,
                        DateOfBirth = new DateTime(1974, 1, 30),
                        CreatedAt = new DateTime(2017, 4, 18),
                        ProfilePicture = "/uploads/profilePictures/userSlika5.jpg",
                        CityId = 81
                    },
                    new User
                    {
                        Id = 8,
                        UserName = "adelon",
                        FirstName = "Alain",
                        LastName = "Delon",
                        Email = "alain@gmail.com",
                        PhoneNumber = "060778899",
                        Adress = "Unska ulica 12",
                        Gender = "M",
                        IsAdmin = false,
                        DateOfBirth = new DateTime(1935, 11, 8),
                        CreatedAt = new DateTime(2016, 9, 9),
                        ProfilePicture = "/uploads/profilePictures/userSlika6.jpg",
                        CityId = 77
                    },
                    new User
                    {
                        Id = 9,
                        UserName = "csreckovic",
                        FirstName = "Cico",
                        LastName = "Sreckovic",
                        Email = "cico@gmail.com",
                        PhoneNumber = "060889900",
                        Adress = "Njegoševa ulica",
                        Gender = "M",
                        IsAdmin = false,
                        DateOfBirth = new DateTime(1975, 3, 15),
                        CreatedAt = new DateTime(2024, 1, 7),
                        ProfilePicture = "/uploads/profilePictures/userSlika7.jpeg",
                        CityId = 31
                    },
                    new User
                    {
                        Id = 10,
                        UserName = "akicanski",
                        FirstName = "Aljosa",
                        LastName = "Kicanski",
                        Email = "aljosa@gmail.com",
                        PhoneNumber = "061990011",
                        Adress = "Benici 22",
                        Gender = "M",
                        IsAdmin = false,
                        DateOfBirth = new DateTime(1980, 6, 20),
                        CreatedAt = new DateTime(2023, 11, 14),
                        ProfilePicture = "/uploads/profilePictures/userSlika8.jpg",
                        CityId = 31
                    },
                     new User
                    {
                        Id = 11,
                        UserName = "Almin123",
                        FirstName = "Almmin",
                        LastName = "Muratshpaic",
                        Email = "almin@gmail.com",
                        PhoneNumber = "061990011",
                        Adress = "Put mira 10",
                        Gender = "M",
                        IsAdmin = false,
                        DateOfBirth = new DateTime(2010, 6, 20),
                        CreatedAt = new DateTime(2022, 7, 23),
                        ProfilePicture = "/uploads/profilePictures/userSlika8.jpg",
                        CityId = 33
                    },
                    new User
                    {
                        Id = 12,
                        UserName = "Selman",
                        FirstName = "Selman",
                        LastName = "Aliman",
                        Email = "selman@gmail.com",
                        PhoneNumber = "061990011",
                        Adress = "Alije Hodžića 44",
                        Gender = "M",
                        IsAdmin = false,
                        DateOfBirth = new DateTime(2002, 2, 20),
                        CreatedAt = new DateTime(2021, 5, 1),
                        ProfilePicture = "/uploads/profilePictures/userSlika8.jpg",
                        CityId = 83
                    },
                    new User
                    {
                        Id = 13,
                        UserName = "Amar123",
                        FirstName = "Amar",
                        LastName = "Mehic",
                        Email = "amar.mehic@gmail.com",
                        PhoneNumber = "062345678",
                        Adress = "Bosanska 12",
                        Gender = "M",
                        IsAdmin = false,
                        DateOfBirth = new DateTime(1998, 5, 10),
                        CreatedAt = new DateTime(2020, 10, 12),
                        ProfilePicture = "/uploads/profilePictures/userSlika7.jpeg",
                        CityId = 83
                    },
                    new User
                    {
                        Id = 14,
                        UserName = "Lana987",
                        FirstName = "Lana",
                        LastName = "Hadzic",
                        Email = "lana.hadzic@gmail.com",
                        PhoneNumber = "063567890",
                        Adress = "Hrasnička cesta 5",
                        Gender = "F",
                        IsAdmin = false,
                        DateOfBirth = new DateTime(2000, 8, 22),
                        CreatedAt = new DateTime(2019, 2, 28),
                        ProfilePicture = "/uploads/profilePictures/userSlika7.jpeg",
                        CityId = 52
                    },
                    new User
                    {
                        Id = 15,
                        UserName = "EminaK",
                        FirstName = "Emina",
                        LastName = "Kovac",
                        Email = "emina.kovac@gmail.com",
                        PhoneNumber = "061123456",
                        Adress = "Titova 25",
                        Gender = "F",
                        IsAdmin = false,
                        DateOfBirth = new DateTime(1995, 3, 15),
                        CreatedAt = new DateTime(2018, 8, 3),
                        ProfilePicture = "/uploads/profilePictures/userSlika.jpg",
                        CityId = 33
                    },
                    new User
                    {
                        Id = 16,
                        UserName = "Tarik77",
                        FirstName = "Tarik",
                        LastName = "Basic",
                        Email = "tarik.basic@gmail.com",
                        PhoneNumber = "060998877",
                        Adress = "Zmaja od Bosne 10",
                        Gender = "M",
                        IsAdmin = false,
                        DateOfBirth = new DateTime(1997, 12, 5),
                        CreatedAt = new DateTime(2017, 3, 15),
                        ProfilePicture = "/uploads/profilePictures/user2Slika.jpg",
                        CityId = 83
                    },
                    new User
                    {
                        Id = 17,
                        UserName = "Adnan2023",
                        FirstName = "Adnan",
                        LastName = "Smajic",
                        Email = "adnan.smajic@gmail.com",
                        PhoneNumber = "061789012",
                        Adress = "Bulevar Meše Selimovića 8",
                        Gender = "M",
                        IsAdmin = false,
                        DateOfBirth = new DateTime(1999, 7, 18),
                        CreatedAt = new DateTime(2016, 6, 7),
                        ProfilePicture = "/uploads/profilePictures/user3Slika.jpg",
                        CityId = 31
                    },
                    new User
                    {
                        Id = 18,
                        UserName = "Ivana_S",
                        FirstName = "Ivana",
                        LastName = "Stanic",
                        Email = "ivana.stanic@gmail.com",
                        PhoneNumber = "062555666",
                        Adress = "Džemala Bijedića 13",
                        Gender = "F",
                        IsAdmin = false,
                        DateOfBirth = new DateTime(1996, 9, 25),
                        CreatedAt = new DateTime(2015, 12, 19),
                        ProfilePicture = "/uploads/profilePictures/userSlika8.jpg",
                        CityId = 61
                    },
                    new User
                    {
                        Id = 19,
                        UserName = "KenanPro",
                        FirstName = "Kenan",
                        LastName = "Hadžić",
                        Email = "kenan.hadzic@gmail.com",
                        PhoneNumber = "063777888",
                        Adress = "Ferhadija 2",
                        Gender = "M",
                        IsAdmin = false,
                        DateOfBirth = new DateTime(1994, 6, 11),
                        CreatedAt = new DateTime(2024, 2, 4),
                        ProfilePicture = "/uploads/profilePictures/user2Slika.jpg",
                        CityId = 83
                    },
                    new User
                    {
                        Id = 20,
                        UserName = "Dina_R",
                        FirstName = "Dina",
                        LastName = "Radončić",
                        Email = "dina.radoncic@gmail.com",
                        PhoneNumber = "060333444",
                        Adress = "Alipašina 77",
                        Gender = "F",
                        IsAdmin = false,
                        DateOfBirth = new DateTime(2001, 1, 30),
                        CreatedAt = new DateTime(2023, 9, 30),
                        ProfilePicture = "/uploads/profilePictures/user4Slika.jpg",
                        CityId = 31
                    },
                    new User
                    {
                        Id = 21,
                        UserName = "MirzaC",
                        FirstName = "Mirza",
                        LastName = "Čaušević",
                        Email = "mirza.causevic@gmail.com",
                        PhoneNumber = "061666777",
                        Adress = "Grbavica 15",
                        Gender = "M",
                        IsAdmin = false,
                        DateOfBirth = new DateTime(1993, 10, 14),
                        CreatedAt = new DateTime(2022, 6, 11),
                        ProfilePicture = "/uploads/profilePictures/user4Slika.jpg",
                        CityId = 61
                    },
                    new User
                    {
                        Id = 22,
                        UserName = "Selma88",
                        FirstName = "Selma",
                        LastName = "Pirić",
                        Email = "selma.piric@gmail.com",
                        PhoneNumber = "062222333",
                        Adress = "Stup 22",
                        Gender = "F",
                        IsAdmin = false,
                        DateOfBirth = new DateTime(1998, 4, 9),
                        CreatedAt = new DateTime(2021, 1, 27),
                        ProfilePicture = "/uploads/profilePictures/user4Slika.jpg",
                        CityId = 83
                    },
                    new User
                    {
                        Id = 23,
                        UserName = "ArminB",
                        FirstName = "Armin",
                        LastName = "Beširović",
                        Email = "armin.besirovic@gmail.com",
                        PhoneNumber = "060123789",
                        Adress = "Otoka 7",
                        Gender = "M",
                        IsAdmin = false,
                        DateOfBirth = new DateTime(2000, 11, 20),
                        CreatedAt = new DateTime(2020, 4, 9),
                         ProfilePicture = "/uploads/profilePictures/user4Slika.jpg",
                        CityId = 31
                    },
                    new User
                    {
                        Id = 24,
                        UserName = "LejlaA",
                        FirstName = "Lejla",
                        LastName = "Avdić",
                        Email = "lejla.avdic@gmail.com",
                        PhoneNumber = "063987654",
                        Adress = "Ilidža 19",
                        Gender = "F",
                        IsAdmin = false,
                        DateOfBirth = new DateTime(1997, 2, 7),
                        CreatedAt = new DateTime(2019, 7, 22),
                       ProfilePicture = "/uploads/profilePictures/user4Slika.jpg",
                        CityId = 61
                    },
                    new User
                    {
                        Id = 25,
                        UserName = "BenjaminM",
                        FirstName = "Benjamin",
                        LastName = "Mujkanović",
                        Email = "benjamin.mujkanovic@gmail.com",
                        PhoneNumber = "061654321",
                        Adress = "Nedžarići 31",
                        Gender = "M",
                        IsAdmin = false,
                        DateOfBirth = new DateTime(1995, 6, 23),
                        CreatedAt = new DateTime(2018, 10, 5),
                        ProfilePicture = "/uploads/profilePictures/user4Slika.jpg",
                        CityId = 83
                    },
                    new User
                    {
                        Id = 26,
                        UserName = "HanaG",
                        FirstName = "Hana",
                        LastName = "Gavran",
                        Email = "hana.gavran@gmail.com",
                        PhoneNumber = "062111222",
                        Adress = "Koševo 10",
                        Gender = "F",
                        IsAdmin = false,
                        DateOfBirth = new DateTime(2003, 12, 17),
                        CreatedAt = new DateTime(2017, 5, 17),
                        ProfilePicture = "/uploads/profilePictures/user4Slika.jpg",
                        CityId = 61
                    },
                    new User
                    {
                        Id = 27,
                        UserName = "DamirH",
                        FirstName = "Damir",
                        LastName = "Hadžović",
                        Email = "damir.hadzovic@gmail.com",
                        PhoneNumber = "060432678",
                        Adress = "Vogošća 6",
                        Gender = "M",
                        IsAdmin = false,
                        DateOfBirth = new DateTime(1996, 8, 29),
                        CreatedAt = new DateTime(2016, 11, 13),
                        ProfilePicture = "/uploads/profilePictures/user4Slika.jpg",
                        CityId = 31
                    }
                };


                foreach (var user in users)
                {

                    PasswordHelper.SetPassword(user, "password123");
                }

                return users;
            }
        }


    }


}
