using System;

namespace Assignment
{
    class Employee
    {
        protected string name;
        protected int id;
        protected double salary;

        // Initialize employee details
        public Employee(string name, int id, double salary)
        {
            this.name = name;
            this.id = id;
            this.salary = salary;
        }

        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Name   : {name}");
            Console.WriteLine($"ID     : {id}");
            Console.WriteLine($"Salary : ₹{salary}");
        }
    }

    class Manager : Employee
    {
        private int teamSize;

        public Manager(string name, int id, double salary, int teamSize)
            : base(name, id, salary)
        {
            this.teamSize = teamSize;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Team Size : {teamSize}");
        }
    }

    class Developer : Employee
    {
        private string programmingLanguage;

        public Developer(string name, int id, double salary, string programmingLanguage)
            : base(name, id, salary)
        {
            this.programmingLanguage = programmingLanguage;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Language  : {programmingLanguage}");
        }
    }

    class Intern : Employee
    {
        private string internshipDuration;

        public Intern(string name, int id, double salary, string internshipDuration)
            : base(name, id, salary)
        {
            this.internshipDuration = internshipDuration;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Duration  : {internshipDuration}");
        }
    }
}