using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09Task02
{
    internal class Teacher : Staff
    {
        string subject;
        string publication;

        //getter and setter
        public void SetSubject(string value)
        { this.subject = value; }
        public string GetSubject()
        { return this.subject; }
        public void SetPublication(string value)
        { this.publication = value; }
        public string GetPublication()
        { return this.publication; }

        public override string WhoAmI()
        {
            return "Teacher.\nName: " + GetName()
                + "\nCode: " + GetCode()
                + "\nSubject: " + GetSubject() +
                "\nPublication: " + GetPublication();
        }
    }
}

