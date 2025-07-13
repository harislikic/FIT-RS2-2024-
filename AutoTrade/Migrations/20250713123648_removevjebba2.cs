using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoTrade.Migrations
{
    /// <inheritdoc />
    public partial class removevjebba2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RezervacijaProstora");

            migrationBuilder.DropTable(
                name: "RadniProstor");

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateOFadd", "HighlightExpiryDate" },
                values: new object[] { new DateTime(2025, 7, 13, 14, 36, 47, 914, DateTimeKind.Local).AddTicks(3120), new DateTime(2025, 7, 15, 14, 36, 47, 914, DateTimeKind.Local).AddTicks(3180) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 13, 14, 36, 47, 914, DateTimeKind.Local).AddTicks(3200), new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 13, 14, 36, 47, 914, DateTimeKind.Local).AddTicks(3200), new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 13, 14, 36, 47, 914, DateTimeKind.Local).AddTicks(3210), new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateOFadd", "HighlightExpiryDate", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 13, 14, 36, 47, 914, DateTimeKind.Local).AddTicks(3220), new DateTime(2025, 8, 2, 14, 36, 47, 914, DateTimeKind.Local).AddTicks(3220), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateOFadd", "HighlightExpiryDate", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 13, 14, 36, 47, 914, DateTimeKind.Local).AddTicks(3220), new DateTime(2025, 7, 23, 14, 36, 47, 914, DateTimeKind.Local).AddTicks(3230), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 13, 14, 36, 47, 914, DateTimeKind.Local).AddTicks(3230), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 13, 14, 36, 47, 914, DateTimeKind.Local).AddTicks(3250), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 13, 14, 36, 47, 914, DateTimeKind.Local).AddTicks(3260), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 13, 14, 36, 47, 914, DateTimeKind.Local).AddTicks(3260), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateOFadd", "HighlightExpiryDate", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 13, 14, 36, 47, 914, DateTimeKind.Local).AddTicks(3270), new DateTime(2025, 8, 2, 14, 36, 47, 914, DateTimeKind.Local).AddTicks(3280), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 13, 14, 36, 47, 914, DateTimeKind.Local).AddTicks(3280), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateOFadd", "HighlightExpiryDate", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 13, 14, 36, 47, 914, DateTimeKind.Local).AddTicks(3280), new DateTime(2025, 7, 23, 14, 36, 47, 914, DateTimeKind.Local).AddTicks(3290), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 13, 14, 36, 47, 914, DateTimeKind.Local).AddTicks(3290), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 13, 14, 36, 47, 914, DateTimeKind.Local).AddTicks(3300), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 13, 14, 36, 47, 914, DateTimeKind.Local).AddTicks(3300), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateOFadd", "HighlightExpiryDate", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 13, 14, 36, 47, 914, DateTimeKind.Local).AddTicks(3320), new DateTime(2025, 7, 23, 14, 36, 47, 914, DateTimeKind.Local).AddTicks(3340), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 13, 14, 36, 47, 914, DateTimeKind.Local).AddTicks(3340), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 13, 14, 36, 47, 914, DateTimeKind.Local).AddTicks(3350), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 13, 14, 36, 47, 914, DateTimeKind.Local).AddTicks(3360), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 13, 14, 36, 47, 914, DateTimeKind.Local).AddTicks(3360), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 13, 14, 36, 47, 914, DateTimeKind.Local).AddTicks(3370), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 13, 14, 36, 47, 914, DateTimeKind.Local).AddTicks(3380), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 13, 14, 36, 47, 914, DateTimeKind.Local).AddTicks(3380), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 13, 14, 36, 47, 914, DateTimeKind.Local).AddTicks(3390), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 13, 14, 36, 47, 914, DateTimeKind.Local).AddTicks(3400), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 13, 14, 36, 47, 914, DateTimeKind.Local).AddTicks(3400), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateOFadd", "HighlightExpiryDate", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 13, 14, 36, 47, 914, DateTimeKind.Local).AddTicks(3410), new DateTime(2025, 8, 2, 14, 36, 47, 914, DateTimeKind.Local).AddTicks(3410), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 13, 14, 36, 47, 914, DateTimeKind.Local).AddTicks(3420), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 13, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3660));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 13, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3660));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 13, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3670));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 13, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3670));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 13, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3670));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 13, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3670));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 13, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3670));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 13, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3670));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 13, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3670));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 13, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3670));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 13, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3670));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 13, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3680));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 13, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3680));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 13, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3680));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 13, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3680));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 13, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3680));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 13, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3680));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 13, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3680));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 13, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3680));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 13, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3680));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 13, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3690));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 13, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3690));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 13, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3690));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 13, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3690));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 13, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3690));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 13, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3690));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 13, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3690));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 13, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3690));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 13, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3690));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 13, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3700));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 13, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3700));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 13, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3700));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3730));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 18, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3730));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 5,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 20, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3730));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 8,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3750));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 9,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 18, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3750));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 10,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 20, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3750));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 13,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3760));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 14,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 18, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3760));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 15,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 20, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3760));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 18,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3770));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 19,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 18, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3770));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 20,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 20, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3770));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 23,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3780));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 24,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 18, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3780));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 25,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 20, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3780));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 28,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3790));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 29,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 18, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3790));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 30,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 20, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3790));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 33,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3790));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 34,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 18, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3790));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 35,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 20, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3800));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 38,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3800));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 39,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 18, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3800));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 40,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 20, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3800));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 43,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3810));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 44,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 18, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3810));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 45,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 20, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3820));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 48,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3830));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 49,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 18, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3830));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 50,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 20, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3830));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 53,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3830));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 54,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 18, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3840));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 55,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 20, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3840));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 58,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3840));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 59,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 18, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3840));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 60,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 20, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3840));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 63,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3850));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 64,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 18, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3850));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 65,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 20, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3850));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 68,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3860));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 69,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 18, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3860));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 70,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 20, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3860));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 73,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3870));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 74,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 18, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3870));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 75,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 20, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3870));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 78,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3870));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 79,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 18, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3870));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 80,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 20, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3880));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 83,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3890));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 84,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 18, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3890));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 85,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 20, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3890));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 88,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3900));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 89,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 18, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3900));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 90,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 20, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3900));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 93,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3910));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 94,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 18, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3910));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 95,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 20, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3910));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 98,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3910));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 99,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 18, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3920));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 100,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 20, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3920));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 103,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3920));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 104,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 18, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3920));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 105,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 20, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3920));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 108,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3940));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 109,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 18, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3940));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 110,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 20, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3940));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 113,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3950));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 114,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 18, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3950));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 115,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 20, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3950));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 118,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3960));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 119,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 18, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3960));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 120,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 20, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3960));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 123,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3960));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 124,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 18, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3970));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 125,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 20, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3970));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 128,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3970));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 129,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 18, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3970));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 130,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 20, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3970));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 133,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3980));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 134,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 18, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3980));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 135,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 20, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3980));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 138,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3990));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 139,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 18, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3990));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 140,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 20, 12, 36, 47, 914, DateTimeKind.Utc).AddTicks(3990));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "9tlDNBt5+rnml6gPGcLeH5wgoaU=", "UszNFimB/NuFE/2CeyQY4Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "qk9761HVv2QN91cyZWSmlIEPcRM=", "jom9C1cd7qu7mklvmx6M+A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "9F1DG+ar6UQxcHqUhJnVypum79s=", "w3D6B1pATooXK2rf2RTNNA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "y00C9YMuyF/hJnrkhiLLvYP0zio=", "GnMabxaETOnCVNnLDdWVMA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "PIuvrka/PJqJGftoDmlPCfFHt1A=", "lP5QO7b4jjxiOlxOrmY1Zg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "PmFIuilb26uvPgUim5H57dyY2VY=", "EUTRFcGUI68JXBbCOwUirQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "veUfJmN/atWbWmQia8epAIINOuo=", "YVImc5G1IdwPJ0x9tpRgzQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "pck7IwKdam5eiMr+6Wg2nowPZow=", "WTRP9UiKILtJ+v4jK1Atzw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "kmgDiUoIm1w0bCJluRimV4hizXA=", "nVAjgp0exmv/0tHBTYHtwQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "cAIMAoFbsv+l6KZzku8TmhIczZ0=", "WHfyN+MbLORv09/FoqkcWw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "Zwjg09189bU9zsvQjeV9ebboRSg=", "BBfDAULRugakgazRCbIxqQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "h+9/Zh58GFxgbEtUlMQa3BcDSEI=", "lZz+9DmK2NNudAfKL97bdA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "U/M3QR06rYb6Wyq+G5IVBjFTWOk=", "lbkDTg07idUsIaLxgIr8cQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "Grzo8SSghSchM7P8YIZXKNeY/Dk=", "pjZh9rzHDovxzqLniQGSfA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "qHIhOoKejmS33aOkANjHZ9GuecY=", "0JWUTOVaeXkMeuQaVki//Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "GHRxjJhiIK7bChcKI/do9bVEPgs=", "jYs2LCkr2v+gMsxcJVynbg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "NzD0GuK89TMIrmlpf9tetT73Xw8=", "lgPFFTHvJFQUWgzCwL5w6A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "hotgI5pcpqftRzY/gCbxxuDNo+k=", "MOHiyB9+JpIChr2tgbASYA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "EfGvpFwDn/7Lg6eSfj5cmRPDPAM=", "bU3lrA/YVyouZ8R17P+hjQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "mShzBbVeW6r4/vZMQtpZ7unMrj0=", "QOuivFQSzRpYeR6aKFaIQA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "jHwnqFxC3BMZ+pKpzYmTz/ICVmk=", "w0q44AiDa70RjH8zO5pUcA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "zStO7pqMFfm50J7aW2mODqjItDg=", "xQKotGLyONNiQTV0EmvnZw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "lrMFBC9YB46rINDXs0zRWoNWYG0=", "gC3ozus74rwrYbepT+P9nA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "nTwSSk2E9UBxz5fJ6GSPWsbnUtw=", "qFSI66VJfXjMgDgG8T4V5g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "UJqxK3Z+pazLdMZxOLuJlnEzfzQ=", "C4Hgu7SKtWcGYbjYOnYziw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "dtHPcDaLxpkEqzcWpftauvSpHWo=", "SBB5hDeiM3CfW2qAojqOEQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "1dJSBYsYk7U3eQThZr2poHGKzSk=", "wRzy6Qw6o2SsOE1W0MfVnA==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RadniProstor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Aktivna = table.Column<bool>(type: "bit", nullable: false),
                    Kapacitet = table.Column<int>(type: "int", nullable: false),
                    Oznaka = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RadniProstor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RezervacijaProstora",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RadniProstorId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Napomena = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PocetakRezervacije = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrajanjeUsatima = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RezervacijaProstora", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RezervacijaProstora_RadniProstor_RadniProstorId",
                        column: x => x.RadniProstorId,
                        principalTable: "RadniProstor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RezervacijaProstora_Users_UserId",
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
                values: new object[] { new DateTime(2025, 7, 11, 16, 19, 7, 775, DateTimeKind.Local).AddTicks(560), new DateTime(2025, 7, 13, 16, 19, 7, 775, DateTimeKind.Local).AddTicks(620) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 11, 16, 19, 7, 775, DateTimeKind.Local).AddTicks(630), null, null });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 11, 16, 19, 7, 775, DateTimeKind.Local).AddTicks(640), null, null });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 11, 16, 19, 7, 775, DateTimeKind.Local).AddTicks(650), null, null });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateOFadd", "HighlightExpiryDate", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 11, 16, 19, 7, 775, DateTimeKind.Local).AddTicks(650), new DateTime(2025, 7, 31, 16, 19, 7, 775, DateTimeKind.Local).AddTicks(660), null, null });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateOFadd", "HighlightExpiryDate", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 11, 16, 19, 7, 775, DateTimeKind.Local).AddTicks(670), new DateTime(2025, 7, 21, 16, 19, 7, 775, DateTimeKind.Local).AddTicks(670), null, null });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 11, 16, 19, 7, 775, DateTimeKind.Local).AddTicks(670), null, null });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 11, 16, 19, 7, 775, DateTimeKind.Local).AddTicks(680), null, null });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 11, 16, 19, 7, 775, DateTimeKind.Local).AddTicks(690), null, null });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 11, 16, 19, 7, 775, DateTimeKind.Local).AddTicks(690), null, null });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateOFadd", "HighlightExpiryDate", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 11, 16, 19, 7, 775, DateTimeKind.Local).AddTicks(700), new DateTime(2025, 7, 31, 16, 19, 7, 775, DateTimeKind.Local).AddTicks(710), null, null });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 11, 16, 19, 7, 775, DateTimeKind.Local).AddTicks(710), null, null });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateOFadd", "HighlightExpiryDate", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 11, 16, 19, 7, 775, DateTimeKind.Local).AddTicks(710), new DateTime(2025, 7, 21, 16, 19, 7, 775, DateTimeKind.Local).AddTicks(720), null, null });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 11, 16, 19, 7, 775, DateTimeKind.Local).AddTicks(720), null, null });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 11, 16, 19, 7, 775, DateTimeKind.Local).AddTicks(730), null, null });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 11, 16, 19, 7, 775, DateTimeKind.Local).AddTicks(740), null, null });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateOFadd", "HighlightExpiryDate", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 11, 16, 19, 7, 775, DateTimeKind.Local).AddTicks(740), new DateTime(2025, 7, 21, 16, 19, 7, 775, DateTimeKind.Local).AddTicks(750), null, null });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 11, 16, 19, 7, 775, DateTimeKind.Local).AddTicks(750), null, null });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 11, 16, 19, 7, 775, DateTimeKind.Local).AddTicks(760), null, null });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 11, 16, 19, 7, 775, DateTimeKind.Local).AddTicks(760), null, null });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 11, 16, 19, 7, 775, DateTimeKind.Local).AddTicks(810), null, null });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 11, 16, 19, 7, 775, DateTimeKind.Local).AddTicks(820), null, null });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 11, 16, 19, 7, 775, DateTimeKind.Local).AddTicks(820), null, null });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 11, 16, 19, 7, 775, DateTimeKind.Local).AddTicks(830), null, null });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 11, 16, 19, 7, 775, DateTimeKind.Local).AddTicks(840), null, null });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 11, 16, 19, 7, 775, DateTimeKind.Local).AddTicks(840), null, null });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 11, 16, 19, 7, 775, DateTimeKind.Local).AddTicks(850), null, null });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateOFadd", "HighlightExpiryDate", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 11, 16, 19, 7, 775, DateTimeKind.Local).AddTicks(860), new DateTime(2025, 7, 31, 16, 19, 7, 775, DateTimeKind.Local).AddTicks(860), null, null });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 11, 16, 19, 7, 775, DateTimeKind.Local).AddTicks(860), null, null });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1140));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1140));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1150));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1150));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1150));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1150));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1150));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1150));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1150));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1150));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1150));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1160));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1160));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1160));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1160));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1160));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1160));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1160));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1160));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1170));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1170));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1170));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1170));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1170));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1170));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1170));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1180));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1180));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1180));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1180));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1180));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1180));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1220));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1220));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 5,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 18, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1220));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 8,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1240));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 9,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1240));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 10,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 18, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1240));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 13,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1250));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 14,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1250));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 15,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 18, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1250));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 18,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1250));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 19,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1260));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 20,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 18, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1260));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 23,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1260));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 24,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1260));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 25,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 18, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1260));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 28,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1270));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 29,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1270));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 30,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 18, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1270));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 33,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1280));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 34,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1280));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 35,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 18, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1280));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 38,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1290));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 39,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1290));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 40,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 18, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1290));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 43,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1300));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 44,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1300));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 45,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 18, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1310));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 48,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1310));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 49,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1320));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 50,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 18, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1320));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 53,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1320));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 54,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1320));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 55,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 18, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1320));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 58,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1330));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 59,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1330));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 60,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 18, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1330));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 63,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1340));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 64,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1340));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 65,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 18, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1340));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 68,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1340));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 69,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1350));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 70,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 18, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1350));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 73,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1350));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 74,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1350));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 75,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 18, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1360));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 78,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1360));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 79,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1360));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 80,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 18, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1360));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 83,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1380));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 84,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1380));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 85,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 18, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1380));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 88,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1390));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 89,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1390));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 90,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 18, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1390));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 93,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1390));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 94,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1400));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 95,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 18, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1400));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 98,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1400));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 99,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1400));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 100,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 18, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1400));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 103,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1410));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 104,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1410));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 105,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 18, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1410));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 108,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1420));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 109,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1420));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 110,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 18, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1420));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 113,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1420));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 114,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1430));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 115,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 18, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1430));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 118,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1430));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 119,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1430));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 120,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 18, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1440));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 123,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1440));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 124,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1440));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 125,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 18, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1440));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 128,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1450));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 129,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1450));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 130,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 18, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1510));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 133,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1520));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 134,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1520));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 135,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 18, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1520));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 138,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1530));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 139,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1530));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 140,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 18, 14, 19, 7, 775, DateTimeKind.Utc).AddTicks(1530));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "5VHta76DKQujHpf52PkYQrV+JKA=", "FdVli3fjQmNBI2UjCLe1Tw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "08ruZ63Q8JO/vsKgjWjCtO7C6/k=", "jXY1PKbL2GmQ8q76DqlEGw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "54vsJ8bBk7/H77HMbJIuBqxxIQg=", "P1EewUgncr+61ns2bcWMwg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "WqKv7GT/uWSWcAl6U5gtte5vYWI=", "BnownO8i/X/sG4Iy/JG9bA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "TPtd6nbWa4svzii3dW7rxk12v6c=", "e0y6jfZeZB1rIutfmnNTXQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "pVEfycHzqy4q/C4XStQb0huh9Rk=", "vdinegRlEb/EgW7iITJtdQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "8liJI49EPrT4qjhUAPx6o43hxJk=", "zWfkWdd3pxQPQrDzcFonFg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "KUxXIo17lqRtjtbopzLESh5NJyM=", "ENu7+qWrjaH4Fh3XlBpYVw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "7FphshDygnOx3tMt2/D1YrE/G9A=", "E6/yfu8NTNNaKcxDrDQLtQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "uhuGdt1F1qB2TxT9hgkg641YNjw=", "znBitVMqQuExz9MkmwCAtA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "ZQLnN791mSJb9fq2yJ+nO/VxtAQ=", "8VGYGRvCDjItFFjF93SWyg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "75hNNA5ri2toIv46epGxabQ5QuQ=", "DNt1Ew5o3NT6h0tON5a8eg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "ED9cYYrClecQlGLg9sWx0gRRk7s=", "VWOF8G/7Bri1KNpCL0MtUg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "iT/aBMqrxYLVSVhjQ5nlgo4JY1g=", "c50gzhsFXrmuZY0hMeeupQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "oAVqaAVkR+myTOSjAxPirw+ht98=", "HpgAbjU/5CXg4T3OxNEeuw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "Rp/ZAVFYvh927AJYfnSMIBkzV6g=", "eP2MMdZmUeEIp1LWteWcGA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "YNqaJHAJxkAdGDhmPAEO2DW/594=", "8gu7SnTuAX6/vMBRVeh/cg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "OYhw/URFUWZZwFBi6pqvBxByiIY=", "PDtGijY6Eh10Eeo39wltUQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "f0NEoajmoZ+dCIaV+qSK5bEHQtw=", "Fz6xnIUWwpIZTjS0+NxJNw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "QW5SWMvwFbpixlBVs+rBCAQg2EA=", "gBCcaZynn+VhatLgeYYDAw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "gkmtUGzsjbN3lb+FG/qx9c7yi9s=", "RvyOg/ucs/SLuciBhELcuA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "ctpvEBmEtVb8M1FI/rZQsARsnQs=", "NhVZLg/5pREoOQjIbVyFtA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "nwHCFz0k99nYJTaDPJqb+5fD4XI=", "gbv68eQBGdmdE7+jvz2p3w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "oVJcZrs88P0eQh2q2mWv0ZHFG2w=", "ULOlJ+81OarXYy3hzJtlLw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "2dtX/nn8xFLv0F8V48mv2lMlEY0=", "zSrd0t0Sc8SoyDuXY8UktA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "6EvnTLlvPt6iX7aMEeF8EVpUNjM=", "SVLWi8vIZ9Ijdr+lbIxSpw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "AopihsAuHPBlb2H4XMWzUBK0q/g=", "0bOa1GXEaLA/goT0FrP8cg==" });

            migrationBuilder.CreateIndex(
                name: "IX_RezervacijaProstora_RadniProstorId",
                table: "RezervacijaProstora",
                column: "RadniProstorId");

            migrationBuilder.CreateIndex(
                name: "IX_RezervacijaProstora_UserId",
                table: "RezervacijaProstora",
                column: "UserId");
        }
    }
}
