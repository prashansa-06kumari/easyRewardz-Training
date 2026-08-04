using System;

namespace Assignment
{
    interface ITaxable
    {
        double CalculateTax();
        void GetTaxDetails();
    }

    abstract class Product
    {
        private int productId;
        private string name;
        private double price;

        public int ProductId
        {
            get { return productId; }
            set { productId = value; }
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    name = value;
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

        public Product(int productId, string name, double price)
        {
            ProductId = productId;
            Name = name;
            Price = price;
        }

        public abstract double CalculateDiscount();

        public void DisplayProduct()
        {
            Console.WriteLine($"Product ID : {ProductId}");
            Console.WriteLine($"Name       : {Name}");
            Console.WriteLine($"Price      : ₹{Price}");
        }
    }

    class Electronics : Product, ITaxable
    {
        public Electronics(int productId, string name, double price)
            : base(productId, name, price)
        {
        }

        public override double CalculateDiscount()
        {
            return Price * 0.10;
        }

        public double CalculateTax()
        {
            return Price * 0.18;
        }

        public void GetTaxDetails()
        {
            Console.WriteLine($"Tax : ₹{CalculateTax()}");
        }
    }

    class Clothing : Product, ITaxable
    {
        public Clothing(int productId, string name, double price)
            : base(productId, name, price)
        {
        }

        public override double CalculateDiscount()
        {
            return Price * 0.20;
        }

        public double CalculateTax()
        {
            return Price * 0.12;
        }

        public void GetTaxDetails()
        {
            Console.WriteLine($"Tax : ₹{CalculateTax()}");
        }
    }

    class Groceries : Product
    {
        public Groceries(int productId, string name, double price)
            : base(productId, name, price)
        {
        }

        public override double CalculateDiscount()
        {
            return Price * 0.05;
        }
    }
}