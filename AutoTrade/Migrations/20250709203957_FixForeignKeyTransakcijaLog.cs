using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoTrade.Migrations
{
    /// <inheritdoc />
    public partial class FixForeignKeyTransakcijaLog : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TransakcijaLogs_Transakcije_transakcija25062025Id",
                table: "TransakcijaLogs");

            migrationBuilder.DropColumn(
                name: "TransakcijaId",
                table: "TransakcijaLogs");

            migrationBuilder.RenameColumn(
                name: "transakcija25062025Id",
                table: "TransakcijaLogs",
                newName: "Transakcija25062025Id");

            migrationBuilder.RenameIndex(
                name: "IX_TransakcijaLogs_transakcija25062025Id",
                table: "TransakcijaLogs",
                newName: "IX_TransakcijaLogs_Transakcija25062025Id");

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateOFadd", "HighlightExpiryDate" },
                values: new object[] { new DateTime(2025, 7, 9, 22, 39, 57, 236, DateTimeKind.Local).AddTicks(4620), new DateTime(2025, 7, 11, 22, 39, 57, 236, DateTimeKind.Local).AddTicks(4690) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 9, 22, 39, 57, 236, DateTimeKind.Local).AddTicks(4700), new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 9, 22, 39, 57, 236, DateTimeKind.Local).AddTicks(4700), new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 9, 22, 39, 57, 236, DateTimeKind.Local).AddTicks(4710), new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateOFadd", "HighlightExpiryDate", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 9, 22, 39, 57, 236, DateTimeKind.Local).AddTicks(4720), new DateTime(2025, 7, 29, 22, 39, 57, 236, DateTimeKind.Local).AddTicks(4720), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateOFadd", "HighlightExpiryDate", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 9, 22, 39, 57, 236, DateTimeKind.Local).AddTicks(4730), new DateTime(2025, 7, 19, 22, 39, 57, 236, DateTimeKind.Local).AddTicks(4740), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 9, 22, 39, 57, 236, DateTimeKind.Local).AddTicks(4770), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 9, 22, 39, 57, 236, DateTimeKind.Local).AddTicks(4770), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 9, 22, 39, 57, 236, DateTimeKind.Local).AddTicks(4780), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 9, 22, 39, 57, 236, DateTimeKind.Local).AddTicks(4790), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateOFadd", "HighlightExpiryDate", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 9, 22, 39, 57, 236, DateTimeKind.Local).AddTicks(4790), new DateTime(2025, 7, 29, 22, 39, 57, 236, DateTimeKind.Local).AddTicks(4800), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 9, 22, 39, 57, 236, DateTimeKind.Local).AddTicks(4800), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateOFadd", "HighlightExpiryDate", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 9, 22, 39, 57, 236, DateTimeKind.Local).AddTicks(4810), new DateTime(2025, 7, 19, 22, 39, 57, 236, DateTimeKind.Local).AddTicks(4810), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 9, 22, 39, 57, 236, DateTimeKind.Local).AddTicks(4820), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 9, 22, 39, 57, 236, DateTimeKind.Local).AddTicks(4820), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 9, 22, 39, 57, 236, DateTimeKind.Local).AddTicks(4830), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateOFadd", "HighlightExpiryDate", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 9, 22, 39, 57, 236, DateTimeKind.Local).AddTicks(4830), new DateTime(2025, 7, 19, 22, 39, 57, 236, DateTimeKind.Local).AddTicks(4850), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 9, 22, 39, 57, 236, DateTimeKind.Local).AddTicks(4850), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 9, 22, 39, 57, 236, DateTimeKind.Local).AddTicks(4860), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 9, 22, 39, 57, 236, DateTimeKind.Local).AddTicks(4870), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 9, 22, 39, 57, 236, DateTimeKind.Local).AddTicks(4870), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 9, 22, 39, 57, 236, DateTimeKind.Local).AddTicks(4880), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 9, 22, 39, 57, 236, DateTimeKind.Local).AddTicks(4890), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 9, 22, 39, 57, 236, DateTimeKind.Local).AddTicks(4900), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 9, 22, 39, 57, 236, DateTimeKind.Local).AddTicks(4900), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 9, 22, 39, 57, 236, DateTimeKind.Local).AddTicks(4910), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 9, 22, 39, 57, 236, DateTimeKind.Local).AddTicks(4920), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateOFadd", "HighlightExpiryDate", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 9, 22, 39, 57, 236, DateTimeKind.Local).AddTicks(4920), new DateTime(2025, 7, 29, 22, 39, 57, 236, DateTimeKind.Local).AddTicks(4930), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 9, 22, 39, 57, 236, DateTimeKind.Local).AddTicks(4930), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5170));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5170));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5170));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5170));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5170));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5180));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5180));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5180));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5180));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5180));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5180));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5190));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5190));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5190));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5190));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5190));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5190));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5190));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5190));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5200));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5200));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5200));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5200));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5200));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5200));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5200));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5200));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5200));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5200));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5210));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5210));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5210));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 12, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5240));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5240));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 5,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5250));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 8,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 12, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5260));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 9,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5260));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 10,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5260));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 13,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 12, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5270));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 14,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5270));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 15,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5270));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 18,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 12, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5280));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 19,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5280));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 20,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5280));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 23,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 12, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5280));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 24,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5290));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 25,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5290));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 28,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 12, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5290));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 29,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5290));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 30,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5290));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 33,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 12, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5300));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 34,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5300));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 35,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5300));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 38,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 12, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5310));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 39,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5310));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 40,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5310));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 43,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 12, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5330));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 44,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5330));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 45,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5330));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 48,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 12, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5330));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 49,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5340));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 50,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5340));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 53,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 12, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5360));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 54,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5360));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 55,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5360));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 58,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 12, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5360));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 59,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5360));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 60,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5370));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 63,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 12, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5370));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 64,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5370));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 65,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5370));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 68,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 12, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5380));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 69,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5380));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 70,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5380));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 73,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 12, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5390));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 74,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5390));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 75,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5390));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 78,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 12, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5390));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 79,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5410));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 80,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5410));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 83,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 12, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5410));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 84,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5410));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 85,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5420));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 88,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 12, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5420));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 89,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5420));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 90,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5420));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 93,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 12, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5430));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 94,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5430));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 95,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5430));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 98,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 12, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5440));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 99,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5440));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 100,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5440));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 103,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 12, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5440));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 104,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5450));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 105,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5450));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 108,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 12, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5450));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 109,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5450));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 110,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5450));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 113,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 12, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5460));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 114,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5460));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 115,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5460));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 118,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 12, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5470));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 119,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5470));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 120,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5470));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 123,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 12, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5470));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 124,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5480));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 125,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5480));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 128,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 12, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5480));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 129,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5480));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 130,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5490));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 133,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 12, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5490));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 134,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5500));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 135,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5500));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 138,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 12, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5500));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 139,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5500));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 140,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 20, 39, 57, 236, DateTimeKind.Utc).AddTicks(5500));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "YfYSV+BAtpj99d6dajOgc2b5fxQ=", "zxNfUtZ6YShEmMvXM6+P/w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "ZDe0vBtCaDdlZzmdNYlgjLxksoI=", "8CAHuzQQ4OV6pjxgd4jGig==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "gZuR7SKM3YE6KGAehhSr+dyE5no=", "gjSqR3Q2aRcB1PRwfMG3XA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "gApGH53Da05EKt/BOvJTPBe6t2w=", "2tBr2u/2R5I1UIKT4jQKnA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "3jmFk5VJwX9DkoO/bt1K3QnyS1Q=", "zWCYAo9C/QqQZ2K0DCwnlA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "j9nHwZw4NL3U4hcgUD8dog5fVMk=", "8+Sf+r6wpNgY65bo59uG5w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "9oZK/ggqSZKIiH9DpREPLPQcDvw=", "gZq0a1SK4u+YtIhDUZXCAA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "nkZs2oPCIsUNSrXHRGZomA498yU=", "pAD2/+xiOX6A6HyxBIdULw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "dH86UXTAJQX7ZwLU7lOmuRTBNl4=", "6K3u4jjIABORSkkbAGIKqA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "nW/0Z/F+RsU+np4QwFsmxWPwKCg=", "HpzQIeWmEJq2f1m/7GPejA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "32QtGJsKBwWpl+xypmU6zPzgd9I=", "3FXJ7sBtu5HK9BGhLzP/2A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "/AEOJsvAK8ktp1XeErf7ZVbUXXc=", "srE+sk6N7YiJ4XUYUG3vew==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "9++8yRHe3s9UCMp6J7cfHDpBQk8=", "pDGmArJXpXDwBykxAOqPBw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "KGfYrDSnezS5LS7M87ginHcQ2zA=", "dgsnSs1mgTHFnRq/pDO8Rw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "t5V1BQ+QqeTdcBfd9PvsO56nsRo=", "r4dWhcs8N87ZA2j74IUcfw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "TD0UuE9ePSsECao5rmWjSbToCpU=", "1dKsv52ZQHR6jlJ1wX1MzQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "9aHW+ROwoVEO4qolgOqW0XCe6QU=", "gQOx3xVZlb8J9SY0GQX3Zg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "kIiPjZttMScNo3QMZy4148KHhpU=", "ce/1fR8BSJUKltZjfEQZZg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "mcZ7sMlmBwIR9KXMZn614seJi8U=", "NUQ0axDVk109e7j3Fvn/qg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "wivm223dRnw20VPwDaqxxEY387M=", "68hlz3Bn9mZr+g9Yumc/MA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "6mRcvs+zy91zPjSJr+LK7W3iHPw=", "syyOd1hakA5DVKWe3nKmoA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "5Omb7Rc1DJzMNkfBQUfSq5wY0dM=", "dJtBrPTTb+Qdd56n1031gA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "zxqule9xLnV6UBHjRP3gE6BDy04=", "MRIt9kfhb4o7saTvpHOCvw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "bj7AulDl3Gh8bDyPTDPxULdW6XY=", "x2TkYUToMPqVyPrkWelnVg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "b2xqR98eXKn2iD+NYmbXnKsDFZA=", "DLJbgJYiT43TCBidC3NaDg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "PslAmRNJvc8J6ScdLURlchxB0aM=", "S+G/8v/UVpBRUyJKK1fK1g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "U9AIbLILkNXj8KUCOP7UjD5lWK4=", "hVTPdZGyVXTpmRy7j52g9w==" });

            migrationBuilder.AddForeignKey(
                name: "FK_TransakcijaLogs_Transakcije_Transakcija25062025Id",
                table: "TransakcijaLogs",
                column: "Transakcija25062025Id",
                principalTable: "Transakcije",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TransakcijaLogs_Transakcije_Transakcija25062025Id",
                table: "TransakcijaLogs");

            migrationBuilder.RenameColumn(
                name: "Transakcija25062025Id",
                table: "TransakcijaLogs",
                newName: "transakcija25062025Id");

            migrationBuilder.RenameIndex(
                name: "IX_TransakcijaLogs_Transakcija25062025Id",
                table: "TransakcijaLogs",
                newName: "IX_TransakcijaLogs_transakcija25062025Id");

            migrationBuilder.AddColumn<int>(
                name: "TransakcijaId",
                table: "TransakcijaLogs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateOFadd", "HighlightExpiryDate" },
                values: new object[] { new DateTime(2025, 7, 9, 21, 53, 26, 433, DateTimeKind.Local).AddTicks(6060), new DateTime(2025, 7, 11, 21, 53, 26, 433, DateTimeKind.Local).AddTicks(6120) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 9, 21, 53, 26, 433, DateTimeKind.Local).AddTicks(6130), null, null });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 9, 21, 53, 26, 433, DateTimeKind.Local).AddTicks(6140), null, null });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 9, 21, 53, 26, 433, DateTimeKind.Local).AddTicks(6140), null, null });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateOFadd", "HighlightExpiryDate", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 9, 21, 53, 26, 433, DateTimeKind.Local).AddTicks(6150), new DateTime(2025, 7, 29, 21, 53, 26, 433, DateTimeKind.Local).AddTicks(6160), null, null });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateOFadd", "HighlightExpiryDate", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 9, 21, 53, 26, 433, DateTimeKind.Local).AddTicks(6160), new DateTime(2025, 7, 19, 21, 53, 26, 433, DateTimeKind.Local).AddTicks(6160), null, null });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 9, 21, 53, 26, 433, DateTimeKind.Local).AddTicks(6170), null, null });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 9, 21, 53, 26, 433, DateTimeKind.Local).AddTicks(6170), null, null });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 9, 21, 53, 26, 433, DateTimeKind.Local).AddTicks(6180), null, null });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 9, 21, 53, 26, 433, DateTimeKind.Local).AddTicks(6190), null, null });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateOFadd", "HighlightExpiryDate", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 9, 21, 53, 26, 433, DateTimeKind.Local).AddTicks(6190), new DateTime(2025, 7, 29, 21, 53, 26, 433, DateTimeKind.Local).AddTicks(6200), null, null });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 9, 21, 53, 26, 433, DateTimeKind.Local).AddTicks(6200), null, null });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateOFadd", "HighlightExpiryDate", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 9, 21, 53, 26, 433, DateTimeKind.Local).AddTicks(6210), new DateTime(2025, 7, 19, 21, 53, 26, 433, DateTimeKind.Local).AddTicks(6210), null, null });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 9, 21, 53, 26, 433, DateTimeKind.Local).AddTicks(6260), null, null });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 9, 21, 53, 26, 433, DateTimeKind.Local).AddTicks(6260), null, null });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 9, 21, 53, 26, 433, DateTimeKind.Local).AddTicks(6270), null, null });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateOFadd", "HighlightExpiryDate", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 9, 21, 53, 26, 433, DateTimeKind.Local).AddTicks(6270), new DateTime(2025, 7, 19, 21, 53, 26, 433, DateTimeKind.Local).AddTicks(6280), null, null });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 9, 21, 53, 26, 433, DateTimeKind.Local).AddTicks(6280), null, null });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 9, 21, 53, 26, 433, DateTimeKind.Local).AddTicks(6290), null, null });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 9, 21, 53, 26, 433, DateTimeKind.Local).AddTicks(6300), null, null });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 9, 21, 53, 26, 433, DateTimeKind.Local).AddTicks(6300), null, null });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 9, 21, 53, 26, 433, DateTimeKind.Local).AddTicks(6310), null, null });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 9, 21, 53, 26, 433, DateTimeKind.Local).AddTicks(6310), null, null });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 9, 21, 53, 26, 433, DateTimeKind.Local).AddTicks(6320), null, null });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 9, 21, 53, 26, 433, DateTimeKind.Local).AddTicks(6330), null, null });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 9, 21, 53, 26, 433, DateTimeKind.Local).AddTicks(6330), null, null });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 9, 21, 53, 26, 433, DateTimeKind.Local).AddTicks(6340), null, null });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateOFadd", "HighlightExpiryDate", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 9, 21, 53, 26, 433, DateTimeKind.Local).AddTicks(6350), new DateTime(2025, 7, 29, 21, 53, 26, 433, DateTimeKind.Local).AddTicks(6350), null, null });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 9, 21, 53, 26, 433, DateTimeKind.Local).AddTicks(6360), null, null });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6570));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6570));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6570));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6580));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6580));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6580));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6580));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6580));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6580));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6580));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6580));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6590));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6590));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6590));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6590));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6590));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6590));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6590));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6590));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6590));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6600));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6600));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6600));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6600));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6600));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6600));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6600));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6600));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6600));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6610));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6610));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6610));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 12, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6650));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6650));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 5,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6650));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 8,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 12, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6660));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 9,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6660));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 10,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6660));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 13,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 12, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6670));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 14,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6670));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 15,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6670));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 18,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 12, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6670));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 19,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6670));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 20,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6680));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 23,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 12, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6680));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 24,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6680));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 25,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6680));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 28,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 12, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6690));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 29,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6690));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 30,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6690));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 33,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 12, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6700));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 34,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6700));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 35,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6700));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 38,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 12, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6700));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 39,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6700));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 40,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6710));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 43,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 12, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6710));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 44,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6710));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 45,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6710));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 48,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 12, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6720));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 49,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6720));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 50,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6720));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 53,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 12, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6730));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 54,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6730));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 55,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6730));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 58,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 12, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6740));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 59,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6740));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 60,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6740));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 63,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 12, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6740));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 64,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6740));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 65,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6750));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 68,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 12, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6750));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 69,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6750));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 70,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6750));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 73,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 12, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6760));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 74,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6760));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 75,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6760));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 78,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 12, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6770));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 79,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6770));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 80,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6770));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 83,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 12, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6810));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 84,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6810));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 85,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6810));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 88,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 12, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6820));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 89,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6820));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 90,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6820));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 93,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 12, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6830));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 94,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6830));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 95,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6830));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 98,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 12, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6830));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 99,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6840));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 100,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6840));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 103,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 12, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6840));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 104,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6840));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 105,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6840));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 108,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 12, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6850));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 109,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6850));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 110,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6850));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 113,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 12, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6860));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 114,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6860));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 115,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6860));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 118,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 12, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6860));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 119,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6870));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 120,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6870));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 123,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 12, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6870));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 124,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6870));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 125,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6870));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 128,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 12, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6880));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 129,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6880));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 130,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6880));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 133,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 12, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6890));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 134,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6890));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 135,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6890));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 138,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 12, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6890));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 139,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6890));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 140,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 19, 53, 26, 433, DateTimeKind.Utc).AddTicks(6900));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "fd6Q1ffdFhrJXV/6t+yNKEpAzX0=", "DPCQ2QXmbBC8ixs8kz54bg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "9Bt/+OHgLcoVV9thFtm0Y0bOaRg=", "wRTLW10w8fkUylL+vBXmnQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "hm/oHTVlJpkwoid44xo2dHMBje0=", "3BTli628qnDJLsyj2TPRuw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "VP8irm1S2tjokfpjTweMbJx1FiY=", "pfc7GSCntJ+o5XA5KvQxdA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "Ks5CTLiJa1Yqi50SM8Ax6RB55lA=", "DH/YDY8jswVispeN8SHDHw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "NIlz9yQ5fvOdUim2u4NDIynndbc=", "A1AOmQFSVo8SgM/bRN+Jkw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "445P2+sSsK9L38PWkbBMoVWZB9M=", "O3Gxnbo9t2YD1QSQN5shlg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "SXXE1nRZ9yfpfCt1sTD33SIPoOc=", "o1+A1JqemqF8s/nsp1HGaA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "69D3VOtoo1Y3OupU4Sb9VNDuhd4=", "udnyo0KGqh3Zuxrxvv8WEA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "/ZxmlPAr58wV/SsWGoN1SeveP6M=", "P+pbp8+1tO7W0q7DwTO0Pw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "rUXyG+N1b5Hn1nyvgSLKKfC4Vus=", "lWPYg5MZUoL3+Jw33+Y9Ig==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "HvyzothEK2vSDSVeJcQkKwNCFFc=", "/FQMPkXxCmUFQd75bOqM6A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "bZVqZK4aSsMCPpITnuTONN1oY/g=", "UQVkCXkY+gpyC/RYwONAcA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "qrYtPYjkNPk/1pbNNS4aP+171AA=", "nPlMD9BUbNKBWoBiSQjcUQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "D5KC0/bOqBim+7dhOKa/Im6Y5IU=", "51+cz1r2RLz/y0WwqlAJ7w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "f8Zn9mzXc0ZAf5h03Q92WT3LA7A=", "flJdpPJtJ7LtDcZIiUYIIw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "PY51cxqbkPWSEAeypvjT75xpOd4=", "GJEZ+0a04wOiZmJhaBulmQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "k9GtlICE/IRx7UzhWaLcoR/vwWc=", "d0JdInHXDFxTQuOllJZX6w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "QG+y5l+cyTdFmMgAHLD+GlfcRNs=", "ORrDrYwOGyu3oLi2LdO6Ig==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "VEWcHHsi9Ky3hQWhhCkGNDLuEl8=", "UBzcogvtLmH9VaRwmJRRhg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "SLj+9ptUMQidcQjtg4/NbgSV++A=", "boJv4VfjiZqAqO+3eGpMYw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "Q7GXz+3rtyyOTbF2FNGK+x10ink=", "G/Dxl4x3J6x4n7Po2i5VEg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "VjsM5OyO6+sEyIbGfXU6aw7T85E=", "9AexFHHuvgRpRNOuS/gsYw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "V6n54iigjdKAJl5quzy8WDGBoSQ=", "n/cvSa9abVCb6NNfsImOdQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "3Skpc3Lh2eshzRjmyoXlZ70EL9I=", "hVc1vPNhBa23S6QBU3BxfA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "Hw2ws6aVi43Em0NyC5CkPSETuqU=", "mxYMU3NRQ0o2ZeSSvEMdIQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "aJNvq5YfFXfOYK7WHNsg19dDoio=", "b8S5Ls3zwLo5V0gP4LOyVw==" });

            migrationBuilder.AddForeignKey(
                name: "FK_TransakcijaLogs_Transakcije_transakcija25062025Id",
                table: "TransakcijaLogs",
                column: "transakcija25062025Id",
                principalTable: "Transakcije",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
