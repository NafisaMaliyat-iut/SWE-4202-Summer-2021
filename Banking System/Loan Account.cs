using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System
{
    internal class LoanAccount : Account
    {
        public static int LoanAccountCount = 0;
        string AccountNumber;

        double LoanBalance;

        public void SetAccountBalance(double value)
        {
            this.LoanBalance = value;
        }

        public double GetAccountBalance()
        { return this.LoanBalance; }

        public override void GenerateAccountNumber()
        {
            LoanAccountCount++;
            AccountNumber = Convert.ToString(LoanAccountCount) + "400";
        }

        public string GetAccountNumber()
        {
            return AccountNumber;
        }

        public override string GetAccountInfo()
        {
            return "Account Number: " + this.AccountNumber + "\nAccount Holder\nUser ID: " + this.GetUserID() + "\nName: " + this.GetUserName() + "\nAccount Type: Loan Account\nLoan remaining: BDT " + Convert.ToString(this.LoanBalance);
        }


    }
}