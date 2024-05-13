using System;

namespace CourseWork
{
    // Oleksandr Tolmachov 20233989
    internal class Program
    {
        static void Main(string[] args)
        {
            IShopManager shopManager = new ShopManager();

            shopManager.AddProduct(new ItemWithDescription(
                id:              shopManager.GetAvailableProductId(), 
                name:            "Book The Maze of Bones",
                cost:            19.99f,
                manufactureData: new DateTime(2023, 5, 1),
                description:     "Book includes game cards which the reader may use to play an online version of the treasure hunt.",
                quantity:        10));

            shopManager.AddProduct(new ProductWithExpirationData(
                id:              shopManager.GetAvailableProductId(),
                name:            "Milk", 
                cost:            1.99f,
                manufactureData: new DateTime(2024, 5, 1),
                description:     "Keep refrigerated 0° to 5°C. Once opened use within 3 days and before the use by date shown on cap.",
                expirationDate:  new DateTime(2024, 5, 8),
                quantity:        20));

            shopManager.AddProduct(new ProductWithExpirationData(
                id:              shopManager.GetAvailableProductId(),
                name:            "Cheddar Cheese Mild 500g",
                cost:            3.99f,
                manufactureData: new DateTime(2024, 5, 1),
                description:     "A smooth creamy Mild Cheddar Cheese. Made using pasteurised cows milk.",
                expirationDate:  new DateTime(2024, 5, 8),
                quantity:        23));

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Get all products:");
            Console.ForegroundColor = ConsoleColor.White;

            var productList = shopManager.GetProductsToQuantity();
            foreach (var item in productList)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("-------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Get all products after removing one item with id 0:");
            Console.ForegroundColor = ConsoleColor.White;

            shopManager.RemoveProduct(itemId: 0);
            
            productList = shopManager.GetProductsToQuantity();
            foreach (var item in productList)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("-------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Get product by id 0 and 1:");
            Console.ForegroundColor = ConsoleColor.White;

            var requiredProduct = shopManager.GetProductByIds(0, 1);
            foreach (var item in requiredProduct)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("-------------------");
        }
    }
}
