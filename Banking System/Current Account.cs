using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System
{
    internal class CurrentAccount: Account
    {
        public static int CurrentAccountCount = 0;
        string AccountNumber;

        double AccountBalance=0;
        
        public void SetAccountBalance(double value)
        { this.AccountBalance = value;}

        public double GetAccountBalance()
        { return this.AccountBalance; }

        public override void GenerateAccountNumber ()
        {
            CurrentAccountCount++;
            AccountNumber = Convert.ToString(CurrentAccountCount ) + "300";
        }

        public string GetAccountNumber()
            { return AccountNumber; }

        public override string GetAccountInfo()
        {
            return "Account Number: " + AccountNumber + "\nAccount Holder\nUser ID: " + this.GetUserID() + "\nName: " + this.GetUserName() + "\nAccount Type: Current Account\nAccount Balance: BDT " + Convert.ToString(this.AccountBalance);
        }


        


    }
}
