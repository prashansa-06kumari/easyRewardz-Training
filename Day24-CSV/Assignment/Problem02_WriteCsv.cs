using System;
using System.IO;

class Problem02_WriteCsv
{
    public static void Run()
    {
        string filePath = "employees.csv";

        string[] employees =
        {
            "ID,Name,Department,Salary",
            "1,Rahul,IT,50000",
            "2,Anita,HR,45000",
            "3,Aman,Finance,55000",
            "4,Priya,IT,60000",
            "5,Rohit,Sales,48000"
        };

        File.WriteAllLines(filePath, employees);

        Console.WriteLine("Employee CSV file created successfully.");
    }
}