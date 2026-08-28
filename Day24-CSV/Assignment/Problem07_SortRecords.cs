using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Problem07_SortRecords
{
    public static void Run()
    {
        string filePath ="employees.csv";
        string[] lines=File.ReadAllLines(filePath);
        List<string[]> employees = new List<string[]>();
        for (int i=1; i<lines.Length;i++)
        {
            employees.Add(lines[i].Split(','));
        }
        var sortedEmployees = employees
            .OrderByDescending(e => double.Parse(e[3]))
            .Take(5);

        Console.WriteLine("Top 5 Highest Paid Employees:");
        foreach (var employee in sortedEmployees)
        {
            Console.WriteLine(string.Join(" | ", employee));
        }
    }
}