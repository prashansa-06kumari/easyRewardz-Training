using System;

namespace Assignment
{
    class SavingsAccount : BankAccount
    {
        public SavingsAccount(string accountNumber, string accountHolder, double balance)
            : base(accountNumber, accountHolder, balance)
        {
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Account Number : {accountNumber}");
            Console.WriteLine($"Account Holder : {accountHolder}");
            Console.WriteLine($"Balance        : ₹{GetBalance()}");
        }
    }
}