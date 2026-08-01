using System;

namespace Assignment2
{
    class LibraryManagement
    {
        public static string LibraryName = "Central Library";

        private string title;
        private string author;
        public readonly string ISBN;
        // Parameterized constructor
        public LibraryManagement(string title, string author, string isbn)
        {
            this.title = title;
            this.author = author;
            ISBN = isbn;
        }
        public void DisplayDetails()
        {
            Console.WriteLine($"Library Name : {LibraryName}");
            Console.WriteLine($"Title        : {title}");
            Console.WriteLine($"Author       : {author}");
            Console.WriteLine($"ISBN         : {ISBN}");
        }

        public static void DisplayLibraryName()
        {
            Console.WriteLine($"Library Name : {LibraryName}");
        }
    }
}