using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HPCProjectTemplate.Server.Migrations
{
    public partial class AddStoredPlantTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Default_Image",
                columns: table => new
                {
                    thumbnail = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    license = table.Column<int>(type: "int", nullable: false),
                    license_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    license_url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    original_url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    regular_url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    medium_url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    small_url = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Default_Image", x => x.thumbnail);
                });

            migrationBuilder.CreateTable(
                name: "StoredPlants",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    common_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cycle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    watering = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    default_imagethumbnail = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoredPlants", x => x.id);
                    table.ForeignKey(
                        name: "FK_StoredPlants_Default_Image_default_imagethumbnail",
                        column: x => x.default_imagethumbnail,
                        principalTable: "Default_Image",
                        principalColumn: "thumbnail",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StoredPlants_default_imagethumbnail",
                table: "StoredPlants",
                column: "default_imagethumbnail");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StoredPlants");

            migrationBuilder.DropTable(
                name: "Default_Image");
        }
    }
}
