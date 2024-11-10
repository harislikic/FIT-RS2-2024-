using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoTrade.Migrations
{
    /// <inheritdoc />
    public partial class oprema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "AutomobileAds",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CubicCapacity",
                table: "AutomobileAds",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EnginePower",
                table: "AutomobileAds",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HorsePower",
                table: "AutomobileAds",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfDoors",
                table: "AutomobileAds",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Equipments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AutomobileAdEquipments",
                columns: table => new
                {
                    AutomobileAdId = table.Column<int>(type: "int", nullable: false),
                    EquipmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutomobileAdEquipments", x => new { x.AutomobileAdId, x.EquipmentId });
                    table.ForeignKey(
                        name: "FK_AutomobileAdEquipments_AutomobileAds_AutomobileAdId",
                        column: x => x.AutomobileAdId,
                        principalTable: "AutomobileAds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AutomobileAdEquipments_Equipments_EquipmentId",
                        column: x => x.EquipmentId,
                        principalTable: "Equipments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AutomobileAdEquipments_EquipmentId",
                table: "AutomobileAdEquipments",
                column: "EquipmentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AutomobileAdEquipments");

            migrationBuilder.DropTable(
                name: "Equipments");

            migrationBuilder.DropColumn(
                name: "Color",
                table: "AutomobileAds");

            migrationBuilder.DropColumn(
                name: "CubicCapacity",
                table: "AutomobileAds");

            migrationBuilder.DropColumn(
                name: "EnginePower",
                table: "AutomobileAds");

            migrationBuilder.DropColumn(
                name: "HorsePower",
                table: "AutomobileAds");

            migrationBuilder.DropColumn(
                name: "NumberOfDoors",
                table: "AutomobileAds");
        }
    }
}
