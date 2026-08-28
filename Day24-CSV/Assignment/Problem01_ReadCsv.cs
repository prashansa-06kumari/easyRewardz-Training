using System;
using System.IO;

class Problem01_ReadCsv
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

        Console.WriteLine("Student Records:");
        for (int i = 1; i < lines.Length; i++)
        {
            string[] data = lines[i].Split(',');
            Console.WriteLine(
                $"ID: {data[0]}, Name: {data[1]}, Age: {data[2]}, Marks: {data[3]}"
            );
        }
    }
}