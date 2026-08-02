using System;
using System.Collections.Generic;

namespace Assignment
{
    class Library
    {
        public string LibraryName { get; set; }
        private List<Book> books;

        // Initialize library details
        public Library(string libraryName)
        {
            LibraryName = libraryName;
            books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void DisplayBooks()
        {
            Console.WriteLine($"Library : {LibraryName}");
            Console.WriteLine("Books:");

            foreach (Book book in books)
            {
                Console.WriteLine($"- {book.Title} by {book.Author}");
            }
        }
    }
}