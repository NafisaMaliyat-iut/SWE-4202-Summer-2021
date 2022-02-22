using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System
{
    internal class Account
    {
        int userID;
        string userName;

        public void SetUserID(int id)
        { this.userID = id; }

        public void SetUserName(string userName)    
        { this.userName = userName; }

        public int GetUserID()
            { return this.userID; }

        public string GetUserName()
        { return this.userName; }

        public virtual void GenerateAccountNumber()
        { }

        List<string> AccountHistory = new List<string>();

        public List<string> GetAccountHistory()
        { return AccountHistory; }

        public void SetAccountHistory(string value)
        { AccountHistory.Add(value); }

        public virtual string GetAccountInfo()
        {
            return "-1";
        }
    }
}
