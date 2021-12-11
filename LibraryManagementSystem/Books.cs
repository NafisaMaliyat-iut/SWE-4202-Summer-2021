using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    internal class Books
    {
        public int bookID = 0;
        public string bookName = "";
        public string bookAuthor = "";
        public string bookPublisher = "";
        public int bookQuantity = 0;

        public string GetBookInfo()
        {
            return "ID: " + Convert.ToString(bookID) + "\tName: "  + bookName;
        }
    }
}
