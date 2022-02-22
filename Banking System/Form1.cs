using System;
using System.Windows.Forms;

namespace Banking_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        internal class InvalidAmountException : ApplicationException
        {
            public override string Message
            {
                get { return "Transaction amount cannot be negative!"; }
            }

        }

        BankSystem NewBankSystem = new BankSystem();



               //~~~~~~~~~~~~~~~~~~All buttons code~~~~~~~~~~~~~~~~~~~//


        //***************CREATE USER BUTTON*************//
        private void CreateUserAccountButtonClick(object sender, EventArgs e)
        {
            //create a dummy then add it to list

            if (CreateUserAccountUserName.Text == String.Empty)
            {
                MessageBox.Show("Fill up all the fields!");
                return;
            }

            User DummyUser = new User(CreateUserAccountUserName.Text);
            MessageBox.Show("Account created successfully!\nYour UserID is: " + Convert.ToString(DummyUser.GetUserID()));
            NewBankSystem.UserList.Add(DummyUser);
        }









        //************CREATE ACCOUNT USING USER ID***********//
        private void CreateAccountButtonClick(object sender, EventArgs e)
        {
            if (CreateAccountUserID.Text == String.Empty
                || CreateAccountAccountType.Text == String.Empty
                ||CreateAccountAmountTextBox.Text == String.Empty)
            {
                MessageBox.Show("Fill up all the fields!");
                return;
            }

            bool UserIDFound = false;
            foreach (User user in NewBankSystem.UserList)
            {

                //if user exist
                if (Convert.ToInt32(CreateAccountUserID.Text) == user.GetUserID())
                {
                    UserIDFound = true;

                    //for current account 
                    if (CreateAccountAccountType.Text == "Current Account")
                    {
                        CurrentAccount dummyCurrentAccount = new CurrentAccount();
                        dummyCurrentAccount.GenerateAccountNumber();
                        dummyCurrentAccount.SetAccountBalance(Convert.ToDouble(CreateAccountAmountTextBox.Text));
                        dummyCurrentAccount.SetUserID(user.GetUserID());
                        dummyCurrentAccount.SetUserName(user.GetUserName());
                        NewBankSystem.CurrentAccountList.Add(dummyCurrentAccount);
                        user.AccountNumber.Add(dummyCurrentAccount.GetAccountNumber());
                        MessageBox.Show("Account created successfully!\nYour Account Number is: " + dummyCurrentAccount.GetAccountNumber());
                        break;
                    }

                    
                    //for loan account
                    else if (CreateAccountAccountType.Text == "Loan Account")
                    {
                        LoanAccount dummyLoanAccount = new LoanAccount();
                        dummyLoanAccount.GenerateAccountNumber();
                        dummyLoanAccount.SetAccountBalance(1.09 * Convert.ToDouble(CreateAccountAmountTextBox.Text));
                        dummyLoanAccount.SetUserID(user.GetUserID());
                        dummyLoanAccount.SetUserName(user.GetUserName());
                        NewBankSystem.LoanAccountList.Add(dummyLoanAccount);
                        user.AccountNumber.Add(dummyLoanAccount.GetAccountNumber());


                        MessageBox.Show("Account created successfully!\nYour Account Number is: " + dummyLoanAccount.GetAccountNumber());
                        break;
                    }


                    //for savings account
                    else if (CreateAccountAccountType.Text == "Savings Account")
                    {
                        SavingsAccount dummySavingsAccount = new SavingsAccount();
                        if (Convert.ToDouble(CreateAccountAmountTextBox.Text) < 50000)
                        {
                            MessageBox.Show("Insufficient amount to open balance!\nMinimum required balance is BDT 50000");
                            return;
                        }
                        dummySavingsAccount.GenerateAccountNumber();
                        dummySavingsAccount.SetAccountBalance(Convert.ToDouble(CreateAccountAmountTextBox.Text));
                        dummySavingsAccount.SetUserID(user.GetUserID());
                        dummySavingsAccount.SetUserName(user.GetUserName());
                        NewBankSystem.SavingsAccountList.Add(dummySavingsAccount);
                        user.AccountNumber.Add(dummySavingsAccount.GetAccountNumber());
                        MessageBox.Show("Account created successfully!\nYour Account Number is: " + dummySavingsAccount.GetAccountNumber());
                        break;
                    }
                }
            }


            //if user is not found
            if (UserIDFound == false)
                MessageBox.Show("The User ID you entered does not exist!");

        }









        //****************DEPOSIT BUTTON***************//
        private void TransactionsDepositButtonClick(object sender, EventArgs e)
        {
            if (TransactionsAmount.Text == String.Empty
                ||TransactionsAccountNumber.Text == String.Empty)
            {
                MessageBox.Show("Fill up all the fields!");
                return;
            }

            bool AccountNumberExists = false;


            //exception handling if amount is negative
            try
            {
                if (Convert.ToDouble(TransactionsAmount.Text) < 0)
                {
                    throw new InvalidAmountException();
                }
            }
            catch (InvalidAmountException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }



            //for current account
            foreach (CurrentAccount currentAccount in NewBankSystem.CurrentAccountList)
            {
                if (TransactionsAccountNumber.Text == currentAccount.GetAccountNumber())
                {
                    AccountNumberExists = true;
                    currentAccount.SetAccountBalance(currentAccount.GetAccountBalance() + Convert.ToDouble(TransactionsAmount.Text));
                    currentAccount.SetAccountHistory("Deposit of BDT " + TransactionsAmount.Text + " at " + Convert.ToString(DateTime.Now));
                    MessageBox.Show("Transaction completed successfully!");
                    break;
                }
            }

            //for loan account
            if (AccountNumberExists == false)
            {
                foreach (LoanAccount loanAccount in NewBankSystem.LoanAccountList)
                {
                    if (TransactionsAccountNumber.Text == loanAccount.GetAccountNumber())
                    {
                        AccountNumberExists=true;

                        //is the loan already paid off
                        if (loanAccount.GetAccountBalance() == 0)
                        {
                            MessageBox.Show("Loan amount has already paid!\nNo further transactions allowed!");
                            return;
                        }

                        //if loan remains
                        if (loanAccount.GetAccountBalance() >= Convert.ToDouble(TransactionsAmount.Text))
                        {
                            loanAccount.SetAccountBalance(loanAccount.GetAccountBalance() - Convert.ToDouble(TransactionsAmount.Text));
                            loanAccount.SetAccountHistory("Deposit of BDT " + TransactionsAmount.Text + " at " + Convert.ToString(DateTime.Now));
                            MessageBox.Show("Transaction completed successfully!\nRemaining loan amount: " + Convert.ToString(loanAccount.GetAccountBalance()));
                           
                        }
                        //if deposit amount is more than loan 
                        else
                            MessageBox.Show("Invalid amount!");

                        break;
                    }
                }
            }

            //for savings account
            if (AccountNumberExists == false)
            {
                foreach (SavingsAccount savingsAccount in NewBankSystem.SavingsAccountList)
                {
                    if (TransactionsAccountNumber.Text == savingsAccount.GetAccountNumber())
                    {
                        AccountNumberExists=true;
                        if (savingsAccount.CheckNumberOfTransations() < 5)
                        {
                            savingsAccount.UpdateDateTime();
                            savingsAccount.SetAccountBalance(savingsAccount.GetAccountBalance() + Convert.ToDouble(TransactionsAmount.Text));
                            savingsAccount.SetAccountHistory("Deposit of BDT " + TransactionsAmount.Text + " at " + Convert.ToString(DateTime.Now));
                            MessageBox.Show("Transaction completed successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Maximum number of transactions reached!");
                        }
                        break;
                    }
                }
            }

            //account number does not exist
            if (AccountNumberExists==false)
            {
                MessageBox.Show("The account number entered does not exist!");

            }
        }







        //*************SHOW ACCOUNT INFORMATION******************//
        private void AccountInfoShowAccountInfoButtonClick(object sender, EventArgs e)
        {
            if (AccountInfoAccountNumber.Text == String.Empty)
            {
                MessageBox.Show("Fill up all the fields!");
                return;
            }

            bool AccountNumberExists = false;


            //current account
            foreach (CurrentAccount currentAccount in NewBankSystem.CurrentAccountList)
            {
                if (AccountInfoAccountNumber.Text == currentAccount.GetAccountNumber())
                {
                    AccountNumberExists = true;
                    MessageBox.Show(currentAccount.GetAccountInfo());
                    break;
                }
            }

            //loan account
            if (AccountNumberExists == false)
            {
                foreach (LoanAccount loanAccount in NewBankSystem.LoanAccountList)
                {
                    if (AccountInfoAccountNumber.Text == loanAccount.GetAccountNumber())
                    {
                        AccountNumberExists=true;
                        MessageBox.Show(loanAccount.GetAccountInfo());
                        break;
                    }
                }
            }


            //savings account
            if (AccountNumberExists == false)
            {
                foreach (SavingsAccount savingsAccount in NewBankSystem.SavingsAccountList)
                {
                    if (AccountInfoAccountNumber.Text == savingsAccount.GetAccountNumber())
                    {
                        AccountNumberExists=true;
                        MessageBox.Show(savingsAccount.GetAccountInfo());
                        break;
                    }
                }
            }

            //if account does not exist
            if (AccountNumberExists==false)
            {
                MessageBox.Show("The account number entered does not exist!");

            }
        }




        



        //WITHDRAW BUTTON
        private void TransactionsWithdrawButton_Click(object sender, EventArgs e)
        {
            if (TransactionsAccountNumber.Text == String.Empty
                || TransactionsAmount.Text == String.Empty)
            {
                MessageBox.Show("Fill up all the fields!");
                return;
            }
            
            bool AccountNumberExists = false;
            

            //for exception handling
            try
            {
                if(Convert.ToDouble(TransactionsAmount.Text) < 0)
                {
                    throw new InvalidAmountException();
                }
            }
            catch (InvalidAmountException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            

            //current account
            foreach (CurrentAccount currentAccount in NewBankSystem.CurrentAccountList)
            {
                if (TransactionsAccountNumber.Text == currentAccount.GetAccountNumber())
                {
                    AccountNumberExists = true;
                    if((currentAccount.GetAccountBalance() - Convert.ToDouble(TransactionsAmount.Text))<500)
                    {
                        MessageBox.Show("Insufficient balance to withdraw!");
                        return;
                    }
                    else
                    {
                        if (Convert.ToDouble(TransactionsAmount.Text) <= 100000)
                        {
                            currentAccount.SetAccountBalance(currentAccount.GetAccountBalance() - Convert.ToDouble(TransactionsAmount.Text));
                            currentAccount.SetAccountHistory("Withdrawal of BDT " + TransactionsAmount.Text + " at " + Convert.ToString(DateTime.Now));
                            MessageBox.Show("Transaction completed successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Maximum transaction amount exceeded!");
                        }
                    }
                    break;   
                }
            }


            //loan account
            if (AccountNumberExists == false)
            {
                foreach (LoanAccount loanAccount in NewBankSystem.LoanAccountList)
                {
                    if (TransactionsAccountNumber.Text == loanAccount.GetAccountNumber())
                    {
                        AccountNumberExists=true;
                        MessageBox.Show("Invalid request!");
                        break;
                    }
                }
            }


            //savings account
            if (AccountNumberExists == false)
            {
                foreach (SavingsAccount savingsAccount in NewBankSystem.SavingsAccountList)
                {
                    if (TransactionsAccountNumber.Text == savingsAccount.GetAccountNumber())
                    {
                        AccountNumberExists=true;
                        if (savingsAccount.CheckNumberOfTransations() >= 5)
                        {
                            MessageBox.Show("Maximum number of transactions for the day exceeded!");
                            return;
                        }
                        
                        if ((savingsAccount.GetAccountBalance() - Convert.ToDouble(TransactionsAmount.Text))<500)
                        {
                            MessageBox.Show("Insufficient Balance!");
                            return;
                        }
                        else
                        {
                            savingsAccount.UpdateDateTime();
                            savingsAccount.SetAccountBalance(savingsAccount.GetAccountBalance() - Convert.ToDouble(TransactionsAmount.Text) - 15.0);
                            savingsAccount.SetAccountHistory("Withdrawal of BDT " + TransactionsAmount.Text + " at " + Convert.ToString(DateTime.Now));
                            MessageBox.Show("Transaction completed successfully!");
                        }
                        break;
                    }
                   
                }
                
            }


            //account does not exist
            if (AccountNumberExists==false)
            {
                MessageBox.Show("The account number entered does not exist!");

            }
        }







        //SHOW HISTORY BUTTON
        private void TransactionHistoryShowTransactionHistoryButtonOnClick(object sender, EventArgs e)
        {
            if(TransactionHistoryAccountNumber.Text == String.Empty)
            {
                MessageBox.Show("Fill up all the fields!");
                return;
            }
            
            bool AccountNumberExists = false;

            foreach (CurrentAccount currentAccount in NewBankSystem.CurrentAccountList)
            {
                if (TransactionHistoryAccountNumber.Text == currentAccount.GetAccountNumber())
                {
                    AccountNumberExists = true;
                    TransactionHistoryTransactionHistoryListBox.Items.Clear();
                    TransactionHistoryTransactionHistoryListBox.Items.Add("User ID: " + Convert.ToString(currentAccount.GetUserID()));
                    TransactionHistoryTransactionHistoryListBox.Items.Add("Name of account holder: " + currentAccount.GetUserName());
                    foreach (string AccountHistoryString in currentAccount.GetAccountHistory())
                        TransactionHistoryTransactionHistoryListBox.Items.Add(AccountHistoryString);
                    TransactionHistoryTransactionHistoryListBox.Items.Add("Balance: BDT " + Convert.ToString(currentAccount.GetAccountBalance()));
                    break;
                }
            }

            if (AccountNumberExists == false)
            {
                foreach (LoanAccount loanAccount in NewBankSystem.LoanAccountList)
                {
                    AccountNumberExists = true;
                    TransactionHistoryTransactionHistoryListBox.Items.Clear();
                    TransactionHistoryTransactionHistoryListBox.Items.Add("User ID: " + Convert.ToString(loanAccount.GetUserID()));
                    TransactionHistoryTransactionHistoryListBox.Items.Add("Name of account holder: " + loanAccount.GetUserName());
                    foreach (string AccountHistoryString in loanAccount.GetAccountHistory())
                        TransactionHistoryTransactionHistoryListBox.Items.Add(AccountHistoryString);
                    TransactionHistoryTransactionHistoryListBox.Items.Add("Loan Remaining: BDT " + Convert.ToString(loanAccount.GetAccountBalance()));
                    break;
                }
            }

            if (AccountNumberExists == false)
            {
                foreach (SavingsAccount savingsAccount in NewBankSystem.SavingsAccountList)
                {
                    if (TransactionsAccountNumber.Text == savingsAccount.GetAccountNumber())
                    {
                        AccountNumberExists=true;
                        TransactionHistoryTransactionHistoryListBox.Items.Clear();
                        TransactionHistoryTransactionHistoryListBox.Items.Add("User ID: " + Convert.ToString(savingsAccount.GetUserID()));
                        TransactionHistoryTransactionHistoryListBox.Items.Add("Name of account holder: " + savingsAccount.GetUserName());
                        foreach (string AccountHistoryString in savingsAccount.GetAccountHistory())
                            TransactionHistoryTransactionHistoryListBox.Items.Add(AccountHistoryString);
                        TransactionHistoryTransactionHistoryListBox.Items.Add("Balance: BDT " + Convert.ToString(savingsAccount.GetAccountBalance()));
                        break;
                    }

                }

            }

            if (AccountNumberExists==false)
            {
                MessageBox.Show("The account number entered does not exist!");

            }
        }
    }
}
