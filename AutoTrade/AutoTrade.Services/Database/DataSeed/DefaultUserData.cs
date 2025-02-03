using System;
using System.Collections.Generic;
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
                        Email = "creauts.xoxo@gmail.com",
                        PhoneNumber = "062123456",
                        Adress = "Adresa 1",
                        Gender = "M",
                        IsAdmin = true,
                        DateOfBirth = new DateTime(1990, 5, 15),
                        ProfilePicture = "/uploads/harisSlika.jpg",
                        CityId = 1
                    },
                    new User
                    {
                        Id = 2,
                        UserName = "haris",
                        FirstName = "haris",
                        LastName = "likic",
                        Email = "haris.likic@hotmail.com",
                        PhoneNumber = "063654321",
                        Adress = "Adresa 2",
                        Gender = "M",
                        IsAdmin = true,
                        DateOfBirth = new DateTime(1985, 8, 25),
                        ProfilePicture = "/uploads/samirSlika.jpg",
                        CityId = 2
                    },
                    new User
                    {
                        Id = 3,
                        UserName = "user123",
                        FirstName = "Amila",
                        LastName = "Hodžić",
                        Email = "amila@gmail.com",
                        PhoneNumber = "061987654",
                        Adress = "Adresa 3",
                        Gender = "Z",
                        IsAdmin = false,
                        DateOfBirth = new DateTime(1995, 3, 10),
                        ProfilePicture = "/uploads/userSlika.jpg",
                        CityId = 3
                    },
                    new User
                    {
                        Id = 4,
                        UserName = "user2",
                        FirstName = "Adnan",
                        LastName = "Šarić",
                        Email = "adnan@gmail.com",
                        PhoneNumber = "064112233",
                        Adress = "Adresa 4",
                        Gender = "Z",
                        IsAdmin = false,
                        DateOfBirth = new DateTime(1992, 11, 20),
                        ProfilePicture = "/uploads/user2Slika.jpg",
                        CityId = 4
                    },
                    new User
                    {
                        Id = 5,
                        UserName = "user3",
                        FirstName = "Lejla",
                        LastName = "Halilović",
                        Email = "lejla@gmail.com",
                        PhoneNumber = "065223344",
                        Adress = "Adresa 5",
                        Gender = "F",
                        IsAdmin = false,
                        DateOfBirth = new DateTime(1998, 7, 5),
                        ProfilePicture = "/uploads/user3Slika.jpg",
                        CityId = 5
                    },     new User
                    {
                        Id = 6,
                        UserName = "user4",
                        FirstName = "User",
                        LastName = "Test",
                        Email = "user4@gmail.com",
                        PhoneNumber = "060112233",
                        Adress = "Adresa 6",
                        Gender = "M",
                        IsAdmin = false,
                        DateOfBirth = new DateTime(1995, 12, 25),
                        ProfilePicture = "/uploads/user4Slika.jpg",
                        CityId = 6
                    },
                    new User
                    {
                        Id = 7,
                        UserName = "cbale",
                        FirstName = "Christian",
                        LastName = "Bale",
                        Email = "christian@gmail.com",
                        PhoneNumber = "060445566",
                        Adress = "Adresa 7",
                        Gender = "M",
                        IsAdmin = false,
                        DateOfBirth = new DateTime(1974, 1, 30),
                        ProfilePicture = "/uploads/userSlika5.jpg",
                        CityId = 7
                    },
                    new User
                    {
                        Id = 8,
                        UserName = "adelon",
                        FirstName = "Alain",
                        LastName = "Delon",
                        Email = "alain@gmail.com",
                        PhoneNumber = "060778899",
                        Adress = "Adresa 8",
                        Gender = "M",
                        IsAdmin = false,
                        DateOfBirth = new DateTime(1935, 11, 8),
                        ProfilePicture = "/uploads/userSlika6.jpg",
                        CityId = 8
                    },
                    new User
                    {
                        Id = 9,
                        UserName = "csreckovic",
                        FirstName = "Cico",
                        LastName = "Sreckovic",
                        Email = "cico@gmail.com",
                        PhoneNumber = "060889900",
                        Adress = "Adresa 9",
                        Gender = "M",
                        IsAdmin = false,
                        DateOfBirth = new DateTime(1975, 3, 15),
                        ProfilePicture = "/uploads/userSlika7.jpeg",
                        CityId = 9
                    },
                    new User
                    {
                        Id = 10,
                        UserName = "akicanski",
                        FirstName = "Aljosa",
                        LastName = "Kicanski",
                        Email = "aljosa@gmail.com",
                        PhoneNumber = "061990011",
                        Adress = "Adresa 10",
                        Gender = "M",
                        IsAdmin = false,
                        DateOfBirth = new DateTime(1980, 6, 20),
                        ProfilePicture = "/uploads/userSlika8.jpg",
                        CityId = 10
                    }
                };


                foreach (var user in users)
                {

                    PasswordHelper.SetPassword(user, "Password123");
                }

                return users;
            }
        }


    }


}
