using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Management__Even_Lab_
{
    internal class Medicine
    {
        private string MedicineName = "";
        private int MedicineQuantity = 0;
        private double MedicinePrice = 0;
        string MedicineCompany = "";

        public string getMedicineName()
        {
            return this.MedicineName;
        }

        public void setMedicineName(string value)
        {
            this.MedicineName = value;
        }

        public int getMedicineQuantity()
        {
            return this.MedicineQuantity;
        }

        public void setMedicineQuantity(int value)
        {
            this.MedicineQuantity = value;
        }

        public double getMedicinePrice()
        {
            return this.MedicinePrice;
        }

        public void setMedicinePrice(double value)
        {
            this.MedicinePrice = value;
        }

        public string getMedicineCompany()
        {
            return this.MedicineCompany;
        }

        public void setMedicineCompany(string value)
        {
            this.MedicineCompany = value;
        }

        public string getMedicineInfo()
        {
            return this.MedicineName + "\t" + this.MedicineQuantity;
        }

    }
}
