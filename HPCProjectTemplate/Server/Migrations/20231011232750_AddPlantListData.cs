using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HPCProjectTemplate.Server.Migrations
{
    public partial class AddPlantListData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PlantList",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    common_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    scientific_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    other_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cycle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    watering = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sunlight = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    image_id = table.Column<int>(type: "int", nullable: false),
                    license = table.Column<int>(type: "int", nullable: false),
                    license_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    license_url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    original_url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    regular_url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    medium_url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    small_url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    thumbnail = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlantList", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlantList");
        }
    }
}
