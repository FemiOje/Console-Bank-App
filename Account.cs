using System;
using System.Collections;

namespace Console_Bank_App
{
    public class Account
    {
        /// <summary>
        /// Customer's account number.
        /// </summary>
        private string AccountNumber { get; set; }

        private UInt64 AccountNumbers = 0000000000;

        /// <summary>
        /// Account holder's name.
        /// </summary>
        public string AccountName { get; private set; }  // Changed to public with private setter

        /// <summary>
        /// Account balance.
        /// </summary>
        private double AccountBalance { get; set; }

        /// <summary>
        /// Account holder's account must be one of savings, current or domiciliary.
        /// </summary>
        public enum AccountType
        {
            Savings,
            Current,
            Domiciliary
        }

        /// <summary>
        /// Account holder's account must be one of savings, current or domiciliary.
        /// </summary>
        private AccountType _accountType;

        /// <summary>
        /// Creates a new account with the account number generated automatically.
        /// </summary>
        /// <param name="accountName">Preferred name for the newly created account.</param>
        /// <param name="type">Either of savings, current or domiciliary.</param>
        public Account(string accountName, AccountType type)
        {
            AccountName = accountName;
            _accountType = type;
            AccountBalance = 0.00;
            AccountNumber = GenerateAccountNumber();
        }

        /// <summary>
        /// Creates a new savings account by default with the specified account name, and account number generated automatically.
        /// </summary>
        /// <param name="accountName"></param>
        public Account(string accountName)
        {
            AccountName = accountName;
            _accountType = AccountType.Savings;
            AccountBalance = 0.00;
            AccountNumber = GenerateAccountNumber();
        }

        /// <summary>
        /// Generates an account number automatically for a newly created account
        /// </summary>
        /// <returns>New user's account number</returns>
        public string GenerateAccountNumber()
        {
            AccountNumbers++;
            string currentAccountNumber = AccountNumbers.ToString("D10");
            return currentAccountNumber;
        }

        /// <summary>
        /// Increase Account Balance by Amount
        /// </summary>
        /// <param name="amount">Amount to add to the account balance</param>
        private void Deposit(double amount)
        {
            AccountBalance += amount;
        }

        /// <summary>
        /// Decrement Account Balance by Amount
        /// </summary>
        /// <param name="amount">Amount to withdraw</param>
        private void Withdraw(double amount)
        {
            if (AccountBalance < amount)
            {
                throw new InvalidOperationException("Insufficient funds.");
            }

            if (amount < 0)
            {
                throw new InvalidOperationException("Cannot withdraw negative amount.");
            }

            if (AccountBalance >= amount)
            {
                AccountBalance -= amount;
            }
        }


        /// <summary>
        /// Displays the specified customer's account information
        /// </summary>
        public void DisplayAccountInfo()
        {
            Console.WriteLine("Account number: " + AccountNumber);
            Console.WriteLine("Account name: " + AccountName);
            Console.WriteLine("Account balance: " + AccountBalance);
            Console.WriteLine("Account type: " + _accountType);
        }
    }
}
