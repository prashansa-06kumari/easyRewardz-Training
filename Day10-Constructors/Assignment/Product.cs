using System;

namespace Assignment
{
    class Product
    {
        private string productName;
        private double price;

        private static int totalProducts = 0;

        // Parameterized constructor
        public Product(string productName, double price)
        {
            this.productName = productName;
            this.price = price;
            totalProducts++;
        }

        public void DisplayProductDetails()
        {
            Console.WriteLine($"Product Name : {productName}");
            Console.WriteLine($"Price        : ₹{price}");
        }

        public static void DisplayTotalProducts()
        {
            Console.WriteLine($"Total Products : {totalProducts}");
        }
    }
}