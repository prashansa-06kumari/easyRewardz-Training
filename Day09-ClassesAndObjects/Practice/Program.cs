using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] menu1 = { "Pizza", "Pasta", "Burger" };
            string[] menu2 = { "Sushi", "Ramen", "Tempura" };

            Restaurant restaurant1 = new Restaurant("Italian Delight", "Downtown", menu1);
            Restaurant restaurant2 = new Restaurant("Tokyo Treats", "Uptown", menu2);

            Console.WriteLine("Restaurant 1");
            restaurant1.DisplayDetails();
            Console.WriteLine();
            Console.WriteLine("Restaurant 2");
            restaurant2.DisplayDetails();

            Console.WriteLine();
            Console.WriteLine("Is Pasta Available? " + restaurant1.IsFoodAvailable("Pasta"));
            Console.WriteLine("Is Sushi Available? " + restaurant1.IsFoodAvailable("Sushi"));
        }
    }
}