using Database;

namespace AutoTrade.Services.Database
{
    public static class DefaultCarBrandData
    {
        public static IEnumerable<CarBrand> CarBrands
        {
            get => new List<CarBrand>()
            {
                new CarBrand { Id = 1, Name = "Toyota" },
                new CarBrand { Id = 2, Name = "Volkswagen" },
                new CarBrand { Id = 3, Name = "Ford" },
                new CarBrand { Id = 4, Name = "Honda" },
                new CarBrand { Id = 5, Name = "Nissan" },
                new CarBrand { Id = 6, Name = "Chevrolet" },
                new CarBrand { Id = 7, Name = "Mercedes-Benz" },
                new CarBrand { Id = 8, Name = "BMW" },
                new CarBrand { Id = 9, Name = "Audi" },
                new CarBrand { Id = 10, Name = "Hyundai" },
                new CarBrand { Id = 11, Name = "Kia" },
                new CarBrand { Id = 12, Name = "Peugeot" },
                new CarBrand { Id = 13, Name = "Renault" },
                new CarBrand { Id = 14, Name = "Citroën" },
                new CarBrand { Id = 15, Name = "Fiat" },
                new CarBrand { Id = 16, Name = "Opel" },
                new CarBrand { Id = 17, Name = "Škoda" },
                new CarBrand { Id = 18, Name = "Volvo" },
                new CarBrand { Id = 19, Name = "Tesla" },
                new CarBrand { Id = 20, Name = "Lexus" },
                new CarBrand { Id = 21, Name = "Jeep" },
                new CarBrand { Id = 22, Name = "Dodge" },
                new CarBrand { Id = 23, Name = "Chrysler" },
                new CarBrand { Id = 24, Name = "Mazda" },
                new CarBrand { Id = 25, Name = "Subaru" },
                new CarBrand { Id = 26, Name = "Suzuki" },
                new CarBrand { Id = 27, Name = "Mitsubishi" },
                new CarBrand { Id = 28, Name = "Land Rover" },
                new CarBrand { Id = 29, Name = "Jaguar" },
                new CarBrand { Id = 30, Name = "Porsche" },
                new CarBrand { Id = 31, Name = "Mini" },
                new CarBrand { Id = 32, Name = "Aston Martin" },
                new CarBrand { Id = 33, Name = "Ferrari" },
                new CarBrand { Id = 34, Name = "Lamborghini" },
                new CarBrand { Id = 35, Name = "Bentley" },
                new CarBrand { Id = 36, Name = "Rolls-Royce" },
                new CarBrand { Id = 37, Name = "Maserati" },
                new CarBrand { Id = 38, Name = "Alfa Romeo" },
                new CarBrand { Id = 39, Name = "Cadillac" },
                new CarBrand { Id = 40, Name = "Buick" },
                new CarBrand { Id = 41, Name = "GMC" },
                new CarBrand { Id = 42, Name = "Ram" },
                new CarBrand { Id = 43, Name = "Infiniti" },
                new CarBrand { Id = 44, Name = "Acura" },
                new CarBrand { Id = 45, Name = "Lincoln" },
                new CarBrand { Id = 46, Name = "Genesis" },
                new CarBrand { Id = 47, Name = "Daihatsu" },
                new CarBrand { Id = 48, Name = "Pagani" },
                new CarBrand { Id = 49, Name = "Koenigsegg" },
                new CarBrand { Id = 50, Name = "Bugatti" }
            };
        }
    }

}
