using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n=================================");
            Console.WriteLine("       LINKED LIST ASSIGNMENTS");
            Console.WriteLine("=================================");
            Console.WriteLine("1. Student Record Management");
            Console.WriteLine("2. Movie Management System");
            Console.WriteLine("3. Circular Task Scheduler");
            Console.WriteLine("4. Inventory Management System");
            Console.WriteLine("5. Library Management System");
            Console.WriteLine("6. Round Robin Scheduling");
            Console.WriteLine("7. Social Media Friend Connections");
            Console.WriteLine("8. Undo/Redo Text Editor");
            Console.WriteLine("9. Ticket Reservation System");
            Console.WriteLine("0. Exit");
            Console.Write("\nEnter your choice: ");

            string choice = Console.ReadLine();

            Console.Clear();

            switch (choice)
            {
                case "1":
                    StudentRecordManagement();
                    break;

                case "2":
                    MovieManagementSystem();
                    break;

                case "3":
                    CircularTaskScheduler();
                    break;

                case "4":
                    InventoryManagementSystem();
                    break;

                case "5":
                    LibraryManagementSystem();
                    break;

                case "6":
                    RoundRobinScheduling();
                    break;

                case "7":
                    SocialMediaFriends();
                    break;

                case "8":
                    UndoRedoTextEditor();
                    break;

                case "9":
                    TicketReservationSystem();
                    break;

                case "0":
                    Console.WriteLine("Exiting...");
                    return;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

            Console.WriteLine("\nPress any key to return to menu...");
            Console.ReadKey();
            Console.Clear();
        }
    }

    // 1. Singly Linked List - Student Record Management
    static void StudentRecordManagement()
    {
        Console.WriteLine("===== STUDENT RECORD MANAGEMENT =====\n");

        StudentLinkedList students = new StudentLinkedList();

        students.AddAtBeginning(
            new Student(1, "Rahul", 20, 'A'));

        students.AddAtEnd(
            new Student(2, "Priya", 21, 'B'));

        students.AddAtEnd(
            new Student(3, "Aman", 19, 'A'));

        students.AddAtPosition(
            new Student(4, "Neha", 20, 'B'), 2);

        Console.WriteLine("Student Records:");
        students.Display();

        Console.WriteLine("\nSearching for Roll Number 2:");

        Student student = students.Search(2);

        if (student != null)
        {
            Console.WriteLine(
                $"{student.RollNumber} - {student.Name} - {student.Age} - {student.Grade}");
        }

        Console.WriteLine("\nUpdating Grade of Roll Number 2:");
        students.UpdateGrade(2, 'A');

        students.Display();
        Console.WriteLine("\nDeleting Roll Number 3:");
        students.DeleteByRollNumber(3);
        students.Display();
    }

    // 2. Doubly Linked List - Movie Management
    static void MovieManagementSystem()
    {
        Console.WriteLine("===== MOVIE MANAGEMENT SYSTEM =====\n");

        MovieLinkedList movies = new MovieLinkedList();

        movies.AddAtBeginning(
            new Movie("Inception", "Christopher Nolan", 2010, 8.8));

        movies.AddAtEnd(
            new Movie("Interstellar", "Christopher Nolan", 2014, 8.7));

        movies.AddAtEnd(
            new Movie("Titanic", "James Cameron", 1997, 7.9));

        movies.AddAtPosition(
            new Movie("Avatar", "James Cameron", 2009, 7.8), 2);

        Console.WriteLine("Movies - Forward:");
        movies.DisplayForward();
        Console.WriteLine("\nMovies - Reverse:");
        movies.DisplayReverse();
        Console.WriteLine("\nMovies directed by Christopher Nolan:");
        movies.SearchByDirector("Christopher Nolan");

        Console.WriteLine("\nUpdating rating of Titanic:");

        movies.UpdateRating("Titanic", 8.0);

        movies.DisplayForward();

        Console.WriteLine("\nRemoving Avatar:");

        movies.RemoveByTitle("Avatar");

        movies.DisplayForward();
    }

    // 3. Circular Linked List - Task Scheduler
    static void CircularTaskScheduler()
    {
        Console.WriteLine("===== CIRCULAR TASK SCHEDULER =====\n");

        TaskScheduler scheduler = new TaskScheduler();

        scheduler.AddAtBeginning(
            new TaskItem(1, "Study C#", 1, "12-08-2026"));

        scheduler.AddAtEnd(
            new TaskItem(2, "Practice LINQ", 2, "13-08-2026"));

        scheduler.AddAtEnd(
            new TaskItem(3, "Practice LinkedList", 1, "14-08-2026"));

        Console.WriteLine("All Tasks:");
        scheduler.Display();
        Console.WriteLine("\nCurrent Task:");
        scheduler.ViewCurrentTask();
        Console.WriteLine("\nMoving to next task:");
        scheduler.MoveNext();
        scheduler.ViewCurrentTask();

        Console.WriteLine("\nTasks with Priority 1:");
        scheduler.SearchByPriority(1);
        Console.WriteLine("\nRemoving Task 2:");
        scheduler.Remove(2);
        scheduler.Display();
    }

    // 4. Singly Linked List - Inventory Management
    static void InventoryManagementSystem()
    {
        Console.WriteLine("===== INVENTORY MANAGEMENT SYSTEM =====\n");

        InventoryLinkedList inventory = new InventoryLinkedList();

        inventory.AddAtBeginning(
            new InventoryItem(1, "Laptop", 5, 50000));

        inventory.AddAtEnd(
            new InventoryItem(2, "Mouse", 10, 500));

        inventory.AddAtEnd(
            new InventoryItem(3, "Keyboard", 8, 1000));

        inventory.AddAtPosition(
            new InventoryItem(4, "Monitor", 4, 15000), 2);

        Console.WriteLine("Inventory:");
        inventory.Display();

        Console.WriteLine("\nUpdating Laptop quantity:");

        inventory.UpdateQuantity(1, 10);

        inventory.Display();

        Console.WriteLine("\nSearching for Item ID 2:");

        InventoryItem item = inventory.SearchById(2);

        if (item != null)
        {
            Console.WriteLine(
                $"{item.ItemId} - {item.ItemName} - {item.Quantity} - {item.Price}");
        }
        Console.WriteLine("\nTotal Inventory Value:");
        Console.WriteLine(inventory.TotalValue());

        Console.WriteLine("\nRemoving Item ID 3:");

        inventory.Remove(3);

        inventory.Display();
    }

    // 5. Doubly Linked List - Library Management
    static void LibraryManagementSystem()
    {
        Console.WriteLine("===== LIBRARY MANAGEMENT SYSTEM =====\n");

        LibraryLinkedList library = new LibraryLinkedList();

        library.AddAtBeginning(
            new Book(1, "Clean Code", "Robert Martin", "Programming", true));

        library.AddAtEnd(
            new Book(2, "The Pragmatic Programmer", "Andrew Hunt", "Programming", true));

        library.AddAtEnd(
            new Book(3, "C# in Depth", "Jon Skeet", "Programming", false));

        library.AddAtPosition(
            new Book(4, "Design Patterns", "Erich Gamma", "Programming", true), 2);

        Console.WriteLine("Books - Forward:");
        library.DisplayForward();

        Console.WriteLine("\nBooks - Reverse:");
        library.DisplayReverse();

        Console.WriteLine("\nSearching for Clean Code:");

        Book book = library.SearchByTitle("Clean Code");

        if (book != null)
        {
            Console.WriteLine(
                $"{book.Title} - {book.Author} - Available: {book.IsAvailable}");
        }

        Console.WriteLine("\nUpdating availability of Book ID 3:");

        library.UpdateAvailability(3, true);

        library.DisplayForward();

        Console.WriteLine("\nTotal Books:");

        Console.WriteLine(library.Count());

        Console.WriteLine("\nRemoving Book ID 2:");

        library.Remove(2);

        library.DisplayForward();
    }

    // 6. Circular Linked List - Round Robin Scheduling
    static void RoundRobinScheduling()
    {
        Console.WriteLine("===== ROUND ROBIN SCHEDULING =====\n");

        RoundRobin roundRobin = new RoundRobin();

        roundRobin.AddProcess(
            new Process(1, 10));

        roundRobin.AddProcess(
            new Process(2, 5));

        roundRobin.AddProcess(
            new Process(3, 8));

        Console.WriteLine("Running Round Robin Scheduling...");
        Console.WriteLine("Time Quantum = 3\n");

        roundRobin.Schedule(3);
    }

    // 7. Social Media Friend Connections
    static void SocialMediaFriends()
    {
        Console.WriteLine("===== SOCIAL MEDIA FRIEND CONNECTIONS =====\n");

        SocialMediaSystem socialMedia = new SocialMediaSystem();

        socialMedia.AddUser(
            new User(1, "Rahul", 22));

        socialMedia.AddUser(
            new User(2, "Priya", 21));

        socialMedia.AddUser(
            new User(3, "Aman", 23));

        socialMedia.AddUser(
            new User(4, "Neha", 22));

        socialMedia.AddFriend(1, 2);
        socialMedia.AddFriend(1, 3);
        socialMedia.AddFriend(2, 3);
        socialMedia.AddFriend(2, 4);

        Console.WriteLine("Rahul's Friends:");

        socialMedia.DisplayFriends(1);

        Console.WriteLine("\nMutual Friends of Rahul and Priya:");

        socialMedia.FindMutualFriends(1, 2);

        Console.WriteLine("\nFriend Count:");

        socialMedia.CountFriends();

        Console.WriteLine("\nRemoving Rahul and Aman friendship:");

        socialMedia.RemoveFriend(1, 3);

        socialMedia.DisplayFriends(1);
    }

    // 8. Doubly Linked List - Undo/Redo
    static void UndoRedoTextEditor()
    {
        Console.WriteLine("===== UNDO / REDO TEXT EDITOR =====\n");

        TextEditorHistory editor = new TextEditorHistory();

        editor.AddState("Hello");
        editor.AddState("Hello World");
        editor.AddState("Hello World!");

        Console.WriteLine("Current State:");
        editor.DisplayCurrentState();

        Console.WriteLine("\nUndo:");

        editor.Undo();
        editor.DisplayCurrentState();

        Console.WriteLine("\nUndo again:");

        editor.Undo();
        editor.DisplayCurrentState();

        Console.WriteLine("\nRedo:");

        editor.Redo();
        editor.DisplayCurrentState();

        Console.WriteLine("\nAdding new state:");

        editor.AddState("Hello C#");
        editor.DisplayCurrentState();
    }

    // 9. Circular Linked List - Ticket Reservation
    static void TicketReservationSystem()
    {
        Console.WriteLine("===== TICKET RESERVATION SYSTEM =====\n");

        TicketReservation tickets = new TicketReservation();

        tickets.AddTicket(
            new Ticket(
                1,
                "Rahul",
                "Avengers",
                "A10",
                "10:30 AM"));

        tickets.AddTicket(
            new Ticket(
                2,
                "Priya",
                "Avengers",
                "A11",
                "10:35 AM"));

        tickets.AddTicket(
            new Ticket(
                3,
                "Aman",
                "Batman",
                "B05",
                "11:00 AM"));

        Console.WriteLine("Booked Tickets:");

        tickets.Display();

        Console.WriteLine("\nTickets booked by Rahul:");

        tickets.SearchByCustomer("Rahul");

        Console.WriteLine("\nTickets for Avengers:");

        tickets.SearchByMovie("Avengers");

        Console.WriteLine("\nTotal Booked Tickets:");

        Console.WriteLine(tickets.CountTickets());

        Console.WriteLine("\nRemoving Ticket ID 2:");

        tickets.RemoveTicket(2);

        tickets.Display();

        Console.WriteLine("\nTotal Booked Tickets:");

        Console.WriteLine(tickets.CountTickets());
    }
}