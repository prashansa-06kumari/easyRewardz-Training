using System;
using System.Collections.Generic;
using System.IO;

class Problem13_DatabaseToCsv
{
    public static void Run()
    {
        List<string[]> employees = new List<string[]>();
        employees.Add(new string[] { "1","Rahul", "IT","50000" });
        employees.Add(new string[] { "2","Anita","HR", "45000" });
        employees.Add(new string[] { "3","Aman", "Finance", "55000" });
        employees.Add(new string[] { "4","Priya","IT","60000" });
        string filePath = "database_report.csv";
        List<string> lines = new List<string>();
        lines.Add("Employee ID,Name,Department,Salary");
        foreach (string[] employee in employees)
        {
            lines.Add(string.Join(",", employee));
        }
        File.WriteAllLines(filePath, lines);
        Console.WriteLine("Database report CSV created.");
    }
}