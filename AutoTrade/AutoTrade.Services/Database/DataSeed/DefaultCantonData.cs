using System;
using System.Collections.Generic;

namespace AutoTrade.Services.Database
{
    public static class DefaultCantonData
    {
        public static IEnumerable<Canton> Cantons
        {
            get => new List<Canton>()
            {
                new Canton
                {
                    Id = 1,
                    Title = "Unsko-sanski"
                },
                new Canton
                {
                    Id = 2,
                    Title = "Posavski"
                },
                new Canton
                {
                    Id = 3,
                    Title = "Tuzlanski"
                },
                new Canton
                {
                    Id = 4,
                    Title = "Zeničko-dobojski"
                },
                new Canton
                {
                    Id = 5,
                    Title = "Bosansko-podrinjski"
                },
                new Canton
                {
                    Id = 6,
                    Title = "Srednjobosanski kanton"
                },
                new Canton
                {
                    Id = 7,
                    Title = "Hercegovačko-neretvanski"
                },
                new Canton
                {
                    Id = 8,
                    Title = "Zapadnohercegovački"
                },
                new Canton
                {
                    Id = 9,
                    Title = "Kanton Sarajevo"
                }
            };
        }
    }


}
