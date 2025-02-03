using System;
using System.Collections.Generic;
using Database;

namespace AutoTrade.Services.Database
{
    public static class DefaultFuelTypeData
    {
        public static IEnumerable<FuelType> FuelTypes
        {
            get => new List<FuelType>()
            {
                new FuelType { Id = 1, Name = "Benzin" },
                new FuelType { Id = 2, Name = "Dizel" },
                new FuelType { Id = 3, Name = "Plin" },
                new FuelType { Id = 4, Name = "Benzin + Plin" },
                new FuelType { Id = 5, Name = "Hibrid" },
                new FuelType { Id = 6, Name = "Električni" },
            };
        }
    }

}
