using AutoTrade.Model;
using Database;
using Microsoft.EntityFrameworkCore;
using CarBrand = Database.CarBrand;
using CarCategory = Database.CarCategory;

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

        public DbSet<Favorite> Favorites { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=127.0.0.1;Initial Catalog=AutoTrade; user=SA; Password=MyPass@word; TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasKey(u => u.Id);

            modelBuilder.Entity<AutomobileAd>()
                .HasKey(a => a.Id);

            modelBuilder.Entity<Favorite>()
                .HasKey(f => f.Id);

            // Relationship between User and Favorite
            modelBuilder.Entity<Favorite>()
                .HasOne(f => f.User)
                .WithMany(u => u.Favorites)
                .HasForeignKey(f => f.UserId)
                .OnDelete(DeleteBehavior.Cascade); // Prevent cascade deletion

            // Relationship between AutomobileAd and Favorite
            modelBuilder.Entity<Favorite>()
                .HasOne(f => f.AutomobileAd)
                .WithMany(a => a.Favorites)
                .HasForeignKey(f => f.AutomobileAdId)
                .OnDelete(DeleteBehavior.Cascade); // Prevent cascade deletion

            // Relationship between User and AutomobileAd
            modelBuilder.Entity<AutomobileAd>()
                .HasOne(a => a.User)
                .WithMany(u => u.AutomobileAds)
                .HasForeignKey(a => a.UserId)
                .OnDelete(DeleteBehavior.Restrict); // Prevent cascade deletion

            // Check any other relationships that could potentially cause cycles
        }

    }
}