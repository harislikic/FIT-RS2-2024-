using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoTrade.Migrations
{
    /// <inheritdoc />
    public partial class addqeupiment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AutomobileAds_AdditionalEquipments_AdditionalEquipmentId",
                table: "AutomobileAds");

            migrationBuilder.DropForeignKey(
                name: "FK_AutomobileAds_CarBrand_CarBrandId",
                table: "AutomobileAds");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_AutomobileAds_AutomobileAdId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_AutomobileAds_AutomobileAdId",
                table: "Reservations");

            migrationBuilder.DropTable(
                name: "CarBrand");

            migrationBuilder.DropIndex(
                name: "IX_AutomobileAds_AdditionalEquipmentId",
                table: "AutomobileAds");

            migrationBuilder.DropColumn(
                name: "AdditionalEquipmentId",
                table: "AutomobileAds");

            migrationBuilder.AlterColumn<int>(
                name: "AutomobileAdId",
                table: "Reservations",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AutomobileAdId",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "AutomobileAdAdditionalEquipments",
                columns: table => new
                {
                    AutomobileAdId = table.Column<int>(type: "int", nullable: false),
                    AdditionalEquipmentId = table.Column<int>(type: "int", nullable: false),
                    AdditionalEquipmentId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutomobileAdAdditionalEquipments", x => new { x.AutomobileAdId, x.AdditionalEquipmentId });
                    table.ForeignKey(
                        name: "FK_AutomobileAdAdditionalEquipments_AdditionalEquipments_AdditionalEquipmentId",
                        column: x => x.AdditionalEquipmentId,
                        principalTable: "AdditionalEquipments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AutomobileAdAdditionalEquipments_AdditionalEquipments_AdditionalEquipmentId1",
                        column: x => x.AdditionalEquipmentId1,
                        principalTable: "AdditionalEquipments",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AutomobileAdAdditionalEquipments_AutomobileAds_AutomobileAdId",
                        column: x => x.AutomobileAdId,
                        principalTable: "AutomobileAds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AutomobileAdAdditionalEquipments_AdditionalEquipmentId",
                table: "AutomobileAdAdditionalEquipments",
                column: "AdditionalEquipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_AutomobileAdAdditionalEquipments_AdditionalEquipmentId1",
                table: "AutomobileAdAdditionalEquipments",
                column: "AdditionalEquipmentId1");

            migrationBuilder.AddForeignKey(
                name: "FK_AutomobileAds_CarBrands_CarBrandId",
                table: "AutomobileAds",
                column: "CarBrandId",
                principalTable: "CarBrands",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_AutomobileAds_AutomobileAdId",
                table: "Comments",
                column: "AutomobileAdId",
                principalTable: "AutomobileAds",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_AutomobileAds_AutomobileAdId",
                table: "Reservations",
                column: "AutomobileAdId",
                principalTable: "AutomobileAds",
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
                name: "FK_Comments_AutomobileAds_AutomobileAdId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_AutomobileAds_AutomobileAdId",
                table: "Reservations");

            migrationBuilder.DropTable(
                name: "AutomobileAdAdditionalEquipments");

            migrationBuilder.AlterColumn<int>(
                name: "AutomobileAdId",
                table: "Reservations",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "AutomobileAdId",
                table: "Comments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "AdditionalEquipmentId",
                table: "AutomobileAds",
                type: "int",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_AutomobileAds_AdditionalEquipmentId",
                table: "AutomobileAds",
                column: "AdditionalEquipmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_AutomobileAds_AdditionalEquipments_AdditionalEquipmentId",
                table: "AutomobileAds",
                column: "AdditionalEquipmentId",
                principalTable: "AdditionalEquipments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AutomobileAds_CarBrand_CarBrandId",
                table: "AutomobileAds",
                column: "CarBrandId",
                principalTable: "CarBrand",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_AutomobileAds_AutomobileAdId",
                table: "Comments",
                column: "AutomobileAdId",
                principalTable: "AutomobileAds",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_AutomobileAds_AutomobileAdId",
                table: "Reservations",
                column: "AutomobileAdId",
                principalTable: "AutomobileAds",
                principalColumn: "Id");
        }
    }
}
