using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09Task03
{
    internal class Door
    {
        string OpeningMode;

        public void SetOpeningMode(string value)
        { this.OpeningMode = value; }
        public string GetOpeningMode()
        { return this.OpeningMode; }
    }
}
