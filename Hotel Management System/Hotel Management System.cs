using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System
{
    internal class Hotel_Management_System
    {
        public List<Customer> customerList = new List<Customer>();
        public List <Booking> bookingList = new List<Booking>();

        double HotelAccountBalance = 100.0;

        public double GetHotelAccountBalance()
        {
            return this.HotelAccountBalance;
        }
        public void SetHotelAccountBalance(double value)
        {
            this.HotelAccountBalance += value;
        }
    }
}
