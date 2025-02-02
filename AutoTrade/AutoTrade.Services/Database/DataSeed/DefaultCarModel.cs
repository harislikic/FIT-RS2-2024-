using System;
using System.Collections.Generic;
using Database;

namespace AutoTrade.Services.Database
{
    public static class DefaultCarModelData
    {
        public static IEnumerable<CarModel> CarModels
        {
            get => new List<CarModel>()
            {
                // Toyota
                new CarModel { Id = 1, Name= "Corolla" },
                new CarModel { Id = 2, Name = "Yaris" },
                new CarModel { Id = 3, Name = "Camry" },
                new CarModel { Id = 4, Name = "RAV4" },
                new CarModel { Id = 5, Name = "Land Cruiser" },

                // Volkswagen
                new CarModel { Id = 6,Name= "Golf" },
                new CarModel { Id = 7,Name= "Passat" },
                new CarModel { Id = 8,Name= "Polo" },
                new CarModel { Id = 9,Name= "Tiguan" },
                new CarModel { Id = 10,Name = "Touareg" },

                // Ford
                new CarModel { Id = 11, Name = "Fiesta" },
                new CarModel { Id = 12, Name = "Focus" },
                new CarModel { Id = 13, Name = "Mondeo" },
                new CarModel { Id = 14, Name = "Mustang" },
                new CarModel { Id = 15, Name = "Kuga" },

                // Honda
                new CarModel { Id = 16, Name = "Civic" },
                new CarModel { Id = 17, Name = "Accord" },
                new CarModel { Id = 18, Name = "CR-V" },
                new CarModel { Id = 19, Name = "Jazz" },
                new CarModel { Id = 20, Name = "HR-V" },

                // BMW
                new CarModel { Id = 21, Name = "1 Series" },
                new CarModel { Id = 22, Name = "3 Series" },
                new CarModel { Id = 23, Name = "5 Series" },
                new CarModel { Id = 24, Name = "X3" },
                new CarModel { Id = 25, Name = "X5" },

                // Mercedes-Benz
                new CarModel { Id = 26, Name = "A-Class" },
                new CarModel { Id = 27, Name = "C-Class" },
                new CarModel { Id = 28, Name = "E-Class" },
                new CarModel { Id = 29, Name = "GLA" },
                new CarModel { Id = 30, Name = "GLE" },

                // Audi
                new CarModel { Id = 31, Name = "A3" },
                new CarModel { Id = 32, Name = "A4" },
                new CarModel { Id = 33, Name = "A6" },
                new CarModel { Id = 34, Name = "Q3" },
                new CarModel { Id = 35, Name = "Q5" },

                // Hyundai
                new CarModel { Id = 36, Name = "i10" },
                new CarModel { Id = 37, Name = "i20" },
                new CarModel { Id = 38, Name = "i30" },
                new CarModel { Id = 39, Name = "Tucson" },
                new CarModel { Id = 40, Name = "Santa Fe" },

                // Kia
                new CarModel { Id = 41, Name = "Picanto" },
                new CarModel { Id = 42, Name = "Rio" },
                new CarModel { Id = 43, Name = "Ceed" },
                new CarModel { Id = 44, Name = "Sportage" },
                new CarModel { Id = 45, Name = "Sorento" },

                // Volvo
                new CarModel { Id = 46, Name = "XC60" },
                new CarModel { Id = 47, Name = "S60" },

                // Tesla
                new CarModel { Id = 48, Name = "Model S" },
                new CarModel { Id = 49, Name = "Model 3" }
            };
        }
    }

}
