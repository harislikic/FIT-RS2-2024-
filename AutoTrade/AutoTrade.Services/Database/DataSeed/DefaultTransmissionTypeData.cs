using System;
using System.Collections.Generic;
using Database;

namespace AutoTrade.Services.Database
{
    public static class DefaultTransmissionTypeData
    {
        public static IEnumerable<TransmissionType> TransmissionTypes
        {
            get => new List<TransmissionType>()
            {
                new TransmissionType { Id = 1, Name = "Manuelni" },
                new TransmissionType { Id = 2, Name = "Automatski" },
                new TransmissionType { Id = 3, Name = "Polu-automatski" },
                new TransmissionType { Id = 4, Name = "CVT" },
                new TransmissionType { Id = 5, Name = "DSG" }
            };
        }
    }

}