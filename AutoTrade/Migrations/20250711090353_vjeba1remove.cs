using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoTrade.Migrations
{
    /// <inheritdoc />
    public partial class vjeba1remove : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
	IF OBJECT_ID('MoodTrackers', 'U') IS NOT NULL
		DROP TABLE MoodTrackers;
");

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateOFadd", "HighlightExpiryDate" },
                values: new object[] { new DateTime(2025, 7, 11, 11, 3, 52, 895, DateTimeKind.Local).AddTicks(8280), new DateTime(2025, 7, 13, 11, 3, 52, 895, DateTimeKind.Local).AddTicks(8330) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 11, 11, 3, 52, 895, DateTimeKind.Local).AddTicks(8340), new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 11, 11, 3, 52, 895, DateTimeKind.Local).AddTicks(8350), new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 11, 11, 3, 52, 895, DateTimeKind.Local).AddTicks(8360), new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateOFadd", "HighlightExpiryDate", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 11, 11, 3, 52, 895, DateTimeKind.Local).AddTicks(8360), new DateTime(2025, 7, 31, 11, 3, 52, 895, DateTimeKind.Local).AddTicks(8370), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateOFadd", "HighlightExpiryDate", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 11, 11, 3, 52, 895, DateTimeKind.Local).AddTicks(8370), new DateTime(2025, 7, 21, 11, 3, 52, 895, DateTimeKind.Local).AddTicks(8380), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 11, 11, 3, 52, 895, DateTimeKind.Local).AddTicks(8380), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 11, 11, 3, 52, 895, DateTimeKind.Local).AddTicks(8390), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 11, 11, 3, 52, 895, DateTimeKind.Local).AddTicks(8400), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 11, 11, 3, 52, 895, DateTimeKind.Local).AddTicks(8410), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateOFadd", "HighlightExpiryDate", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 11, 11, 3, 52, 895, DateTimeKind.Local).AddTicks(8410), new DateTime(2025, 7, 31, 11, 3, 52, 895, DateTimeKind.Local).AddTicks(8420), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 11, 11, 3, 52, 895, DateTimeKind.Local).AddTicks(8420), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateOFadd", "HighlightExpiryDate", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 11, 11, 3, 52, 895, DateTimeKind.Local).AddTicks(8430), new DateTime(2025, 7, 21, 11, 3, 52, 895, DateTimeKind.Local).AddTicks(8430), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 11, 11, 3, 52, 895, DateTimeKind.Local).AddTicks(8440), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 11, 11, 3, 52, 895, DateTimeKind.Local).AddTicks(8440), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 11, 11, 3, 52, 895, DateTimeKind.Local).AddTicks(8450), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateOFadd", "HighlightExpiryDate", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 11, 11, 3, 52, 895, DateTimeKind.Local).AddTicks(8460), new DateTime(2025, 7, 21, 11, 3, 52, 895, DateTimeKind.Local).AddTicks(8460), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 11, 11, 3, 52, 895, DateTimeKind.Local).AddTicks(8470), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 11, 11, 3, 52, 895, DateTimeKind.Local).AddTicks(8470), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 11, 11, 3, 52, 895, DateTimeKind.Local).AddTicks(8480), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 11, 11, 3, 52, 895, DateTimeKind.Local).AddTicks(8490), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 11, 11, 3, 52, 895, DateTimeKind.Local).AddTicks(8490), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 11, 11, 3, 52, 895, DateTimeKind.Local).AddTicks(8500), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 11, 11, 3, 52, 895, DateTimeKind.Local).AddTicks(8500), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 11, 11, 3, 52, 895, DateTimeKind.Local).AddTicks(8510), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 11, 11, 3, 52, 895, DateTimeKind.Local).AddTicks(8530), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 11, 11, 3, 52, 895, DateTimeKind.Local).AddTicks(8540), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateOFadd", "HighlightExpiryDate", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 11, 11, 3, 52, 895, DateTimeKind.Local).AddTicks(8540), new DateTime(2025, 7, 31, 11, 3, 52, 895, DateTimeKind.Local).AddTicks(8550), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 11, 11, 3, 52, 895, DateTimeKind.Local).AddTicks(8550), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(8760));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(8760));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(8760));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(8760));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(8760));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(8770));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(8770));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(8770));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(8770));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(8770));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(8770));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(8770));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(8770));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(8780));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(8780));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(8780));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(8780));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(8780));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(8780));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(8800));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(8800));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(8800));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(8800));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(8800));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(8800));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(8800));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(8800));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(8800));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(8810));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(8810));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(8810));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(8810));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(8840));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(8850));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 5,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 18, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(8850));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 6,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 7,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 8,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(8850));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 9,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(8850));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 10,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 18, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(8860));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 11,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 12,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 13,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(8860));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 14,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(8860));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 15,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 18, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(8870));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 16,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 17,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 18,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(8870));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 19,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(8870));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 20,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 18, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(8870));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 21,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 22,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 23,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(8880));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 24,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(8880));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 25,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 18, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(8880));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 26,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 27,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 28,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(8890));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 29,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(8890));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 30,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 18, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(8890));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 31,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 32,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 33,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(8890));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 34,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(8900));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 35,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 18, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(8900));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 36,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 37,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 38,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(8900));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 39,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(8900));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 40,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 18, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(8900));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 41,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 42,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 43,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(8910));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 44,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(8910));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 45,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 18, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(8910));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 46,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 47,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 48,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(8920));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 49,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(8920));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 50,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 18, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(8920));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 51,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 52,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 53,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(8930));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 54,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(8930));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 55,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 18, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(8930));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 56,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 57,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 58,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(8930));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 59,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(8940));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 60,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 18, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(8940));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 61,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 62,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 63,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(8940));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 64,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(8940));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 65,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 18, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(8950));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 66,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 67,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 68,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(8950));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 69,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(8960));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 70,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 18, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(8960));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 71,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 72,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 73,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(8960));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 74,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(8960));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 75,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 18, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(8960));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 76,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 77,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 78,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(8970));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 79,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(8970));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 80,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 18, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(8970));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 81,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 82,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 83,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(8980));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 84,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(8980));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 85,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 18, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(8980));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 86,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 87,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 88,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(8990));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 89,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(8990));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 90,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 18, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(8990));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 91,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 92,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 93,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(8990));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 94,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(8990));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 95,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 18, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(9000));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 96,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 97,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 98,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(9000));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 99,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(9000));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 100,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 18, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(9000));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 101,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 102,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 103,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(9010));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 104,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(9010));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 105,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 18, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(9010));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 106,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 107,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 108,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(9020));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 109,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(9020));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 110,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 18, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(9020));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 111,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 112,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 113,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(9020));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 114,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(9020));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 115,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 18, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(9030));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 116,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 117,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 118,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(9030));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 119,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(9030));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 120,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 18, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(9030));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 121,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 122,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 123,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(9040));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 124,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(9040));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 125,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 18, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(9040));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 126,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 127,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 128,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(9050));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 129,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(9050));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 130,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 18, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(9050));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 131,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 132,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 133,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(9060));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 134,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(9060));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 135,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 18, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(9060));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 136,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 137,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 138,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 14, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(9060));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 139,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 16, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(9060));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 140,
                column: "ReservationDate",
                value: new DateTime(2025, 7, 18, 9, 3, 52, 895, DateTimeKind.Utc).AddTicks(9070));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "Qe4l3WUfL7BKzt9mdPcRhyBWH4I=", "vuput3WtSA4Izcb217+xcw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "JDs8PE6Z0E915qX7kbdxtUI2Z9A=", "YCO+RiMlrA6ju5mflf9inA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "vdd0qHNUavz79jkjXDk8YH0lTVQ=", "c2BPNMA436Htv9XejusO2Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "KNHHBGro151aQSLpzmGAUZyoLkM=", "ZinL4WmZmnIdNqqY+WaHjg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "lp6/yjEIAedvkvHkVL33fLQD4Bs=", "iyy9CVaVeG4jKEDny+sDMA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "D6oAnMW0J4GKTdDnHmGBzEUCQlg=", "iIh12zV7IzNA5eDd5WQ63A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "9HL0sEWGlfl8fWYbHneTyRwCC8E=", "Rd8kaGwovd5yAm2+YYrhJA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "MOCiKBxm+B0WECqRgKwIo/xk7Q4=", "ue1GS5aOOwFt7OSjyDyCLw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "5Zk3qva+YPbt6fcjqefwHG0I8kg=", "2pl74wekEih4exjybO9afQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "UkZ8ScGHvwXGYZt/2FDspR5WPCI=", "agZfETyFZ0E6c+rv6maZPA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "apzLjz0kkDcptI65cG6M8aI2ylM=", "mri8aPWEUke6dlB/4QF1kA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "Hi2/+deDNh0Z0FBJ8UZaPB0avps=", "/YBC4vvFD5GrqkajEwIOPw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "HBI4ZgeeadNAUxII/AD8piIQuqg=", "8Nwr2Dtbw6Z6Elv/ywwTPw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "FA1i6PhYkG9AbHkYtnaS5upnp3E=", "JHidakvXxW14PjL6/MpOWQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "ZkXbNd5DVHT4kmArQi2x34dkHzQ=", "1gpAJC8sccI7Dje5/Za0DA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "Aa2UVT+ipfurSt+S8KHm4770omI=", "tYh6vqwpq1riuOb5J8pCLQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "ajfiPAyH/+cjrsMHjLTi2OKhNxE=", "VnkepXdg9YN+Kv+mmIHOCA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "ht1nO/VB8JaAoFjUGFzNfI+hO8I=", "VQ7qsy3KpX88ZdZbAUUQKQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "Kh8yFBmcmqS0P5YrJzZ6X5s5TRk=", "zOC1ydzr9JfZUt6dMoah0A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "kSr4alsPz9LO9F/9PI7flB4/fW0=", "ZiYWOQ/ucpYJHgA2j2FBpg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "/oM8KfaM2O8hiWzxPm8qB7RJDlI=", "f7QtdYNX5e+B3Zo/rosNIA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "k+m7ThUVaCY7x9SWLrFdIF4tcYc=", "gFGtZ8hFi5Yh8sPiO9c+uw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "RA56gz4cPD7NWsn6F2pJOpBqR8s=", "YskIBiox69xlPUcZlfyF/w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "2TqvBfxPNP5cTYXb6mUUvEma6rM=", "o+p2C87/AbiLHC+Ga/CgcQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "+mPsDqj26Qn2sBV9rTOuyWlgYao=", "IxdkKadDHIzL5qf9y1qxKg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "RuX9+aSPt3Lro+z0smWZTufgyUs=", "rhy8Mw8L9Z0B5zut/BhYyw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "jE4c0TFGSP9+fnsy8U6D+whm22g=", "3sO/0IxvzjjG1xb8v8JVpA==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MoodTrackers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mood = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MoodDate = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                values: new object[] { new DateTime(2025, 3, 23, 12, 55, 57, 796, DateTimeKind.Local).AddTicks(5170), null, null });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 3, 23, 12, 55, 57, 796, DateTimeKind.Local).AddTicks(5180), null, null });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 3, 23, 12, 55, 57, 796, DateTimeKind.Local).AddTicks(5180), null, null });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateOFadd", "HighlightExpiryDate", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 3, 23, 12, 55, 57, 796, DateTimeKind.Local).AddTicks(5190), new DateTime(2025, 4, 12, 12, 55, 57, 796, DateTimeKind.Local).AddTicks(5190), null, null });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateOFadd", "HighlightExpiryDate", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 3, 23, 12, 55, 57, 796, DateTimeKind.Local).AddTicks(5190), new DateTime(2025, 4, 2, 12, 55, 57, 796, DateTimeKind.Local).AddTicks(5210), null, null });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 3, 23, 12, 55, 57, 796, DateTimeKind.Local).AddTicks(5210), null, null });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 3, 23, 12, 55, 57, 796, DateTimeKind.Local).AddTicks(5210), null, null });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 3, 23, 12, 55, 57, 796, DateTimeKind.Local).AddTicks(5220), null, null });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 3, 23, 12, 55, 57, 796, DateTimeKind.Local).AddTicks(5230), null, null });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateOFadd", "HighlightExpiryDate", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 3, 23, 12, 55, 57, 796, DateTimeKind.Local).AddTicks(5240), new DateTime(2025, 4, 12, 12, 55, 57, 796, DateTimeKind.Local).AddTicks(5250), null, null });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 3, 23, 12, 55, 57, 796, DateTimeKind.Local).AddTicks(5250), null, null });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateOFadd", "HighlightExpiryDate", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 3, 23, 12, 55, 57, 796, DateTimeKind.Local).AddTicks(5250), new DateTime(2025, 4, 2, 12, 55, 57, 796, DateTimeKind.Local).AddTicks(5260), null, null });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 3, 23, 12, 55, 57, 796, DateTimeKind.Local).AddTicks(5260), null, null });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 3, 23, 12, 55, 57, 796, DateTimeKind.Local).AddTicks(5270), null, null });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 3, 23, 12, 55, 57, 796, DateTimeKind.Local).AddTicks(5270), null, null });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateOFadd", "HighlightExpiryDate", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 3, 23, 12, 55, 57, 796, DateTimeKind.Local).AddTicks(5280), new DateTime(2025, 4, 2, 12, 55, 57, 796, DateTimeKind.Local).AddTicks(5290), null, null });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 3, 23, 12, 55, 57, 796, DateTimeKind.Local).AddTicks(5290), null, null });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 3, 23, 12, 55, 57, 796, DateTimeKind.Local).AddTicks(5300), null, null });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 3, 23, 12, 55, 57, 796, DateTimeKind.Local).AddTicks(5300), null, null });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 3, 23, 12, 55, 57, 796, DateTimeKind.Local).AddTicks(5310), null, null });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 3, 23, 12, 55, 57, 796, DateTimeKind.Local).AddTicks(5310), null, null });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 3, 23, 12, 55, 57, 796, DateTimeKind.Local).AddTicks(5320), null, null });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 3, 23, 12, 55, 57, 796, DateTimeKind.Local).AddTicks(5330), null, null });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 3, 23, 12, 55, 57, 796, DateTimeKind.Local).AddTicks(5330), null, null });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 3, 23, 12, 55, 57, 796, DateTimeKind.Local).AddTicks(5340), null, null });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 3, 23, 12, 55, 57, 796, DateTimeKind.Local).AddTicks(5350), null, null });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateOFadd", "HighlightExpiryDate", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 3, 23, 12, 55, 57, 796, DateTimeKind.Local).AddTicks(5350), new DateTime(2025, 4, 12, 12, 55, 57, 796, DateTimeKind.Local).AddTicks(5360), null, null });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 3, 23, 12, 55, 57, 796, DateTimeKind.Local).AddTicks(5360), null, null });

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
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "HUoUvbIG9CoHvRZ4K68Cqqs7Zmc=", "8qQgS/dLNq6lEBVg7x7rIg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "JUO8GDQ53TCf5pSkLZYC15Mu1xk=", "uf3CfviBxrUns0BSlw4iZw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "FbE289qtd6FKPCNhVXG+n5BPpXU=", "fjJbAOfKeNhRPlOye1rt9g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "AmiDLOQ7WxnaX2f7H7ZV7uV4duI=", "DLKeb1HIo/V/jeApO/I0ug==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "oNZywlIPFN/NY6JR1xTthuG2bDc=", "3fwsYZRKyqn7NeOBhkiqqQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "04pCxNUaEchp1NbawaybAe5xriQ=", "8ROACtwcm07JM0tF+c5wOA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "AkFYLfa1fV+4rME8tM8nKtKPqJE=", "W/+EkzvM3BXuGU5FjKW9CQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "2Ln5JSF969OenizFKSH4hfg+MTs=", "nubwy/Er4u36oQ4vMSaMIA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "BAkUe/3MCV6EJ46dr6uncEE8rA0=", "4moDEv1hbzmMxGD6evswVw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "UsgxHOPujMGdDqPxW7yLRRzdNP4=", "SFL8PsDSfUST/lqCa6ap4w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "XJVZB+G3M7wjUKgk00PjYB7ZymY=", "4wm4PsOzB8CK8Za0b+X1uA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "IS9WsfDm37WCYU5uX+MklRORetQ=", "QrdrrFQUmRAWvGxpPOoCzw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "kMgXmEBmxsoWeFdaBrdZFoAsTDs=", "W4hl4XGtL4vrsaE8b0KgSw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "NH1cTkdM6OgiWKRNBaqmaWZcock=", "ANTfSwEaPSAwpS08up9+DQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "cE/MP3c4T0hxLJ2V67mU52G1aFk=", "/no2aoltJMmZyDKJH7FsiA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "Gck7qgZvNEsl9lhoVBatlOB3uK0=", "x8mMEI4mD8S2ol8dRfbD1w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "V5vHfPbDIIzdMll5ch7vP0SeAZY=", "gijWg9+m7aWHkmA6Pw/Big==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "rpATzLMysbKCiSZ0tflKsX3rVi0=", "p1zYNtGvzYyFvj8F9MxMYA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "RIIaSBeeTOTTSptMC6Y6U6xk7ec=", "33p7oUL5/CJwPsfkifNpiw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "IzTgC/VK7uWIQF6sDROSyeBBTgU=", "ouAS2ZD6pp6CZDn8T1zkJA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "jhuT66+JpQDEKZNgilKESxa6YWo=", "66fG57mJb/WvNrNqUxeADA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "Va99Qo8H1tWN2FPTvNP5R5pgziI=", "vraDQWjH8CJAKJzcrEOtBQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "8GLmMxarV820kTFw0FLJ+Nb5IeE=", "tjR89IWzAMoYPoPaL94Qzw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "+4KQd6QkrfgZzL61dkwD99aRHPA=", "KP5ZkwH1ViIPbyMEN0a9sA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "P2nShRw/YuUE9WZ1U2C4I/UN49U=", "b/H8iEL7JoOArv4Pw9a9bQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "1YUFUTrePeFIvWJKfrlxwLO8cdQ=", "hgO1PQh2ayicT1QtodCKoA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "rcrjvlRDd7cnEbUFIIt4GbWnEdo=", "oIPmjI64Cotrn98UroTbgg==" });

            migrationBuilder.CreateIndex(
                name: "IX_MoodTrackers_UserId",
                table: "MoodTrackers",
                column: "UserId");
        }
    }
}
