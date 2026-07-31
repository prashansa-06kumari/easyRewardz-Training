using System;

namespace Assignment
{
    class BankAccount
    {
        public string accountNumber;
        protected string accountHolder;
        private double balance;
        public BankAccount(string accountNumber, string accountHolder, double balance)
        {
            this.accountNumber = accountNumber;
            this.accountHolder = accountHolder;
            this.balance = balance;
        }
        public void SetBalance(double balance)
        {
            this.balance = balance;
        }
        public double GetBalance()
        {
            return balance;
        }
    }
}