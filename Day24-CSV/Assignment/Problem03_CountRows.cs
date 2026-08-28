using System;
using System.IO;

class Problem03_CountRows
{
    public static void Run()
    {
        string filePath = "students.csv";

        if (!File.Exists(filePath))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string[] lines = File.ReadAllLines(filePath);

        int recordCount = lines.Length - 1;

        Console.WriteLine($"Number of records: {recordCount}");
    }
}