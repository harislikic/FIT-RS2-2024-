﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoTrade.Migrations
{
    /// <inheritdoc />
    public partial class removeadditional : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AutomobileAdAdditionalEquipments");

            migrationBuilder.DropTable(
                name: "AdditionalEquipments");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
