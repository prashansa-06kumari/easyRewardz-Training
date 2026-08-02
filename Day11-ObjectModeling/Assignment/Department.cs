using System;
using System.Collections.Generic;

namespace Assignment
{
    class Department
    {
        public string DepartmentName { get; set; }
        private List<Employee> employees;

        // Initialize department details
        public Department(string departmentName)
        {
            DepartmentName = departmentName;
            employees = new List<Employee>();
        }

        public void AddEmployee(string employeeName)
        {
            employees.Add(new Employee(employeeName));
        }

        public void DisplayEmployees()
        {
            Console.WriteLine($"Department : {DepartmentName}");

            foreach (Employee employee in employees)
            {
                Console.WriteLine($"- {employee.Name}");
            }
        }
    }
}