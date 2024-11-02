﻿// <auto-generated />
using System;
using AutoTrade.Services.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AutoTrade.Migrations
{
    [DbContext(typeof(AutoTradeContext))]
    [Migration("20241102203917_AddAutomobileAdImagesedit")]
    partial class AddAutomobileAdImagesedit
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AutoTrade.Services.Database.Canton", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cantons");
                });

            modelBuilder.Entity("AutoTrade.Services.Database.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CantonId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CantonId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("AutoTrade.Services.Database.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Adress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordSalt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfilePicture")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Database.AutomobileAd", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CarBrandId")
                        .HasColumnType("int");

                    b.Property<int?>("CarCategoryId")
                        .HasColumnType("int");

                    b.Property<int?>("CarModelId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOFadd")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("FeaturedExpiryDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("FuelTypeId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Last_Big_Service")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Last_Small_Service")
                        .HasColumnType("datetime2");

                    b.Property<double>("Milage")
                        .HasColumnType("float");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<bool>("Registered")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("RegistrationExpirationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TransmissionTypeId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int?>("VehicleConditionId")
                        .HasColumnType("int");

                    b.Property<int>("ViewsCount")
                        .HasColumnType("int");

                    b.Property<int>("YearOfManufacture")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CarBrandId");

                    b.HasIndex("CarCategoryId");

                    b.HasIndex("CarModelId");

                    b.HasIndex("FuelTypeId");

                    b.HasIndex("TransmissionTypeId");

                    b.HasIndex("UserId");

                    b.HasIndex("VehicleConditionId");

                    b.ToTable("AutomobileAds");
                });

            modelBuilder.Entity("Database.AutomobileAdImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AutomobileAdId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AutomobileAdId");

                    b.ToTable("AutomobileAdImages");
                });

            modelBuilder.Entity("Database.CarBrand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CarBrands");
                });

            modelBuilder.Entity("Database.CarCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CarCategories");
                });

            modelBuilder.Entity("Database.CarModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CarModels");
                });

            modelBuilder.Entity("Database.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AutomobileAdId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AutomobileAdId");

                    b.HasIndex("UserId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("Database.Favorite", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AutomobileAdId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AutomobileAdId");

                    b.HasIndex("UserId");

                    b.ToTable("Favorites");
                });

            modelBuilder.Entity("Database.FuelType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FuelTypes");
                });

            modelBuilder.Entity("Database.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AutomobileAdId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<DateTime>("ReservationDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AutomobileAdId");

                    b.HasIndex("UserId");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("Database.TransmissionType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("transmissionTypes");
                });

            modelBuilder.Entity("Database.VehicleCondition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("VehicleConditions");
                });

            modelBuilder.Entity("AutoTrade.Services.Database.City", b =>
                {
                    b.HasOne("AutoTrade.Services.Database.Canton", "Canton")
                        .WithMany("Cities")
                        .HasForeignKey("CantonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Canton");
                });

            modelBuilder.Entity("AutoTrade.Services.Database.User", b =>
                {
                    b.HasOne("AutoTrade.Services.Database.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("Database.AutomobileAd", b =>
                {
                    b.HasOne("Database.CarBrand", "CarBrand")
                        .WithMany("AutomobileAds")
                        .HasForeignKey("CarBrandId");

                    b.HasOne("Database.CarCategory", "CarCategory")
                        .WithMany("AutomobileAds")
                        .HasForeignKey("CarCategoryId");

                    b.HasOne("Database.CarModel", "CarModel")
                        .WithMany("AutomobileAds")
                        .HasForeignKey("CarModelId");

                    b.HasOne("Database.FuelType", "FuelType")
                        .WithMany("AutomobileAds")
                        .HasForeignKey("FuelTypeId");

                    b.HasOne("Database.TransmissionType", "TransmissionType")
                        .WithMany("AutomobileAds")
                        .HasForeignKey("TransmissionTypeId");

                    b.HasOne("AutoTrade.Services.Database.User", "User")
                        .WithMany("AutomobileAds")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Database.VehicleCondition", null)
                        .WithMany("AutomobileAds")
                        .HasForeignKey("VehicleConditionId");

                    b.Navigation("CarBrand");

                    b.Navigation("CarCategory");

                    b.Navigation("CarModel");

                    b.Navigation("FuelType");

                    b.Navigation("TransmissionType");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Database.AutomobileAdImage", b =>
                {
                    b.HasOne("Database.AutomobileAd", "AutomobileAd")
                        .WithMany("Images")
                        .HasForeignKey("AutomobileAdId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AutomobileAd");
                });

            modelBuilder.Entity("Database.Comment", b =>
                {
                    b.HasOne("Database.AutomobileAd", "AutomobileAd")
                        .WithMany("Comments")
                        .HasForeignKey("AutomobileAdId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AutoTrade.Services.Database.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AutomobileAd");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Database.Favorite", b =>
                {
                    b.HasOne("Database.AutomobileAd", "AutomobileAd")
                        .WithMany("Favorites")
                        .HasForeignKey("AutomobileAdId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AutoTrade.Services.Database.User", "User")
                        .WithMany("Favorites")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AutomobileAd");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Database.Reservation", b =>
                {
                    b.HasOne("Database.AutomobileAd", "AutomobileAd")
                        .WithMany("Reservations")
                        .HasForeignKey("AutomobileAdId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AutoTrade.Services.Database.User", "User")
                        .WithMany("Reservations")
                        .HasForeignKey("UserId");

                    b.Navigation("AutomobileAd");

                    b.Navigation("User");
                });

            modelBuilder.Entity("AutoTrade.Services.Database.Canton", b =>
                {
                    b.Navigation("Cities");
                });

            modelBuilder.Entity("AutoTrade.Services.Database.User", b =>
                {
                    b.Navigation("AutomobileAds");

                    b.Navigation("Favorites");

                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("Database.AutomobileAd", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Favorites");

                    b.Navigation("Images");

                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("Database.CarBrand", b =>
                {
                    b.Navigation("AutomobileAds");
                });

            modelBuilder.Entity("Database.CarCategory", b =>
                {
                    b.Navigation("AutomobileAds");
                });

            modelBuilder.Entity("Database.CarModel", b =>
                {
                    b.Navigation("AutomobileAds");
                });

            modelBuilder.Entity("Database.FuelType", b =>
                {
                    b.Navigation("AutomobileAds");
                });

            modelBuilder.Entity("Database.TransmissionType", b =>
                {
                    b.Navigation("AutomobileAds");
                });

            modelBuilder.Entity("Database.VehicleCondition", b =>
                {
                    b.Navigation("AutomobileAds");
                });
#pragma warning restore 612, 618
        }
    }
}
