using Microsoft.EntityFrameworkCore.Migrations;

namespace ParkQuest.Migrations
{
    public partial class modifyseededdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 2,
                column: "HasRestrooms",
                value: "Unknown");

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 7,
                column: "HasRestrooms",
                value: "Unknown");

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 22,
                column: "HasRestrooms",
                value: "Unknown");

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 25,
                column: "HasRestrooms",
                value: "Unknown");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 2,
                column: "HasRestrooms",
                value: "Yes");

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 7,
                column: "HasRestrooms",
                value: "No");

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 22,
                column: "HasRestrooms",
                value: "Yes");

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 25,
                column: "HasRestrooms",
                value: "No");
        }
    }
}
