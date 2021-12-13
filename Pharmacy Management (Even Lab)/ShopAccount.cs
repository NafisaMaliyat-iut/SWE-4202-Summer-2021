using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Management__Even_Lab_
{
    internal class ShopAccount
    {
        double ShopBalance = 100.0;

        public double getShopBalance()
        {
            return this.ShopBalance;
        }

        public void setShopBalance(double value)
        {
            this.ShopBalance = value;
        }

        public void AddBalance(double price)
        {
            this.ShopBalance +=price;
        }

        public void DeductBalance(double price)
        {
            this.ShopBalance -= price;
        }
    }
}
