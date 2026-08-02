using System;
using System.Collections.Generic;

namespace Assignment
{
    class Bank
    {
        public string BankName { get; set; }
        private List<Customer> customers;

        // Initialize bank details
        public Bank(string bankName)
        {
            BankName = bankName;
            customers = new List<Customer>();
        }

        public void OpenAccount(Customer customer, double initialBalance)
        {
            customer.SetBalance(initialBalance);
            customers.Add(customer);

            Console.WriteLine($"Account opened for {customer.Name} in {BankName}");
        }

        public void DisplayCustomers()
        {
            Console.WriteLine($"Bank : {BankName}");
            Console.WriteLine("Customers:");

            foreach (Customer customer in customers)
            {
                Console.WriteLine($"- {customer.Name}");
            }
        }
    }
}