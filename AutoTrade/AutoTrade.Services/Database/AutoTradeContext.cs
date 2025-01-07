using AutoTrade.Model;
using Database;
using Microsoft.EntityFrameworkCore;
using CarBrand = Database.CarBrand;
using CarCategory = Database.CarCategory;
using CarModel = Database.CarModel;
using Comment = Database.Comment;
using Favorite = Database.Favorite;
using FuelType = Database.FuelType;
using Reservation = Database.Reservation;
using TransmissionType = Database.TransmissionType;
using VehicleCondition = Database.VehicleCondition;
using AutomobileAd = Database.AutomobileAd;
using AutomobileAdImage = Database.AutomobileAdImage;
using Equipment = Database.Equipment;
using AutomobileAdEquipment = Database.AutomobileAdEquipment;

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

        public DbSet<Favorite> Favorites { get; set; }

        public DbSet<AutomobileAdImage> AutomobileAdImages { get; set; }

        public DbSet<Equipment> Equipments { get; set; }

        public DbSet<AutomobileAdEquipment> AutomobileAdEquipments { get; set; }

        public DbSet<PaymentTransaction> PaymentTransactions { get; set; }


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

            modelBuilder.Entity<AutomobileAdEquipment>()
            .HasKey(ae => new { ae.AutomobileAdId, ae.EquipmentId });

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

            // Relationship between AutomobileAd and Reservation
            modelBuilder.Entity<Reservation>()
                .HasOne(r => r.AutomobileAd)
                .WithMany(a => a.Reservations)
                .HasForeignKey(r => r.AutomobileAdId)
                .OnDelete(DeleteBehavior.Cascade); // Automatically delete reservations when an automobile ad is deleted

            // Relationship between AutomobileAd and Comment
            modelBuilder.Entity<Comment>()
                .HasOne(c => c.AutomobileAd)
                .WithMany(a => a.Comments)
                .HasForeignKey(c => c.AutomobileAdId)
                .OnDelete(DeleteBehavior.Cascade); // Automatically delete comments when an automobile ad is deleted


            modelBuilder.Entity<AutomobileAdEquipment>()
                .HasOne(ae => ae.AutomobileAd)
                .WithMany(a => a.AutomobileAdEquipments)
                .HasForeignKey(ae => ae.AutomobileAdId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<AutomobileAdImage>()
                .HasOne(ai => ai.AutomobileAd)
                .WithMany(ad => ad.Images)
                .HasForeignKey(ai => ai.AutomobileAdId);

            modelBuilder.Entity<AutomobileAdEquipment>()
                .HasKey(ae => new { ae.AutomobileAdId, ae.EquipmentId });

            modelBuilder.Entity<AutomobileAdEquipment>()
                .HasOne(ae => ae.AutomobileAd)
                .WithMany(a => a.AutomobileAdEquipments)
                .HasForeignKey(ae => ae.AutomobileAdId);

            modelBuilder.Entity<AutomobileAdEquipment>()
                .HasOne(ae => ae.Equipment)
                .WithMany(e => e.AutomobileAdEquipments)
                .HasForeignKey(ae => ae.EquipmentId);



            modelBuilder.Entity<AutomobileAd>()
                .HasOne(ad => ad.PaymentTransaction)
                .WithOne(transaction => transaction.AutomobileAd)
                .HasForeignKey<AutomobileAd>(ad => ad.PaymentTransactionId)
                .OnDelete(DeleteBehavior.SetNull);
        }


    }
}