using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management__Even_Lab_
{
    public partial class PharmacyManagementApp : Form
    {
        public PharmacyManagementApp()
        {
            InitializeComponent();
        }


        List <Medicine> listMedicines = new List<Medicine>();
        ShopAccount account = new ShopAccount();


        //to stock up on meds (existing and new medicine)
        private void AddMedicine(string name, int quantity, double price, string company)
        {
            bool MedAlreadyExists = false;

            //searching to see if med already exists
            foreach(Medicine medicine in listMedicines)
            {
                //medicine exists
                if(name == medicine.getMedicineName())
                {
                    MedAlreadyExists = true;
                    int currentQuantity = medicine.getMedicineQuantity();

                    //if there is enough money to buy
                    if (account.getShopBalance() >= Convert.ToDouble(quantity)*price)
                    {
                        medicine.setMedicineQuantity(currentQuantity+quantity);
                        account.DeductBalance(price*quantity);
                        MessageBox.Show("Medicine added to stock successfully!");
                    }
                    //not enough money to buy
                    else
                    {
                        MessageBox.Show("Balance is not sufficient!");
                    }
                    break;
                }
            }

            //medicine does not exist
            if(!MedAlreadyExists)
            {
                if (account.getShopBalance() >= quantity*price)
                {
                    Medicine DummyMedicine = new Medicine();
                    DummyMedicine.setMedicineName(name);
                    DummyMedicine.setMedicineQuantity(quantity);
                    DummyMedicine.setMedicinePrice(price);
                    DummyMedicine.setMedicineCompany(company);
                    account.DeductBalance(price*quantity);
                    listMedicines.Add(DummyMedicine);

                    MedicineListComboBox.Items.Add(DummyMedicine.getMedicineName());
                    MessageBox.Show("Medicine added to stock successfully!");
                }
                //not enough money
                else
                {
                    MessageBox.Show("Balance is not sufficient!");
                }
                
            }
        }

        //sale of medicine
        private void SellMedicine(string name, int quantity, double price)
        {
            //searching through list for the medicine specified
            foreach (Medicine medicine in listMedicines)
            {
                //Decreasing the quantity of the medicine and increasing balance in account
                if (name == medicine.getMedicineName())
                {
                    int currentQuantity = medicine.getMedicineQuantity();

                    //if there is sufficient medicine in stock, quantity decrease and balance increase
                    if (currentQuantity>=quantity && quantity>0 && (currentQuantity-quantity)>=0)
                    {
                        medicine.setMedicineQuantity(currentQuantity-quantity);
                        account.AddBalance(price*quantity);
                        MessageBox.Show("Sale completed succesfully!");
                    }
                    else //if there is not enough medicine in stock 
                    {
                        MessageBox.Show("There is not enough medicine in stock!");
                    }
                    break;
                }
            }

        }

        

        //Add Button Function
        private void AddMedicineToStockButtonClick(object sender, EventArgs e)
        {
            AddMedicine(AddMedicineNameTextBox.Text, Convert.ToInt32(AddMedicineQuantityTextBox.Text), Convert.ToDouble(AddMedicinePriceTextBox.Text), AddMedicineCompanyTextBox.Text);
            /*AddMedicineCompanyTextBox.Text = String.Empty;
            AddMedicineNameTextBox.Text = String.Empty;
            AddMedicinePriceTextBox.Text = String.Empty;
            AddMedicineQuantityTextBox.Text = String.Empty ;*/
        }

        //Sell Medicine Button Function
        private void SellMedicineButtonClick(object sender, EventArgs e)
        {
            SellMedicine(MedicineListComboBox.Text, Convert.ToInt32(SellMedicineQuantityTxtBox.Text), Convert.ToDouble(SellMedicinePriceTextBox.Text));
        }

        //Check Balance Button
        private void CheckBalanceButtonClick(object sender, EventArgs e)
        {
            ShowBalanceHere.Text = Convert.ToString(account.getShopBalance());
        }

        private void ShowInventoryButtonOnClick(object sender, EventArgs e)
        {
            InventoryList.Items.Clear();
            InventoryList.Items.Add("Name\tQuantity");
            foreach (Medicine medicine in listMedicines)
            {
                InventoryList.Items.Add(medicine.getMedicineInfo());
            }
        }
    }
}
