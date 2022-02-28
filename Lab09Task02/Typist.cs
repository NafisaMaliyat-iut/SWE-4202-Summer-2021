using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09Task02
{
    internal class Typist:Staff
    {
        double speed;

        public void SetSpeed(double value)
        { this.speed = value; }
        public double GetSpeed()
        { return this.speed; }


        public override string WhoAmI()
        {
            return "Typist.\nName: " + GetName()
                + "\nCode: " + GetCode()
                + "\nSpeed: " + Convert.ToString(GetSpeed());
        }
    }
}
