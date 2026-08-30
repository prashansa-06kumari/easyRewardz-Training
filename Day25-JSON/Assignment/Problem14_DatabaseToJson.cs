using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

class DatabaseEmployee
{
    public int EmployeeId { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public double Salary { get; set; }
}

class Problem14_DatabaseToJson
{
    public static void Run()
    {
        List<DatabaseEmployee> employees =
            new List<DatabaseEmployee>
            {
                new DatabaseEmployee
                {
                    EmployeeId = 101,
                    Name = "Rahul",
                    Department = "IT",
                    Salary = 60000
                },

                new DatabaseEmployee
                {
                    EmployeeId = 102,
                    Name = "Priya",
                    Department = "HR",
                    Salary = 50000
                },

                new DatabaseEmployee
                {
                    EmployeeId = 103,
                    Name = "Aman",
                    Department = "Finance",
                    Salary = 70000
                }
            };

        string json =
            JsonConvert.SerializeObject(
                employees,
                Formatting.Indented
            );

        File.WriteAllText(
            "employee_report.json",
            json
        );

        Console.WriteLine(
            "JSON database report generated."
        );
    }
}