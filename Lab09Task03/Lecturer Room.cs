using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09Task03
{
    internal class Lecturer_Room
    {
        string RoomName;
        int RoomNumber;
        int Capacity;

        public string GetRoomName()
        { return this.RoomName; }
        public void SetRoomName(string value)
        { this.RoomName = value; }
        public int GetRoomNumber()
        { return this.RoomNumber; }
        public void SetRoomNumber(int value)
        { this.RoomNumber = value; }
        public int GetCapacity()
        { return this.Capacity; }
        public void SetCapacity(int value)
        { this.Capacity = value; }

        public string WhoAmI()
        {
             return "\nLecturer Room\nRoom Name: " + this.RoomName
                + "\nRoom Number: " + Convert.ToString(this.RoomNumber)
                + "\nCapacity: " + Convert.ToString(this.Capacity);
                
        }
    }
}
