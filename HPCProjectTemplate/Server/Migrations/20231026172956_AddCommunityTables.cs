using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HPCProjectTemplate.Server.Migrations
{
    public partial class AddCommunityTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StoredPlants");

            migrationBuilder.DropTable(
                name: "Default_Image");

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TopicId = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Topics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Topics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Replies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TopicId = table.Column<int>(type: "int", nullable: false),
                    PostId = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostsId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Replies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Replies_Posts_PostsId",
                        column: x => x.PostsId,
                        principalTable: "Posts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Replies_PostsId",
                table: "Replies",
                column: "PostsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Replies");

            migrationBuilder.DropTable(
                name: "Topics");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.CreateTable(
                name: "Default_Image",
                columns: table => new
                {
                    thumbnail = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    license = table.Column<int>(type: "int", nullable: false),
                    license_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    license_url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    medium_url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    original_url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    regular_url = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    default_imagethumbnail = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    common_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cycle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    watering = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
    }
}
