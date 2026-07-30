using System;

namespace Assignment
{
    class Employee
    {
        private string name;
        private int id;
        private double salary;
        public Employee(string name, int id, double salary)
        {
            this.name = name;
            this.id = id;
            this.salary = salary;
        }
        public void DisplayDetails()
        {
            Console.WriteLine($"Name   : {name}");
            Console.WriteLine($"ID     : {id}");
            Console.WriteLine($"Salary : ₹{salary}");
        }
    }
}