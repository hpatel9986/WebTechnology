namespace Assignment_1.Models
{
    public class ProductBL
    {
        public List<Product> Products = new List<Product>();

        public ProductBL()
        {
            Products.Add(new Product { Id = 101, ProductName = "Iphone", ProductPrice = 12.32, ImgUrl = "iphone.jpg", Description = "Apple iPhone 17 Pro Max 512GB - Cosmic Orange - Unlocked" });
            Products.Add(new Product { Id = 102, ProductName = "Airpods", ProductPrice = 8.09, ImgUrl = "airpods.jpg", Description = "Apple AirPods Pro 3 Wireless Earbuds, Active Noise Cancellation, Live Translation, Heart Rate Sensing, Bluetooth Headphones, Spatial Audio, High-Fidelity Sound, USB-C Charging" });
            Products.Add(new Product { Id = 103, ProductName = "Ipad", ProductPrice = 5.21, ImgUrl = "ipad.jpg", Description = "Apple iPad with A16 chip: 11-inch Liquid Retina Display, 128 GB, Wi-Fi 6, 12MP Front/12MP Back Camera, Touch ID, All-Day Battery Life — Blue" });
            Products.Add(new Product { Id = 104, ProductName = "Apple Macbook", ProductPrice = 9.65, ImgUrl = "laptop.jpg", Description = "2020 Apple MacBook Air with Apple M1 Chip (13-inch, 8GB RAM, 256GB) (QWERTY English) Space Gray (Renewed)" });
            Products.Add(new Product { Id = 105, ProductName = "Apple Watch", ProductPrice = 15.20, ImgUrl = "apple_watch.jpg", Description = "Apple Watch SE 3 [GPS 40mm] Smartwatch with Starlight Case with Starlight Sport Band. Fitness and Sleep Trackers, Heart Rate Monitor, Always-On Display" });
            Products.Add(new Product { Id = 106, ProductName = "Jeans", ProductPrice = 12.32, ImgUrl = "jeans.jpg", Description = "Baggy Jeans for Men Y2K Streetwear Vintage Wide Leg Loose Fit Denim Pants Hip Hop Skater Carpenter Jeans" });
            Products.Add(new Product { Id = 107, ProductName = "Pajama", ProductPrice = 8.09, ImgUrl = "pajama.jpg", Description = "Fruit of The Loom Mens Yarn-dye Woven Flannel Pajama Pant" });
            Products.Add(new Product { Id = 108, ProductName = "Polo T-shirt", ProductPrice = 5.21, ImgUrl = "polo_tshirt.jpg", Description = "Jack & Jones Mens Jack & Jones Paulos Polo SSPolo T-Shirt" });
            Products.Add(new Product { Id = 109, ProductName = "Polo Shirt", ProductPrice = 9.65, ImgUrl = "polo_shirt.jpg", Description = "HMIYA Mens Golf Polo Shirt Casual Short Sleeve S-3XL 2026 New" });
            Products.Add(new Product { Id = 110, ProductName = "Shorts", ProductPrice = 15.20, ImgUrl = "shorts.jpg", Description = "Mens Baggy Jean Shorts Loose Fit Vintage Wide Leg Jorts Y2K Streetwear Hip Hop Casual Long Denim Shorts" });
            Products.Add(new Product { Id = 111, ProductName = "Sweatshirt", ProductPrice = 32.32, ImgUrl = "sweatshirt.jpg", Description = "Jack & Jones Mens Bradley Sweat Crew Plus Sweatshirt" });
            Products.Add(new Product { Id = 112, ProductName = "Watch", ProductPrice = 52.99, ImgUrl = "watch.jpg", Description = "Timex Men's Weekender 40mm Watch" });

        }

        public List<Product> GetAll()
        {
            return Products;
        }

        public Product ShowById(int id)
        {
            Product product = Products.Find(m => m.Id == id);
            return product;
        }
    }
}
