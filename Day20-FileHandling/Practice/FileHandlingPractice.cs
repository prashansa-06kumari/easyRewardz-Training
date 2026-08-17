using System;
using System.IO;

class FileHandlingPractice
{
    public static void Run()
    {
        string file = "practice.txt";

        try
        {
            Console.Write("Enter some text: ");
            string text = Console.ReadLine() ?? "";

            using StreamWriter writer = new StreamWriter(file);
            writer.WriteLine(text);

            Console.WriteLine("Data saved successfully.");

            using StreamReader reader = new StreamReader(file);

            Console.WriteLine("\nData from file:");
            Console.WriteLine(reader.ReadToEnd());
        }
        catch (IOException ex)
        {
            Console.WriteLine("File error: " + ex.Message);
        }
    }
}