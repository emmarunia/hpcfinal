using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HPCProjectTemplate.Server.Migrations
{
    public partial class UpdateSprayBottlePhoto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 9,
                column: "image2",
                value: "https://cdn.brookfieldresidential.net/-/media/brp/global/modules/news-and-blog/corporate/natural-weed-killers-pest-control-remedies/female-hand-spraying-from-a-bottle-onto-plants-in-a-garden-1189.jpg?rev=51b47b3d0a604a878c623b9782bad048&cx=0.5&cy=0.5");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 9,
                column: "image2",
                value: "https://m.media-amazon.com/images/S/aplus-media-library-service-media/1fc7bb54-8421-4875-8353-4074c0e5425b.__CR0,0,1940,1200_PT0_SX970_V1___.jpg");
        }
    }
}
