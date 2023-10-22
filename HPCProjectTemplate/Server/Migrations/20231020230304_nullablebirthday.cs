using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HPCProjectTemplate.Server.Migrations
{
    public partial class nullablebirthday : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "imageURL",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "link",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Birthday",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "imageURL", "link" },
                values: new object[] { "https://m.media-amazon.com/images/I/71klu8s1ByL._AC_SL1500_.jpg", "https://www.amazon.com/Schultz-Purpose-Plant-10-15-10-1012/dp/B00BARNKVI" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "imageURL", "link" },
                values: new object[] { "https://m.media-amazon.com/images/I/61pbHrnjtiL.__AC_SX300_SY300_QL70_FMwebp_.jpg", "https://www.thesill.com/products/watering-can" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "imageURL", "link", "name" },
                values: new object[] { "https://m.media-amazon.com/images/I/6152WkWN1pL._AC_SL1500_.jpg", "https://a.co/d/5wWRADc", "Hose Nozzle" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "imageURL", "link", "name" },
                values: new object[] { "https://m.media-amazon.com/images/I/51f02NCHHZL._AC_.jpg", "https://a.co/d/7cKk3Ko", "Hose" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "imageURL", "link" },
                values: new object[] { "https://m.media-amazon.com/images/I/81-H4AxC-HL._AC_SL1500_.jpg", "https://a.co/d/8I984yK" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "imageURL", "link" },
                values: new object[] { "https://images.thdstatic.com/productImages/6f13eda0-b539-4f8e-af0b-efb8b7244c8b/svn/white-trendspot-plant-pots-cr01721s-06w-64_145.jpg", "https://www.homedepot.com/p/Trendspot-6-in-White-Knack-Ceramic-Decorative-Planter-CR01721S-06W/314647810#overlay" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "imageURL", "link" },
                values: new object[] { "https://images.thdstatic.com/productImages/e96ac4ef-c26c-4650-9019-3d1620008850/svn/terra-cotta-bloem-plant-pots-50016c-64_145.jpg", "https://www.homedepot.com/p/Bloem-Terra-16-in-Terra-Cotta-Plastic-Planter-50016C/301861355" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "imageURL", "link" },
                values: new object[] { "https://mobileimages.lowes.com/productimages/2d392f1f-0a01-43da-becd-a6dd0265a3fc/03943290.jpg?size=mthb", "https://www.lowes.com/pd/L-G-Solutions-19-3-in-W-x-12-1-in-H-Oak-Resin-Planter/50445052?cm_mmc=shp-_-c-_-prd-_-lwn-_-ggl-_-LIA_LWN_243_Planters-And-Outdoor-Decor-_-50445052-_-local-_-0-_-0&gclid=CjwKCAjwp8OpBhAFEiwAG7NaEm-5zdjPHY60pE4d1f2KqemFEiS5XFwjXcjXFBu_9pu2YFsbqq42XxoCkBsQAvD_BwE&gclsrc=aw.ds" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "imageURL", "link" },
                values: new object[] { "https://m.media-amazon.com/images/I/41v5rWcdioL._SY450_.jpg", "https://a.co/d/fWtmOMk" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "imageURL", "link" },
                values: new object[] { "https://m.media-amazon.com/images/I/617QtlPIYkL._AC_SL1008_.jpg", "https://a.co/d/626DZLq" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "imageURL", "link" },
                values: new object[] { "https://m.media-amazon.com/images/I/61i6pPfDOXL._AC_SL1500_.jpg", "https://a.co/d/1EtpyHh" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "imageURL", "link" },
                values: new object[] { "https://m.media-amazon.com/images/I/61sql7HKnrL._AC_SL1000_.jpg", "https://a.co/d/gdYMp7P" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "imageURL", "link" },
                values: new object[] { "https://m.media-amazon.com/images/I/81g9I5kaC4L._AC_SL1500_.jpg", "https://a.co/d/2TyK4q0" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "imageURL", "link" },
                values: new object[] { "https://media.self.com/photos/613a28d4761c8e04eaf65719/3:4/w_1280%2Cc_limit/untitled-1.png", "https://cna.st/p/meh9fHuiYWLjmKvrfKeMpz4Kmp7XkzM8Z5wUSR8sWe9M8i3hFgPgGoRQonNHa9bHj1Xthh1KnADaRjTy7qPnSAnKAcWXCCcxoaSoEPHh1sHE7eGUthXFx3SvdAcBdee2QFYigTAJSignYsFnEd57TA6QtZh58sB7LPAe8oh4a?xid=fr1697744462979iih" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "imageURL", "link" },
                values: new object[] { "https://m.media-amazon.com/images/I/71lQbCwk-PL._AC_SL1500_.jpg", "https://a.co/d/8gtjYit" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "imageURL", "link" },
                values: new object[] { "https://m.media-amazon.com/images/I/61lUweEadvL._AC_SL1500_.jpg", "https://a.co/d/i28n7fc" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "imageURL", "link" },
                values: new object[] { "https://target.scene7.com/is/image/Target/GUEST_4b9d1941-405f-4c08-a881-0fd3c5c8f0bd?wid=800&hei=800&qlt=80&fmt=webp", "https://www.target.com/p/honeywell-cool-mist-ultrasonic-humidifier/-/A-14568404?clkid=ba631689N5ca111ee8ddeddd158242021&cpng=PTID1&lnm=81938&afid=Self%20Commerce&ref=tgt_adv_xasd0002#lnk=sametab" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "imageURL", "link" },
                values: new object[] { "https://www.amleo.com/media/catalog/product/cache/aa1841770a2aa8b05bb5b429e42f9ba2/a/t/ats1.jpg", "https://www.amleo.com/leonard-complete-aluminum-gardening-tool-set/p/ATS1?utm_source=bing&utm_medium=cpc&utm_campaign=Bing%20Shopping%20%7C%20AM%20%7C%20Catch%20All&utm_term=&utm_content=301093518--1287528186799977--80470528555497&msclkid=d81a275df9081f3c4d65426c73b86712" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "imageURL", "link" },
                values: new object[] { "https://m.media-amazon.com/images/I/61xA6AEkpKL._AC_SY679_.jpg", "https://a.co/d/dVNNsly" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "imageURL", "link" },
                values: new object[] { "https://m.media-amazon.com/images/I/51C6b3bd4AL._AC_SL1280_.jpg", "https://a.co/d/ceW5PG7" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "imageURL",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "link",
                table: "Products");

            migrationBuilder.AlterColumn<string>(
                name: "Birthday",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 3,
                column: "name",
                value: "Hose");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 4,
                column: "name",
                value: "Hose Nozzle");
        }
    }
}
