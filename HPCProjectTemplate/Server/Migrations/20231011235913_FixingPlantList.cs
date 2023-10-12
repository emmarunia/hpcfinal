using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HPCProjectTemplate.Server.Migrations
{
    public partial class FixingPlantList : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "other_name",
                table: "PlantList");

            migrationBuilder.DropColumn(
                name: "scientific_name",
                table: "PlantList");

            migrationBuilder.DropColumn(
                name: "sunlight",
                table: "PlantList");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "other_name",
                table: "PlantList",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "scientific_name",
                table: "PlantList",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "sunlight",
                table: "PlantList",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
