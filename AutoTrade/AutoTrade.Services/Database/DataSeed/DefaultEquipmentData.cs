using System;
using System.Collections.Generic;
using Database;

namespace AutoTrade.Services.Database
{
    public static class DefaultEquipmentData
    {
        public static IEnumerable<Equipment> Equipments
        {
            get => new List<Equipment>()
            {
                new Equipment { Id = 1, Name = "Klimatizacija" },
                new Equipment { Id = 2, Name = "Automatska klima" },
                new Equipment { Id = 3, Name = "Tempomat (klasični)" },
                new Equipment { Id = 4, Name = "Adaptivni tempomat (ACC)" },
                new Equipment { Id = 5, Name = "Putni računar" },
                new Equipment { Id = 6, Name = "ABS" },
                new Equipment { Id = 7, Name = "ESP/ASR/DSC" },
                new Equipment { Id = 8, Name = "Zračni jastuci (Airbag)" },
                new Equipment { Id = 9, Name = "Isofix pričvršćivači za dječija sjedišta" },
                new Equipment { Id = 10, Name = "Daljinsko/centralno zaključavanje" },
                new Equipment { Id = 11, Name = "Električni prozori" },
                new Equipment { Id = 12, Name = "Električno podešavanje retrovizora" },
                new Equipment { Id = 13, Name = "Električno sklapanje retrovizora" },
                new Equipment { Id = 14, Name = "Multifunkcionalni volan" },
                new Equipment { Id = 15, Name = "Podesivi volan" },
                new Equipment { Id = 16, Name = "Senzori za parkiranje (prednji)" },
                new Equipment { Id = 17, Name = "Senzori za parkiranje (stražnji)" },
                new Equipment { Id = 18, Name = "Stražnja kamera" },
                new Equipment { Id = 19, Name = "Automatsko parkiranje" },
                new Equipment { Id = 20, Name = "Panoramski krov" },
                new Equipment { Id = 21, Name = "Krovni prozor (šiber)" },
                new Equipment { Id = 22, Name = "Aluminijske (lijevane) felge" },
                new Equipment { Id = 23, Name = "Čelične felge" },
                new Equipment { Id = 24, Name = "LED prednja svjetla" },
                new Equipment { Id = 25, Name = "LED zadnja svjetla" },
                new Equipment { Id = 26, Name = "Bi-Xenon svjetla" },
                new Equipment { Id = 27, Name = "Maglenke" },
                new Equipment { Id = 28, Name = "Senzor za kišu" },
                new Equipment { Id = 29, Name = "Senzor za svjetla" },
                new Equipment { Id = 30, Name = "Start/Stop sistem" },
                new Equipment { Id = 31, Name = "Keyless Go" },
                new Equipment { Id = 32, Name = "Hands-free Bluetooth" },
                new Equipment { Id = 33, Name = "Radio/CD/MP3" },
                new Equipment { Id = 34, Name = "USB/AUX priključak" },
                new Equipment { Id = 35, Name = "Navigacioni sistem" },
                new Equipment { Id = 36, Name = "Grijana sjedišta (prednja)" },
                new Equipment { Id = 37, Name = "Grijana sjedišta (stražnja)" },
                new Equipment { Id = 38, Name = "Ventilirana sjedišta" },
                new Equipment { Id = 39, Name = "Kožna sjedišta" },
                new Equipment { Id = 40, Name = "Električno podesiva sjedišta" },
                new Equipment { Id = 41, Name = "Memorija položaja sjedišta" },
                new Equipment { Id = 42, Name = "Grijani volan" },
                new Equipment { Id = 43, Name = "Ambijentalno osvjetljenje" },
                new Equipment { Id = 44, Name = "Head-up display" },
                new Equipment { Id = 45, Name = "Alarmni sistem" },
                new Equipment { Id = 46, Name = "Kuka za vuču" },
                new Equipment { Id = 47, Name = "Grijano vjetrobransko staklo" },
                new Equipment { Id = 48, Name = "Automatsko zatamnjivanje retrovizora" },
                new Equipment { Id = 49, Name = "Mrtvi ugao" },
                new Equipment { Id = 50, Name = "Lane Assist" },
                new Equipment { Id = 51, Name = "Bežično punjenje telefona" }
            };
        }
    }

}
