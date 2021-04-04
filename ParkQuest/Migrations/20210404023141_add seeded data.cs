using Microsoft.EntityFrameworkCore.Migrations;

namespace ParkQuest.Migrations
{
    public partial class addseededdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "HasRestrooms", "Name", "ParkType" },
                values: new object[,]
                {
                    { 1, "No", "Ainsworth", "State" },
                    { 23, "Yes", "Black Canyon of the Gunnison", "National" },
                    { 22, "Yes", "Port Orford Heads", "State" },
                    { 21, "Yes", "Congaree", "National" },
                    { 20, "No", "Nehalem Bay", "State" },
                    { 19, "No", "Prineville Reservoir", "State" },
                    { 18, "Yes", "Mayer", "State" },
                    { 17, "Yes", "Great Basin", "National" },
                    { 16, "No", "North Cascades", "National" },
                    { 15, "Yes", "LaPine", "State" },
                    { 14, "No", "Harris Beach", "State" },
                    { 24, "Yes", "Umpqua Lighthouse", "State" },
                    { 13, "No", "Cottonwood Canyon", "State" },
                    { 11, "Yes", "Dry Tortugas", "National" },
                    { 10, "No", "Kobuk Valley", "National" },
                    { 9, "Yes", "Isle Royale", "National" },
                    { 8, "No", "Cascadia", "State" },
                    { 7, "No", "Lake Clark", "National" },
                    { 6, "Yes", "Brian Booth - Beaver Creek", "State" },
                    { 5, "Yes", "William M. Tugman", "State" },
                    { 4, "Yes", "Bob Straub", "State" },
                    { 3, "No", "Gates of the Arctic", "National" },
                    { 2, "Yes", "Crater Lake", "National" },
                    { 12, "No", "Ecola", "State" },
                    { 25, "No", "Guadalupe Mountains", "National" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 25);
        }
    }
}
