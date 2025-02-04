using System.Collections.Generic;
using Database;

namespace AutoTrade.Services.Database
{
    public static class DefaultFavoriteData
    {
        public static IEnumerable<Favorite> Favorites
        {
            get => new List<Favorite>()
            {
                //1
                new Favorite { Id = 1, UserId = 1, AutomobileAdId = 2 },
                new Favorite { Id = 2, UserId = 1, AutomobileAdId = 3 },
                new Favorite { Id = 3, UserId = 1, AutomobileAdId = 4 },
                new Favorite { Id = 4, UserId = 1, AutomobileAdId = 5 },
                //2
                new Favorite { Id = 5, UserId = 2, AutomobileAdId = 1 },
                new Favorite { Id = 6, UserId = 2, AutomobileAdId = 3 },
                new Favorite { Id = 7, UserId = 2, AutomobileAdId = 4 },
                //3
                new Favorite { Id = 8, UserId = 3, AutomobileAdId = 1 },
                new Favorite { Id = 9, UserId = 3, AutomobileAdId = 4 },
                new Favorite { Id = 10, UserId = 3, AutomobileAdId = 5 },
                new Favorite { Id = 11, UserId = 3, AutomobileAdId = 13 },
                //4
                new Favorite { Id = 12, UserId = 4, AutomobileAdId = 1 },
                new Favorite { Id = 13, UserId = 4, AutomobileAdId = 13 },
                new Favorite { Id = 14, UserId = 4, AutomobileAdId = 13 },
                //5
                new Favorite { Id = 15, UserId = 5, AutomobileAdId = 21 },
                new Favorite { Id = 16, UserId = 5, AutomobileAdId = 22 },
                new Favorite { Id = 17, UserId = 5, AutomobileAdId = 23 },
                //6
                new Favorite { Id = 18, UserId = 6, AutomobileAdId = 24 },
                new Favorite { Id = 19, UserId = 6, AutomobileAdId = 25 },
                //7
                new Favorite { Id = 20, UserId = 7, AutomobileAdId = 26 },
                new Favorite { Id = 21, UserId = 7, AutomobileAdId = 27 },
                new Favorite { Id = 22, UserId = 7, AutomobileAdId = 1 },
                //8
                new Favorite { Id = 23, UserId = 8, AutomobileAdId = 28 },
                new Favorite { Id = 24, UserId = 8, AutomobileAdId = 16 },
                new Favorite { Id = 25, UserId = 8, AutomobileAdId = 20 },
                //9
                new Favorite { Id = 26, UserId = 9, AutomobileAdId = 1 },
                new Favorite { Id = 27, UserId = 9, AutomobileAdId = 2 },
                new Favorite { Id = 28, UserId = 9, AutomobileAdId = 3 },
                //10
                new Favorite { Id = 29, UserId = 10, AutomobileAdId = 2 },
                new Favorite { Id = 30, UserId = 10, AutomobileAdId = 23 },
                new Favorite { Id = 31, UserId = 10, AutomobileAdId = 24 },
            };
        }
    }
}
