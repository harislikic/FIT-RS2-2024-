using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoTrade.Migrations
{
    /// <inheritdoc />
    public partial class vjezba1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MoodTrackers");

            migrationBuilder.CreateTable(
                name: "KategorijaTransackije",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tip = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KategorijaTransackije", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FinansijskiLimit",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KategorijaTransackijeId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    MaksimalniIznos = table.Column<int>(type: "int", nullable: false),
                    Mjesec = table.Column<int>(type: "int", nullable: false),
                    Godina = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinansijskiLimit", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FinansijskiLimit_KategorijaTransackije_KategorijaTransackijeId",
                        column: x => x.KategorijaTransackijeId,
                        principalTable: "KategorijaTransackije",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FinansijskiLimit_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Transakcije",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    Iznos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DatumTransakcije = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Opis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KategorijaTransackijeId = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transakcije", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transakcije_KategorijaTransackije_KategorijaTransackijeId",
                        column: x => x.KategorijaTransackijeId,
                        principalTable: "KategorijaTransackije",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Transakcije_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TransakcijaLogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransakcijaId = table.Column<int>(type: "int", nullable: false),
                    transakcija25062025Id = table.Column<int>(type: "int", nullable: false),
                    StaraVrijednost = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NovaVrijednost = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VrijemePromjene = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransakcijaLogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TransakcijaLogs_Transakcije_transakcija25062025Id",
                        column: x => x.transakcija25062025Id,
                        principalTable: "Transakcije",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TransakcijaLogs_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

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
                values: new object[] { new DateTime(2025, 7, 9, 21, 53, 26, 433, DateTimeKind.Local).AddTicks(6130), new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 9, 21, 53, 26, 433, DateTimeKind.Local).AddTicks(6140), new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 9, 21, 53, 26, 433, DateTimeKind.Local).AddTicks(6140), new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateOFadd", "HighlightExpiryDate", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 9, 21, 53, 26, 433, DateTimeKind.Local).AddTicks(6150), new DateTime(2025, 7, 29, 21, 53, 26, 433, DateTimeKind.Local).AddTicks(6160), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateOFadd", "HighlightExpiryDate", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 9, 21, 53, 26, 433, DateTimeKind.Local).AddTicks(6160), new DateTime(2025, 7, 19, 21, 53, 26, 433, DateTimeKind.Local).AddTicks(6160), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 9, 21, 53, 26, 433, DateTimeKind.Local).AddTicks(6170), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 9, 21, 53, 26, 433, DateTimeKind.Local).AddTicks(6170), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 9, 21, 53, 26, 433, DateTimeKind.Local).AddTicks(6180), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 9, 21, 53, 26, 433, DateTimeKind.Local).AddTicks(6190), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateOFadd", "HighlightExpiryDate", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 9, 21, 53, 26, 433, DateTimeKind.Local).AddTicks(6190), new DateTime(2025, 7, 29, 21, 53, 26, 433, DateTimeKind.Local).AddTicks(6200), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 9, 21, 53, 26, 433, DateTimeKind.Local).AddTicks(6200), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateOFadd", "HighlightExpiryDate", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 9, 21, 53, 26, 433, DateTimeKind.Local).AddTicks(6210), new DateTime(2025, 7, 19, 21, 53, 26, 433, DateTimeKind.Local).AddTicks(6210), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 9, 21, 53, 26, 433, DateTimeKind.Local).AddTicks(6260), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 9, 21, 53, 26, 433, DateTimeKind.Local).AddTicks(6260), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 9, 21, 53, 26, 433, DateTimeKind.Local).AddTicks(6270), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateOFadd", "HighlightExpiryDate", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 9, 21, 53, 26, 433, DateTimeKind.Local).AddTicks(6270), new DateTime(2025, 7, 19, 21, 53, 26, 433, DateTimeKind.Local).AddTicks(6280), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 9, 21, 53, 26, 433, DateTimeKind.Local).AddTicks(6280), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 9, 21, 53, 26, 433, DateTimeKind.Local).AddTicks(6290), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 9, 21, 53, 26, 433, DateTimeKind.Local).AddTicks(6300), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 9, 21, 53, 26, 433, DateTimeKind.Local).AddTicks(6300), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 9, 21, 53, 26, 433, DateTimeKind.Local).AddTicks(6310), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 9, 21, 53, 26, 433, DateTimeKind.Local).AddTicks(6310), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 9, 21, 53, 26, 433, DateTimeKind.Local).AddTicks(6320), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 9, 21, 53, 26, 433, DateTimeKind.Local).AddTicks(6330), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 9, 21, 53, 26, 433, DateTimeKind.Local).AddTicks(6330), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 9, 21, 53, 26, 433, DateTimeKind.Local).AddTicks(6340), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateOFadd", "HighlightExpiryDate", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 9, 21, 53, 26, 433, DateTimeKind.Local).AddTicks(6350), new DateTime(2025, 7, 29, 21, 53, 26, 433, DateTimeKind.Local).AddTicks(6350), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomobileAds",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateOFadd", "Last_Big_Service", "Last_Small_Service" },
                values: new object[] { new DateTime(2025, 7, 9, 21, 53, 26, 433, DateTimeKind.Local).AddTicks(6360), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

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

            migrationBuilder.CreateIndex(
                name: "IX_FinansijskiLimit_KategorijaTransackijeId",
                table: "FinansijskiLimit",
                column: "KategorijaTransackijeId");

            migrationBuilder.CreateIndex(
                name: "IX_FinansijskiLimit_UserId",
                table: "FinansijskiLimit",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_TransakcijaLogs_transakcija25062025Id",
                table: "TransakcijaLogs",
                column: "transakcija25062025Id");

            migrationBuilder.CreateIndex(
                name: "IX_TransakcijaLogs_UserId",
                table: "TransakcijaLogs",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Transakcije_KategorijaTransackijeId",
                table: "Transakcije",
                column: "KategorijaTransackijeId");

            migrationBuilder.CreateIndex(
                name: "IX_Transakcije_UserId",
                table: "Transakcije",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FinansijskiLimit");

            migrationBuilder.DropTable(
                name: "TransakcijaLogs");

            migrationBuilder.DropTable(
                name: "Transakcije");

            migrationBuilder.DropTable(
                name: "KategorijaTransackije");

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
