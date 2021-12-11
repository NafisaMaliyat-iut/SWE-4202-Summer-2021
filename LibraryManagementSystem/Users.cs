using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    internal class Users
    {
        public int userID = 0;
        public string userName = "";
        public string userAddress = "";
        public List<int> bookIDBorrrowedList = new List<int>();

        

        public void BorrowBook(int userIDBorrowed, int bookIDBorrowed)
        {
            
        }

        public string GetUserInfo()
        {
            return Convert.ToString(userID) + "\t" + userName + "\t" + userAddress;

        }
    }
}
