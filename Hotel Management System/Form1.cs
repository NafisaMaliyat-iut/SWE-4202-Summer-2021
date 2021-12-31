using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Hotel_Management_System MyHotel = new Hotel_Management_System();

        

        private void UserSectionCreateAccountButtonOnClick(object sender, EventArgs e)
        {
            if (CreateAccountContactNo.Text == String.Empty
                || CreateAccountAddress.Text == String.Empty
                || CreateAccountName.Text == String.Empty
                || CreateAccountUserID.Text == String.Empty)
            {
                MessageBox.Show("Please fill up all the fields!");
                return;
            }

            Customer DummyCustomer = new Customer(Convert.ToInt32(CreateAccountUserID.Text), CreateAccountName.Text, CreateAccountAddress.Text, CreateAccountContactNo.Text);
            foreach (Customer customer in MyHotel.customerList)
            {
                if(customer.GetCustomerID() == DummyCustomer.GetCustomerID())
                {
                    MessageBox.Show("User already exists!");
                    return;
                }
            }
            MyHotel.customerList.Add(DummyCustomer);
            MessageBox.Show("Account Created Successfully!");
        }

        private void UserSectionPlaceBookingButtonOnClick(object sender, EventArgs e)
        {
            if (PlaceBookingUserID.Text == String.Empty
                ||PlaceBookingRoomQuantity.Text == String.Empty
                ||PlaceBookingRoomChoice.Text == String.Empty
                ||UserSectionEntryDate.Text == String.Empty
                ||UserSectionDepartureDate.Text == String.Empty)
            {
                MessageBox.Show("Please fill out up all the fields!");
                return;
            }


            
            Booking DummyBooking = new Booking(PlaceBookingRoomChoice.Text, Convert.ToInt32(PlaceBookingRoomQuantity.Text), Convert.ToDateTime(UserSectionEntryDate.Text), Convert.ToDateTime(UserSectionDepartureDate.Text), Convert.ToInt32(PlaceBookingUserID.Text));
            MyHotel.bookingList.Add(DummyBooking);

            
            MyHotel.SetHotelAccountBalance(DummyBooking.GetTotalAmountToBePaid()) ;
            MessageBox.Show("Booking placed successfully!\nTotal amount to be paid: " + Convert.ToString(DummyBooking.GetTotalAmountToBePaid()) + "\nYour booking ID is: " + Convert.ToString(DummyBooking.GetBookingID()));
        }

        private void OwnerSectionSetStatusButtonOnClick(object sender, EventArgs e)
        {
            
            bool BookingIDExists = false;

            //searching if booking ID exists
            foreach (Booking booking in MyHotel.bookingList)
            {
                if (Convert.ToInt32(OwnerSectionBookingID.Text) == booking.GetBookingID())
                {
                    BookingIDExists = true;
                    MessageBox.Show("Status Set Successfully!");
                    if (OwnerSectionRoomNumberLabel.Visible == true)
                    {
                        if (booking.GetRoomQuantity() == 1)
                        {
                            booking.SetRoomNumber1(Convert.ToInt32(OwnerSectionRoomNumber1.Text));
                        }

                        else if (booking.GetRoomQuantity() == 2)
                        {
                            booking.SetRoomNumber1(Convert.ToInt32(OwnerSectionRoomNumber1.Text));
                            booking.SetRoomNumber2(Convert.ToInt32(OwnerSectionRoomNumber2.Text));
                        }

                        else if (booking.GetRoomQuantity() == 3)
                        {
                            booking.SetRoomNumber1(Convert.ToInt32(OwnerSectionRoomNumber1.Text));
                            booking.SetRoomNumber2(Convert.ToInt32(OwnerSectionRoomNumber2.Text));
                            booking.SetRoomNumber3(Convert.ToInt32(OwnerSectionRoomNumber3.Text));
                        }
                    }

                break;

                
                }

            }

            if(!BookingIDExists)
            {
                MessageBox.Show("The booking ID you entered does not exist!");
            }

            OwnerSectionShowCurrentBalance.Text = Convert.ToString(MyHotel.GetHotelAccountBalance());
        }

        private void OwnerSectionShowRoomDetailsOnClick(object sender, EventArgs e)
        {
            OwnerSectionListBox.Items.Clear();
            OwnerSectionListBox.Items.Add("Booking ID\tRoom Type\tRoom Qty\t    Bill");
            foreach (Booking booking in MyHotel.bookingList)
            {
                OwnerSectionListBox.Items.Add(booking.GetBookingInfo());
            }
        }

        private void SeeOrderDetailsOnClick(object sender, EventArgs e)
        {
            bool bookingIdExists = false;

            foreach (Booking booking in MyHotel.bookingList)
            {
                if(booking.GetBookingID() == Convert.ToInt32(SeeOrderDetailsBookingID.Text))
                {
                    //booking id exists
                    bookingIdExists = true;
                    SeeOrderDetailsAmount.Text = Convert.ToString(booking.GetTotalAmountToBePaid());
                    SeeOrderDetailsStatus.Text = Convert.ToString(booking.GetBookingStatus());

                    foreach (Customer customer in MyHotel.customerList)
                    {
                        if (customer.GetCustomerID() == booking.GetCustomerID())
                        {
                            SeeOrderDetailsUserName.Text = customer.GetCustomerName();
                            SeeOrderDetailsAddress.Text = customer.GetCustomerAddress();
                            break;
                        }
                    }
                    if(booking.GetBookingStatus() == "Confirmed")
                    {
                        //must be a room 1 if the status is confirmed
                        SeeOrderDetailsRoomNumber1.Text = Convert.ToString(booking.GetRoomNumber1());
                        
                        //if it has a room 3
                        if(booking.GetRoomQuantity() > 2 & booking.GetRoomNumber3( )!= 0)
                            SeeOrderDetailsRoomNumber3.Text = Convert.ToString(booking.GetRoomNumber3());

                        //if it has a room 2
                        if (booking.GetRoomQuantity() > 1 & booking.GetRoomNumber2() != 0)
                            SeeOrderDetailsRoomNumber2.Text = Convert.ToString(booking.GetRoomNumber2());

                    }

                }
            }

            if (!bookingIdExists)
                MessageBox.Show("The booking ID you entered does not exist!");
        }

        private void OwnerSectionStatusDropDownEvent(object sender, EventArgs e)
        {
            OwnerSectionRoomNumberLabel.Visible = false;
            OwnerSectionRoomNumber1.Visible = false;
            OwnerSectionRoomNumber2.Visible = false;
            OwnerSectionRoomNumber3.Visible = false;
            
            if (OwnerSectionStatusDropDown.Text == "Confirmed")
            {

                //searching if booking ID exists
                foreach (Booking booking in MyHotel.bookingList)
                {
                    if (Convert.ToInt32(OwnerSectionBookingID.Text) == booking.GetBookingID())
                    {
                        booking.SetBookingStatus(OwnerSectionStatusDropDown.Text);

                        OwnerSectionRoomNumberLabel.Visible = true;

                        if (booking.GetRoomQuantity() == 1)
                        {
                            OwnerSectionRoomNumber1.Visible = true;
                        }

                        else if (booking.GetRoomQuantity() == 2)
                        {
                            OwnerSectionRoomNumber1.Visible=true;
                            OwnerSectionRoomNumber2.Visible = true;
                        }

                        else if (booking.GetRoomQuantity() == 3)
                        {
                            OwnerSectionRoomNumber1.Visible=true;
                            OwnerSectionRoomNumber2.Visible = true;
                            OwnerSectionRoomNumber3.Visible = true;
                        }


                    }
                }

            }
                
        }

        //private void testevent(object sender, EventArgs e)
        //{
        //    textBox1.Text = Convert.ToString(MyHotel.bookingList[0].GetRoomNumber1());
        //}
    }
}
