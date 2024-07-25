using System;
using System.Collections.Generic;

namespace ATMApplication.Models
{
    public class Account
    {
        public string AccountNumber { get; }
        public string AccountHolderName { get; }
        public double InitialDeposit { get; }
        public double InterestRate { get; }
        private double _balance;
        private List<Transaction> _transactions;

        public Account(string accountNumber, string accountHolderName, double initialDeposit, double interestRate)
        {
            AccountNumber = accountNumber;
            AccountHolderName = accountHolderName;
            InitialDeposit = initialDeposit;
            InterestRate = interestRate;
            _balance = initialDeposit;
            _transactions = new List<Transaction>
            {
                new Transaction("Initial Deposit", initialDeposit)
            };
        }

        public double Balance => _balance;

        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                throw new InvalidOperationException("Deposit amount must be positive.");
            }

            _balance += amount;
            _transactions.Add(new Transaction("Deposit", amount));
        }

        public void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                throw new InvalidOperationException("Withdrawal amount must be positive.");
            }

            if (amount > _balance)
            {
                throw new InvalidOperationException("Insufficient funds.");
            }

            _balance -= amount;
            _transactions.Add(new Transaction("Withdrawal", amount));
        }

        public IEnumerable<Transaction> GetTransactions()
        {
            return _transactions;
        }
    }
}
