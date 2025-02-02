using System;
using System.Collections.Generic;
using Database;

namespace AutoTrade.Services.Database
{
    public static class DefaultVehicleConditionData
    {
        public static IEnumerable<VehicleCondition> VehicleConditions
        {
            get => new List<VehicleCondition>()
            {
                new VehicleCondition { Id = 1, Name = "Novo" },
                new VehicleCondition { Id = 2, Name = "Polovno" },
                new VehicleCondition { Id = 3, Name = "Oštećeno" },
                new VehicleCondition { Id = 4, Name = "Havarisano" },
                new VehicleCondition { Id = 5, Name = "Za dijelove" },
                new VehicleCondition { Id = 6, Name = "Ispravno" },
                new VehicleCondition { Id = 7, Name = "Neispravno" },
                new VehicleCondition { Id = 8, Name = "Oldtimer" },
                new VehicleCondition { Id = 9, Name = "Restaurirano" }
            };
        }
    }


}
