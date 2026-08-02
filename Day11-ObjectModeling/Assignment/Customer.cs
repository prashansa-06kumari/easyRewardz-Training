using System;

namespace Assignment
{
    class Customer
    {
        public string Name { get; set; }
        public double Balance { get; private set; }

        // Initialize customer details
        public Customer(string name)
        {
            Name = name;
            Balance = 0;
        }

        public void SetBalance(double balance)
        {
            Balance = balance;
        }

        public void ViewBalance()
        {
            Console.WriteLine($"{Name}'s Balance : ₹{Balance}");
        }
    }
}