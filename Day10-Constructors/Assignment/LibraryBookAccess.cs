using System;

namespace Assignment
{
    class LibraryBookAccess
    {
        public string ISBN;
        protected string title;
        private string author;
        // Parameterized constructor
        public LibraryBookAccess(string isbn, string title, string author)
        {
            ISBN = isbn;
            this.title = title;
            this.author = author;
        }

        public void SetAuthor(string author)
        {
            this.author = author;
        }

        public string GetAuthor()
        {
            return author;
        }
    }
}