using Shop_app.Models;

namespace HW_MVC_Core_11_Roles_2.Models
{
    public static class ProductCollection
    {
        public static List<Product> Products = new List<Product>
        {
            new Product
            {
                Id = 1,
                Name = "Laptop",
                Price = 999.99m,
                Description = "High performance laptop for gaming and work"
            },
            new Product
            {
                Id = 2,
                Name = "Smartphone",
                Price = 599.99m,
                Description = "Latest smartphone with 5G connectivity"
            },
            new Product
            {
                Id = 3,
                Name = "Headphones",
                Price = 79.99m,
                Description = "Noise-cancelling over-ear headphones"
            },
            new Product
            {
                Id = 4,
                Name = "Monitor",
                Price = 199.99m,
                Description = "27-inch 4K UHD monitor for professional use"
            },
            new Product
            {
                Id = 5,
                Name = "Keyboard",
                Price = 49.99m,
                Description = "Mechanical keyboard with RGB backlight"
            },
            new Product
            {
                Id = 6,
                Name = "Mouse",
                Price = 29.99m,
                Description = "Wireless optical mouse with ergonomic design"
            },
            new Product
            {
                Id = 7,
                Name = "Tablet",
                Price = 299.99m,
                Description = "10-inch tablet with high-resolution display"
            },
            new Product
            {
                Id = 8,
                Name = "Printer",
                Price = 149.99m,
                Description = "All-in-one color printer with Wi-Fi support"
            },
            new Product
            {
                Id = 9,
                Name = "External Hard Drive",
                Price = 89.99m,
                Description = "1TB external hard drive for data backup"
            },
            new Product
            {
                Id = 10,
                Name = "Webcam",
                Price = 59.99m,
                Description = "1080p HD webcam with built-in microphone"
            }
        };
    }

}