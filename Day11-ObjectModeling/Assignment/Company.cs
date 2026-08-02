using System;
using System.Collections.Generic;

namespace Assignment
{
    class Company
    {
        public string CompanyName { get; set; }
        private List<Department> departments;

        // Initialize company details
        public Company(string companyName)
        {
            CompanyName = companyName;
            departments = new List<Department>();
        }

        public Department CreateDepartment(string departmentName)
        {
            Department department = new Department(departmentName);
            departments.Add(department);

            return department;
        }

        public void DisplayCompany()
        {
            Console.WriteLine($"Company : {CompanyName}");
            Console.WriteLine();

            foreach (Department department in departments)
            {
                department.DisplayEmployees();
                Console.WriteLine();
            }
        }
    }
}