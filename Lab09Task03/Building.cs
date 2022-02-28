using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09Task03
{
    internal class Building
    {
        public List<Lab> LabRooms = new List<Lab>();
        public List<Lecturer_Room> LecturerRooms = new List<Lecturer_Room>();

        public void ShowAllLabs()
        {
            foreach (Lab ALab in LabRooms)
            {
                Console.WriteLine(ALab.WhoAmI());
            }
        }

        public void ShowAllLecturerRooms()
        {
            foreach (Lecturer_Room ALecturerRoom in LecturerRooms)
            {
                Console.WriteLine(ALecturerRoom.WhoAmI());
            }
        }
    }
}
