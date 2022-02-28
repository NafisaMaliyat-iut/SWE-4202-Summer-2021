using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09Task02
{
    internal class Staff
    {
        string code;
        string name;

        public void SetCode(string value)
        { this.code = value; }
        public string GetCode()
            { return this.code; }

        public void SetName(string value)
        { this.name = value; }
        public string GetName()
        { return this.name; }


        public virtual string WhoAmI()
        {
            return "Staff.\nName: " + GetName()
                + "\nCode: " + GetCode();
        }
    }
}
