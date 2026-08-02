using System;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========== Aggregation ==========\n");

            Book book1 = new Book("Atomic Habits", "James Clear");
            Book book2 = new Book("The Alchemist", "Paulo Coelho");

            Library library = new Library("Central Library");

            library.AddBook(book1);
            library.AddBook(book2);

            library.DisplayBooks();

            Console.WriteLine("\n========== Association ==========\n");

            Bank bank = new Bank("State Bank of India");

            Customer customer = new Customer("Prince Sharma");

            bank.OpenAccount(customer, 50000);

            bank.DisplayCustomers();
            customer.ViewBalance();

            Console.WriteLine("\n========== Composition ==========\n");

            Company company = new Company("EasyRewardz");

            Department it = company.CreateDepartment("IT");
            Department hr = company.CreateDepartment("HR");

            it.AddEmployee("Prince Sharma");
            it.AddEmployee("Rahul");

            hr.AddEmployee("Anjali");

            company.DisplayCompany();
        }
    }
}