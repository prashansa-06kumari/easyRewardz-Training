using System;
using System.IO;

class Problem04_FilterRecords
{
    public static void Run()
    {
        string filePath = "students.csv";

        string[] lines = File.ReadAllLines(filePath);

        Console.WriteLine("Students with marks greater than 80:");

        for (int i = 1; i < lines.Length; i++)
        {
            string[] data = lines[i].Split(',');

            int marks = int.Parse(data[3]);

            if (marks > 80)
            {
                Console.WriteLine(lines[i]);
            }
        }
    }
}