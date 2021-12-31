using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System
{
    internal class Customer
    {
        int CustomerID = 0;
        string Name = "";
        string Address = "";
        string ContactNumber = "";

        public string GetCustomerName()
        {
            return this.Name;
        }

        public string GetCustomerAddress()
        {
            return this.Address;
        }

        public int GetCustomerID()
        {
            return this.CustomerID;
        }

        public Customer()
        {

        }

        public Customer(int CustomerID, string Name, string Address, string ContactNumber)
        {
            this.CustomerID = CustomerID;
            this.Name = Name ;
            this.Address = Address ;
            this.ContactNumber = ContactNumber ;
        }
    }
}
