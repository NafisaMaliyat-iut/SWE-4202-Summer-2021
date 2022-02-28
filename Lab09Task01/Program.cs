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
            Car MyCar = new Car();
            MyCar.SetMaxAcceleration(330.7);
            MyCar.SetFuelCapacity(30.3);
            MyCar.MyDoor.SetOpeningMode("Upward ways");
            MyCar.MySeat.SetComfortability("Comfy");
            MyCar.MySeat.SetPresenceOfSeatWarmer(true);
            MyCar.MyEngine.SetAverageRPM(1000);
            MyCar.MyEngine.SetMaximumEnergyProductionRate(225);
            MyCar.MyEngine.SetMaximumFuelConsumptionRate(7.5);
            MyCar.MyWheel.SetCircumference(62.87);

            Console.WriteLine(MyCar.DisplayInformation());
            Console.ReadLine();
        }
    }
}
