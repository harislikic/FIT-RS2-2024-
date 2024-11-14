using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoTrade.Migrations
{
    /// <inheritdoc />
    public partial class AddHighlightFieldsToAutomobileAd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "HighlightExpiryDate",
                table: "AutomobileAds",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsHighlighted",
                table: "AutomobileAds",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HighlightExpiryDate",
                table: "AutomobileAds");

            migrationBuilder.DropColumn(
                name: "IsHighlighted",
                table: "AutomobileAds");
        }
    }
}
