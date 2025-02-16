using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AutoTrade.Migrations
{
    /// <inheritdoc />
    public partial class testiranjefinal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AutomobileAds_CarBrands_CarBrandId",
                table: "AutomobileAds");

            migrationBuilder.DropForeignKey(
                name: "FK_AutomobileAds_CarCategories_CarCategoryId",
                table: "AutomobileAds");

            migrationBuilder.DropForeignKey(
                name: "FK_AutomobileAds_CarModels_CarModelId",
                table: "AutomobileAds");

            migrationBuilder.DropForeignKey(
                name: "FK_AutomobileAds_FuelTypes_FuelTypeId",
                table: "AutomobileAds");

            migrationBuilder.DropForeignKey(
                name: "FK_AutomobileAds_VehicleConditions_VehicleConditionId",
                table: "AutomobileAds");

            migrationBuilder.DropForeignKey(
                name: "FK_AutomobileAds_transmissionTypes_TransmissionTypeId",
                table: "AutomobileAds");

            migrationBuilder.DeleteData(
                table: "AutomobileAdImages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AutomobileAdImages",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AutomobileAdImages",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AutomobileAdImages",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AutomobileAdImages",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "AutomobileAdImages",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "AutomobileAdImages",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "AutomobileAdImages",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "AutomobileAdImages",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "AutomobileAdImages",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "AutomobileAdImages",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "AutomobileAdImages",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "AutomobileAdImages",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "AutomobileAdImages",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "AutomobileAdImages",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "AutomobileAdImages",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "AutomobileAdImages",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "AutomobileAdImages",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "AutomobileAdImages",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "AutomobileAdImages",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "AutomobileAdImages",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "AutomobileAdImages",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "AutomobileAdImages",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "AutomobileAdImages",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "AutomobileAdImages",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "AutomobileAdImages",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "AutomobileAdImages",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "AutomobileAdImages",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "AutomobileAdImages",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "AutomobileAdImages",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "AutomobileAdImages",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "AutomobileAdImages",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "AutomobileAdImages",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "AutomobileAdImages",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "AutomobileAdImages",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "AutomobileAdImages",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "AutomobileAdImages",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "AutomobileAdImages",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "AutomobileAdImages",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "AutomobileAdImages",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "AutomobileAdImages",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "AutomobileAdImages",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "AutomobileAdImages",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "AutomobileAdImages",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "AutomobileAdImages",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "AutomobileAdImages",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "AutomobileAdImages",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "AutomobileAdImages",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "AutomobileAdImages",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "AutomobileAdImages",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "AutomobileAdImages",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "AutomobileAdImages",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "AutomobileAdImages",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "AutomobileAdImages",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "AutomobileAdImages",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "AutomobileAdImages",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "AutomobileAdImages",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "AutomobileAdImages",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "AutomobileAdImages",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "AutomobileAdImages",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "AutomobileAdImages",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "AutomobileAdImages",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "AutomobileAdImages",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "AutomobileAdImages",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "AutomobileAdImages",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "AutomobileAdImages",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "AutomobileAdImages",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "AutomobileAdImages",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "AutomobileAdImages",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "AutomobileAdImages",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "AutomobileAdImages",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "AutomobileAdImages",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "AutomobileAdImages",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "AutomobileAdImages",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "AutomobileAdImages",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "AutomobileAdImages",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "AutomobileAdImages",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "AutomobileAdImages",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "AutomobileAdImages",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "AutomobileAdImages",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "AutomobileAdImages",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "CarBrands",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CarBrands",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CarBrands",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CarBrands",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CarBrands",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "CarBrands",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "CarBrands",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "CarBrands",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "CarBrands",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "CarBrands",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "CarBrands",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "CarBrands",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "CarBrands",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "CarBrands",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "CarBrands",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "CarBrands",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "CarBrands",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "CarBrands",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "CarBrands",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "CarBrands",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "CarBrands",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "CarBrands",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "CarBrands",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "CarBrands",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "CarBrands",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "CarBrands",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "CarBrands",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "CarBrands",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "CarBrands",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "CarBrands",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "CarBrands",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "CarBrands",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "CarBrands",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "CarBrands",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "CarBrands",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "CarBrands",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "CarCategories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CarCategories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CarCategories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CarCategories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "CarCategories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "CarCategories",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "CarCategories",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "CarCategories",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "FuelTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "FuelTypes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "VehicleConditions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "VehicleConditions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "VehicleConditions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "VehicleConditions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "VehicleConditions",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "VehicleConditions",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "VehicleConditions",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "transmissionTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "transmissionTypes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Cantons",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cantons",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cantons",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cantons",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cantons",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Cantons",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Cantons",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Cantons",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "CarBrands",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CarBrands",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CarBrands",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "CarBrands",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "CarBrands",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "CarBrands",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "CarBrands",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "CarBrands",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "CarBrands",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "CarBrands",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "CarBrands",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "CarBrands",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "CarBrands",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "CarBrands",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "CarCategories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CarCategories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CarCategories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "FuelTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FuelTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FuelTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "FuelTypes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "VehicleConditions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "VehicleConditions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "transmissionTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "transmissionTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "transmissionTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Cantons",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Adress",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<int>(
                name: "VehicleConditionId",
                table: "AutomobileAds",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TransmissionTypeId",
                table: "AutomobileAds",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "HorsePower",
                table: "AutomobileAds",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FuelTypeId",
                table: "AutomobileAds",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EnginePower",
                table: "AutomobileAds",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "CubicCapacity",
                table: "AutomobileAds",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CarModelId",
                table: "AutomobileAds",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CarCategoryId",
                table: "AutomobileAds",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CarBrandId",
                table: "AutomobileAds",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AutomobileAds_CarBrands_CarBrandId",
                table: "AutomobileAds",
                column: "CarBrandId",
                principalTable: "CarBrands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AutomobileAds_CarCategories_CarCategoryId",
                table: "AutomobileAds",
                column: "CarCategoryId",
                principalTable: "CarCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AutomobileAds_CarModels_CarModelId",
                table: "AutomobileAds",
                column: "CarModelId",
                principalTable: "CarModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AutomobileAds_FuelTypes_FuelTypeId",
                table: "AutomobileAds",
                column: "FuelTypeId",
                principalTable: "FuelTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AutomobileAds_VehicleConditions_VehicleConditionId",
                table: "AutomobileAds",
                column: "VehicleConditionId",
                principalTable: "VehicleConditions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AutomobileAds_transmissionTypes_TransmissionTypeId",
                table: "AutomobileAds",
                column: "TransmissionTypeId",
                principalTable: "transmissionTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AutomobileAds_CarBrands_CarBrandId",
                table: "AutomobileAds");

            migrationBuilder.DropForeignKey(
                name: "FK_AutomobileAds_CarCategories_CarCategoryId",
                table: "AutomobileAds");

            migrationBuilder.DropForeignKey(
                name: "FK_AutomobileAds_CarModels_CarModelId",
                table: "AutomobileAds");

            migrationBuilder.DropForeignKey(
                name: "FK_AutomobileAds_FuelTypes_FuelTypeId",
                table: "AutomobileAds");

            migrationBuilder.DropForeignKey(
                name: "FK_AutomobileAds_VehicleConditions_VehicleConditionId",
                table: "AutomobileAds");

            migrationBuilder.DropForeignKey(
                name: "FK_AutomobileAds_transmissionTypes_TransmissionTypeId",
                table: "AutomobileAds");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Users");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Adress",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "VehicleConditionId",
                table: "AutomobileAds",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "TransmissionTypeId",
                table: "AutomobileAds",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "HorsePower",
                table: "AutomobileAds",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "FuelTypeId",
                table: "AutomobileAds",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "EnginePower",
                table: "AutomobileAds",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<double>(
                name: "CubicCapacity",
                table: "AutomobileAds",
                type: "float",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<int>(
                name: "CarModelId",
                table: "AutomobileAds",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CarCategoryId",
                table: "AutomobileAds",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CarBrandId",
                table: "AutomobileAds",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "Cantons",
                columns: new[] { "Id", "Title" },
                values: new object[,]
                {
                    { 1, "Unsko-sanski" },
                    { 2, "Posavski" },
                    { 3, "Tuzlanski" },
                    { 4, "Zeničko-dobojski" },
                    { 5, "Bosansko-podrinjski" },
                    { 6, "Srednjobosanski kanton" },
                    { 7, "Hercegovačko-neretvanski" },
                    { 8, "Zapadnohercegovački" },
                    { 9, "Kanton Sarajevo" }
                });

            migrationBuilder.InsertData(
                table: "CarBrands",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Toyota" },
                    { 2, "Volkswagen" },
                    { 3, "Ford" },
                    { 4, "Honda" },
                    { 5, "Nissan" },
                    { 6, "Chevrolet" },
                    { 7, "Mercedes" },
                    { 8, "BMW" },
                    { 9, "Audi" },
                    { 10, "Hyundai" },
                    { 11, "Kia" },
                    { 12, "Peugeot" },
                    { 13, "Renault" },
                    { 14, "Citroën" },
                    { 15, "Fiat" },
                    { 16, "Opel" },
                    { 17, "Škoda" },
                    { 18, "Volvo" },
                    { 19, "Tesla" },
                    { 20, "Lexus" },
                    { 21, "Jeep" },
                    { 22, "Dodge" },
                    { 23, "Chrysler" },
                    { 24, "Mazda" },
                    { 25, "Subaru" },
                    { 26, "Suzuki" },
                    { 27, "Mitsubishi" },
                    { 28, "Land Rover" },
                    { 29, "Jaguar" },
                    { 30, "Porsche" },
                    { 31, "Mini" },
                    { 32, "Aston Martin" },
                    { 33, "Ferrari" },
                    { 34, "Lamborghini" },
                    { 35, "Bentley" },
                    { 36, "Rolls-Royce" },
                    { 37, "Maserati" },
                    { 38, "Alfa Romeo" },
                    { 39, "Cadillac" },
                    { 40, "Buick" },
                    { 41, "GMC" },
                    { 42, "Ram" },
                    { 43, "Infiniti" },
                    { 44, "Acura" },
                    { 45, "Lincoln" },
                    { 46, "Genesis" },
                    { 47, "Daihatsu" },
                    { 48, "Pagani" },
                    { 49, "Koenigsegg" },
                    { 50, "Bugatti" }
                });

            migrationBuilder.InsertData(
                table: "CarCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Limuzina" },
                    { 2, "Karavan" },
                    { 3, "Hečbek" },
                    { 4, "Kupe" },
                    { 5, "Kabriolet" },
                    { 6, "Terenac" },
                    { 7, "Krosover" },
                    { 8, "Monovolumen" },
                    { 9, "Pikap" },
                    { 10, "Sportski automobil" },
                    { 11, "Kombi" }
                });

            migrationBuilder.InsertData(
                table: "CarModels",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Corolla" },
                    { 2, "Yaris" },
                    { 3, "Camry" },
                    { 4, "RAV4" },
                    { 5, "Land Cruiser" },
                    { 6, "Golf" },
                    { 7, "Passat" },
                    { 8, "Polo" },
                    { 9, "Tiguan" },
                    { 10, "Touareg" },
                    { 11, "Fiesta" },
                    { 12, "Focus" },
                    { 13, "Mondeo" },
                    { 14, "Mustang" },
                    { 15, "Kuga" },
                    { 16, "Civic" },
                    { 17, "Accord" },
                    { 18, "CR-V" },
                    { 19, "Jazz" },
                    { 20, "HR-V" },
                    { 21, "1 Series" },
                    { 22, "3 Series" },
                    { 23, "5 Series" },
                    { 24, "X3" },
                    { 25, "X5" },
                    { 26, "A-Class" },
                    { 27, "C-Class" },
                    { 28, "E-Class" },
                    { 29, "GLA" },
                    { 30, "GLE" },
                    { 31, "A3" },
                    { 32, "A4" },
                    { 33, "A6" },
                    { 34, "Q3" },
                    { 35, "Q5" },
                    { 36, "i10" },
                    { 37, "i20" },
                    { 38, "i30" },
                    { 39, "Tucson" },
                    { 40, "Santa Fe" },
                    { 41, "Picanto" },
                    { 42, "Rio" },
                    { 43, "Ceed" },
                    { 44, "Sportage" },
                    { 45, "Sorento" },
                    { 46, "XC60" },
                    { 47, "S60" },
                    { 48, "Model S" },
                    { 49, "Model 3" }
                });

            migrationBuilder.InsertData(
                table: "Equipments",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Klimatizacija" },
                    { 2, "Automatska klima" },
                    { 3, "Tempomat (klasični)" },
                    { 4, "Adaptivni tempomat (ACC)" },
                    { 5, "Putni računar" },
                    { 6, "ABS" },
                    { 7, "ESP/ASR/DSC" },
                    { 8, "Zračni jastuci (Airbag)" },
                    { 9, "Isofix pričvršćivači za dječija sjedišta" },
                    { 10, "Daljinsko/centralno zaključavanje" },
                    { 11, "Električni prozori" },
                    { 12, "Električno podešavanje retrovizora" },
                    { 13, "Električno sklapanje retrovizora" },
                    { 14, "Multifunkcionalni volan" },
                    { 15, "Podesivi volan" },
                    { 16, "Senzori za parkiranje (prednji)" },
                    { 17, "Senzori za parkiranje (stražnji)" },
                    { 18, "Stražnja kamera" },
                    { 19, "Automatsko parkiranje" },
                    { 20, "Panoramski krov" },
                    { 21, "Krovni prozor (šiber)" },
                    { 22, "Aluminijske (lijevane) felge" },
                    { 23, "Čelične felge" },
                    { 24, "LED prednja svjetla" },
                    { 25, "LED zadnja svjetla" },
                    { 26, "Bi-Xenon svjetla" },
                    { 27, "Maglenke" },
                    { 28, "Senzor za kišu" },
                    { 29, "Senzor za svjetla" },
                    { 30, "Start/Stop sistem" },
                    { 31, "Keyless Go" },
                    { 32, "Hands-free Bluetooth" },
                    { 33, "Radio/CD/MP3" },
                    { 34, "USB/AUX priključak" },
                    { 35, "Navigacioni sistem" },
                    { 36, "Grijana sjedišta (prednja)" },
                    { 37, "Grijana sjedišta (stražnja)" },
                    { 38, "Ventilirana sjedišta" },
                    { 39, "Kožna sjedišta" },
                    { 40, "Električno podesiva sjedišta" },
                    { 41, "Memorija položaja sjedišta" },
                    { 42, "Grijani volan" },
                    { 43, "Ambijentalno osvjetljenje" },
                    { 44, "Head-up display" },
                    { 45, "Alarmni sistem" },
                    { 46, "Kuka za vuču" },
                    { 47, "Grijano vjetrobransko staklo" },
                    { 48, "Automatsko zatamnjivanje retrovizora" },
                    { 49, "Mrtvi ugao" },
                    { 50, "Lane Assist" },
                    { 51, "Bežično punjenje telefona" }
                });

            migrationBuilder.InsertData(
                table: "FuelTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Benzin" },
                    { 2, "Dizel" },
                    { 3, "Plin" },
                    { 4, "Benzin + Plin" },
                    { 5, "Hibrid" },
                    { 6, "Električni" }
                });

            migrationBuilder.InsertData(
                table: "VehicleConditions",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Novo" },
                    { 2, "Polovno" },
                    { 3, "Oštećeno" },
                    { 4, "Havarisano" },
                    { 5, "Za dijelove" },
                    { 6, "Ispravno" },
                    { 7, "Neispravno" },
                    { 8, "Oldtimer" },
                    { 9, "Restaurirano" }
                });

            migrationBuilder.InsertData(
                table: "transmissionTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Manuelni" },
                    { 2, "Automatski" },
                    { 3, "Polu-automatski" },
                    { 4, "CVT" },
                    { 5, "DSG" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CantonId", "Title" },
                values: new object[,]
                {
                    { 1, 1, "Bihać" },
                    { 2, 1, "Cazin" },
                    { 3, 1, "Velika Kladuša" },
                    { 4, 1, "Bosanska Krupa" },
                    { 5, 1, "Bužim" },
                    { 6, 1, "Ključ" },
                    { 7, 1, "Bosanski Petrovac" },
                    { 8, 1, "Sanski Most" },
                    { 9, 1, "Ostrožac" },
                    { 10, 1, "Ćoralići" },
                    { 11, 2, "Orašje" },
                    { 12, 2, "Domaljevac" },
                    { 13, 2, "Odžak" },
                    { 14, 2, "Kostrč" },
                    { 15, 2, "Tolisa" },
                    { 16, 2, "Ugljara" },
                    { 17, 2, "Bukova Greda" },
                    { 18, 2, "Vidovice" },
                    { 19, 2, "Jenjić" },
                    { 20, 2, "Lončari" },
                    { 21, 3, "Tuzla" },
                    { 22, 3, "Lukavac" },
                    { 23, 3, "Gračanica" },
                    { 24, 3, "Srebrenik" },
                    { 25, 3, "Kalesija" },
                    { 26, 3, "Gradačac" },
                    { 27, 3, "Živinice" },
                    { 28, 3, "Čelić" },
                    { 29, 3, "Sapna" },
                    { 30, 3, "Teočak" },
                    { 31, 4, "Zenica" },
                    { 32, 4, "Doboj Jug" },
                    { 33, 4, "Kakanj" },
                    { 34, 4, "Maglaj" },
                    { 35, 4, "Olovo" },
                    { 36, 4, "Tešanj" },
                    { 37, 4, "Usora" },
                    { 38, 4, "Vareš" },
                    { 39, 4, "Visoko" },
                    { 40, 4, "Zavidovići" },
                    { 41, 5, "Goražde" },
                    { 42, 5, "Pale-Prača" },
                    { 43, 5, "Foča-Ustikolina" },
                    { 44, 5, "Ilovača" },
                    { 45, 5, "Vitkovići" },
                    { 46, 5, "Hubjeri" },
                    { 47, 5, "Berič" },
                    { 48, 5, "Osanica" },
                    { 49, 5, "Čitluk" },
                    { 50, 5, "Rorovi" },
                    { 51, 6, "Travnik" },
                    { 52, 6, "Bugojno" },
                    { 53, 6, "Novi Travnik" },
                    { 54, 6, "Vitez" },
                    { 55, 6, "Jajce" },
                    { 56, 6, "Gornji Vakuf-Uskoplje" },
                    { 57, 6, "Donji Vakuf" },
                    { 58, 6, "Busovača" },
                    { 59, 6, "Kiseljak" },
                    { 60, 6, "Fojnica" },
                    { 61, 7, "Mostar" },
                    { 62, 7, "Konjic" },
                    { 63, 7, "Jablanica" },
                    { 64, 7, "Prozor-Rama" },
                    { 65, 7, "Neum" },
                    { 66, 7, "Stolac" },
                    { 67, 7, "Čapljina" },
                    { 68, 7, "Čitluk" },
                    { 69, 7, "Ravno" },
                    { 70, 7, "Blagaj" },
                    { 71, 8, "Široki Brijeg" },
                    { 72, 8, "Grude" },
                    { 73, 8, "Ljubuški" },
                    { 74, 8, "Posušje" },
                    { 75, 8, "Kočerin" },
                    { 76, 8, "Vitina" },
                    { 77, 8, "Ružići" },
                    { 78, 8, "Tihaljina" },
                    { 79, 8, "Veljaci" },
                    { 80, 8, "Hardomilje" },
                    { 81, 9, "Stari Grad" },
                    { 82, 9, "Centar" },
                    { 83, 9, "Novo Sarajevo" },
                    { 84, 9, "Novi Grad" },
                    { 85, 9, "Ilidža" },
                    { 86, 9, "Hadžići" },
                    { 87, 9, "Vogošća" },
                    { 88, 9, "Ilijaš" },
                    { 89, 9, "Trnovo (FBiH)" },
                    { 90, 9, "Hrasnica" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Adress", "CityId", "DateOfBirth", "Email", "FirstName", "Gender", "IsAdmin", "LastName", "PasswordHash", "PasswordSalt", "PhoneNumber", "ProfilePicture", "UserName" },
                values: new object[,]
                {
                    { 1, "Adresa 1", 1, new DateTime(1990, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "creauts.xoxo@gmail.com", "admin", "M", true, "admin", "Z4mZJdmZoBGfib2YgbhhW6gBRHs=", "82b87KYEv/cpg+n7F8ve+A==", "062123456", "/uploads/harisSlika.jpg", "admin" },
                    { 2, "Adresa 2", 2, new DateTime(1985, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "haris.likic@hotmail.com", "haris", "M", true, "likic", "ZO4OflK7DZRsGlNWK0xiZ2O/5CA=", "y9guykHYGpv/3RYNIWyTpQ==", "063654321", "/uploads/samirSlika.jpg", "haris" },
                    { 3, "Adresa 3", 3, new DateTime(1995, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "amila@gmail.com", "Amila", "Z", false, "Hodžić", "b2OPCXPHyppkYErk3+cDSOG7WRE=", "pBRofuHlT5+5eA3xieW8xQ==", "061987654", "/uploads/userSlika.jpg", "user123" },
                    { 4, "Adresa 4", 4, new DateTime(1992, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "adnan@gmail.com", "Adnan", "Z", false, "Šarić", "G3Os49ddyYJ7F8IMsssGi6U8Cc4=", "qDfM0DotBb34ILmrNVSeIA==", "064112233", "/uploads/user2Slika.jpg", "user2" },
                    { 5, "Adresa 5", 5, new DateTime(1998, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "lejla@gmail.com", "Lejla", "F", false, "Halilović", "TDP9ycebWQ+hOLpE2KlExcVs9sI=", "4SZj0/yH/4NhJTNwjJ3eaw==", "065223344", "/uploads/user3Slika.jpg", "user3" },
                    { 6, "Adresa 6", 6, new DateTime(1995, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "user4@gmail.com", "User", "M", false, "Test", "USOk/HeFuumuhDX0tVzHXM41olE=", "xTLo6379Xxfotpul1qOGAQ==", "060112233", "/uploads/user4Slika.jpg", "user4" },
                    { 7, "Adresa 7", 7, new DateTime(1974, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "christian@gmail.com", "Christian", "M", false, "Bale", "9K8Cx1lFKl1lRRiMJT39KwAn1zM=", "ckw0SgPNCtyIwTe2nFdD3A==", "060445566", "/uploads/userSlika5.jpg", "cbale" },
                    { 8, "Adresa 8", 8, new DateTime(1935, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "alain@gmail.com", "Alain", "M", false, "Delon", "2d0lD/MwABzGG+qyQiiD0rnp+LU=", "BZlurL4//EovoIxzTSbx9w==", "060778899", "/uploads/userSlika6.jpg", "adelon" },
                    { 9, "Adresa 9", 9, new DateTime(1975, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "cico@gmail.com", "Cico", "M", false, "Sreckovic", "3jNOeofEpyt01HeWQ1SnXauGh2Y=", "VSe2jcDV2diXTqb4PYCCnA==", "060889900", "/uploads/userSlika7.jpeg", "csreckovic" },
                    { 10, "Adresa 10", 10, new DateTime(1980, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "aljosa@gmail.com", "Aljosa", "M", false, "Kicanski", "rmSCMhfs8icyi5NEb/MpKNnQpog=", "9ZRfOlbHVYPnuQBIh5GZ0Q==", "061990011", "/uploads/userSlika8.jpg", "akicanski" }
                });

            migrationBuilder.InsertData(
                table: "AutomobileAds",
                columns: new[] { "Id", "CarBrandId", "CarCategoryId", "CarModelId", "Color", "CubicCapacity", "DateOFadd", "Description", "EnginePower", "FeaturedExpiryDate", "FuelTypeId", "HighlightExpiryDate", "HorsePower", "IsHighlighted", "Last_Big_Service", "Last_Small_Service", "Milage", "NumberOfDoors", "PaymentTransactionId", "Price", "Registered", "RegistrationExpirationDate", "Status", "Title", "TransmissionTypeId", "UserId", "VehicleConditionId", "ViewsCount", "YearOfManufacture" },
                values: new object[,]
                {
                    { 1, 1, 1, 1, "Crna", 2000.0, new DateTime(2025, 2, 7, 16, 3, 56, 637, DateTimeKind.Local).AddTicks(180), "Audi A3 u odličnom stanju, dobro održavan, prvi vlasnik.", 140, null, 1, new DateTime(2025, 2, 9, 16, 3, 56, 637, DateTimeKind.Local).AddTicks(220), 190, true, null, null, 75000.0, 4, null, 25000.0, true, new DateTime(2024, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", "Audi A3 2018", 2, 1, 2, 230, 2018 },
                    { 2, 9, 1, 33, "Bijela", 1.0, new DateTime(2025, 2, 7, 16, 3, 56, 637, DateTimeKind.Local).AddTicks(230), "audi a3 sa odličnim performansama, drugi vlasnik. S line oprema sve u fullu uradjeno. Crno nebo", 120, new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, 184, false, null, null, 123223.0, 4, null, 20000.0, true, new DateTime(2024, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", "Audi a3 s line", 1, 2, 2, 123, 2015 },
                    { 3, 9, 2, 32, "Crna", 2.0, new DateTime(2025, 2, 7, 16, 3, 56, 637, DateTimeKind.Local).AddTicks(230), "Audi A4 u odličnom stanju, dobro održavan, drugo vlasnik. Karavan jako ocuvan sa puno dodatne opreme", 140, new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, 120, false, null, null, 230121.0, 4, null, 13450.0, true, new DateTime(2024, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", "Audi A4 B8 Karavan 2015", 1, 3, 2, 30, 2015 },
                    { 4, 9, 1, 31, "Bijela", 2.0, new DateTime(2025, 2, 7, 16, 3, 56, 637, DateTimeKind.Local).AddTicks(240), "Audi A5 u odličnom stanju, dobro održavan nove 4 gume zimske i ljetne, drugi vlasnik.Jako ocuvan sa puno dodatne opreme auto bez packe sjedi i vozi", 140, new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, 120, false, null, null, 230121.0, 4, null, 16500.0, true, new DateTime(2024, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", "Audi A5", 1, 4, 2, 39, 2018 },
                    { 5, 9, 1, 33, "Siva", 2.0, new DateTime(2025, 2, 7, 16, 3, 56, 637, DateTimeKind.Local).AddTicks(250), "Audi A6 u odličnom stanju, dobro održavan nove 4 gume zimske i ljetne, drugi vlasnik.Jako ocuvan sa puno dodatne opreme auto bez packe sjedi i vozi. Najbolje doci i pogledati auto. Vozeno na posao i nazad. Nov akumulator i set kvacila odradjen nedavno.!!!PRODAJA SAMO", 140, new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2025, 2, 27, 16, 3, 56, 637, DateTimeKind.Local).AddTicks(250), 190, true, null, null, 120121.0, 4, null, 22500.0, true, new DateTime(2025, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", "Audi A6", 1, 5, 2, 123, 2020 },
                    { 6, 8, 1, 24, "Smedja", 2.0, new DateTime(2025, 2, 7, 16, 3, 56, 637, DateTimeKind.Local).AddTicks(260), "BMW E60 u odličnom stanju, dobro održavan nove 4 gume zimske i ljetne, drugi vlasnik.Jako ocuvan sa puno dodatne opreme auto bez packe sjedi i vozi. Najbolje doci i pogledati auto. Vozeno na posao i nazad. Nov akumulator i set kvacila odradjen nedavno.!!!PRODAJA SAMO", 88, new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, 190, false, null, null, 450301.0, 4, null, 10500.0, true, new DateTime(2025, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", "BMW E60", 2, 6, 2, 250, 2010 },
                    { 7, 13, 1, 16, "Plava", 2.0, new DateTime(2025, 2, 7, 16, 3, 56, 637, DateTimeKind.Local).AddTicks(260), "Citroen ds 6 u odličnom stanju, dobro održavan nove 4 gume zimske i ljetne, drugi vlasnik.Jako ocuvan sa puno dodatne opreme auto bez packe sjedi i vozi. Najbolje doci i pogledati auto. Vozeno na posao i nazad. Nov akumulator i set kvacila odradjen nedavno.!!!PRODAJA SAMO", 104, new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, 88, false, null, null, 290421.0, 4, null, 6000.0, true, new DateTime(2025, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", "Citroen DS 5", 2, 7, 2, 10, 2009 },
                    { 8, 15, 1, 48, "Crna", 2.0, new DateTime(2025, 2, 7, 16, 3, 56, 637, DateTimeKind.Local).AddTicks(270), "Fiat punto u odličnom stanju, dobro održavan nove 4 gume zimske i ljetne, drugi vlasnik.Jako ocuvan sa puno dodatne opreme auto bez packe sjedi i vozi. Najbolje doci i pogledati auto. Vozeno na posao i nazad. Nov akumulator i set kvacila odradjen nedavno.!!!PRODAJA SAMO", 44, new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, 88, false, null, null, 542121.0, 4, null, 3500.0, true, new DateTime(2025, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", "Fiat punto", 2, 8, 3, 11, 2004 },
                    { 9, 2, 1, 6, "Siva", 2.0, new DateTime(2025, 2, 7, 16, 3, 56, 637, DateTimeKind.Local).AddTicks(280), "Golf 4 u perfektnom stanju, dobro održavan nove 4 gume zimske i ljetne, drugi vlasnik.Jako ocuvan sa puno dodatne opreme auto bez packe sjedi i vozi. Najbolje doci i pogledati auto. Vozeno na posao i nazad. Nov akumulator i set kvacila odradjen nedavno.!!!PRODAJA SAMO", 88, new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, 88, false, null, null, 321211.0, 4, null, 5800.0, true, new DateTime(2025, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", "Golf 4", 2, 9, 2, 300, 2002 },
                    { 10, 2, 1, 6, "Crna", 2.0, new DateTime(2025, 2, 7, 16, 3, 56, 637, DateTimeKind.Local).AddTicks(280), "Golf 6 GTD u perfektnom stanju, Auto koje puno trosi al se zna za sta se placa, VR 6 motor,dobro održavan nove 4 gume zimske i ljetne, drugi vlasnik.Jako ocuvan sa puno dodatne opreme auto bez packe sjedi i vozi. Najbolje doci i pogledati auto. Vozeno na posao i nazad. Nov akumulator i set kvacila odradjen nedavno.!!!PRODAJA SAMO", 180, new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, 210, false, null, null, 234012.0, 4, null, 18500.0, true, new DateTime(2025, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", "Golf 6 GTD", 2, 10, 2, 550, 2016 },
                    { 11, 2, 1, 6, "Crna", 2.0, new DateTime(2025, 2, 7, 16, 3, 56, 637, DateTimeKind.Local).AddTicks(300), "Golf 7 u perfektnom stanju, Auto koje puno trosi al se zna za sta se placa, VR 6 motor,dobro održavan nove 4 gume zimske i ljetne, drugi vlasnik.Jako ocuvan sa puno dodatne opreme auto bez packe sjedi i vozi. Najbolje doci i pogledati auto. Vozeno na posao i nazad. Nov akumulator i set kvacila odradjen nedavno.!!!PRODAJA SAMO", 180, new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2025, 2, 27, 16, 3, 56, 637, DateTimeKind.Local).AddTicks(310), 210, true, null, null, 234012.0, 4, null, 19900.0, true, new DateTime(2025, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", "Golf 7", 2, 1, 2, 123, 2012 },
                    { 12, 2, 1, 6, "Siva", 2.0, new DateTime(2025, 2, 7, 16, 3, 56, 637, DateTimeKind.Local).AddTicks(310), "Golf 7 TDI u perfektnom stanju, Auto koje puno trosi al se zna za sta se placa, VR 6 motor,dobro održavan nove 4 gume zimske i ljetne, drugi vlasnik.Jako ocuvan sa puno dodatne opreme auto bez packe sjedi i vozi. Najbolje doci i pogledati auto. Vozeno na posao i nazad. Nov akumulator i set kvacila odradjen nedavno.!!!PRODAJA SAMO", 180, new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, 210, false, null, null, 215012.0, 4, null, 17800.0, true, new DateTime(2025, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", "Golf 7 Tdi", 2, 2, 2, 231, 2014 },
                    { 13, 10, 1, 36, "Crvena", 2.0, new DateTime(2025, 2, 7, 16, 3, 56, 637, DateTimeKind.Local).AddTicks(320), "Hyundai Kona TDI u perfektnom stanju, Auto koje puno trosi al se zna za sta se placa, VR 6 motor,dobro održavan nove 4 gume zimske i ljetne, drugi vlasnik.Jako ocuvan sa puno dodatne opreme auto bez packe sjedi i vozi. Najbolje doci i pogledati auto. Vozeno na posao i nazad. Nov akumulator i set kvacila odradjen nedavno.!!!PRODAJA SAMO", 100, new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, 100, false, null, null, 123444.0, 4, null, 24100.0, true, new DateTime(2025, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", "Hyundai Kona", 1, 2, 2, 333, 2020 },
                    { 14, 28, 1, 47, "Bež", 2.0, new DateTime(2025, 2, 7, 16, 3, 56, 637, DateTimeKind.Local).AddTicks(330), "Land Roveru perfektnom stanju, Auto koje puno trosi al se zna za sta se placa, VR 6 motor,dobro održavan nove 4 gume zimske i ljetne, drugi vlasnik.Jako ocuvan sa puno dodatne opreme auto bez packe sjedi i vozi. Najbolje doci i pogledati auto. Vozeno na posao i nazad. Nov akumulator i set kvacila odradjen nedavno.!!!PRODAJA SAMO", 150, new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, 144, false, null, null, 450000.0, 4, null, 13500.0, true, new DateTime(2025, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", "Land Rover", 2, 3, 2, 231, 2011 },
                    { 15, 24, 1, 36, "Bijela", 2.0, new DateTime(2025, 2, 7, 16, 3, 56, 637, DateTimeKind.Local).AddTicks(330), "Mazda cx7 u perfektnom stanju, Auto koje puno trosi al se zna za sta se placa, VR 6 motor,dobro održavan nove 4 gume zimske i ljetne, drugi vlasnik.Jako ocuvan sa puno dodatne opreme auto bez packe sjedi i vozi. Najbolje doci i pogledati auto. Vozeno na posao i nazad. Nov akumulator i set kvacila odradjen nedavno.!!!PRODAJA SAMO", 150, new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, 144, false, null, null, 450000.0, 4, null, 9500.0, true, new DateTime(2025, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", "Mazda cx 7", 3, 4, 2, 50, 2008 },
                    { 16, 7, 1, 26, "Siva", 2.0, new DateTime(2025, 2, 7, 16, 3, 56, 637, DateTimeKind.Local).AddTicks(340), "Mercedes ML 350 u perfektnom stanju, Auto koje puno trosi al se zna za sta se placa, VR 6 motor,dobro održavan nove 4 gume zimske i ljetne, drugi vlasnik.Jako ocuvan sa puno dodatne opreme auto bez packe sjedi i vozi. Najbolje doci i pogledati auto. Vozeno na posao i nazad. Nov akumulator i set kvacila odradjen nedavno.!!!PRODAJA SAMO", 150, new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, null, 144, false, null, null, 300000.0, 4, null, 11200.0, true, new DateTime(2025, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", "Mercedes ML 350", 1, 5, 2, 55, 2010 },
                    { 17, 16, 1, 2, "Plava", 2.0, new DateTime(2025, 2, 7, 16, 3, 56, 637, DateTimeKind.Local).AddTicks(350), "Open Corsa 1.2 u dobrom stanju, Auto koje puno trosi al se zna za sta se placa, VR 6 motor,dobro održavan nove 4 gume zimske i ljetne, drugi vlasnik.Jako ocuvan sa puno dodatne opreme auto bez packe sjedi i vozi. Najbolje doci i pogledati auto. Vozeno na posao i nazad. Nov akumulator i set kvacila odradjen nedavno.!!!PRODAJA SAMO", 110, new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, null, 150, false, null, null, 348400.0, 4, null, 5400.0, true, new DateTime(2025, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", "Opel Corsa 1.3", 1, 6, 2, 35, 2005 },
                    { 18, 2, 1, 7, "Siva", 2.0, new DateTime(2025, 2, 7, 16, 3, 56, 637, DateTimeKind.Local).AddTicks(360), "Passat b6 u dobrom stanju, Auto koje puno trosi al se zna za sta se placa, VR 6 motor,dobro održavan nove 4 gume zimske i ljetne, drugi vlasnik.Jako ocuvan sa puno dodatne opreme auto bez packe sjedi i vozi. Najbolje doci i pogledati auto. Vozeno na posao i nazad. Nov akumulator i set kvacila odradjen nedavno.!!!PRODAJA SAMO", 110, new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, null, 150, false, null, null, 448400.0, 4, null, 6600.0, true, new DateTime(2025, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", "Passat b6", 2, 7, 2, 90, 2004 },
                    { 19, 2, 1, 7, "Crna", 2.0, new DateTime(2025, 2, 7, 16, 3, 56, 637, DateTimeKind.Local).AddTicks(360), "Passat CC u dobrom stanju, Auto koje puno trosi al se zna za sta se placa, VR 6 motor,dobro održavan nove 4 gume zimske i ljetne, drugi vlasnik.Jako ocuvan sa puno dodatne opreme auto bez packe sjedi i vozi. Najbolje doci i pogledati auto. Vozeno na posao i nazad. Nov akumulator i set kvacila odradjen nedavno.!!!PRODAJA SAMO", 110, new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, null, 150, false, null, null, 245131.0, 4, null, 21000.0, true, new DateTime(2025, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", "Passat CC", 2, 8, 2, 123, 2019 },
                    { 20, 12, 1, 7, "Siva", 2.0, new DateTime(2025, 2, 7, 16, 3, 56, 637, DateTimeKind.Local).AddTicks(370), "Peugeot 407 u dobrom stanju, Auto koje puno trosi al se zna za sta se placa, VR 6 motor,dobro održavan nove 4 gume zimske i ljetne, drugi vlasnik.Jako ocuvan sa puno dodatne opreme auto bez packe sjedi i vozi. Najbolje doci i pogledati auto. Vozeno na posao i nazad. Nov akumulator i set kvacila odradjen nedavno.!!!PRODAJA SAMO", 88, new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, null, 110, false, null, null, 545131.0, 4, null, 3500.0, true, new DateTime(2025, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", "Peugeot 407", 1, 9, 2, 222, 2001 },
                    { 21, 2, 1, 7, "Plava", 2.0, new DateTime(2025, 2, 7, 16, 3, 56, 637, DateTimeKind.Local).AddTicks(380), "Polo 2006 u dobrom stanju, Auto koje puno trosi al se zna za sta se placa, VR 6 motor,dobro održavan nove 4 gume zimske i ljetne, drugi vlasnik.Jako ocuvan sa puno dodatne opreme auto bez packe sjedi i vozi. Najbolje doci i pogledati auto. Vozeno na posao i nazad. Nov akumulator i set kvacila odradjen nedavno.!!!PRODAJA SAMO", 88, new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, 110, false, null, null, 345000.0, 4, null, 4300.0, true, new DateTime(2025, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", "Polo 2006", 1, 10, 2, 111, 2002 },
                    { 22, 47, 6, 41, "Crna", 2.0, new DateTime(2025, 2, 7, 16, 3, 56, 637, DateTimeKind.Local).AddTicks(380), "Quad u dobrom stanju, Auto koje puno trosi al se zna za sta se placa, VR 6 motor,dobro održavan nove 4 gume zimske i ljetne, drugi vlasnik.Jako ocuvan sa puno dodatne opreme auto bez packe sjedi i vozi. Najbolje doci i pogledati auto. Vozeno na posao i nazad. Nov akumulator i set kvacila odradjen nedavno.!!!PRODAJA SAMO", 88, new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, 110, false, null, null, 55000.0, 4, null, 14000.0, true, new DateTime(2025, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", "Quad", 1, 2, 2, 30, 2009 },
                    { 23, 13, 2, 2, "Plava", 2.0, new DateTime(2025, 2, 7, 16, 3, 56, 637, DateTimeKind.Local).AddTicks(390), "Renault Megan u dobrom stanju, Auto koje puno trosi al se zna za sta se placa, VR 6 motor,dobro održavan nove 4 gume zimske i ljetne, drugi vlasnik.Jako ocuvan sa puno dodatne opreme auto bez packe sjedi i vozi. Najbolje doci i pogledati auto. Vozeno na posao i nazad. Nov akumulator i set kvacila odradjen nedavno.!!!PRODAJA SAMO", 140, new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, 103, false, null, null, 250111.0, 4, null, 3500.0, true, new DateTime(2025, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", "Renault Megan", 1, 3, 2, 35, 2004 },
                    { 24, 17, 1, 5, "Plava", 2.0, new DateTime(2025, 2, 7, 16, 3, 56, 637, DateTimeKind.Local).AddTicks(400), "Renault Scenic u dobrom stanju, Auto koje puno trosi al se zna za sta se placa, VR 6 motor,dobro održavan nove 4 gume zimske i ljetne, drugi vlasnik.Jako ocuvan sa puno dodatne opreme auto bez packe sjedi i vozi. Najbolje doci i pogledati auto. Vozeno na posao i nazad. Nov akumulator i set kvacila odradjen nedavno.!!!PRODAJA SAMO", 140, new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, 103, false, null, null, 250111.0, 4, null, 3500.0, true, new DateTime(2025, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", "Renault Scenic", 1, 4, 2, 35, 2004 },
                    { 25, 17, 2, 2, "Plava", 2.0, new DateTime(2025, 2, 7, 16, 3, 56, 637, DateTimeKind.Local).AddTicks(410), "Skoda fabia HTP u dobrom stanju, Auto koje puno trosi al se zna za sta se placa, VR 6 motor,dobro održavan nove 4 gume zimske i ljetne, drugi vlasnik.Jako ocuvan sa puno dodatne opreme auto bez packe sjedi i vozi. Najbolje doci i pogledati auto. Vozeno na posao i nazad. Nov akumulator i set kvacila odradjen nedavno.!!!PRODAJA SAMO", 140, new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, 103, false, null, null, 250111.0, 4, null, 5000.0, true, new DateTime(2025, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", "Skoda Octavia HTP", 1, 5, 2, 55, 20014 },
                    { 26, 17, 2, 2, "Bijela", 2.0, new DateTime(2025, 2, 7, 16, 3, 56, 637, DateTimeKind.Local).AddTicks(410), "Skoda Octavia 1.2 u dobrom stanju, Auto koje puno trosi al se zna za sta se placa, VR 6 motor,dobro održavan nove 4 gume zimske i ljetne, drugi vlasnik.Jako ocuvan sa puno dodatne opreme auto bez packe sjedi i vozi. Najbolje doci i pogledati auto. Vozeno na posao i nazad. Nov akumulator i set kvacila odradjen nedavno.!!!PRODAJA SAMO", 140, new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, 103, false, null, null, 350000.0, 4, null, 5000.0, true, new DateTime(2025, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", "Skoda Octavia", 1, 6, 2, 55, 20014 },
                    { 27, 2, 1, 15, "Bijela", 2.0, new DateTime(2025, 2, 7, 16, 3, 56, 637, DateTimeKind.Local).AddTicks(420), "Bora  u dobrom stanju, Auto koje puno trosi al se zna za sta se placa, VR 6 motor,dobro održavan nove 4 gume zimske i ljetne, drugi vlasnik.Jako ocuvan sa puno dodatne opreme auto bez packe sjedi i vozi. Najbolje doci i pogledati auto. Vozeno na posao i nazad. Nov akumulator i set kvacila odradjen nedavno.!!!PRODAJA SAMO", 140, new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, 103, false, null, null, 450131.0, 4, null, 11000.0, true, new DateTime(2025, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pending", "WV bora", 1, 6, 2, 142, 20014 },
                    { 28, 2, 6, 9, "Bijela", 2.0, new DateTime(2025, 2, 7, 16, 3, 56, 637, DateTimeKind.Local).AddTicks(430), "Tiguran u dobrom stanju, Auto koje puno trosi al se zna za sta se placa, VR 6 motor,dobro održavan nove 4 gume zimske i ljetne, drugi vlasnik.Jako ocuvan sa puno dodatne opreme auto bez packe sjedi i vozi. Najbolje doci i pogledati auto. Vozeno na posao i nazad. Nov akumulator i set kvacila odradjen nedavno.!!!PRODAJA SAMO", 190, new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2025, 2, 27, 16, 3, 56, 637, DateTimeKind.Local).AddTicks(430), 103, true, null, null, 222000.0, 4, null, 11000.0, true, new DateTime(2025, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pending", "Tiguan", 1, 6, 2, 541, 20014 },
                    { 29, 2, 6, 9, "Bijela", 2.0, new DateTime(2025, 2, 7, 16, 3, 56, 637, DateTimeKind.Local).AddTicks(440), "Tiguran u dobrom stanju, Auto koje puno trosi al se zna za sta se placa, VR 6 motor,dobro održavan nove 4 gume zimske i ljetne, drugi vlasnik.Jako ocuvan sa puno dodatne opreme auto bez packe sjedi i vozi. Najbolje doci i pogledati auto. Vozeno na posao i nazad. Nov akumulator i set kvacila odradjen nedavno.!!!PRODAJA SAMO", 190, new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, 103, false, null, null, 222000.0, 4, null, 11000.0, true, new DateTime(2025, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pending", "Tiguan 2", 1, 4, 2, 541, 20014 }
                });

            migrationBuilder.InsertData(
                table: "AutomobileAdImages",
                columns: new[] { "Id", "AutomobileAdId", "ImageUrl" },
                values: new object[,]
                {
                    { 1, 1, "/uploads/automobiles/Audia3/unutrasnjost.jpg" },
                    { 2, 1, "/uploads/automobiles/Audia3/vanjska1.jpg" },
                    { 3, 1, "/uploads/automobiles/Audia3/vanjska2.jpg" },
                    { 4, 2, "/uploads/automobiles/Audia3sline/vanjska1.jpg" },
                    { 5, 2, "/uploads/automobiles/Audia3sline/unutrasnja1.jpg" },
                    { 6, 3, "/uploads/automobiles/Audia4b8karavan/vanjska1.jpg" },
                    { 7, 3, "/uploads/automobiles/Audia4b8karavan/vanjska2.jpg" },
                    { 8, 3, "/uploads/automobiles/Audia4b8karavan/vanjska3.jpg" },
                    { 9, 4, "/uploads/automobiles/Audia5/unutrasnja1.jpg" },
                    { 10, 4, "/uploads/automobiles/Audia5/vanjska1.jpg" },
                    { 11, 4, "/uploads/automobiles/Audia5/vanjska2.jpg" },
                    { 12, 5, "/uploads/automobiles/Audia6/unutrasnja1.jpg" },
                    { 13, 5, "/uploads/automobiles/Audia6/vanjska1.jpg" },
                    { 14, 5, "/uploads/automobiles/Audia6/vanjska2.jpg" },
                    { 15, 6, "/uploads/automobiles/BMWE60/unutrasnja1.jpg" },
                    { 16, 6, "/uploads/automobiles/BMWE60/vanjska1.jpg" },
                    { 17, 6, "/uploads/automobiles/BMWE60/vanjska2.jpg" },
                    { 18, 7, "/uploads/automobiles/CitroenDS5/unutrasnja1.jpg" },
                    { 19, 7, "/uploads/automobiles/CitroenDS5/vanjska1.jpg" },
                    { 20, 7, "/uploads/automobiles/CitroenDS5/vanjska2.jpg" },
                    { 21, 8, "/uploads/automobiles/FiatPunto/unutrasnja1.jpg" },
                    { 22, 8, "/uploads/automobiles/FiatPunto/vanjska1.jpg" },
                    { 23, 9, "/uploads/automobiles/Golf4/vanjska1.jpg" },
                    { 24, 9, "/uploads/automobiles/Golf4/vanjska2.jpg" },
                    { 25, 9, "/uploads/automobiles/Golf4/unutrasnja1.jpg" },
                    { 26, 10, "/uploads/automobiles/Golf6gtd/unutrasnjost1.jpg" },
                    { 27, 10, "/uploads/automobiles/Golf6gtd/unutrasnjost2.jpg" },
                    { 28, 10, "/uploads/automobiles/Golf6gtd/vanjska1.jpg" },
                    { 29, 10, "/uploads/automobiles/Golf6gtd/vanjska2.jpg" },
                    { 30, 11, "/uploads/automobiles/Golf7/unutrasnja1.jpg" },
                    { 31, 11, "/uploads/automobiles/Golf7/unutrasnja2.jpg" },
                    { 32, 11, "/uploads/automobiles/Golf7/vanjska1.jpg" },
                    { 33, 11, "/uploads/automobiles/Golf7/vanjska2.jpg" },
                    { 34, 12, "/uploads/automobiles/Golf7Tdi/unutrasnja1.jpg" },
                    { 35, 12, "/uploads/automobiles/Golf7Tdi/vanjska1.jpg" },
                    { 36, 12, "/uploads/automobiles/Golf7Tdi/vanjska2.jpg" },
                    { 37, 13, "/uploads/automobiles/HyundaiKona/unutrasnja1.jpg" },
                    { 38, 13, "/uploads/automobiles/HyundaiKona/vanjska1.jpg" },
                    { 39, 14, "/uploads/automobiles/LandRover/unutrasnja1.jpg" },
                    { 40, 14, "/uploads/automobiles/LandRover/vanjska1.jpg" },
                    { 41, 14, "/uploads/automobiles/LandRover/vanjska2.jpg" },
                    { 42, 15, "/uploads/automobiles/Mazdacx7/unutrasnja1.jpg" },
                    { 43, 15, "/uploads/automobiles/Mazdacx7/vanjska1.jpg" },
                    { 44, 15, "/uploads/automobiles/Mazdacx7/vanjska2.jpg" },
                    { 45, 16, "/uploads/automobiles/MercedesMl350/unutrasnja1.jpg" },
                    { 46, 16, "/uploads/automobiles/MercedesMl350/vanjska1.jpg" },
                    { 47, 16, "/uploads/automobiles/MercedesMl350/vanjska2.jpg" },
                    { 48, 17, "/uploads/automobiles/OpelCorsa/unutrasnja1.jpg" },
                    { 49, 17, "/uploads/automobiles/OpelCorsa/vanjska1.jpg" },
                    { 50, 17, "/uploads/automobiles/OpelCorsa/vanjska2.jpg" },
                    { 51, 18, "/uploads/automobiles/Passatb6/unutrasnja1.jpg" },
                    { 52, 18, "/uploads/automobiles/Passatb6/vanjska1.jpg" },
                    { 53, 18, "/uploads/automobiles/Passatb6/vanjska2.jpg" },
                    { 54, 19, "/uploads/automobiles/PassatCC/vanjska1.jpg" },
                    { 55, 19, "/uploads/automobiles/PassatCC/vanjska2.jpg" },
                    { 56, 20, "/uploads/automobiles/Peugeot407/unutrasnja1.jpg" },
                    { 57, 20, "/uploads/automobiles/Peugeot407/vanjska1.jpg" },
                    { 58, 20, "/uploads/automobiles/Peugeot407/vanjska2.jpg" },
                    { 59, 21, "/uploads/automobiles/Polo2006/unutrasnja1.jpg" },
                    { 60, 21, "/uploads/automobiles/Polo2006/vanjska1.jpg" },
                    { 61, 21, "/uploads/automobiles/Polo2006/vanjska2.jpg" },
                    { 62, 22, "/uploads/automobiles/Quad/vanjska1.jpg" },
                    { 63, 22, "/uploads/automobiles/Quad/vanjska2.jpg" },
                    { 64, 23, "/uploads/automobiles/RenaultMegan/unutrasnja1.jpg" },
                    { 65, 23, "/uploads/automobiles/RenaultMegan/unutrasnja2.jpg" },
                    { 66, 23, "/uploads/automobiles/RenaultMegan/vanjska1.jpg" },
                    { 67, 24, "/uploads/automobiles/RenaultScenic/unutrasnja1.jpg" },
                    { 68, 24, "/uploads/automobiles/RenaultScenic/vanjska1.jpg" },
                    { 69, 24, "/uploads/automobiles/RenaultScenic/vanjska2.jpg" },
                    { 70, 25, "/uploads/automobiles/SkodafabiaHTP/vanjska1.jpg" },
                    { 71, 25, "/uploads/automobiles/SkodafabiaHTP/vanjska2.jpg" },
                    { 72, 26, "/uploads/automobiles/Skodaoctavia/unutrasnja1.jpg" },
                    { 73, 26, "/uploads/automobiles/Skodaoctavia/vanjska1.jpg" },
                    { 74, 26, "/uploads/automobiles/Skodaoctavia/vanjska2.jpg" },
                    { 75, 27, "/uploads/automobiles/WVBora/unutrasnja1.jpg" },
                    { 76, 27, "/uploads/automobiles/WVBora/vanjska1.jpg" },
                    { 77, 27, "/uploads/automobiles/WVBora/vanjska2.jpg" },
                    { 78, 28, "/uploads/automobiles/WVTiguan/unutrasnja1.jpg" },
                    { 79, 28, "/uploads/automobiles/WVTiguan/vanjska1.jpg" },
                    { 80, 28, "/uploads/automobiles/WVTiguan/vanjska2.jpg" },
                    { 81, 29, "/uploads/automobiles/WVTiguan/vanjska2.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "AutomobileAdId", "Content", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 1, 1, "Izgleda odlično! Ima li servisnu knjižicu?", new DateTime(2025, 2, 7, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(760), null, 2 },
                    { 2, 1, "Može li zamjena za Passat?", new DateTime(2025, 2, 7, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(770), null, 3 },
                    { 3, 2, "Predivan auto! Kakvo je stanje felgi?", new DateTime(2025, 2, 7, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(770), null, 1 },
                    { 4, 2, "Da li je moguće probna vožnja?", new DateTime(2025, 2, 7, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(770), null, 4 },
                    { 5, 3, "Super ponuda! Kada je zadnji put zamijenjen ulje i filteri?", new DateTime(2025, 2, 7, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(770), null, 5 },
                    { 6, 3, "Je li kilometraža tačna?", new DateTime(2025, 2, 7, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(770), null, 6 },
                    { 7, 4, "Fantastičan auto! Kakvo je stanje enterijera?", new DateTime(2025, 2, 7, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(770), null, 3 },
                    { 8, 4, "Mogu li dobiti više slika unutrašnjosti?", new DateTime(2025, 2, 7, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(780), null, 7 },
                    { 9, 5, "Top model! Da li je registrovan?", new DateTime(2025, 2, 7, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(780), null, 8 },
                    { 10, 5, "Koliko je star akumulator?", new DateTime(2025, 2, 7, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(780), null, 9 },
                    { 11, 6, "Odličan BMW! Koliko troši goriva u prosjeku?", new DateTime(2025, 2, 7, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(780), null, 10 },
                    { 12, 6, "Ima li problema sa motorom?", new DateTime(2025, 2, 7, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(780), null, 1 },
                    { 13, 7, "Citroen izgleda moćno! Kakvo je stanje guma?", new DateTime(2025, 2, 7, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(780), null, 2 },
                    { 14, 7, "Je li prva boja na vozilu?", new DateTime(2025, 2, 7, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(780), null, 3 },
                    { 15, 8, "Punto je odlično gradsko auto! Ima li servisna evidencija?", new DateTime(2025, 2, 7, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(790), null, 4 },
                    { 16, 8, "Koliko je prešao od zadnje izmjene ulja?", new DateTime(2025, 2, 7, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(790), null, 5 },
                    { 17, 9, "Ovaj Golf izgleda kao da je očuvan! Kakvo je stanje limarije?", new DateTime(2025, 2, 7, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(790), null, 6 },
                    { 18, 9, "Ima li klima?", new DateTime(2025, 2, 7, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(790), null, 7 },
                    { 19, 10, "Perfektan auto! Ima li mogućnost kupovine na rate?", new DateTime(2025, 2, 7, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(790), null, 8 },
                    { 20, 10, "Koliko je star akumulator?", new DateTime(2025, 2, 7, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(800), null, 9 },
                    { 21, 11, "Odličan Golf! Da li je uvoz ili kupljen kod nas?", new DateTime(2025, 2, 7, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(800), null, 10 },
                    { 22, 11, "Jesi li radio veliki servis?", new DateTime(2025, 2, 7, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(800), null, 1 },
                    { 23, 21, "Odlična cijena za Polo! Kakvo je stanje sjedala?", new DateTime(2025, 2, 7, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(800), null, 2 },
                    { 24, 21, "Ima li hrđe na rubovima?", new DateTime(2025, 2, 7, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(800), null, 3 },
                    { 25, 28, "Tiguan izgleda odlično! Je li redovno održavan?", new DateTime(2025, 2, 7, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(800), null, 4 },
                    { 26, 28, "Koliko troši na otvorenoj cesti?", new DateTime(2025, 2, 7, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(800), null, 5 },
                    { 27, 24, "Scenic je idealan za porodicu! Kakvo je stanje zadnjih sjedišta?", new DateTime(2025, 2, 7, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(800), null, 6 },
                    { 28, 24, "Koliko traje registracija?", new DateTime(2025, 2, 7, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(810), null, 7 },
                    { 29, 26, "Odlična Skoda! Može li se pogledati u Sarajevu?", new DateTime(2025, 2, 7, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(810), null, 8 },
                    { 30, 26, "Koliko su stare gume?", new DateTime(2025, 2, 7, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(810), null, 9 },
                    { 31, 27, "Koliko su stare gume?", new DateTime(2025, 2, 7, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(810), null, 1 },
                    { 33, 28, "Koliko su stare gume, jel ima i zimske?", new DateTime(2025, 2, 7, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(810), null, 2 }
                });

            migrationBuilder.InsertData(
                table: "Favorites",
                columns: new[] { "Id", "AutomobileAdId", "UserId" },
                values: new object[,]
                {
                    { 1, 2, 1 },
                    { 2, 3, 1 },
                    { 3, 4, 1 },
                    { 4, 5, 1 },
                    { 5, 1, 2 },
                    { 6, 3, 2 },
                    { 7, 4, 2 },
                    { 8, 1, 3 },
                    { 9, 4, 3 },
                    { 10, 5, 3 },
                    { 11, 13, 3 },
                    { 12, 1, 4 },
                    { 13, 13, 4 },
                    { 14, 13, 4 },
                    { 15, 21, 5 },
                    { 16, 22, 5 },
                    { 17, 23, 5 },
                    { 18, 24, 6 },
                    { 19, 25, 6 },
                    { 20, 26, 7 },
                    { 21, 27, 7 },
                    { 22, 1, 7 },
                    { 23, 28, 8 },
                    { 24, 16, 8 },
                    { 25, 20, 8 },
                    { 26, 1, 9 },
                    { 27, 2, 9 },
                    { 28, 3, 9 },
                    { 29, 2, 10 },
                    { 30, 23, 10 },
                    { 31, 24, 10 }
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "AutomobileAdId", "ReservationDate", "Status", "UserId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved", 1 },
                    { 2, 1, new DateTime(2025, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved", 2 },
                    { 3, 1, new DateTime(2025, 2, 10, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(870), "Pending", 3 },
                    { 4, 1, new DateTime(2025, 2, 12, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(870), "Pending", 4 },
                    { 5, 1, new DateTime(2025, 2, 14, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(870), "Pending", 5 },
                    { 6, 2, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved", 6 },
                    { 7, 2, new DateTime(2025, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved", 7 },
                    { 8, 2, new DateTime(2025, 2, 10, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(880), "Pending", 8 },
                    { 9, 2, new DateTime(2025, 2, 12, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(880), "Pending", 9 },
                    { 10, 2, new DateTime(2025, 2, 14, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(880), "Pending", 10 },
                    { 11, 3, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved", 1 },
                    { 12, 3, new DateTime(2025, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved", 2 },
                    { 13, 3, new DateTime(2025, 2, 10, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(890), "Pending", 3 },
                    { 14, 3, new DateTime(2025, 2, 12, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(890), "Pending", 4 },
                    { 15, 3, new DateTime(2025, 2, 14, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(890), "Pending", 5 },
                    { 16, 4, new DateTime(2025, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved", 6 },
                    { 17, 4, new DateTime(2025, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved", 7 },
                    { 18, 4, new DateTime(2025, 2, 10, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(900), "Pending", 8 },
                    { 19, 4, new DateTime(2025, 2, 12, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(910), "Pending", 9 },
                    { 20, 4, new DateTime(2025, 2, 14, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(910), "Pending", 10 },
                    { 21, 5, new DateTime(2025, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved", 1 },
                    { 22, 5, new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved", 2 },
                    { 23, 5, new DateTime(2025, 2, 10, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(910), "Pending", 3 },
                    { 24, 5, new DateTime(2025, 2, 12, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(910), "Pending", 4 },
                    { 25, 5, new DateTime(2025, 2, 14, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(920), "Pending", 5 },
                    { 26, 6, new DateTime(2025, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved", 6 },
                    { 27, 6, new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved", 7 },
                    { 28, 6, new DateTime(2025, 2, 10, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(920), "Pending", 8 },
                    { 29, 6, new DateTime(2025, 2, 12, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(920), "Pending", 9 },
                    { 30, 6, new DateTime(2025, 2, 14, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(920), "Pending", 10 },
                    { 31, 7, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved", 1 },
                    { 32, 7, new DateTime(2025, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved", 2 },
                    { 33, 7, new DateTime(2025, 2, 10, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(930), "Pending", 3 },
                    { 34, 7, new DateTime(2025, 2, 12, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(930), "Pending", 4 },
                    { 35, 7, new DateTime(2025, 2, 14, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(930), "Pending", 5 },
                    { 36, 8, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved", 6 },
                    { 37, 8, new DateTime(2025, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved", 7 },
                    { 38, 8, new DateTime(2025, 2, 10, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(940), "Pending", 8 },
                    { 39, 8, new DateTime(2025, 2, 12, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(940), "Pending", 9 },
                    { 40, 8, new DateTime(2025, 2, 14, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(940), "Pending", 10 },
                    { 41, 9, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved", 1 },
                    { 42, 9, new DateTime(2025, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved", 2 },
                    { 43, 9, new DateTime(2025, 2, 10, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(950), "Pending", 3 },
                    { 44, 9, new DateTime(2025, 2, 12, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(950), "Pending", 4 },
                    { 45, 9, new DateTime(2025, 2, 14, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(950), "Pending", 5 },
                    { 46, 10, new DateTime(2025, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved", 6 },
                    { 47, 10, new DateTime(2025, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved", 7 },
                    { 48, 10, new DateTime(2025, 2, 10, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(950), "Pending", 8 },
                    { 49, 10, new DateTime(2025, 2, 12, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(960), "Pending", 9 },
                    { 50, 10, new DateTime(2025, 2, 14, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(960), "Pending", 10 },
                    { 51, 11, new DateTime(2025, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved", 1 },
                    { 52, 11, new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved", 2 },
                    { 53, 11, new DateTime(2025, 2, 10, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(970), "Pending", 3 },
                    { 54, 11, new DateTime(2025, 2, 12, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(970), "Pending", 4 },
                    { 55, 11, new DateTime(2025, 2, 14, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(970), "Pending", 5 },
                    { 56, 12, new DateTime(2025, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved", 6 },
                    { 57, 12, new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved", 7 },
                    { 58, 12, new DateTime(2025, 2, 10, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(980), "Pending", 8 },
                    { 59, 12, new DateTime(2025, 2, 12, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(980), "Pending", 9 },
                    { 60, 12, new DateTime(2025, 2, 14, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(980), "Pending", 10 },
                    { 61, 13, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved", 1 },
                    { 62, 13, new DateTime(2025, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved", 2 },
                    { 63, 13, new DateTime(2025, 2, 10, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(990), "Pending", 3 },
                    { 64, 13, new DateTime(2025, 2, 12, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(990), "Pending", 4 },
                    { 65, 13, new DateTime(2025, 2, 14, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(990), "Pending", 5 },
                    { 66, 14, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved", 6 },
                    { 67, 14, new DateTime(2025, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved", 7 },
                    { 68, 14, new DateTime(2025, 2, 10, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(1010), "Pending", 8 },
                    { 69, 14, new DateTime(2025, 2, 12, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(1010), "Pending", 9 },
                    { 70, 14, new DateTime(2025, 2, 14, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(1010), "Pending", 10 },
                    { 71, 15, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved", 1 },
                    { 72, 15, new DateTime(2025, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved", 2 },
                    { 73, 15, new DateTime(2025, 2, 10, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(1020), "Pending", 3 },
                    { 74, 15, new DateTime(2025, 2, 12, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(1020), "Pending", 4 },
                    { 75, 15, new DateTime(2025, 2, 14, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(1020), "Pending", 5 },
                    { 76, 16, new DateTime(2025, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved", 6 },
                    { 77, 16, new DateTime(2025, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved", 7 },
                    { 78, 16, new DateTime(2025, 2, 10, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(1020), "Pending", 8 },
                    { 79, 16, new DateTime(2025, 2, 12, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(1030), "Pending", 9 },
                    { 80, 16, new DateTime(2025, 2, 14, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(1030), "Pending", 10 },
                    { 81, 17, new DateTime(2025, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved", 1 },
                    { 82, 17, new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved", 2 },
                    { 83, 17, new DateTime(2025, 2, 10, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(1030), "Pending", 3 },
                    { 84, 17, new DateTime(2025, 2, 12, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(1030), "Pending", 4 },
                    { 85, 17, new DateTime(2025, 2, 14, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(1040), "Pending", 5 },
                    { 86, 18, new DateTime(2025, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved", 6 },
                    { 87, 18, new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved", 7 },
                    { 88, 18, new DateTime(2025, 2, 10, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(1040), "Pending", 8 },
                    { 89, 18, new DateTime(2025, 2, 12, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(1040), "Pending", 9 },
                    { 90, 18, new DateTime(2025, 2, 14, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(1050), "Pending", 10 },
                    { 91, 19, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved", 1 },
                    { 92, 19, new DateTime(2025, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved", 2 },
                    { 93, 19, new DateTime(2025, 2, 10, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(1050), "Pending", 3 },
                    { 94, 19, new DateTime(2025, 2, 12, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(1060), "Pending", 4 },
                    { 95, 19, new DateTime(2025, 2, 14, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(1060), "Pending", 5 },
                    { 96, 20, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved", 6 },
                    { 97, 20, new DateTime(2025, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved", 7 },
                    { 98, 20, new DateTime(2025, 2, 10, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(1060), "Pending", 8 },
                    { 99, 20, new DateTime(2025, 2, 12, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(1060), "Pending", 9 },
                    { 100, 20, new DateTime(2025, 2, 14, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(1070), "Pending", 10 },
                    { 101, 21, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved", 1 },
                    { 102, 21, new DateTime(2025, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved", 2 },
                    { 103, 21, new DateTime(2025, 2, 10, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(1070), "Pending", 3 },
                    { 104, 21, new DateTime(2025, 2, 12, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(1070), "Pending", 4 },
                    { 105, 21, new DateTime(2025, 2, 14, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(1070), "Pending", 5 },
                    { 106, 22, new DateTime(2025, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved", 6 },
                    { 107, 22, new DateTime(2025, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved", 7 },
                    { 108, 22, new DateTime(2025, 2, 10, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(1080), "Pending", 8 },
                    { 109, 22, new DateTime(2025, 2, 12, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(1080), "Pending", 9 },
                    { 110, 22, new DateTime(2025, 2, 14, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(1080), "Pending", 10 },
                    { 111, 23, new DateTime(2025, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved", 1 },
                    { 112, 23, new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved", 2 },
                    { 113, 23, new DateTime(2025, 2, 10, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(1090), "Pending", 3 },
                    { 114, 23, new DateTime(2025, 2, 12, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(1090), "Pending", 4 },
                    { 115, 23, new DateTime(2025, 2, 14, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(1090), "Pending", 5 },
                    { 116, 24, new DateTime(2025, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved", 6 },
                    { 117, 24, new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved", 7 },
                    { 118, 24, new DateTime(2025, 2, 10, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(1100), "Pending", 8 },
                    { 119, 24, new DateTime(2025, 2, 12, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(1100), "Pending", 9 },
                    { 120, 24, new DateTime(2025, 2, 14, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(1100), "Pending", 10 },
                    { 121, 25, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved", 1 },
                    { 122, 25, new DateTime(2025, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved", 2 },
                    { 123, 25, new DateTime(2025, 2, 10, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(1110), "Pending", 3 },
                    { 124, 25, new DateTime(2025, 2, 12, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(1110), "Pending", 4 },
                    { 125, 25, new DateTime(2025, 2, 14, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(1110), "Pending", 5 },
                    { 126, 26, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved", 6 },
                    { 127, 26, new DateTime(2025, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved", 7 },
                    { 128, 26, new DateTime(2025, 2, 10, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(1120), "Pending", 8 },
                    { 129, 26, new DateTime(2025, 2, 12, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(1120), "Pending", 9 },
                    { 130, 26, new DateTime(2025, 2, 14, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(1120), "Pending", 10 },
                    { 131, 27, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved", 1 },
                    { 132, 27, new DateTime(2025, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved", 2 },
                    { 133, 27, new DateTime(2025, 2, 10, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(1130), "Pending", 3 },
                    { 134, 27, new DateTime(2025, 2, 12, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(1130), "Pending", 4 },
                    { 135, 27, new DateTime(2025, 2, 14, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(1130), "Pending", 5 },
                    { 136, 28, new DateTime(2025, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved", 6 },
                    { 137, 28, new DateTime(2025, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved", 7 },
                    { 138, 28, new DateTime(2025, 2, 10, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(1130), "Pending", 8 },
                    { 139, 28, new DateTime(2025, 2, 12, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(1140), "Pending", 9 },
                    { 140, 28, new DateTime(2025, 2, 14, 15, 3, 56, 637, DateTimeKind.Utc).AddTicks(1140), "Pending", 10 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_AutomobileAds_CarBrands_CarBrandId",
                table: "AutomobileAds",
                column: "CarBrandId",
                principalTable: "CarBrands",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AutomobileAds_CarCategories_CarCategoryId",
                table: "AutomobileAds",
                column: "CarCategoryId",
                principalTable: "CarCategories",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AutomobileAds_CarModels_CarModelId",
                table: "AutomobileAds",
                column: "CarModelId",
                principalTable: "CarModels",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AutomobileAds_FuelTypes_FuelTypeId",
                table: "AutomobileAds",
                column: "FuelTypeId",
                principalTable: "FuelTypes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AutomobileAds_VehicleConditions_VehicleConditionId",
                table: "AutomobileAds",
                column: "VehicleConditionId",
                principalTable: "VehicleConditions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AutomobileAds_transmissionTypes_TransmissionTypeId",
                table: "AutomobileAds",
                column: "TransmissionTypeId",
                principalTable: "transmissionTypes",
                principalColumn: "Id");
        }
    }
}
