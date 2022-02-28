using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09Task02
{
    internal class Regular:Typist
    {
        public override string WhoAmI()
        {
            return "Regular typist.\nName: " + GetName()
                + "\nCode: " + GetCode()
                + "\nSpeed: " + Convert.ToString(GetSpeed());
        }
    }
}
