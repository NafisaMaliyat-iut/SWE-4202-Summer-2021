using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09Task03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Building N28Building = new Building();
            
            Lecturer_Room ALecturerRoom = new Lecturer_Room();
            ALecturerRoom.SetRoomName("A");
            ALecturerRoom.SetCapacity(3);
            ALecturerRoom.SetRoomNumber(1);
            N28Building.LecturerRooms.Add(ALecturerRoom);

            Lecturer_Room BLecturerRoom = new Lecturer_Room();
            BLecturerRoom.SetRoomName("B");
            BLecturerRoom.SetCapacity(6);
            BLecturerRoom.SetRoomNumber(5);
            N28Building.LecturerRooms.Add(BLecturerRoom);

            Lab ALab = new Lab();
            ALab.SetLabName("C");
            ALab.SetCapacity(60);
            N28Building.LabRooms.Add(ALab);

            Lab BLab = new Lab();
            BLab.SetLabName("D");
            BLab.SetCapacity(45);
            N28Building.LabRooms.Add(BLab);

            N28Building.ShowAllLabs();
            N28Building.ShowAllLecturerRooms();
            Console.ReadLine();
        }
    }
}
