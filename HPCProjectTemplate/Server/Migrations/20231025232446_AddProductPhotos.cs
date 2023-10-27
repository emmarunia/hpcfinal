using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HPCProjectTemplate.Server.Migrations
{
    public partial class AddProductPhotos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    price = table.Column<double>(type: "float", nullable: false),
                    link = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    imageURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    image2 = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.id);
                });
            migrationBuilder.InsertData(
               table: "Products",
               columns: new[] { "id", "brand", "name", "price", "link", "imageURL", "image2" },
               values: new object[,]
               {
                    { 1, "Schultz", "Plant Food", 11.99, "https://www.amazon.com/Schultz-Purpose-Plant-10-15-10-1012/dp/B00BARNKVI", "https://m.media-amazon.com/images/I/71klu8s1ByL._AC_SL1500_.jpg", "https://images.rawpixel.com/image_800/cHJpdmF0ZS9sci9pbWFnZXMvd2Vic2l0ZS8yMDIyLTExL2ZsNTIwODU0NTY2MjQtaW1hZ2UuanBn.jpg" },
                    { 2, "The Sill", "Watering Can", 15.0, "https://www.thesill.com/products/watering-can", "https://m.media-amazon.com/images/I/61pbHrnjtiL.__AC_SX300_SY300_QL70_FMwebp_.jpg","https://images.food52.com/JBkjPq3oVC4z56MS6vtUNP2Q-EY=/1200x1200/6d00ee8f-f663-446f-85da-ba86124d63e9--2022-0316_garden-glory_swedish-lightweight-watering-can_sahara-tan_1x1_julia-gartland.jpg"},
                    { 3, "RestMo", "Hose", 19.989999999999998, "https://a.co/d/5wWRADc", "https://m.media-amazon.com/images/I/6152WkWN1pL._AC_SL1500_.jpg", "https://fox40.com/wp-content/uploads/sites/13/2023/10/Water-hose-GettyImages-1414801266.jpg" },
                    { 4, "J&B", "Hose Nozzle", 79.950000000000003, "https://a.co/d/7cKk3Ko", "https://m.media-amazon.com/images/I/51f02NCHHZL._AC_.jpg", "https://www.thespruce.com/thmb/8En6NwHucvfDH3xAcLRTiNZYlKU=/6523x0/filters:no_upscale():max_bytes(150000):strip_icc()/SPR_GROUPSHOT_DB__7-038db210ff384ff69d30ccd44d970d8f.jpg"},
                    { 5, "Cool Job", "Gardening Gloves", 9.9900000000000002, "https://a.co/d/8I984yK", "https://m.media-amazon.com/images/I/81-H4AxC-HL._AC_SL1500_.jpg", "https://b3n8a3n8.rocketcdn.me/wp-content/uploads/2021/08/best-gardening-gloves.jpg" },
                    { 6, "Trendspot", "Small Pot", 15.0, "https://www.homedepot.com/p/Trendspot-6-in-White-Knack-Ceramic-Decorative-Planter-CR01721S-06W/314647810#overlay", "https://images.thdstatic.com/productImages/6f13eda0-b539-4f8e-af0b-efb8b7244c8b/svn/white-trendspot-plant-pots-cr01721s-06w-64_145.jpg", "https://cdn11.bigcommerce.com/s-tjft0ubcp2/images/stencil/1280x1280/products/11342/56608/CMR083__91105.1683898443.jpg?c=1" },
                    { 7, "Bloem Terra", "Medium Pot", 15.66, "https://www.homedepot.com/p/Bloem-Terra-16-in-Terra-Cotta-Plastic-Planter-50016C/301861355", "https://images.thdstatic.com/productImages/e96ac4ef-c26c-4650-9019-3d1620008850/svn/terra-cotta-bloem-plant-pots-50016c-64_145.jpg", "https://cdn.thewirecutter.com/wp-content/media/2021/06/staffpicks-plantpots-2048px-target.jpg?auto=webp&quality=75&width=1024" },
                    { 8, "Style Selections", "Large Pot", 16.98, "https://www.lowes.com/pd/L-G-Solutions-19-3-in-W-x-12-1-in-H-Oak-Resin-Planter/50445052?cm_mmc=shp-_-c-_-prd-_-lwn-_-ggl-_-LIA_LWN_243_Planters-And-Outdoor-Decor-_-50445052-_-local-_-0-_-0&gclid=CjwKCAjwp8OpBhAFEiwAG7NaEm-5zdjPHY60pE4d1f2KqemFEiS5XFwjXcjXFBu_9pu2YFsbqq42XxoCkBsQAvD_BwE&gclsrc=aw.ds", "https://mobileimages.lowes.com/productimages/2d392f1f-0a01-43da-becd-a6dd0265a3fc/03943290.jpg?size=mthb", "https://paxtongate.com/cdn/shop/files/Paxton_Gate_Product_white_stone_pot.jpg?v=1696362283" },
                    { 9, "Aplree", "Spray Bottle", 9.9900000000000002, "https://a.co/d/fWtmOMk", "https://m.media-amazon.com/images/I/41v5rWcdioL._SY450_.jpg", "https://m.media-amazon.com/images/S/aplus-media-library-service-media/1fc7bb54-8421-4875-8353-4074c0e5425b.__CR0,0,1940,1200_PT0_SX970_V1___.jpg" },
                    { 10, "Fox Farm", "Potting Soil", 23.989999999999998, "https://a.co/d/626DZLq", "https://m.media-amazon.com/images/I/617QtlPIYkL._AC_SL1008_.jpg", "https://greenplanetwholesale.ca/wp-content/uploads/2022/04/GreenPlanet-Wholesale-FoxFarm-Canada-Featured-Image-Happy-Frog-Ocean-Forest.png" },
                    { 11, "Growneer", "Plant Saucer", 14.99, "https://a.co/d/1EtpyHh", "https://m.media-amazon.com/images/I/61i6pPfDOXL._AC_SL1500_.jpg", "https://mylittlejungle.com/wp-content/uploads/2020/12/Pebble-Humidity-Tray-for-Plants.jpg" },
                    { 12, "Gouevn", "Soil Moisture Meter", 8.9700000000000006, "https://a.co/d/gdYMp7P", "https://m.media-amazon.com/images/I/61sql7HKnrL._AC_SL1000_.jpg", "https://gardenerspath.com/wp-content/uploads/2021/02/Reading-a-Two-Prong-Moisture-Meter.jpg" },
                    { 13, "Maxam", "Watering Globes", 17.949999999999999, "https://a.co/d/2TyK4q0", "https://m.media-amazon.com/images/I/81g9I5kaC4L._AC_SL1500_.jpg", "https://www.rushfields.com/files/images/news/are-watering-globes-good-for-your-houseplants-1000x667-6356a2d67edaa_n.webp"},
                    { 14, "Flora Animalia", "Pruning Shears", 24.0, "https://cna.st/p/meh9fHuiYWLjmKvrfKeMpz4Kmp7XkzM8Z5wUSR8sWe9M8i3hFgPgGoRQonNHa9bHj1Xthh1KnADaRjTy7qPnSAnKAcWXCCcxoaSoEPHh1sHE7eGUthXFx3SvdAcBdee2QFYigTAJSignYsFnEd57TA6QtZh58sB7LPAe8oh4a?xid=fr1697744462979iih", "https://media.self.com/photos/613a28d4761c8e04eaf65719/3:4/w_1280%2Cc_limit/untitled-1.png", "https://assets.pbimgs.com/pbimgs/rk/images/dp/wcm/202332/0966/garden-trimming-pruning-shears-set-l.jpg" },
                    { 15, "Roadwater", "Outdoor Plant Stand", 32.990000000000002, "https://a.co/d/8gtjYit", "https://m.media-amazon.com/images/I/71lQbCwk-PL._AC_SL1500_.jpg", "https://i5.walmartimages.com/asr/51cce375-1c16-4581-8164-0872eda8dec6.6e596fedb833954666f64f82b403ea8d.jpeg" },
                    { 16, "PlantsHome", "Indoor Plant Stand", 20.989999999999998, "https://a.co/d/i28n7fc", "https://m.media-amazon.com/images/I/61lUweEadvL._AC_SL1500_.jpg", "https://www.bhg.com/thmb/pvMGtwADI4EotJ8ONq6Jj9yCSZY=/4000x0/filters:no_upscale():strip_icc()/gardening-trends-best-plant-stands-b36c869af0f3430d8c7a860b7706dd30.jpg" },
                    { 17, "Honeywell", "Humidifier", 41.990000000000002, "https://www.target.com/p/honeywell-cool-mist-ultrasonic-humidifier/-/A-14568404?clkid=ba631689N5ca111ee8ddeddd158242021&cpng=PTID1&lnm=81938&afid=Self%20Commerce&ref=tgt_adv_xasd0002#lnk=sametab", "https://target.scene7.com/is/image/Target/GUEST_4b9d1941-405f-4c08-a881-0fd3c5c8f0bd?wid=800&hei=800&qlt=80&fmt=webp", "https://geekygreenhouse.com/wp-content/uploads/2023/03/where-to-place-humidifier-plants.jpg" },
                    { 18, "Leonard", "Gardening Tool Set", 54.689999999999998, "https://www.amleo.com/leonard-complete-aluminum-gardening-tool-set/p/ATS1?utm_source=bing&utm_medium=cpc&utm_campaign=Bing%20Shopping%20%7C%20AM%20%7C%20Catch%20All&utm_term=&utm_content=301093518--1287528186799977--80470528555497&msclkid=d81a275df9081f3c4d65426c73b86712", "https://www.amleo.com/media/catalog/product/cache/aa1841770a2aa8b05bb5b429e42f9ba2/a/t/ats1.jpg", "https://cdn.mall.adeptmind.ai/https%3A%2F%2Fassets.pbimgs.com%2Fpbimgs%2Frk%2Fimages%2Fdp%2Fwcm%2F202234%2F2338%2Fimg43z.jpg_large.jpg" },
                    { 19, "Soltech Solutions", "LED Grow Light", 149.99000000000001, "https://a.co/d/dVNNsly", "https://m.media-amazon.com/images/I/61xA6AEkpKL._AC_SY679_.jpg", "https://www.thespruce.com/thmb/T1JfyNijXplHYLIyedbUdVXXDO8=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/Aceple-LED-Grow-Light-5-b2aede32ce7b467d960613cf40adda3e.jpg"},
                    { 20, "Fiskars", "Hand Trowel", 12.99, "https://a.co/d/ceW5PG7", "https://m.media-amazon.com/images/I/51C6b3bd4AL._AC_SL1280_.jpg", "https://ae01.alicdn.com/kf/Sc5528a50b2eb4537b57242809c8291beU/EZARC-Garden-Hand-Trowel-Hand-Shovel-Stainless-Steel-Garden-Spade-with-Wood-Handle-for-Transplanting-Planting.jpg"}
               });
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "id", "brand", "image2", "imageURL", "link", "name", "price" },
                values: new object[] { 21, "Feedee", "https://diybar.co/cdn/shop/products/macrame-plant-hanger-kit-807604_1024x1024.jpg?v=1658436810", "https://diybar.co/cdn/shop/products/macrame-plant-hanger-kit-807604_1024x1024.jpg?v=1658436810", "https://a.co/d/6h1oSWH", "Plant Hanger", 24.989999999999998 });
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
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "id",
                keyValue: 21);


            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
