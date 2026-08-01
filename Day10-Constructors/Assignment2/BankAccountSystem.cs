using System;

namespace Assignment2
{
    class BankAccountSystem
    {
        public static string BankName = "State Bank of India";
        private static int totalAccounts = 0;

        private string accountHolderName;
        public readonly string accountNumber;

        // Parameterized constructor
        public BankAccountSystem(string accountHolderName, string accountNumber)
        {
            this.accountHolderName = accountHolderName;
            this.accountNumber = accountNumber;
            totalAccounts++;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Bank Name      : {BankName}");
            Console.WriteLine($"Account Holder : {accountHolderName}");
            Console.WriteLine($"Account Number : {accountNumber}");
        }

        public static void GetTotalAccounts()
        {
            Console.WriteLine($"Total Accounts : {totalAccounts}");
        }
    }
}