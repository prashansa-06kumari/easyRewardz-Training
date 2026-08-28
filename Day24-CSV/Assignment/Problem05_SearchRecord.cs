using System;
using System.IO;

class Problem05_SearchRecord
{
    public static void Run()
    {
        string filePath = "employees.csv";

        Console.Write("Enter employee name: ");
        string searchName = Console.ReadLine();

        string[] lines = File.ReadAllLines(filePath);

        bool found = false;

        for (int i = 1; i < lines.Length; i++)
        {
            string[] data = lines[i].Split(',');

            if (data[1].Equals(searchName, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Department: {data[2]}");
                Console.WriteLine($"Salary: {data[3]}");

                found = true;
                break;
            }
        }

        if (!found)
        {
            Console.WriteLine("Employee not found.");
        }
    }
}