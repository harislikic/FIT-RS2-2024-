using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoTrade.Migrations
{
    /// <inheritdoc />
    public partial class RemoveAutomobileAdAdditionalEquipmentsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AutomobileAdAdditionalEquipments_AdditionalEquipments_AdditionalEquipmentId",
                table: "AutomobileAdAdditionalEquipments");

            migrationBuilder.DropForeignKey(
                name: "FK_AutomobileAdAdditionalEquipments_AdditionalEquipments_AdditionalEquipmentId1",
                table: "AutomobileAdAdditionalEquipments");

            migrationBuilder.DropForeignKey(
                name: "FK_AutomobileAdAdditionalEquipments_AutomobileAds_AutomobileAdId",
                table: "AutomobileAdAdditionalEquipments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AutomobileAdAdditionalEquipments",
                table: "AutomobileAdAdditionalEquipments");

            migrationBuilder.RenameTable(
                name: "AutomobileAdAdditionalEquipments",
                newName: "AutomobileAdAdditionalEquipment");

            migrationBuilder.RenameIndex(
                name: "IX_AutomobileAdAdditionalEquipments_AdditionalEquipmentId1",
                table: "AutomobileAdAdditionalEquipment",
                newName: "IX_AutomobileAdAdditionalEquipment_AdditionalEquipmentId1");

            migrationBuilder.RenameIndex(
                name: "IX_AutomobileAdAdditionalEquipments_AdditionalEquipmentId",
                table: "AutomobileAdAdditionalEquipment",
                newName: "IX_AutomobileAdAdditionalEquipment_AdditionalEquipmentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AutomobileAdAdditionalEquipment",
                table: "AutomobileAdAdditionalEquipment",
                columns: new[] { "AutomobileAdId", "AdditionalEquipmentId" });

            migrationBuilder.AddForeignKey(
                name: "FK_AutomobileAdAdditionalEquipment_AdditionalEquipments_AdditionalEquipmentId",
                table: "AutomobileAdAdditionalEquipment",
                column: "AdditionalEquipmentId",
                principalTable: "AdditionalEquipments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AutomobileAdAdditionalEquipment_AdditionalEquipments_AdditionalEquipmentId1",
                table: "AutomobileAdAdditionalEquipment",
                column: "AdditionalEquipmentId1",
                principalTable: "AdditionalEquipments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AutomobileAdAdditionalEquipment_AutomobileAds_AutomobileAdId",
                table: "AutomobileAdAdditionalEquipment",
                column: "AutomobileAdId",
                principalTable: "AutomobileAds",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AutomobileAdAdditionalEquipment_AdditionalEquipments_AdditionalEquipmentId",
                table: "AutomobileAdAdditionalEquipment");

            migrationBuilder.DropForeignKey(
                name: "FK_AutomobileAdAdditionalEquipment_AdditionalEquipments_AdditionalEquipmentId1",
                table: "AutomobileAdAdditionalEquipment");

            migrationBuilder.DropForeignKey(
                name: "FK_AutomobileAdAdditionalEquipment_AutomobileAds_AutomobileAdId",
                table: "AutomobileAdAdditionalEquipment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AutomobileAdAdditionalEquipment",
                table: "AutomobileAdAdditionalEquipment");

            migrationBuilder.RenameTable(
                name: "AutomobileAdAdditionalEquipment",
                newName: "AutomobileAdAdditionalEquipments");

            migrationBuilder.RenameIndex(
                name: "IX_AutomobileAdAdditionalEquipment_AdditionalEquipmentId1",
                table: "AutomobileAdAdditionalEquipments",
                newName: "IX_AutomobileAdAdditionalEquipments_AdditionalEquipmentId1");

            migrationBuilder.RenameIndex(
                name: "IX_AutomobileAdAdditionalEquipment_AdditionalEquipmentId",
                table: "AutomobileAdAdditionalEquipments",
                newName: "IX_AutomobileAdAdditionalEquipments_AdditionalEquipmentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AutomobileAdAdditionalEquipments",
                table: "AutomobileAdAdditionalEquipments",
                columns: new[] { "AutomobileAdId", "AdditionalEquipmentId" });

            migrationBuilder.AddForeignKey(
                name: "FK_AutomobileAdAdditionalEquipments_AdditionalEquipments_AdditionalEquipmentId",
                table: "AutomobileAdAdditionalEquipments",
                column: "AdditionalEquipmentId",
                principalTable: "AdditionalEquipments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AutomobileAdAdditionalEquipments_AdditionalEquipments_AdditionalEquipmentId1",
                table: "AutomobileAdAdditionalEquipments",
                column: "AdditionalEquipmentId1",
                principalTable: "AdditionalEquipments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AutomobileAdAdditionalEquipments_AutomobileAds_AutomobileAdId",
                table: "AutomobileAdAdditionalEquipments",
                column: "AutomobileAdId",
                principalTable: "AutomobileAds",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
