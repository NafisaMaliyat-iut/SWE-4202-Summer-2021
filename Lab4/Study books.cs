using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class StudyBooks: Book
    {
        long ISBN = 0;
        string genre = "";

        public long getStudyBookISBN()
        {
            return ISBN;
        }

        public void setStudyBookISBN(long value)
        {
            this.ISBN = value;
        }

        public string getStudyBookGenre()
        {
            return genre;
        }

        public void setStudyBookGenre(string value)
        {
            this.genre = value ;
        }

        public string getStudyBookInfo()
        {
            return Convert.ToString(ID) + "\t\t" + title + "\t\t" + author + "\t\t" + publisher + "\t\t" + Convert.ToString(quantity) + "\t\t" + Convert.ToString(ISBN) + "\t\t" + genre;
        }

    }
}