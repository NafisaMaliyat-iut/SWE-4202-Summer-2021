using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System
{
    internal class SavingsAccount: Account
    {
        public static int SavingsAccountCount = 0;
        string AccountNumber;

        double AccountBalance = 0;
        int NumberOfTransactions = 0;
        DateTime TimeOfLastTransaction;

        public void UpdateDateTime()
        {
            if ((DateTime.Now.Day - TimeOfLastTransaction.Day) ==0)
            {
                TimeOfLastTransaction = DateTime.Now;
                NumberOfTransactions++;
            }
            else
            {
                TimeOfLastTransaction = DateTime.Now;
                NumberOfTransactions = 1;
            }
        }
        public int CheckNumberOfTransations()
        {
            return this.NumberOfTransactions;
        }

        public void SetAccountBalance(double value)
        {
            this.AccountBalance = value;
        }

        public double GetAccountBalance()
        { return this.AccountBalance; }

        public override void GenerateAccountNumber()
        {
            SavingsAccountCount++;
            AccountNumber = Convert.ToString(SavingsAccountCount) + "314";
        }

        public string GetAccountNumber()
        {
            return AccountNumber;
        }

        public override string GetAccountInfo()
        {
            return "Account Number: " + AccountNumber + "\nAccount Holder\nUser ID: " + this.GetUserID() + "\nName: " + this.GetUserName() + "\nAccount Type: Savings Account\nAccount Balance: BDT " + Convert.ToString(this.AccountBalance);
        }

       
    }
}
