using System;

namespace Assignment
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }

        // Initialize book details
        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }

        public void DisplayBook()
        {
            Console.WriteLine($"Title  : {Title}");
            Console.WriteLine($"Author : {Author}");
        }
    }
}