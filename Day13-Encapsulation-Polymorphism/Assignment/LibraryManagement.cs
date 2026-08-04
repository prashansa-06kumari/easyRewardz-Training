using System;

namespace Assignment
{
    interface IReservable
    {
        void ReserveItem();
        void CheckAvailability();
    }

    abstract class LibraryItem
    {
        private int itemId;
        private string title;
        private string author;

        private string borrower;

        public int ItemId
        {
            get { return itemId; }
            set { itemId = value; }
        }

        public string Title
        {
            get { return title; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    title = value;
            }
        }

        public string Author
        {
            get { return author; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    author = value;
            }
        }

        public LibraryItem(int itemId, string title, string author)
        {
            ItemId = itemId;
            Title = title;
            Author = author;
        }

        public void SetBorrower(string borrower)
        {
            this.borrower = borrower;
        }

        public string GetBorrower()
        {
            return borrower;
        }

        public abstract int GetLoanDuration();

        public void GetItemDetails()
        {
            Console.WriteLine($"Item ID : {ItemId}");
            Console.WriteLine($"Title   : {Title}");
            Console.WriteLine($"Author  : {Author}");
        }
    }

    class Book : LibraryItem, IReservable
    {
        public Book(int itemId, string title, string author)
            : base(itemId, title, author)
        {
        }

        public override int GetLoanDuration()
        {
            return 14;
        }

        public void ReserveItem()
        {
            Console.WriteLine("Book reserved successfully.");
        }

        public void CheckAvailability()
        {
            Console.WriteLine("Book is available.");
        }
    }

    class Magazine : LibraryItem, IReservable
    {
        public Magazine(int itemId, string title, string author)
            : base(itemId, title, author)
        {
        }

        public override int GetLoanDuration()
        {
            return 7;
        }

        public void ReserveItem()
        {
            Console.WriteLine("Magazine reserved successfully.");
        }

        public void CheckAvailability()
        {
            Console.WriteLine("Magazine is available.");
        }
    }

    class DVD : LibraryItem, IReservable
    {
        public DVD(int itemId, string title, string author)
            : base(itemId, title, author)
        {
        }

        public override int GetLoanDuration()
        {
            return 3;
        }

        public void ReserveItem()
        {
            Console.WriteLine("DVD reserved successfully.");
        }

        public void CheckAvailability()
        {
            Console.WriteLine("DVD is available.");
        }
    }
}