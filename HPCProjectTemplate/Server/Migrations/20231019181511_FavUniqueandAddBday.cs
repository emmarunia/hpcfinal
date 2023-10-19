using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HPCProjectTemplate.Server.Migrations
{
    public partial class FavUniqueandAddBday : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Plants_AspNetUsers_ApplicationUserId",
                table: "Plants");

            migrationBuilder.DropColumn(
                name: "perenualId",
                table: "Plants");
            migrationBuilder.AddColumn<string>(
                name: "perenualId",
                table: "Plants",
                nullable: false);
            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Plants");
            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Plants",
                nullable: false);

            migrationBuilder.AddColumn<string>(
                name: "Birthday",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Plants_perenualId_ApplicationUserId",
                table: "Plants",
                columns: new[] { "perenualId", "ApplicationUserId" },
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Plants_AspNetUsers_ApplicationUserId",
                table: "Plants",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Plants_AspNetUsers_ApplicationUserId",
                table: "Plants");

            migrationBuilder.DropIndex(
                name: "IX_Plants_perenualId_ApplicationUserId",
                table: "Plants");

            migrationBuilder.DropColumn(
                name: "Birthday",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "perenualId",
                table: "Plants",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "ApplicationUserId",
                table: "Plants",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddForeignKey(
                name: "FK_Plants_AspNetUsers_ApplicationUserId",
                table: "Plants",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
