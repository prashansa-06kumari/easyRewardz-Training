using System;

class Movie
{
    public string Title { get; set; }
    public string Director { get; set; }
    public int Year { get; set; }
    public double Rating { get; set; }

    public Movie(string title, string director, int year, double rating)
    {
        Title = title;
        Director = director;
        Year = year;
        Rating = rating;
    }
}

class MovieNode
{
    public Movie Data { get; set; }
    public MovieNode Next { get; set; }
    public MovieNode Prev { get; set; }

    public MovieNode(Movie movie)
    {
        Data = movie;
    }
}

class MovieLinkedList
{
    private MovieNode head;
    private MovieNode tail;

    public void AddAtBeginning(Movie movie)
    {
        MovieNode newNode = new MovieNode(movie);

        if (head == null)
        {
            head = tail = newNode;
        }
        else
        {
            newNode.Next = head;
            head.Prev = newNode;
            head = newNode;
        }
    }

    public void AddAtEnd(Movie movie)
    {
        MovieNode newNode = new MovieNode(movie);

        if (head == null)
        {
            head = tail = newNode;
        }
        else
        {
            tail.Next = newNode;
            newNode.Prev = tail;
            tail = newNode;
        }
    }

    public void AddAtPosition(Movie movie, int position)
    {
        if (position <= 1)
        {
            AddAtBeginning(movie);
            return;
        }

        MovieNode current = head;

        for (int i = 1; i < position - 1 && current != null; i++)
            current = current.Next;

        if (current == null)
        {
            Console.WriteLine("Invalid position.");
            return;
        }

        MovieNode newNode = new MovieNode(movie);

        newNode.Next = current.Next;
        newNode.Prev = current;

        if (current.Next != null)
            current.Next.Prev = newNode;
        else
            tail = newNode;

        current.Next = newNode;
    }

    public void RemoveByTitle(string title)
    {
        MovieNode current = head;

        while (current != null)
        {
            if (current.Data.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
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

        Console.WriteLine("Movie not found.");
    }

    public void SearchByDirector(string director)
    {
        MovieNode current = head;

        while (current != null)
        {
            if (current.Data.Director.Equals(director, StringComparison.OrdinalIgnoreCase))
                Console.WriteLine($"{current.Data.Title} - {current.Data.Rating}");

            current = current.Next;
        }
    }

    public void SearchByRating(double rating)
    {
        MovieNode current = head;

        while (current != null)
        {
            if (current.Data.Rating == rating)
                Console.WriteLine(current.Data.Title);

            current = current.Next;
        }
    }

    public void UpdateRating(string title, double rating)
    {
        MovieNode current = head;

        while (current != null)
        {
            if (current.Data.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
            {
                current.Data.Rating = rating;
                return;
            }

            current = current.Next;
        }
    }

    public void DisplayForward()
    {
        MovieNode current = head;

        while (current != null)
        {
            Console.WriteLine(
                $"{current.Data.Title} | {current.Data.Director} | " +
                $"{current.Data.Year} | {current.Data.Rating}");

            current = current.Next;
        }
    }

    public void DisplayReverse()
    {
        MovieNode current = tail;

        while (current != null)
        {
            Console.WriteLine(
                $"{current.Data.Title} | {current.Data.Director} | " +
                $"{current.Data.Year} | {current.Data.Rating}");

            current = current.Prev;
        }
    }
}