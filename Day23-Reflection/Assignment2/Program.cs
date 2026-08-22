using System;

public class Program
{
    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("1. Method Overriding");
            Console.WriteLine("2. Obsolete Attribute");
            Console.WriteLine("3. Pragma Warning");
            Console.WriteLine("4. TaskInfo Attribute");
            Console.WriteLine("5. Repeatable BugReport Attribute");
            Console.WriteLine("6. ImportantMethod Attribute");
            Console.WriteLine("7. Todo Attribute");
            Console.WriteLine("8. LogExecutionTime Attribute");
            Console.WriteLine("9. MaxLength Attribute");
            Console.WriteLine("10. RoleAllowed Attribute");
            Console.WriteLine("11. JsonField Attribute");
            Console.WriteLine("12. CacheResult Attribute");
            Console.WriteLine("0. Exit");

            Console.Write("\nEnter your choice: ");

            string choice = Console.ReadLine();

            Console.WriteLine();

            try
            {
                switch (choice)
                {
                    case "1":
                        Exercise1.Run();
                        break;

                    case "2":
                        Exercise2.Run();
                        break;

                    case "3":
                        Exercise3.Run();
                        break;

                    case "4":
                        Exercise4.Run();
                        break;

                    case "5":
                        Exercise5.Run();
                        break;

                    case "6":
                        Problem1.Run();
                        break;

                    case "7":
                        Problem2.Run();
                        break;

                    case "8":
                        Problem3.Run();
                        break;

                    case "9":
                        Problem4.Run();
                        break;

                    case "10":
                        Problem5.Run();
                        break;

                    case "11":
                        Problem6.Run();
                        break;

                    case "12":
                        Problem7.Run();
                        break;

                    case "0":
                        Console.WriteLine("Program ended.");
                        return;

                    default:
                        Console.WriteLine(
                            "Invalid choice.");
                        break;
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(
                    "Error: " + exception.Message);
            }

            Console.WriteLine();
            Console.WriteLine(
                "Press ENTER to continue...");

            Console.ReadLine();
        }
    }
}