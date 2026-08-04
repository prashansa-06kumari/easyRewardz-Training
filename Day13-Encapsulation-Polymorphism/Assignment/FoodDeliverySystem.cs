using System;

namespace Assignment
{
    interface IDiscountable
    {
        double ApplyDiscount();
        void GetDiscountDetails();
    }

    abstract class FoodItem
    {
        private string itemName;
        private double price;
        private int quantity;

        public string ItemName
        {
            get { return itemName; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    itemName = value;
            }
        }

        public double Price
        {
            get { return price; }
            set
            {
                if (value >= 0)
                    price = value;
            }
        }

        public int Quantity
        {
            get { return quantity; }
            set
            {
                if (value > 0)
                    quantity = value;
            }
        }

        public FoodItem(string itemName, double price, int quantity)
        {
            ItemName = itemName;
            Price = price;
            Quantity = quantity;
        }

        public abstract double CalculateTotalPrice();

        public void GetItemDetails()
        {
            Console.WriteLine($"Item     : {ItemName}");
            Console.WriteLine($"Price    : ₹{Price}");
            Console.WriteLine($"Quantity : {Quantity}");
        }
    }

    class VegItem : FoodItem, IDiscountable
    {
        public VegItem(string itemName, double price, int quantity)
            : base(itemName, price, quantity)
        {
        }

        public override double CalculateTotalPrice()
        {
            return Price * Quantity;
        }

        public double ApplyDiscount()
        {
            return CalculateTotalPrice() * 0.10;
        }

        public void GetDiscountDetails()
        {
            Console.WriteLine($"Discount : ₹{ApplyDiscount()}");
        }
    }

    class NonVegItem : FoodItem, IDiscountable
    {
        public NonVegItem(string itemName, double price, int quantity)
            : base(itemName, price, quantity)
        {
        }

        public override double CalculateTotalPrice()
        {
            return (Price * Quantity) + 50;
        }

        public double ApplyDiscount()
        {
            return CalculateTotalPrice() * 0.05;
        }

        public void GetDiscountDetails()
        {
            Console.WriteLine($"Discount : ₹{ApplyDiscount()}");
        }
    }
}