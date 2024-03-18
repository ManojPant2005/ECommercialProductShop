using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ECommercial.Api.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CartId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Qty = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IconCSS = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Qty = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_ProductCategories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "ProductCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "Id", "UserId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "Id", "IconCSS", "Name" },
                values: new object[,]
                {
                    { 1, "fas fa-spa", "Ideaped" },
                    { 2, "fas fa-couch", "IPhone" },
                    { 3, "fas fa-headphones", "Mens" },
                    { 4, "fas fa-shoe-prints", "QElectronics" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "UserName" },
                values: new object[,]
                {
                    { 1, "Manoj" },
                    { 2, "Suraj" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageURL", "Name", "Price", "Qty" },
                values: new object[,]
                {
                    { 1, 1, "The device is an entry-level laptop that comes with a powerful AMD Ryzen 7 4700U Mobile Processor along with discrete AMD Radeon graphics options. It allows you to perform tasks with good speed and multitask without any lags, the display is IPS FHD 15.6 inches providing 1920 x 1080 resolution. The laptop is pack with 12 GB RAM .", "/Images/IdeaPed/Ideaped1.png", "Lenovo IdeaPed Slim-3", 484m, 100 },
                    { 2, 1, "HP Laptops starting ₹28149 w/13th Gen Intel Core. Shop Now! Explore affordable range of HP laptops. Built for Multi-tasking & productivity. Shop Now! Save 18% with GST Invoice.", "/Images/IdeaPed/Ideaped2.png", "HP Envy x360", 450m, 45 },
                    { 3, 1, "The HP ProBook 455 Laptop provides growing businesses with the commercial-grade performance", "/Images/IdeaPed/Ideaped3.png", "HP ProBook 455 G9", 480m, 30 },
                    { 4, 1, "Powerful Productivity:Intel Core i3-1215U processor delivers unmatched speed and intelligence", "/Images/IdeaPed/Ideaped4.png", "Lenovo IdeaPad Slim 3 AMD 3020e", 400m, 60 },
                    { 5, 1, "UFC with T-Type HD camera, 1280 x 720 resolution, 720p HD video at 30 fps with Temporal Noise Reduction, Blue glass lens", "/Images/IdeaPed/Ideaped5.png", "Acer Aspire 3", 460m, 85 },
                    { 6, 1, "Thin and Laptop (8GB/512GB SSD/Integrated Graphics/Windows 11", "/Images/IdeaPed/Ideaped6.png", "ASUS [SmartChoice] Vivobook 16X ", 590m, 85 },
                    { 7, 3, "Included in the box is a USB‑C to Lightning Cable that supports charging and is compatible with USB‑C power adapters and computer ports.", "/Images/IPhone/Iphone1.png", "IPhone 13", 1550m, 120 },
                    { 8, 3, "iPhone 13 Pro. Super Retina XDR display with ProMotion; 6.1‑inch (diagonal) all‑screen OLED display; 2532‑by‑1170-pixel resolution at 460 ppi.", "/Images/IPhone/Iphone2.png", "IPhone 13 pro max", 1600m, 200 },
                    { 9, 3, "upgraded A17 Pro processor, enhanced display, better battery life and improved camera system", "/Images/IPhone/Iphone3.png", "IPhone 15 Pro Max", 1400m, 300 },
                    { 10, 3, "Tipped to Launch in 2022: OnePlus 10 Pro, Nord 2 Lite, Nord 2T, and More - MySmartPrice", "/Images/IPhone/Iphone4.png", "OnePlus Mobiles", 1200m, 20 },
                    { 11, 3, "reliable choice for everyday tasks and demanding apps. When compared to the iPhone 11 and iPhone 12", "/Images/IPhone/Iphone5.png", "Apple iPhone 13", 1100m, 15 },
                    { 12, 4, "Comfortable Golden Bracelet in most sizes", "/Images/Shoes/Bracelet.png", "Golden Bracelet", 100m, 50 },
                    { 13, 4, "On-ear Golden Headphones - these headphones are not wireless", "/Images/Shoes/HeadPhone1.png", "On-ear Golden Headphones", 150m, 60 },
                    { 14, 4, "On-ear Black Headphones - these headphones are not wireless", "/Images/Shoes/HeadPhone2.png", "On-ear White Headphones", 200m, 70 },
                    { 15, 4, "Colorful attractive watch - available in most sizes", "/Images/Shoes/Watch1.png", "Colorful Watch", 120m, 120 },
                    { 16, 4, "Colourful Watch - available in most sizes and colurs.", "/Images/Shoes/Watch2.png", "SkyBlue Colourful Watch", 200m, 100 },
                    { 17, 4, "Birkenstock Watch - available in single colour", "/Images/Shoes/Watch3.png", "Oldest Watches", 105m, 150 },
                    { 18, 2, "White and blue Porcelain Table Lamp", "/Images/Electronic/Furniture1.png", "Porcelain Table Lamp", 15m, 100 },
                    { 19, 2, "Office Table Lamp", "/Images/Electronic/Furniture2.png", "Office Table Lamp", 20m, 73 },
                    { 20, 2, "Very comfortable gaming setup with all features", "/Images/Electronic/Gaming1.png", "Gaming Setup", 150m, 90 },
                    { 21, 2, "Very comfortable keyboard with low coast.", "/Images/Electronic/KeyBoard.png", " Black-Gray KeyBoard", 120m, 95 },
                    { 22, 2, "White, Red and another different colours comfortable keyboard.", "/Images/Electronic/KeyBoard1.png", "New Coloured KeyBoard", 15m, 60 },
                    { 23, 2, "New product for daily use.", "/Images/Electronic/Mouse.png", "Mouse", 40m, 73 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartItems");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "ProductCategories");
        }
    }
}
