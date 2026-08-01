using System;

namespace Assignment2
{
    class ShoppingCart
    {
        public static double Discount = 10;

        private string productName;
        private double price;
        private int quantity;

        public readonly int ProductID;

        // Parameterized constructor
        public ShoppingCart(int productID, string productName, double price, int quantity)
        {
            ProductID = productID;
            this.productName = productName;
            this.price = price;
            this.quantity = quantity;
        }

        public void DisplayDetails()
        {
            double totalAmount = price * quantity;
            double finalAmount = totalAmount - (totalAmount * Discount / 100);

            Console.WriteLine($"Product ID    : {ProductID}");
            Console.WriteLine($"Product Name  : {productName}");
            Console.WriteLine($"Price         : ₹{price}");
            Console.WriteLine($"Quantity      : {quantity}");
            Console.WriteLine($"Discount      : {Discount}%");
            Console.WriteLine($"Final Amount  : ₹{finalAmount}");
        }

        public static void UpdateDiscount(double newDiscount)
        {
            Discount = newDiscount;
        }
    }
}