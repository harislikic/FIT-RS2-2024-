using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoTrade.Migrations
{
    /// <inheritdoc />
    public partial class vehiclecondition : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AutomobileAdEquipments_AutomobileAds_AutomobileAdId",
                table: "AutomobileAdEquipments");

            migrationBuilder.AddForeignKey(
                name: "FK_AutomobileAdEquipments_AutomobileAds_AutomobileAdId",
                table: "AutomobileAdEquipments",
                column: "AutomobileAdId",
                principalTable: "AutomobileAds",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AutomobileAdEquipments_AutomobileAds_AutomobileAdId",
                table: "AutomobileAdEquipments");

            migrationBuilder.AddForeignKey(
                name: "FK_AutomobileAdEquipments_AutomobileAds_AutomobileAdId",
                table: "AutomobileAdEquipments",
                column: "AutomobileAdId",
                principalTable: "AutomobileAds",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
