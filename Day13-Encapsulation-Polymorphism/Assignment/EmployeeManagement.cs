using System;

namespace Assignment
{
    interface IDepartment
    {
        void AssignDepartment(string department);
        void GetDepartmentDetails();
    }

    abstract class Employee : IDepartment
    {
        private int employeeId;
        private string name;
        private double baseSalary;

        private string department;

        public int EmployeeId
        {
            get { return employeeId; }
            set { employeeId = value; }
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    name = value;
            }
        }

        public double BaseSalary
        {
            get { return baseSalary; }
            set
            {
                if (value >= 0)
                    baseSalary = value;
            }
        }

        public Employee(int employeeId, string name, double baseSalary)
        {
            EmployeeId = employeeId;
            Name = name;
            BaseSalary = baseSalary;
        }

        public abstract double CalculateSalary();

        public void DisplayDetails()
        {
            Console.WriteLine($"ID         : {EmployeeId}");
            Console.WriteLine($"Name       : {Name}");
            Console.WriteLine($"Department : {department}");
            Console.WriteLine($"Salary     : ₹{CalculateSalary()}");
        }

        public void AssignDepartment(string department)
        {
            this.department = department;
        }

        public void GetDepartmentDetails()
        {
            Console.WriteLine($"Department : {department}");
        }
    }

    class FullTimeEmployee : Employee
    {
        public FullTimeEmployee(int employeeId, string name, double baseSalary)
            : base(employeeId, name, baseSalary)
        {
        }

        public override double CalculateSalary()
        {
            return BaseSalary;
        }
    }

    class PartTimeEmployee : Employee
    {
        private int workHours;

        public PartTimeEmployee(int employeeId, string name, double hourlyRate, int workHours)
            : base(employeeId, name, hourlyRate)
        {
            this.workHours = workHours;
        }

        public override double CalculateSalary()
        {
            return BaseSalary * workHours;
        }
    }
}