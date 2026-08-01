using System;

namespace Assignment2
{
    class EmployeeManagement
    {
        public static string CompanyName = "EasyRewardz";
        private static int totalEmployees = 0;
        private string name;
        public readonly int Id;
        private string designation;

        // Parameterized constructor
        public EmployeeManagement(string name, int id, string designation)
        {
            this.name = name;
            Id = id;
            this.designation = designation;
            totalEmployees++;
        }
        public void DisplayDetails()
        {
            Console.WriteLine($"Company     : {CompanyName}");
            Console.WriteLine($"Name        : {name}");
            Console.WriteLine($"Employee ID : {Id}");
            Console.WriteLine($"Designation : {designation}");
        }

        public static void DisplayTotalEmployees()
        {
            Console.WriteLine($"Total Employees : {totalEmployees}");
        }
    }
}