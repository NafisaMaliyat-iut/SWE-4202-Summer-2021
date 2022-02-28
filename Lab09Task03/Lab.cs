using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09Task03
{
    internal class Lab
    {
        string LabName;
        int Capacity;

        public string GetLabName()
        { return this.LabName; }
        public void SetLabName(string value)
        { this.LabName = value; }

        public int GetCapacity()
        { return this.Capacity; }
        public void SetCapacity(int value)
        { this.Capacity = value; }

        public string WhoAmI()
        {
            return "\nLab Name: " + this.LabName
                + "\nCapacity: " + Convert.ToString(this.Capacity);

        }
    }
}
