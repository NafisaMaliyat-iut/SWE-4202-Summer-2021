using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09Task03
{
    internal class Seat
    {
        string Comfortability;
        bool PresenceOfSeatWarmer;

        public void SetComfortability(string value)
        { this.Comfortability = value; }
        public string GetComfortability()
        { return this.Comfortability; }

        public void SetPresenceOfSeatWarmer(bool value)
        { this.PresenceOfSeatWarmer = value; }
        public bool GetPresenceOfSeatWarmer()
        { return this.PresenceOfSeatWarmer; }

    }
}
