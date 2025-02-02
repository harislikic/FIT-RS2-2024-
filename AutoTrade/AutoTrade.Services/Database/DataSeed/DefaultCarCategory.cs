using System;
using System.Collections.Generic;
using Database;

namespace AutoTrade.Services.Database
{
    public static class DefaultCarCategoryData
    {
        public static IEnumerable<CarCategory> CarCategories
        {
            get => new List<CarCategory>()
            {
                new CarCategory { Id = 1, Name = "Limuzina" },
                new CarCategory { Id = 2, Name = "Karavan" },
                new CarCategory { Id = 3, Name = "Hečbek" },
                new CarCategory { Id = 4, Name = "Kupe" },
                new CarCategory { Id = 5, Name = "Kabriolet" },
                new CarCategory { Id = 6, Name = "Terenac" },
                new CarCategory { Id = 7, Name = "Krosover" },
                new CarCategory { Id = 8, Name = "Monovolumen" },
                new CarCategory { Id = 9, Name = "Pikap" },
                new CarCategory { Id = 10, Name = "Sportski automobil" },
                new CarCategory { Id = 11, Name = "Kombi" }
            };
        }
    }


}
