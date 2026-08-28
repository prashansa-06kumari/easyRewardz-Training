using System;
using System.Collections.Generic;
using System.IO;

class Problem06_UpdateSalary
{
    public static void Run()
    {
        string inputFile = "employees.csv";
        string outputFile = "updated_employees.csv";

        string[] lines = File.ReadAllLines(inputFile);

        List<string> updatedLines = new List<string>();

        updatedLines.Add(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] data = lines[i].Split(',');

            string department = data[2];
            double salary = double.Parse(data[3]);

            if (department.Equals("IT", StringComparison.OrdinalIgnoreCase))
            {
                salary = salary * 1.10;
            }

            data[3] = salary.ToString("F2");

            updatedLines.Add(string.Join(",", data));
        }

        File.WriteAllLines(outputFile, updatedLines);

        Console.WriteLine("Updated CSV created.");
    }
}