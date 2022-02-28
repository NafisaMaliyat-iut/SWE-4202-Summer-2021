using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09Task03
{
    internal class Car
    {
        double MaxAcceleration;
        double FuelCapacity;

        //getter and setters
        public void SetMaxAcceleration(double value)
        { this.MaxAcceleration = value; }
        public double GetMaxAcceleration()
        { return this.MaxAcceleration; }

        public void SetFuelCapacity(double value)
        { this.FuelCapacity  = value; }
        public double GetFuelCapacity()
        { return this.FuelCapacity; }

        public Door MyDoor = new Door();
        public Engine MyEngine = new Engine();
        public Wheel MyWheel = new Wheel();
        public Seat MySeat = new Seat();


        //to display all Info
        public string DisplayInformation()
        {
            string CarInfo = "Car Information: - \nMaximum acceleration: " + Convert.ToString(this.MaxAcceleration);
            CarInfo += ".\nFuel Capacity: " + Convert.ToString(this.FuelCapacity);  
            CarInfo += ".\nOpening mode of door: " + MyDoor.GetOpeningMode();
            CarInfo += ".\nCircumference of wheel: " + Convert.ToString(MyWheel.GetCircumference());
            CarInfo += ".\nMaximum fuel consumption rate: " + Convert.ToString(MyEngine.GetMaximumFuelConsumptionRate());
            CarInfo += ".\nMaximum energy production rate: " + Convert.ToString(MyEngine.GetMaximumEnergyProductionRate());
            CarInfo += ".\nAverage RPM: " + Convert.ToString(MyEngine.GetAverageRPM());
            CarInfo += ".\nSeat comfortability: " + MySeat.GetComfortability();
            CarInfo += ".\nPresence of seat warmer: ";
            if (MySeat.GetPresenceOfSeatWarmer() == true)
                CarInfo += "Yes";
            else
                CarInfo += "No";
            CarInfo += ".";
            return CarInfo;
        }
    }
}
