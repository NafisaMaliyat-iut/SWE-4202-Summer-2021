using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09Task02
{
    internal class Officer:Staff
    {
        string grade;

        public void SetGrade(string value)
        { this.grade = value; }
        public string GetGrade()
        { return this.grade; }

        public override string WhoAmI()
        {
            return "Officer.\nName: " + GetName()
                + "\nCode: " + GetCode()
                + "\nGrade: " + GetGrade();
        }
    }
}
