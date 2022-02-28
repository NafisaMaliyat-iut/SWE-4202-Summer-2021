using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09Task03
{
    internal class Wheel
    {
        double circumference;

        public void SetCircumference (double value)
        { this.circumference = value; }
        public double GetCircumference()
        { return this.circumference; }
    }
}
