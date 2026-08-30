using System;
using System.Collections.Generic;
using Newtonsoft.Json;

class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
}

class Problem06_ListToJson
{
    public static void Run()
    {
        List<Employee> employees =
            new List<Employee>
            {
                new Employee
                {
                    Id = 1,
                    Name = "Rahul",
                    Department = "IT"
                },

                new Employee
                {
                    Id = 2,
                    Name = "Priya",
                    Department = "HR"
                },

                new Employee
                {
                    Id = 3,
                    Name = "Aman",
                    Department = "Finance"
                }
            };

        string json = JsonConvert.SerializeObject(
            employees,
            Formatting.Indented
        );

        Console.WriteLine(json);
    }
}