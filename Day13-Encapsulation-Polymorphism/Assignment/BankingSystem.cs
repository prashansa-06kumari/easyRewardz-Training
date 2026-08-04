using System;

namespace Assignment
{
    interface ILoanable
    {
        void ApplyForLoan(double amount);
        bool CalculateLoanEligibility();
    }

    abstract class BankAccount
    {
        private string accountNumber;
        private string holderName;
        private double balance;

        public string AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }

        public string HolderName
        {
            get { return holderName; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    holderName = value;
            }
        }

        public double Balance
        {
            get { return balance; }
            protected set { balance = value; }
        }

        public BankAccount(string accountNumber, string holderName, double balance)
        {
            AccountNumber = accountNumber;
            HolderName = holderName;
            Balance = balance;
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
                Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= Balance)
                Balance -= amount;
        }

        public abstract double CalculateInterest();

        public void DisplayDetails()
        {
            Console.WriteLine($"Account Number : {AccountNumber}");
            Console.WriteLine($"Holder Name    : {HolderName}");
            Console.WriteLine($"Balance        : ₹{Balance}");
        }
    }

    class SavingsAccount : BankAccount, ILoanable
    {
        public SavingsAccount(string accountNumber, string holderName, double balance)
            : base(accountNumber, holderName, balance)
        {
        }

        public override double CalculateInterest()
        {
            return Balance * 0.06;
        }

        public void ApplyForLoan(double amount)
        {
            Console.WriteLine($"Loan Applied : ₹{amount}");
        }

        public bool CalculateLoanEligibility()
        {
            return Balance >= 50000;
        }
    }

    class CurrentAccount : BankAccount, ILoanable
    {
        public CurrentAccount(string accountNumber, string holderName, double balance)
            : base(accountNumber, holderName, balance)
        {
        }

        public override double CalculateInterest()
        {
            return Balance * 0.03;
        }

        public void ApplyForLoan(double amount)
        {
            Console.WriteLine($"Loan Applied : ₹{amount}");
        }

        public bool CalculateLoanEligibility()
        {
            return Balance >= 100000;
        }
    }
}