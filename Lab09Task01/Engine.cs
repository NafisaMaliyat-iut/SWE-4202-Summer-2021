using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09Task03
{
    internal class Engine
    {
        double MaximumFuelConsumptionRate;
        double MaximumEnergyProductionRate;
        double AverageRPM;

        //Getter and setter for max fuel consumption rate
        public void SetMaximumFuelConsumptionRate(double value)
        { this.MaximumFuelConsumptionRate = value; }
        public double GetMaximumFuelConsumptionRate()
        { return this.MaximumFuelConsumptionRate; }


        //getter and setter for max energy production rate
        public void SetMaximumEnergyProductionRate(double value)
        { this.MaximumEnergyProductionRate = value; }
        public double GetMaximumEnergyProductionRate()
        { return this.MaximumEnergyProductionRate; }


        //getter and setter for average rpm
        public void SetAverageRPM(double value)
        { this.AverageRPM = value; }
        public double GetAverageRPM()
        { return this.AverageRPM; }

    }
}
