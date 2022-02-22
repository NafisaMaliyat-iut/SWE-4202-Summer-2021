using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System
{
    internal class User
    {
        static int UserCount = 0;
        int UserID;
        string UserName = "";

        public List <string> AccountNumber = new List<string>();

        public User(string UserName)
        {
            this.UserName = UserName;
            UserCount++;
            this.UserID = UserCount;
        }

        public string GetUserName()
        {
            return this.UserName;
        }
        public int GetUserID()
        {
            return this.UserID;
        }

        public void AddAcountNumber(string AccNo)
        {
            AccountNumber.Add(AccNo);
        }

    }
}
