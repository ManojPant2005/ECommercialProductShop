using ECommercial.Api.Entities;
using ECommercial.Models.Models;
using Microsoft.EntityFrameworkCore;

namespace ECommercial.Api.Data
{
    public class ECommerceDbContext : DbContext
    {
        public ECommerceDbContext(DbContextOptions<ECommerceDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Products
            //IdeaPed Category
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 1,
                Name = "Lenovo IdeaPed Slim-3",
                Description = "The device is an entry-level laptop that comes with a powerful AMD Ryzen 7 4700U Mobile Processor along with discrete AMD Radeon graphics options. It allows you to perform tasks with good speed and multitask without any lags, the display is IPS FHD 15.6 inches providing 1920 x 1080 resolution. The laptop is pack with 12 GB RAM .",
                ImageURL = "/Images/IdeaPed/Ideaped1.png",
                Price = 484,
                Qty = 100,
                CategoryId = 1

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 2,
                Name = "HP Envy x360",
                Description = "HP Laptops starting ₹28149 w/13th Gen Intel Core. Shop Now! Explore affordable range of HP laptops. Built for Multi-tasking & productivity. Shop Now! Save 18% with GST Invoice.",
                ImageURL = "/Images/IdeaPed/Ideaped2.png",
                Price = 450,
                Qty = 45,
                CategoryId = 1

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 3,
                Name = "HP ProBook 455 G9",
                Description = "The HP ProBook 455 Laptop provides growing businesses with the commercial-grade performance",
                ImageURL = "/Images/IdeaPed/Ideaped3.png",
                Price = 480,
                Qty = 30,
                CategoryId = 1

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 4,
                Name = "Lenovo IdeaPad Slim 3 AMD 3020e",
                Description = "Powerful Productivity:Intel Core i3-1215U processor delivers unmatched speed and intelligence",
                ImageURL = "/Images/IdeaPed/Ideaped4.png",
                Price = 400,
                Qty = 60,
                CategoryId = 1

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 5,
                Name = "Acer Aspire 3",
                Description = "UFC with T-Type HD camera, 1280 x 720 resolution, 720p HD video at 30 fps with Temporal Noise Reduction, Blue glass lens",
                ImageURL = "/Images/IdeaPed/Ideaped5.png",
                Price = 460,
                Qty = 85,
                CategoryId = 1

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 6,
                Name = "ASUS [SmartChoice] Vivobook 16X ",
                Description = "Thin and Laptop (8GB/512GB SSD/Integrated Graphics/Windows 11",
                ImageURL = "/Images/IdeaPed/Ideaped6.png",
                Price = 590,
                Qty = 85,
                CategoryId = 1

            });
            //IPhone Category
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 7,
                Name = "IPhone 13",
                Description = "Included in the box is a USB‑C to Lightning Cable that supports charging and is compatible with USB‑C power adapters and computer ports.",
                ImageURL = "/Images/IPhone/Iphone1.png",
                Price = 1550,
                Qty = 120,
                CategoryId = 3

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 8,
                Name = "IPhone 13 pro max",
                Description = "iPhone 13 Pro. Super Retina XDR display with ProMotion; 6.1‑inch (diagonal) all‑screen OLED display; 2532‑by‑1170-pixel resolution at 460 ppi.",
                ImageURL = "/Images/IPhone/Iphone2.png",
                Price = 1600,
                Qty = 200,
                CategoryId = 3

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 9,
                Name = "IPhone 15 Pro Max",
                Description = "upgraded A17 Pro processor, enhanced display, better battery life and improved camera system",
                ImageURL = "/Images/IPhone/Iphone3.png",
                Price = 1400,
                Qty = 300,
                CategoryId = 3

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 10,
                Name = "OnePlus Mobiles",
                Description = "Tipped to Launch in 2022: OnePlus 10 Pro, Nord 2 Lite, Nord 2T, and More - MySmartPrice",
                ImageURL = "/Images/IPhone/Iphone4.png",
                Price = 1200,
                Qty = 20,
                CategoryId = 3

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 11,
                Name = "Apple iPhone 13",
                Description = "reliable choice for everyday tasks and demanding apps. When compared to the iPhone 11 and iPhone 12",
                ImageURL = "/Images/IPhone/Iphone5.png",
                Price = 1100,
                Qty = 15,
                CategoryId = 3

            });

            //Mens Category
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 12,
                Name = "Golden Bracelet",
                Description = "Comfortable Golden Bracelet in most sizes",
                ImageURL = "/Images/Shoes/Bracelet.png",
                Price = 100,
                Qty = 50,
                CategoryId = 4
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 13,
                Name = "On-ear Golden Headphones",
                Description = "On-ear Golden Headphones - these headphones are not wireless",
                ImageURL = "/Images/Shoes/HeadPhone1.png",
                Price = 150,
                Qty = 60,
                CategoryId = 4
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 14,
                Name = "On-ear White Headphones",
                Description = "On-ear Black Headphones - these headphones are not wireless",
                ImageURL = "/Images/Shoes/HeadPhone2.png",
                Price = 200,
                Qty = 70,
                CategoryId = 4
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 15,
                Name = "Colorful Watch",
                Description = "Colorful attractive watch - available in most sizes",
                ImageURL = "/Images/Shoes/Watch1.png",
                Price = 120,
                Qty = 120,
                CategoryId = 4
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 16,
                Name = "SkyBlue Colourful Watch",
                Description = "Colourful Watch - available in most sizes and colurs.",
                ImageURL = "/Images/Shoes/Watch2.png",
                Price = 200,
                Qty = 100,
                CategoryId = 4
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 17,
                Name = "Oldest Watches",
                Description = "Birkenstock Watch - available in single colour",
                ImageURL = "/Images/Shoes/Watch3.png",
                Price = 105,
                Qty = 150,
                CategoryId = 4
            });

            //QElectronics Category
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 18,
                Name = "Porcelain Table Lamp",
                Description = "White and blue Porcelain Table Lamp",
                ImageURL = "/Images/Electronic/Furniture1.png",
                Price = 15,
                Qty = 100,
                CategoryId = 2
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 19,
                Name = "Office Table Lamp",
                Description = "Office Table Lamp",
                ImageURL = "/Images/Electronic/Furniture2.png",
                Price = 20,
                Qty = 73,
                CategoryId = 2
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 20,
                Name = "Gaming Setup",
                Description = "Very comfortable gaming setup with all features",
                ImageURL = "/Images/Electronic/Gaming1.png",
                Price = 150,
                Qty = 90,
                CategoryId = 2
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 21,
                Name = " Black-Gray KeyBoard",
                Description = "Very comfortable keyboard with low coast.",
                ImageURL = "/Images/Electronic/KeyBoard.png",
                Price = 120,
                Qty = 95,
                CategoryId = 2
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 22,
                Name = "New Coloured KeyBoard",
                Description = "White, Red and another different colours comfortable keyboard.",
                ImageURL = "/Images/Electronic/KeyBoard1.png",
                Price = 15,
                Qty = 60,
                CategoryId = 2
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 23,
                Name = "Mouse",
                Description = "New product for daily use.",
                ImageURL = "/Images/Electronic/Mouse.png",
                Price = 40,
                Qty = 73,
                CategoryId = 2
            });
 

            //Add users
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 1,
                UserName = "Manoj"

            });
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 2,
                UserName = "Suraj"

            });

            //Create Shopping Cart for Users
            modelBuilder.Entity<Cart>().HasData(new Cart
            {
                Id = 1,
                UserId = 1

            });
            modelBuilder.Entity<Cart>().HasData(new Cart
            {
                Id = 2,
                UserId = 2

            });
            //Add Product Categories
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 1,
                Name = "Ideaped",
                IconCSS = "fas fa-spa"
            });
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 2,
                Name = "IPhone",
                IconCSS = "fas fa-couch"
            });
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 3,
                Name = "Mens",
                IconCSS = "fas fa-headphones"
            });
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 4,
                Name = "QElectronics",
                IconCSS = "fas fa-shoe-prints"
            });
        }

        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<User> Users { get; set; }

        public DbSet<Registration> Registrations { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
    }
}
