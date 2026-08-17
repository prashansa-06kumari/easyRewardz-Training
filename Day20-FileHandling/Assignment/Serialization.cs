using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

class Employee
{
    public int id { get; set; }
    public string name { get; set; } = "";
    public string department { get; set; } = "";
    public double salary { get; set; }
}

class Serialization
{
    public static void Run()
    {
        string file = "employees.json";

        try
        {
            List<Employee> emp = new List<Employee>();

            emp.Add(new Employee
            {
                id = 1,
                name = "Rahul",
                department = "IT",
                salary = 50000
            });

            emp.Add(new Employee
            {
                id = 2,
                name = "Priya",
                department = "HR",
                salary = 45000
            });

            string json = JsonSerializer.Serialize(emp, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            File.WriteAllText(file, json);

            Console.WriteLine("Employees saved.");

            string data = File.ReadAllText(file);
            List<Employee>? employees =
                JsonSerializer.Deserialize<List<Employee>>(data);

            Console.WriteLine("\nEmployee Details:");

            if (employees != null)
            {
                foreach (Employee e in employees)
                {
                    Console.WriteLine(
                        e.id + " " +
                        e.name + " " +
                        e.department + " " +
                        e.salary
                    );
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Serialization error: " + ex.Message);
        }
    }
}