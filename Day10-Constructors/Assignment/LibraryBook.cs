using System;

namespace Assignment
{
    class LibraryBook
    {
        private string title;
        private string author;
        private double price;
        private bool isAvailable;

        // Parameterized constructor
        public LibraryBook(string title, string author, double price)
        {
            this.title = title;
            this.author = author;
            this.price = price;
            isAvailable = true;
        }
        public void BorrowBook()
        {
            if (isAvailable)
            {
                isAvailable = false;
                Console.WriteLine($"{title} has been borrowed.");
            }
            else
            {
                Console.WriteLine($"{title} is not available.");
            }
        }
        public void DisplayDetails()
        {
            Console.WriteLine($"Title      : {title}");
            Console.WriteLine($"Author     : {author}");
            Console.WriteLine($"Price      : ₹{price}");
            Console.WriteLine($"Available  : {isAvailable}");
        }
    }
}