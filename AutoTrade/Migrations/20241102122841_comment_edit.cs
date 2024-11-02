using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoTrade.Migrations
{
    /// <inheritdoc />
    public partial class commentedit : Migration
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

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Comments",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FuelTypeId",
                table: "AutomobileAds",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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

            migrationBuilder.CreateTable(
                name: "CarBrand",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarBrand", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_AutomobileAds_CarBrand_CarBrandId",
                table: "AutomobileAds",
                column: "CarBrandId",
                principalTable: "CarBrand",
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AutomobileAds_CarBrand_CarBrandId",
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

            migrationBuilder.DropTable(
                name: "CarBrand");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Comments");

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
        }
    }
}
