using System;

namespace Assignment
{
    class Book
    {
        private string title;
        private string author;
        private double price;
        public Book()
        {
            title = "Unknown";
            author = "Unknown";
            price = 0;
        }
        // Parameterized constructor to initialize book details
        public Book(string title, string author, double price)
        {
            this.title = title;
            this.author = author;
            this.price = price;
        }
        public void DisplayDetails()
        {
            Console.WriteLine($"Title  : {title}");
            Console.WriteLine($"Author : {author}");
            Console.WriteLine($"Price  : ₹{price}");
        }
    }
}