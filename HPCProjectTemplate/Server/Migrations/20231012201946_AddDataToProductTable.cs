using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HPCProjectTemplate.Server.Migrations
{
    public partial class AddDataToProductTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "id", "brand", "name", "price" },
                values: new object[,]
                {
                    { 1, "Schultz", "Plant Food", 11.99 },
                    { 2, "The Sill", "Watering Can", 15.0 },
                    { 3, "RestMo", "Hose", 19.989999999999998 },
                    { 4, "J&B", "Hose Nozzle", 79.950000000000003 },
                    { 5, "Cool Job", "Gardening Gloves", 9.9900000000000002 },
                    { 6, "Trendspot", "Small Pot", 15.0 },
                    { 7, "Bloem Terra", "Medium Pot", 15.66 },
                    { 8, "Style Selections", "Large Pot", 16.98 },
                    { 9, "Aplree", "Spray Bottle", 9.9900000000000002 },
                    { 10, "Fox Farm", "Potting Soil", 23.989999999999998 },
                    { 11, "Growneer", "Plant Saucer", 14.99 },
                    { 12, "Gouevn", "Soil Moisture Meter", 8.9700000000000006 },
                    { 13, "Maxam", "Watering Globes", 17.949999999999999 },
                    { 14, "Flora Animalia", "Pruning Shears", 24.0 },
                    { 15, "Roadwater", "Outdoor Plant Stand", 32.990000000000002 },
                    { 16, "PLantsHome", "Indoor Plant Stand", 20.989999999999998 },
                    { 17, "Honeywell", "Humidifier", 41.990000000000002 },
                    { 18, "Leonard", "Gardening Tool Set", 54.689999999999998 },
                    { 19, "Soltech Solutions", "LED Grow Light", 149.99000000000001 },
                    { 20, "Fiskars", "Hand Trowel", 12.99 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "id",
                keyValue: 20);
        }
    }
}
