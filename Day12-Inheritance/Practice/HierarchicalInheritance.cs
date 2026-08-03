using System;

namespace Practice
{
    // BankAccount -> SavingsAccount, CheckingAccount, FixedDepositAccount

    class BankAccount
    {
        protected string accountNumber;
        protected double balance;

        public BankAccount(string accountNumber, double balance)
        {
            this.accountNumber = accountNumber;
            this.balance = balance;
        }

        public virtual void DisplayAccountType()
        {
            Console.WriteLine($"Account Number : {accountNumber}");
            Console.WriteLine($"Balance        : ₹{balance}");
        }
    }

    class SavingsAccount : BankAccount
    {
        private double interestRate;

        public SavingsAccount(string accountNumber, double balance, double interestRate)
            : base(accountNumber, balance)
        {
            this.interestRate = interestRate;
        }

        public override void DisplayAccountType()
        {
            base.DisplayAccountType();
            Console.WriteLine($"Account Type  : Savings Account");
            Console.WriteLine($"Interest Rate : {interestRate}%");
        }
    }

    class CheckingAccount : BankAccount
    {
        private double withdrawalLimit;

        public CheckingAccount(string accountNumber, double balance, double withdrawalLimit)
            : base(accountNumber, balance)
        {
            this.withdrawalLimit = withdrawalLimit;
        }

        public override void DisplayAccountType()
        {
            base.DisplayAccountType();
            Console.WriteLine($"Account Type     : Checking Account");
            Console.WriteLine($"Withdrawal Limit : ₹{withdrawalLimit}");
        }
    }

    class FixedDepositAccount : BankAccount
    {
        private int tenure;

        public FixedDepositAccount(string accountNumber, double balance, int tenure)
            : base(accountNumber, balance)
        {
            this.tenure = tenure;
        }

        public override void DisplayAccountType()
        {
            base.DisplayAccountType();
            Console.WriteLine($"Account Type : Fixed Deposit");
            Console.WriteLine($"Tenure       : {tenure} Years");
        }
    }

    // Person -> Teacher, Student, Staff

    class Person
    {
        protected string name;
        protected int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public virtual void DisplayRole()
        {
            Console.WriteLine($"Name : {name}");
            Console.WriteLine($"Age  : {age}");
        }
    }

    class Teacher : Person
    {
        private string subject;

        public Teacher(string name, int age, string subject)
            : base(name, age)
        {
            this.subject = subject;
        }

        public override void DisplayRole()
        {
            base.DisplayRole();
            Console.WriteLine($"Role    : Teacher");
            Console.WriteLine($"Subject : {subject}");
        }
    }

    class Student : Person
    {
        private string grade;

        public Student(string name, int age, string grade)
            : base(name, age)
        {
            this.grade = grade;
        }

        public override void DisplayRole()
        {
            base.DisplayRole();
            Console.WriteLine($"Role  : Student");
            Console.WriteLine($"Grade : {grade}");
        }
    }

    class Staff : Person
    {
        private string department;

        public Staff(string name, int age, string department)
            : base(name, age)
        {
            this.department = department;
        }

        public override void DisplayRole()
        {
            base.DisplayRole();
            Console.WriteLine($"Role       : Staff");
            Console.WriteLine($"Department : {department}");
        }
    }
}