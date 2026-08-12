using System;

class Book
{
    public int BookId { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public string Genre { get; set; }
    public bool IsAvailable { get; set; }

    public Book(int bookId, string title, string author, string genre, bool isAvailable)
    {
        BookId = bookId;
        Title = title;
        Author = author;
        Genre = genre;
        IsAvailable = isAvailable;
    }
}

class BookNode
{
    public Book Data { get; set; }
    public BookNode Next { get; set; }
    public BookNode Prev { get; set; }

    public BookNode(Book book)
    {
        Data = book;
    }
}

class LibraryLinkedList
{
    private BookNode head;
    private BookNode tail;

    public void AddAtBeginning(Book book)
    {
        BookNode node = new BookNode(book);

        if (head == null)
            head = tail = node;
        else
        {
            node.Next = head;
            head.Prev = node;
            head = node;
        }
    }

    public void AddAtEnd(Book book)
    {
        BookNode node = new BookNode(book);

        if (head == null)
            head = tail = node;
        else
        {
            tail.Next = node;
            node.Prev = tail;
            tail = node;
        }
    }

    public void AddAtPosition(Book book, int position)
    {
        if (position <= 1)
        {
            AddAtBeginning(book);
            return;
        }

        BookNode current = head;

        for (int i = 1; i < position - 1 && current != null; i++)
            current = current.Next;

        if (current == null)
            return;

        BookNode node = new BookNode(book);

        node.Next = current.Next;
        node.Prev = current;

        if (current.Next != null)
            current.Next.Prev = node;
        else
            tail = node;

        current.Next = node;
    }

    public void Remove(int bookId)
    {
        BookNode current = head;

        while (current != null)
        {
            if (current.Data.BookId == bookId)
            {
                if (current.Prev != null)
                    current.Prev.Next = current.Next;
                else
                    head = current.Next;

                if (current.Next != null)
                    current.Next.Prev = current.Prev;
                else
                    tail = current.Prev;

                return;
            }

            current = current.Next;
        }
    }

    public Book SearchByTitle(string title)
    {
        BookNode current = head;

        while (current != null)
        {
            if (current.Data.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
                return current.Data;

            current = current.Next;
        }

        return null;
    }

    public void SearchByAuthor(string author)
    {
        BookNode current = head;

        while (current != null)
        {
            if (current.Data.Author.Equals(author, StringComparison.OrdinalIgnoreCase))
                Console.WriteLine(current.Data.Title);

            current = current.Next;
        }
    }

    public void UpdateAvailability(int bookId, bool status)
    {
        BookNode current = head;

        while (current != null)
        {
            if (current.Data.BookId == bookId)
            {
                current.Data.IsAvailable = status;
                return;
            }

            current = current.Next;
        }
    }

    public int Count()
    {
        int count = 0;
        BookNode current = head;

        while (current != null)
        {
            count++;
            current = current.Next;
        }

        return count;
    }

    public void DisplayForward()
    {
        BookNode current = head;

        while (current != null)
        {
            Console.WriteLine(
                $"{current.Data.BookId} | {current.Data.Title} | " +
                $"{current.Data.Author} | Available: {current.Data.IsAvailable}");

            current = current.Next;
        }
    }

    public void DisplayReverse()
    {
        BookNode current = tail;

        while (current != null)
        {
            Console.WriteLine(
                $"{current.Data.BookId} | {current.Data.Title} | " +
                $"{current.Data.Author} | Available: {current.Data.IsAvailable}");

            current = current.Prev;
        }
    }
}