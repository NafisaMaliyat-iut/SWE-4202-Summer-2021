using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System
{
    internal class BankSystem
    {
        public List<User>UserList = new List<User>();
        public List<CurrentAccount>CurrentAccountList = new List<CurrentAccount>();
        public List<LoanAccount>LoanAccountList = new List<LoanAccount>();
        public List<SavingsAccount>SavingsAccountList = new List<SavingsAccount>();
    }
}
