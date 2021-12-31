using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System
{
    internal class Booking
    {
        int BookingID = 0;
        string RoomChoice = "";
        int RoomQuantity = 0;
        DateTime EntryDate;
        DateTime DepartureDate;
        int CustomerID = 0;
        static int BookingCount = 0;
        double TotalAmountToBePaid = 0;
        string BookingStatus = "Pending";
        int RoomNumber1 = 0;
        int RoomNumber2 = 0;
        int RoomNumber3 = 0;

        public int GetCustomerID()
        {
            return this.CustomerID;
        }

        public int GetRoomNumber1()
        {
            return this.RoomNumber1;
        }

        public int GetRoomNumber2()
        {
            return this.RoomNumber2;
        }
        public int GetRoomNumber3()
        {
            return this.RoomNumber3;
        }
        public void SetRoomNumber3(int value)
        {
            this.RoomNumber3 = value;
        }
        public void SetRoomNumber1(int value)
        {
            this.RoomNumber1 = value;
        }

        public void SetRoomNumber2(int value)
        {
            this.RoomNumber2 = value;
        }
        public string GetBookingStatus()
        {
            return this.BookingStatus;
        }

        public void SetBookingStatus(string value)
        {
            this.BookingStatus = value;
        }
        public Booking()
        {

        }

        void CalculatePayment()
        {
            if (this.RoomChoice == "Single")
                TotalAmountToBePaid = 40.0;
            else if (this.RoomChoice == "Double")
                TotalAmountToBePaid = 75.0;
            else if (this.RoomChoice =="Suite")
                TotalAmountToBePaid = 100.0;
            else if (this.RoomChoice == "Deluxe")
                TotalAmountToBePaid = 140;

            TotalAmountToBePaid *= this.RoomQuantity;

            int LengthOfTime = Convert.ToInt32(Math.Ceiling((DepartureDate - EntryDate).TotalDays));

            TotalAmountToBePaid *= (LengthOfTime);
        }

        public Booking(string RoomChoice, int RoomQuantity, DateTime EntryDate, DateTime DepartureDate, int CustomerID)
        {
            this.BookingID = BookingCount;
            BookingCount++;
            this.RoomChoice = RoomChoice;   
            this.RoomQuantity = RoomQuantity;
            this.EntryDate = EntryDate; 
            this.DepartureDate = DepartureDate;
            this.CustomerID = CustomerID;
            
            this.CalculatePayment();
        }

        public double GetTotalAmountToBePaid()
        {
            return this.TotalAmountToBePaid;
        }

        public int GetBookingID()
        {
            return this.BookingID;
        }

        public string GetRoomChoice()
        {
            return this.RoomChoice;
        }

        public int GetRoomQuantity()
        {
            return this.RoomQuantity;
        }
        
        public string GetBookingInfo()
        {
            return Convert.ToString(this.BookingID) + "\t\t" + Convert.ToString(this.RoomChoice) + "\t\t" + Convert.ToString(this.RoomQuantity) + "\t    " + Convert.ToString(TotalAmountToBePaid);
        }       


    }
}
 