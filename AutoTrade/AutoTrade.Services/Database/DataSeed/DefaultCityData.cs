namespace AutoTrade.Services.Database
{
    public static class DefaultCityData
    {
        public static IEnumerable<City> Cities
        {
            get => new List<City>()
            {
                // Unsko-sanski kanton (ID = 1)
                new City { Id = 1, Title = "Bihać", CantonId = 1 },
                new City { Id = 2, Title = "Cazin", CantonId = 1 },
                new City { Id = 3, Title = "Kladuša", CantonId = 1 },
                new City { Id = 4, Title = "Krupa", CantonId = 1 },
                new City { Id = 5, Title = "Bužim", CantonId = 1 },
                new City { Id = 6, Title = "Ključ", CantonId = 1 },
                new City { Id = 7, Title = "Petrovac", CantonId = 1 },
                new City { Id = 8, Title = "Sanski Most", CantonId = 1 },
                new City { Id = 9, Title = "Ostrožac", CantonId = 1 },
                new City { Id = 10, Title = "Ćoralići", CantonId = 1 },

                // Posavski kanton (ID = 2)
                new City { Id = 11, Title = "Orašje", CantonId = 2 },
                new City { Id = 12, Title = "Domaljevac", CantonId = 2 },
                new City { Id = 13, Title = "Odžak", CantonId = 2 },
                new City { Id = 14, Title = "Kostrč", CantonId = 2 },
                new City { Id = 15, Title = "Tolisa", CantonId = 2 },
                new City { Id = 16, Title = "Ugljara", CantonId = 2 },
                new City { Id = 17, Title = "Bukova", CantonId = 2 },
                new City { Id = 18, Title = "Vidovice", CantonId = 2 },
                new City { Id = 19, Title = "Jenjić", CantonId = 2 },
                new City { Id = 20, Title = "Lončari", CantonId = 2 },

                // Tuzlanski kanton (ID = 3)
                new City { Id = 21, Title = "Tuzla", CantonId = 3 },
                new City { Id = 22, Title = "Lukavac", CantonId = 3 },
                new City { Id = 23, Title = "Gračanica", CantonId = 3 },
                new City { Id = 24, Title = "Srebrenik", CantonId = 3 },
                new City { Id = 25, Title = "Kalesija", CantonId = 3 },
                new City { Id = 26, Title = "Gradačac", CantonId = 3 },
                new City { Id = 27, Title = "Živinice", CantonId = 3 },
                new City { Id = 28, Title = "Čelić", CantonId = 3 },
                new City { Id = 29, Title = "Sapna", CantonId = 3 },
                new City { Id = 30, Title = "Teočak", CantonId = 3 },

                // Zeničko-dobojski kanton (ID = 4)
                new City { Id = 31, Title = "Zenica", CantonId = 4 },
                new City { Id = 32, Title = "Doboj Jug", CantonId = 4 },
                new City { Id = 33, Title = "Kakanj", CantonId = 4 },
                new City { Id = 34, Title = "Maglaj", CantonId = 4 },
                new City { Id = 35, Title = "Olovo", CantonId = 4 },
                new City { Id = 36, Title = "Tešanj", CantonId = 4 },
                new City { Id = 37, Title = "Usora", CantonId = 4 },
                new City { Id = 38, Title = "Vareš", CantonId = 4 },
                new City { Id = 39, Title = "Visoko", CantonId = 4 },
                new City { Id = 40, Title = "Zavidovići", CantonId = 4 },

                // Bosansko-podrinjski kanton (ID = 5)
                new City { Id = 41, Title = "Goražde", CantonId = 5 },
                new City { Id = 42, Title = "Pale-Prača", CantonId = 5 },
                new City { Id = 43, Title = "Foča", CantonId = 5 },
                new City { Id = 44, Title = "Ilovača", CantonId = 5 },
                new City { Id = 45, Title = "Vitkovići", CantonId = 5 },
                new City { Id = 46, Title = "Hubjeri", CantonId = 5 },
                new City { Id = 47, Title = "Berič", CantonId = 5 },
                new City { Id = 48, Title = "Osanica", CantonId = 5 },
                new City { Id = 49, Title = "Čitluk", CantonId = 5 },
                new City { Id = 50, Title = "Rorovi", CantonId = 5 },

                // Srednjobosanski kanton (ID = 6)
                new City { Id = 51, Title = "Travnik", CantonId = 6 },
                new City { Id = 52, Title = "Bugojno", CantonId = 6 },
                new City { Id = 53, Title = "Novi Travnik", CantonId = 6 },
                new City { Id = 54, Title = "Vitez", CantonId = 6 },
                new City { Id = 55, Title = "Jajce", CantonId = 6 },
                new City { Id = 56, Title = "Gornji Vakuf", CantonId = 6 },
                new City { Id = 57, Title = "Donji Vakuf", CantonId = 6 },
                new City { Id = 58, Title = "Busovača", CantonId = 6 },
                new City { Id = 59, Title = "Kiseljak", CantonId = 6 },
                new City { Id = 60, Title = "Fojnica", CantonId = 6 },
               
                new City { Id = 61, Title = "Mostar", CantonId = 7 },
                new City { Id = 62, Title = "Konjic", CantonId = 7 },
                new City { Id = 63, Title = "Jablanica", CantonId = 7 },
                new City { Id = 64, Title = "Prozor-Rama", CantonId = 7 },
                new City { Id = 65, Title = "Neum", CantonId = 7 },
                new City { Id = 66, Title = "Stolac", CantonId = 7 },
                new City { Id = 67, Title = "Čapljina", CantonId = 7 },
                new City { Id = 68, Title = "Čitluk", CantonId = 7 },
                new City { Id = 69, Title = "Ravno", CantonId = 7 },
                new City { Id = 70, Title = "Blagaj", CantonId = 7 },

                // Zapadnohercegovački kanton (ID = 8)
                new City { Id = 71, Title = "Široki Brijeg", CantonId = 8 },
                new City { Id = 72, Title = "Grude", CantonId = 8 },
                new City { Id = 73, Title = "Ljubuški", CantonId = 8 },
                new City { Id = 74, Title = "Posušje", CantonId = 8 },
                new City { Id = 75, Title = "Kočerin", CantonId = 8 },
                new City { Id = 76, Title = "Vitina", CantonId = 8 },
                new City { Id = 77, Title = "Ružići", CantonId = 8 },
                new City { Id = 78, Title = "Tihaljina", CantonId = 8 },
                new City { Id = 79, Title = "Veljaci", CantonId = 8 },
                new City { Id = 80, Title = "Hardomilje", CantonId = 8 },

                // Kanton Sarajevo (ID = 9)
                new City { Id = 81, Title = "Stari Grad", CantonId = 9 },
                new City { Id = 82, Title = "Centar", CantonId = 9 },
                new City { Id = 83, Title = "Novo Sarajevo", CantonId = 9 },
                new City { Id = 84, Title = "Novi Grad", CantonId = 9 },
                new City { Id = 85, Title = "Ilidža", CantonId = 9 },
                new City { Id = 86, Title = "Hadžići", CantonId = 9 },
                new City { Id = 87, Title = "Vogošća", CantonId = 9 },
                new City { Id = 88, Title = "Ilijaš", CantonId = 9 },
                new City { Id = 89, Title = "Trnovo", CantonId = 9 },
                new City { Id = 90, Title = "Hrasnica", CantonId = 9 }
            };
        }
    }

}
