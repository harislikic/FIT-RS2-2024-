using AutoTrade.Model;
using Database;
using Microsoft.EntityFrameworkCore;

namespace AutoTrade.Services.Database
{
    public partial class AutoTradeContext : DbContext
    {

        public AutoTradeContext() : base() { }

        public AutoTradeContext(DbContextOptions<AutoTradeContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Canton> Cantons { get; set; }

        public DbSet<City> Cities { get; set; }

        public DbSet<AutomobileAd> AutomobileAds { get; set; }

        public DbSet<CarBrand> CarBrands { get; set; }

        public DbSet<CarCategory> CarCategories { get; set; }

        public DbSet<CarModel> CarModels { get; set; }

        public DbSet<Comment> Comments { get; set; }

        public DbSet<FuelType> FuelTypes { get; set; }

        public DbSet<Reservation> Reservations { get; set; }

        public DbSet<TransmissionType> transmissionTypes { get; set; }

        public DbSet<VehicleCondition> VehicleConditions { get; set; }

        public DbSet<AdditionalEquipment> AdditionalEquipments { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=127.0.0.1;Initial Catalog=AutoTrade; user=SA; Password=MyPass@word; TrustServerCertificate=True;");
        }


    }
}