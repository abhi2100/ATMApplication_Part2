using System.Collections.Generic;

namespace ATMApplication.Models
{
    public class Bank
    {
        private static Bank _instance;
        private List<Account> _accounts;

        private Bank()
        {
            _accounts = new List<Account>();
        }

        public static Bank Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Bank();
                }
                return _instance;
            }
        }

        public void CreateAccount(string accountNumber, string accountHolderName, double initialDeposit, double interestRate)
        {
            var account = new Account(accountNumber, accountHolderName, initialDeposit, interestRate);
            _accounts.Add(account);
        }

        public Account GetAccount(string accountNumber)
        {
            return _accounts.Find(a => a.AccountNumber == accountNumber);
        }
    }
}
