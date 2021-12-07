using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class ResearchArticle : Book
    {
        string DOI = "";
        string publishedDate = "";
        char conferenceOrJournal = '\0';

        public string getDOI()
        { 
            return DOI; 
        }

        public void setDOI(string value)
        { 
            this.DOI = value;
        }

        public string getPublishedDate()
        { return publishedDate; }

        public void setPublishedDate(string value)
        { this.publishedDate = value; }

        public char getConferenceOrJournal()
        { return conferenceOrJournal; }

        public void setConferenceOrJournal(char value)
            { this.conferenceOrJournal = value; }
   

        public string getResearchArticleInfo()
        {
            return Convert.ToString(ID) + "\t\t" + title + "\t\t" + author + "\t\t" + publisher + "\t\t" + Convert.ToString(quantity) + "\t\t" + DOI + "\t\t" + publishedDate + "\t\t" + Convert.ToString(conferenceOrJournal);
        }

    }
}
