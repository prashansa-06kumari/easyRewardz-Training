using System;
using System.IO;

class ConsoleInput
{
    public static void Run()
    {
        try
        {
            using StreamReader reader = new StreamReader(Console.OpenStandardInput());

            Console.Write("Enter name: ");
            string name = reader.ReadLine() ?? "";

            Console.Write("Enter age: ");
            string age = reader.ReadLine() ?? "";

            Console.Write("Enter favorite programming language: ");
            string lang = reader.ReadLine() ?? "";

            using StreamWriter writer = new StreamWriter("user.txt");

            writer.WriteLine("Name: " + name);
            writer.WriteLine("Age: " + age);
            writer.WriteLine("Favorite Language: " + lang);

            Console.WriteLine("Information saved successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}