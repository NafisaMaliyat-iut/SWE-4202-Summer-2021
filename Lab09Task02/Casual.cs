using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09Task02
{
    internal class Casual:Typist
    {
        double DailyWages;
        public void SetDailyWages(double value)
        { this.DailyWages = value; }
        public double GetDailyWages()
        { return this.DailyWages; }

        


        //display information
        public override string WhoAmI()
        {
            return "Casual typist.\nName: " + GetName() 
                + "\nCode: " + GetCode() 
                + "\nSpeed: " + Convert.ToString(GetSpeed()) 
                + "\nDaily wages: BDT " + Convert.ToString(GetDailyWages());
        }
    }
}
