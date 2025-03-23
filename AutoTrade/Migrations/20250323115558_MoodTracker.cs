using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoTrade.Migrations
{
    /// <inheritdoc />
    public partial class MoodTracker : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MoodTrackers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Mood = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MoodDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoodTrackers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MoodTrackers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateOFadd", "HighlightExpiryDate" },
                values: new object[] { new DateTime(2025, 3, 23, 12, 55, 57, 796, DateTimeKind.Local).AddTicks(5110), new DateTime(2025, 3, 25, 12, 55, 57, 796, DateTimeKind.Local).AddTicks(5160) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 3, 23, 12, 55, 57, 796, DateTimeKind.Local).AddTicks(5170), new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 3, 23, 12, 55, 57, 796, DateTimeKind.Local).AddTicks(5180), new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 3, 23, 12, 55, 57, 796, DateTimeKind.Local).AddTicks(5180), new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateOFadd", "HighlightExpiryDate", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 3, 23, 12, 55, 57, 796, DateTimeKind.Local).AddTicks(5190), new DateTime(2025, 4, 12, 12, 55, 57, 796, DateTimeKind.Local).AddTicks(5190), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateOFadd", "HighlightExpiryDate", "IsHighlighted", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 3, 23, 12, 55, 57, 796, DateTimeKind.Local).AddTicks(5190), new DateTime(2025, 4, 2, 12, 55, 57, 796, DateTimeKind.Local).AddTicks(5210), true, new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 3, 23, 12, 55, 57, 796, DateTimeKind.Local).AddTicks(5210), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 3, 23, 12, 55, 57, 796, DateTimeKind.Local).AddTicks(5210), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 3, 23, 12, 55, 57, 796, DateTimeKind.Local).AddTicks(5220), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 3, 23, 12, 55, 57, 796, DateTimeKind.Local).AddTicks(5230), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateOFadd", "HighlightExpiryDate", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 3, 23, 12, 55, 57, 796, DateTimeKind.Local).AddTicks(5240), new DateTime(2025, 4, 12, 12, 55, 57, 796, DateTimeKind.Local).AddTicks(5250), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 3, 23, 12, 55, 57, 796, DateTimeKind.Local).AddTicks(5250), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateOFadd", "HighlightExpiryDate", "IsHighlighted", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 3, 23, 12, 55, 57, 796, DateTimeKind.Local).AddTicks(5250), new DateTime(2025, 4, 2, 12, 55, 57, 796, DateTimeKind.Local).AddTicks(5260), true, new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 3, 23, 12, 55, 57, 796, DateTimeKind.Local).AddTicks(5260), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 3, 23, 12, 55, 57, 796, DateTimeKind.Local).AddTicks(5270), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 3, 23, 12, 55, 57, 796, DateTimeKind.Local).AddTicks(5270), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateOFadd", "HighlightExpiryDate", "IsHighlighted", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 3, 23, 12, 55, 57, 796, DateTimeKind.Local).AddTicks(5280), new DateTime(2025, 4, 2, 12, 55, 57, 796, DateTimeKind.Local).AddTicks(5290), true, new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 3, 23, 12, 55, 57, 796, DateTimeKind.Local).AddTicks(5290), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 3, 23, 12, 55, 57, 796, DateTimeKind.Local).AddTicks(5300), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 3, 23, 12, 55, 57, 796, DateTimeKind.Local).AddTicks(5300), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 3, 23, 12, 55, 57, 796, DateTimeKind.Local).AddTicks(5310), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 3, 23, 12, 55, 57, 796, DateTimeKind.Local).AddTicks(5310), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 3, 23, 12, 55, 57, 796, DateTimeKind.Local).AddTicks(5320), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 3, 23, 12, 55, 57, 796, DateTimeKind.Local).AddTicks(5330), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 3, 23, 12, 55, 57, 796, DateTimeKind.Local).AddTicks(5330), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 3, 23, 12, 55, 57, 796, DateTimeKind.Local).AddTicks(5340), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 3, 23, 12, 55, 57, 796, DateTimeKind.Local).AddTicks(5350), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateOFadd", "HighlightExpiryDate", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 3, 23, 12, 55, 57, 796, DateTimeKind.Local).AddTicks(5350), new DateTime(2025, 4, 12, 12, 55, 57, 796, DateTimeKind.Local).AddTicks(5360), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 3, 23, 12, 55, 57, 796, DateTimeKind.Local).AddTicks(5360), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 23, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5570));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 23, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5570));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 23, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5570));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 23, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5570));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 23, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5580));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 23, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5580));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 23, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5580));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 23, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5580));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 23, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5580));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 23, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5580));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 23, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5580));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 23, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5590));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 23, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5590));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 23, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5590));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 23, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5590));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 23, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5590));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 23, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5590));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 23, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5590));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 23, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5590));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 23, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5590));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 23, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5590));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 23, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5600));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 23, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5600));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 23, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5600));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 23, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5600));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 23, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5600));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 23, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5600));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 23, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5600));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 23, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5610));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 23, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5610));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 23, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5610));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 23, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5610));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 26, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5650));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 28, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5650));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 5,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 30, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5650));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 6,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 7,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 8,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 26, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5660));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 9,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 28, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5670));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 10,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 30, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5670));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 11,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 12,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 13,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 26, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5670));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 14,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 28, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5670));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 15,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 30, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5680));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 16,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 17,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 18,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 26, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5680));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 19,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 28, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5680));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 20,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 30, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5680));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 21,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 22,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 23,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 26, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5690));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 24,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 28, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5690));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 25,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 30, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5690));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 26,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 27,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 28,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 26, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5690));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 29,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 28, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5690));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 30,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 30, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 31,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 32,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 33,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 26, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 34,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 28, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 35,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 30, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 36,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 37,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 38,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 26, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5710));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 39,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 28, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5710));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 40,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 30, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5710));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 41,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 42,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 43,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 26, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5720));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 44,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 28, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5720));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 45,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 30, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5720));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 46,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 47,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 48,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 26, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5730));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 49,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 28, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5730));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 50,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 30, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5730));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 51,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 52,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 53,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 26, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5740));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 54,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 28, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5740));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 55,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 30, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5740));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 56,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 57,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 58,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 26, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5740));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 59,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 28, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5740));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 60,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 30, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5750));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 61,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 62,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 63,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 26, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5750));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 64,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 28, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5750));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 65,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 30, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5750));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 66,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 67,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 68,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 26, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 69,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 28, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 70,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 30, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 71,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 72,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 73,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 26, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 74,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 28, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5780));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 75,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 30, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5780));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 76,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 77,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 78,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 26, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5780));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 79,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 28, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5790));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 80,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 30, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5790));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 81,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 82,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 83,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 26, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5800));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 84,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 28, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5800));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 85,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 30, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5800));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 86,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 87,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 88,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 26, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5800));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 89,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 28, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5800));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 90,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 30, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5810));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 91,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 92,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 93,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 26, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5810));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 94,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 28, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5810));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 95,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 30, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5810));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 96,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 97,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 98,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 26, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5820));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 99,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 28, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5820));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 100,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 30, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5820));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 101,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 102,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 103,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 26, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5820));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 104,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 28, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5830));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 105,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 30, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5830));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 106,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 107,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 108,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 26, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5830));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 109,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 28, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5830));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 110,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 30, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5830));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 111,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 112,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 113,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 26, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5840));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 114,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 28, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5840));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 115,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 30, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5840));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 116,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 117,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 118,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 26, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5850));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 119,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 28, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5850));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 120,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 30, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5850));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 121,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 122,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 123,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 26, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5850));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 124,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 28, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5850));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 125,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 30, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5860));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 126,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 127,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 128,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 26, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5860));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 129,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 28, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5860));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 130,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 30, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5860));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 131,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 132,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 133,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 26, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5870));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 134,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 28, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5870));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 135,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 30, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5870));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 136,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 137,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 138,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 26, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5870));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 139,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 28, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5880));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 140,
                column: "ReservationDate",
                value: new DateTime(2025, 3, 30, 11, 55, 57, 796, DateTimeKind.Utc).AddTicks(5880));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt", "PhoneNumber" },
                values: new object[] { "HUoUvbIG9CoHvRZ4K68Cqqs7Zmc=", "8qQgS/dLNq6lEBVg7x7rIg==", "+38762123456" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt", "PhoneNumber" },
                values: new object[] { "JUO8GDQ53TCf5pSkLZYC15Mu1xk=", "uf3CfviBxrUns0BSlw4iZw==", "+38763654321" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt", "PhoneNumber" },
                values: new object[] { "FbE289qtd6FKPCNhVXG+n5BPpXU=", "fjJbAOfKeNhRPlOye1rt9g==", "+38761987654" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt", "PhoneNumber" },
                values: new object[] { "AmiDLOQ7WxnaX2f7H7ZV7uV4duI=", "DLKeb1HIo/V/jeApO/I0ug==", "+38764112233" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "PasswordHash", "PasswordSalt", "PhoneNumber" },
                values: new object[] { "oNZywlIPFN/NY6JR1xTthuG2bDc=", "3fwsYZRKyqn7NeOBhkiqqQ==", "+38765223344" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "PasswordHash", "PasswordSalt", "PhoneNumber" },
                values: new object[] { "04pCxNUaEchp1NbawaybAe5xriQ=", "8ROACtwcm07JM0tF+c5wOA==", "+38760112233" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "PasswordHash", "PasswordSalt", "PhoneNumber" },
                values: new object[] { "AkFYLfa1fV+4rME8tM8nKtKPqJE=", "W/+EkzvM3BXuGU5FjKW9CQ==", "+38760445566" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "PasswordHash", "PasswordSalt", "PhoneNumber" },
                values: new object[] { "2Ln5JSF969OenizFKSH4hfg+MTs=", "nubwy/Er4u36oQ4vMSaMIA==", "+38760778899" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "PasswordHash", "PasswordSalt", "PhoneNumber" },
                values: new object[] { "BAkUe/3MCV6EJ46dr6uncEE8rA0=", "4moDEv1hbzmMxGD6evswVw==", "+3876088990" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "PasswordHash", "PasswordSalt", "PhoneNumber" },
                values: new object[] { "UsgxHOPujMGdDqPxW7yLRRzdNP4=", "SFL8PsDSfUST/lqCa6ap4w==", "+3876199001" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "PasswordHash", "PasswordSalt", "PhoneNumber" },
                values: new object[] { "XJVZB+G3M7wjUKgk00PjYB7ZymY=", "4wm4PsOzB8CK8Za0b+X1uA==", "+38761990011" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "PasswordHash", "PasswordSalt", "PhoneNumber", "ProfilePicture" },
                values: new object[] { "IS9WsfDm37WCYU5uX+MklRORetQ=", "QrdrrFQUmRAWvGxpPOoCzw==", "+3876199001", "/uploads/profilePictures/userSlika8.jpg" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "PasswordHash", "PasswordSalt", "PhoneNumber", "ProfilePicture" },
                values: new object[] { "kMgXmEBmxsoWeFdaBrdZFoAsTDs=", "W4hl4XGtL4vrsaE8b0KgSw==", "+38762345678", "/uploads/profilePictures/userSlika7.jpeg" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "PasswordHash", "PasswordSalt", "PhoneNumber", "ProfilePicture" },
                values: new object[] { "NH1cTkdM6OgiWKRNBaqmaWZcock=", "ANTfSwEaPSAwpS08up9+DQ==", "+38763567890", "/uploads/profilePictures/userSlika7.jpeg" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Gender", "PasswordHash", "PasswordSalt", "PhoneNumber", "ProfilePicture" },
                values: new object[] { "Z", "cE/MP3c4T0hxLJ2V67mU52G1aFk=", "/no2aoltJMmZyDKJH7FsiA==", "+3876112345", "/uploads/profilePictures/userSlika.jpg" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "PasswordHash", "PasswordSalt", "PhoneNumber", "ProfilePicture" },
                values: new object[] { "Gck7qgZvNEsl9lhoVBatlOB3uK0=", "x8mMEI4mD8S2ol8dRfbD1w==", "+38760998877", "/uploads/profilePictures/user2Slika.jpg" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "PasswordHash", "PasswordSalt", "PhoneNumber", "ProfilePicture" },
                values: new object[] { "V5vHfPbDIIzdMll5ch7vP0SeAZY=", "gijWg9+m7aWHkmA6Pw/Big==", "+38761789012", "/uploads/profilePictures/user3Slika.jpg" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Gender", "PasswordHash", "PasswordSalt", "PhoneNumber", "ProfilePicture" },
                values: new object[] { "Z", "rpATzLMysbKCiSZ0tflKsX3rVi0=", "p1zYNtGvzYyFvj8F9MxMYA==", "+38762555666", "/uploads/profilePictures/userSlika8.jpg" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "PasswordHash", "PasswordSalt", "PhoneNumber", "ProfilePicture" },
                values: new object[] { "RIIaSBeeTOTTSptMC6Y6U6xk7ec=", "33p7oUL5/CJwPsfkifNpiw==", "+38763777888", "/uploads/profilePictures/user2Slika.jpg" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Gender", "PasswordHash", "PasswordSalt", "PhoneNumber", "ProfilePicture" },
                values: new object[] { "Z", "IzTgC/VK7uWIQF6sDROSyeBBTgU=", "ouAS2ZD6pp6CZDn8T1zkJA==", "+3876033344", "/uploads/profilePictures/user4Slika.jpg" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "PasswordHash", "PasswordSalt", "PhoneNumber", "ProfilePicture" },
                values: new object[] { "jhuT66+JpQDEKZNgilKESxa6YWo=", "66fG57mJb/WvNrNqUxeADA==", "+38761666777", "/uploads/profilePictures/user4Slika.jpg" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Gender", "PasswordHash", "PasswordSalt", "PhoneNumber", "ProfilePicture" },
                values: new object[] { "Z", "Va99Qo8H1tWN2FPTvNP5R5pgziI=", "vraDQWjH8CJAKJzcrEOtBQ==", "+38762222333", "/uploads/profilePictures/user4Slika.jpg" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "PasswordHash", "PasswordSalt", "PhoneNumber", "ProfilePicture" },
                values: new object[] { "8GLmMxarV820kTFw0FLJ+Nb5IeE=", "tjR89IWzAMoYPoPaL94Qzw==", "+3876012378", "/uploads/profilePictures/user4Slika.jpg" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Gender", "PasswordHash", "PasswordSalt", "PhoneNumber", "ProfilePicture" },
                values: new object[] { "Z", "+4KQd6QkrfgZzL61dkwD99aRHPA=", "KP5ZkwH1ViIPbyMEN0a9sA==", "+38763987654", "/uploads/profilePictures/user4Slika.jpg" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "PasswordHash", "PasswordSalt", "PhoneNumber", "ProfilePicture" },
                values: new object[] { "P2nShRw/YuUE9WZ1U2C4I/UN49U=", "b/H8iEL7JoOArv4Pw9a9bQ==", "+38761654321", "/uploads/profilePictures/user4Slika.jpg" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Gender", "PasswordHash", "PasswordSalt", "PhoneNumber", "ProfilePicture" },
                values: new object[] { "Z", "1YUFUTrePeFIvWJKfrlxwLO8cdQ=", "hgO1PQh2ayicT1QtodCKoA==", "+38762111222", "/uploads/profilePictures/user4Slika.jpg" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "PasswordHash", "PasswordSalt", "PhoneNumber", "ProfilePicture" },
                values: new object[] { "rcrjvlRDd7cnEbUFIIt4GbWnEdo=", "oIPmjI64Cotrn98UroTbgg==", "+38760432678", "/uploads/profilePictures/user4Slika.jpg" });

            migrationBuilder.CreateIndex(
                name: "IX_MoodTrackers_UserId",
                table: "MoodTrackers",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MoodTrackers");

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateOFadd", "HighlightExpiryDate" },
                values: new object[] { new DateTime(2025, 2, 16, 12, 9, 13, 492, DateTimeKind.Local).AddTicks(7490), new DateTime(2025, 2, 18, 12, 9, 13, 492, DateTimeKind.Local).AddTicks(7550) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 2, 16, 12, 9, 13, 492, DateTimeKind.Local).AddTicks(7570), null, null });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 2, 16, 12, 9, 13, 492, DateTimeKind.Local).AddTicks(7570), null, null });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 2, 16, 12, 9, 13, 492, DateTimeKind.Local).AddTicks(7580), null, null });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateOFadd", "HighlightExpiryDate", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 2, 16, 12, 9, 13, 492, DateTimeKind.Local).AddTicks(7590), new DateTime(2025, 3, 8, 12, 9, 13, 492, DateTimeKind.Local).AddTicks(7590), null, null });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateOFadd", "HighlightExpiryDate", "IsHighlighted", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 2, 16, 12, 9, 13, 492, DateTimeKind.Local).AddTicks(7590), null, false, null, null });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 2, 16, 12, 9, 13, 492, DateTimeKind.Local).AddTicks(7600), null, null });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 2, 16, 12, 9, 13, 492, DateTimeKind.Local).AddTicks(7610), null, null });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 2, 16, 12, 9, 13, 492, DateTimeKind.Local).AddTicks(7620), null, null });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 2, 16, 12, 9, 13, 492, DateTimeKind.Local).AddTicks(7630), null, null });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateOFadd", "HighlightExpiryDate", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 2, 16, 12, 9, 13, 492, DateTimeKind.Local).AddTicks(7630), new DateTime(2025, 3, 8, 12, 9, 13, 492, DateTimeKind.Local).AddTicks(7640), null, null });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 2, 16, 12, 9, 13, 492, DateTimeKind.Local).AddTicks(7640), null, null });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateOFadd", "HighlightExpiryDate", "IsHighlighted", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 2, 16, 12, 9, 13, 492, DateTimeKind.Local).AddTicks(7650), null, false, null, null });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 2, 16, 12, 9, 13, 492, DateTimeKind.Local).AddTicks(7650), null, null });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 2, 16, 12, 9, 13, 492, DateTimeKind.Local).AddTicks(7660), null, null });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 2, 16, 12, 9, 13, 492, DateTimeKind.Local).AddTicks(7660), null, null });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateOFadd", "HighlightExpiryDate", "IsHighlighted", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 2, 16, 12, 9, 13, 492, DateTimeKind.Local).AddTicks(7670), null, false, null, null });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 2, 16, 12, 9, 13, 492, DateTimeKind.Local).AddTicks(7680), null, null });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 2, 16, 12, 9, 13, 492, DateTimeKind.Local).AddTicks(7690), null, null });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 2, 16, 12, 9, 13, 492, DateTimeKind.Local).AddTicks(7700), null, null });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 2, 16, 12, 9, 13, 492, DateTimeKind.Local).AddTicks(7700), null, null });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 2, 16, 12, 9, 13, 492, DateTimeKind.Local).AddTicks(7710), null, null });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 2, 16, 12, 9, 13, 492, DateTimeKind.Local).AddTicks(7710), null, null });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 2, 16, 12, 9, 13, 492, DateTimeKind.Local).AddTicks(7720), null, null });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 2, 16, 12, 9, 13, 492, DateTimeKind.Local).AddTicks(7730), null, null });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 2, 16, 12, 9, 13, 492, DateTimeKind.Local).AddTicks(7730), null, null });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 2, 16, 12, 9, 13, 492, DateTimeKind.Local).AddTicks(7740), null, null });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateOFadd", "HighlightExpiryDate", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 2, 16, 12, 9, 13, 492, DateTimeKind.Local).AddTicks(7740), new DateTime(2025, 3, 8, 12, 9, 13, 492, DateTimeKind.Local).AddTicks(7750), null, null });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 2, 16, 12, 9, 13, 492, DateTimeKind.Local).AddTicks(7750), null, null });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 16, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8040));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 16, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8040));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 16, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8040));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 16, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8040));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 16, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8040));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 16, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8040));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 16, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8050));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 16, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8050));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 16, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8050));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 16, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8050));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 16, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8050));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 16, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8050));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 16, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8050));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 16, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8050));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 16, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8060));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 16, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8060));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 16, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8060));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 16, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8060));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 16, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8060));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 16, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8060));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 16, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8060));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 16, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8070));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 16, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8070));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 16, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8070));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 16, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8070));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 16, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8070));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 16, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8070));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 16, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8070));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 16, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8070));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 16, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8070));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 16, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8080));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 16, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8080));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 19, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8120));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 21, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8120));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 5,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 23, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8120));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 6,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 7,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 8,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 19, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8130));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 9,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 21, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8130));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 10,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 23, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8130));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 11,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 12,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 13,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 19, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8140));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 14,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 21, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8140));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 15,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 23, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8140));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 16,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 17,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 18,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 19, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8150));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 19,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 21, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8150));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 20,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 23, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8150));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 21,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 22,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 23,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 19, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8170));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 24,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 21, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8170));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 25,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 23, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8170));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 26,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 27,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 28,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 19, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8180));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 29,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 21, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8180));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 30,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 23, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8180));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 31,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 32,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 33,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 19, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8180));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 34,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 21, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8190));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 35,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 23, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8190));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 36,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 37,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 38,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 19, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8190));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 39,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 21, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8190));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 40,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 23, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8200));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 41,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 42,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 43,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 19, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8200));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 44,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 21, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8200));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 45,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 23, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8210));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 46,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 47,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 48,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 19, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8210));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 49,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 21, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8210));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 50,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 23, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8210));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 51,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 52,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 53,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 19, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8220));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 54,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 21, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8220));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 55,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 23, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8220));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 56,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 57,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 58,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 19, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8230));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 59,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 21, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8230));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 60,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 23, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8230));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 61,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 62,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 63,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 19, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8240));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 64,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 21, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8240));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 65,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 23, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8240));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 66,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 67,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 68,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 19, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8240));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 69,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 21, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8250));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 70,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 23, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8250));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 71,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 72,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 73,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 19, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8250));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 74,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 21, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8250));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 75,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 23, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8260));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 76,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 77,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 78,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 19, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8260));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 79,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 21, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8260));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 80,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 23, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8260));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 81,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 82,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 83,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 19, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8270));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 84,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 21, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8270));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 85,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 23, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8270));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 86,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 87,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 88,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 19, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8280));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 89,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 21, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8280));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 90,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 23, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8280));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 91,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 92,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 93,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 19, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8290));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 94,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 21, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8290));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 95,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 23, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8290));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 96,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 97,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 98,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 19, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8290));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 99,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 21, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8300));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 100,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 23, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8300));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 101,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 102,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 103,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 19, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8300));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 104,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 21, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8300));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 105,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 23, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8310));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 106,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 107,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 108,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 19, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8310));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 109,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 21, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8310));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 110,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 23, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8310));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 111,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 112,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 113,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 19, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8320));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 114,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 21, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8320));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 115,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 23, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8320));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 116,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 117,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 118,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 19, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8330));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 119,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 21, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8330));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 120,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 23, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8330));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 121,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 122,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 123,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 19, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8340));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 124,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 21, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8340));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 125,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 23, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8340));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 126,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 127,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 128,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 19, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8350));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 129,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 21, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8350));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 130,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 23, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8350));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 131,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 132,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 133,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 19, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8360));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 134,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 21, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8360));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 135,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 23, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8360));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 136,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 137,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 138,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 19, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8360));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 139,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 21, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8370));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 140,
                column: "ReservationDate",
                value: new DateTime(2025, 2, 23, 11, 9, 13, 492, DateTimeKind.Utc).AddTicks(8370));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt", "PhoneNumber" },
                values: new object[] { "XmOdD5gIwvUbYqvNBAcNRZMV81E=", "6sauH+l3A/8fkJZlKAsDQw==", "062123456" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt", "PhoneNumber" },
                values: new object[] { "SFfVP/Gr+23gAG1+CC9ZBr8w2EI=", "L68oS6s42oDntH7Z2Mze/Q==", "063654321" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt", "PhoneNumber" },
                values: new object[] { "xe5Q4OBidVwjyL21Ei0IOpLqR7c=", "uxD9v8tbC40RJjxYUcdSBA==", "061987654" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt", "PhoneNumber" },
                values: new object[] { "j+zbHQO7Le3d7f+M8N2HsDjQSS0=", "uB9eX7MPW6JHA+QAKXf7uw==", "064112233" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "PasswordHash", "PasswordSalt", "PhoneNumber" },
                values: new object[] { "jHnDN5+eNGalNTCC1HXbZX60HLY=", "Ee27GmWNqw6++kt34jIq6w==", "065223344" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "PasswordHash", "PasswordSalt", "PhoneNumber" },
                values: new object[] { "TS06922ByLbvx9vGBx2M+zyJEtw=", "OcBGxyIHUA9z/sxPXbr2+w==", "060112233" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "PasswordHash", "PasswordSalt", "PhoneNumber" },
                values: new object[] { "Gfj+PEOOW0C0z6cwjH3VCKFVC/4=", "TEq9IfH3BqwEx6QfkA1T1A==", "060445566" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "PasswordHash", "PasswordSalt", "PhoneNumber" },
                values: new object[] { "ODjaFX5Pfb3gl+RUG+S+vf+evG0=", "+o4frWU1H+ed5rWO1nlAbg==", "060778899" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "PasswordHash", "PasswordSalt", "PhoneNumber" },
                values: new object[] { "xMkEyVlnIZ0X1/8WwY/qkKRw8x0=", "iZwVUlD/GJbIqb+xcfntCQ==", "060889900" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "PasswordHash", "PasswordSalt", "PhoneNumber" },
                values: new object[] { "7m4EHj9VgJaHkB/RUUuPxhVwYxI=", "GhfVBY9bKBjEgf+kAQCeyw==", "061990011" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "PasswordHash", "PasswordSalt", "PhoneNumber" },
                values: new object[] { "Pb6GpB97ChMOLmqNKx5k6hrDouk=", "J6AYIgA5thxVe1sZIaRU5g==", "061990011" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "PasswordHash", "PasswordSalt", "PhoneNumber", "ProfilePicture" },
                values: new object[] { "f4aDbQZFCaXVf3ufsUzGcFGDwDA=", "YXMHTVkPHFpiWpq/o3VcbQ==", "061990011", "/uploads/profilePictures/userSlika7.jpg" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "PasswordHash", "PasswordSalt", "PhoneNumber", "ProfilePicture" },
                values: new object[] { "deu4m2rLAKL3hOOYigqRdMYAaHs=", "/yAyVtIR5yhqB2uAQsSNXg==", "062345678", "/uploads/profilePictures/userSlika7.jpg" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "PasswordHash", "PasswordSalt", "PhoneNumber", "ProfilePicture" },
                values: new object[] { "N8ZIhMwQFwAQbKr0Di9QKzizQOs=", "gC6CcmIrGoZtFFrFkWijiA==", "063567890", "/uploads/profilePictures/userSlika7.jpg" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Gender", "PasswordHash", "PasswordSalt", "PhoneNumber", "ProfilePicture" },
                values: new object[] { "F", "In5SmLm6OcToFpG1aFiJg4olTAM=", "WwmaHvsfxDQmDGn7EUzYvQ==", "061123456", "/uploads/profilePictures/userSlika7.jpg" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "PasswordHash", "PasswordSalt", "PhoneNumber", "ProfilePicture" },
                values: new object[] { "jtuIvKKP+eL74CLLtcrjCrU+XN8=", "dKqKULzuXwFiGn+sMXpRag==", "060998877", "/uploads/profilePictures/userSlika7.jpg" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "PasswordHash", "PasswordSalt", "PhoneNumber", "ProfilePicture" },
                values: new object[] { "uKovlehoqBkEHYOeJX7Ou/ZKLNM=", "qf6LHtotxPf9xmdERrVxIA==", "061789012", "/uploads/profilePictures/userSlika7.jpg" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Gender", "PasswordHash", "PasswordSalt", "PhoneNumber", "ProfilePicture" },
                values: new object[] { "F", "bOtm9HwYGa3JKgD5++OgXLX8cTE=", "+sx/a8ijEcVo/8Y9aaHbCA==", "062555666", "/uploads/profilePictures/userSlika7.jpg" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "PasswordHash", "PasswordSalt", "PhoneNumber", "ProfilePicture" },
                values: new object[] { "Tq0J3Amh3vyjx23tcLOWGJ4Yl80=", "28uRkwinqoWmNMoCYBvGOg==", "063777888", "/uploads/profilePictures/userSlika7.jpg" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Gender", "PasswordHash", "PasswordSalt", "PhoneNumber", "ProfilePicture" },
                values: new object[] { "F", "wTLiC+g/2J4XKyPqLiGSMjKKNBY=", "lrGi4znuIFSo+51VQ/qnTA==", "060333444", "/uploads/profilePictures/userSlika7.jpg" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "PasswordHash", "PasswordSalt", "PhoneNumber", "ProfilePicture" },
                values: new object[] { "dfUHKDVylhI82tapn1baVafoTes=", "1FyfUSDfFXa4hISVPf9nAQ==", "061666777", "/uploads/profilePictures/userSlika7.jpg" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Gender", "PasswordHash", "PasswordSalt", "PhoneNumber", "ProfilePicture" },
                values: new object[] { "F", "Utyxne7Eqn4CD4s9eYos8b583T0=", "PnEfi7Y59DNmwLPVDQCFdA==", "062222333", "/uploads/profilePictures/userSlika7.jpg" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "PasswordHash", "PasswordSalt", "PhoneNumber", "ProfilePicture" },
                values: new object[] { "IJ5Kl80jE7QdrhmBJyQgYvHQVNo=", "Ok7yXrliQsm5T1+AssVN0w==", "060123789", "/uploads/profilePictures/userSlika7.jpg" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Gender", "PasswordHash", "PasswordSalt", "PhoneNumber", "ProfilePicture" },
                values: new object[] { "F", "dmu+Y6wmxznlZzroIx5L308R7MQ=", "pEVcQkHK03sR3NKluWE52Q==", "063987654", "/uploads/profilePictures/userSlika7.jpg" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "PasswordHash", "PasswordSalt", "PhoneNumber", "ProfilePicture" },
                values: new object[] { "TKXOJgDeAgAJtDIwcmLWs+qKcJQ=", "cqH4nrfhaGPgLygqK06dcA==", "061654321", "/uploads/profilePictures/userSlika7.jpg" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Gender", "PasswordHash", "PasswordSalt", "PhoneNumber", "ProfilePicture" },
                values: new object[] { "F", "pqWkGcHP+3sx0/RnbtLIF1Zqlbc=", "Q0i60BY3yMwBlK8M9bCPZQ==", "062111222", "/uploads/profilePictures/userSlika7.jpg" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "PasswordHash", "PasswordSalt", "PhoneNumber", "ProfilePicture" },
                values: new object[] { "90sx/VhTIpfiB5vTYsKd+6i3Wac=", "MgaQoQTHpo7+gWMSgDVIUA==", "060432678", "/uploads/profilePictures/userSlika7.jpg" });
        }
    }
}
