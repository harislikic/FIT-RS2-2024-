using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoTrade.Migrations
{
    /// <inheritdoc />
    public partial class tabels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AdditionalEquipments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdditionalEquipments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CarBrands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarBrands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CarCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CarModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarModels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FuelTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FuelTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "transmissionTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_transmissionTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VehicleConditions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleConditions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AutomobileAds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    DateOFadd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ViewsCount = table.Column<int>(type: "int", nullable: false),
                    YearOfManufacture = table.Column<int>(type: "int", nullable: false),
                    Registered = table.Column<bool>(type: "bit", nullable: false),
                    RegistrationExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FeaturedExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastSmallService = table.Column<DateTime>(name: "Last_Small_Service", type: "datetime2", nullable: true),
                    LastBigService = table.Column<DateTime>(name: "Last_Big_Service", type: "datetime2", nullable: true),
                    Milage = table.Column<double>(type: "float", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    AdditionalEquipmentId = table.Column<int>(type: "int", nullable: true),
                    CarBrandId = table.Column<int>(type: "int", nullable: true),
                    CarCategoryId = table.Column<int>(type: "int", nullable: false),
                    CarModelId = table.Column<int>(type: "int", nullable: false),
                    FuelTypeId = table.Column<int>(type: "int", nullable: false),
                    TransmissionTypeId = table.Column<int>(type: "int", nullable: true),
                    VehicleConditionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutomobileAds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AutomobileAds_AdditionalEquipments_AdditionalEquipmentId",
                        column: x => x.AdditionalEquipmentId,
                        principalTable: "AdditionalEquipments",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AutomobileAds_CarBrands_CarBrandId",
                        column: x => x.CarBrandId,
                        principalTable: "CarBrands",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AutomobileAds_CarCategories_CarCategoryId",
                        column: x => x.CarCategoryId,
                        principalTable: "CarCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AutomobileAds_CarModels_CarModelId",
                        column: x => x.CarModelId,
                        principalTable: "CarModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AutomobileAds_FuelTypes_FuelTypeId",
                        column: x => x.FuelTypeId,
                        principalTable: "FuelTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AutomobileAds_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AutomobileAds_VehicleConditions_VehicleConditionId",
                        column: x => x.VehicleConditionId,
                        principalTable: "VehicleConditions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AutomobileAds_transmissionTypes_TransmissionTypeId",
                        column: x => x.TransmissionTypeId,
                        principalTable: "transmissionTypes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    AutomobileAdId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_AutomobileAds_AutomobileAdId",
                        column: x => x.AutomobileAdId,
                        principalTable: "AutomobileAds",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Comments_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReservationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    AutomobileAdId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservations_AutomobileAds_AutomobileAdId",
                        column: x => x.AutomobileAdId,
                        principalTable: "AutomobileAds",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Reservations_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AutomobileAds_AdditionalEquipmentId",
                table: "AutomobileAds",
                column: "AdditionalEquipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_AutomobileAds_CarBrandId",
                table: "AutomobileAds",
                column: "CarBrandId");

            migrationBuilder.CreateIndex(
                name: "IX_AutomobileAds_CarCategoryId",
                table: "AutomobileAds",
                column: "CarCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_AutomobileAds_CarModelId",
                table: "AutomobileAds",
                column: "CarModelId");

            migrationBuilder.CreateIndex(
                name: "IX_AutomobileAds_FuelTypeId",
                table: "AutomobileAds",
                column: "FuelTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_AutomobileAds_TransmissionTypeId",
                table: "AutomobileAds",
                column: "TransmissionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_AutomobileAds_UserId",
                table: "AutomobileAds",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AutomobileAds_VehicleConditionId",
                table: "AutomobileAds",
                column: "VehicleConditionId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_AutomobileAdId",
                table: "Comments",
                column: "AutomobileAdId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserId",
                table: "Comments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_AutomobileAdId",
                table: "Reservations",
                column: "AutomobileAdId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_UserId",
                table: "Reservations",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "AutomobileAds");

            migrationBuilder.DropTable(
                name: "AdditionalEquipments");

            migrationBuilder.DropTable(
                name: "CarBrands");

            migrationBuilder.DropTable(
                name: "CarCategories");

            migrationBuilder.DropTable(
                name: "CarModels");

            migrationBuilder.DropTable(
                name: "FuelTypes");

            migrationBuilder.DropTable(
                name: "VehicleConditions");

            migrationBuilder.DropTable(
                name: "transmissionTypes");
        }
    }
}
