namespace Banking_System
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CreateAccountUserID = new System.Windows.Forms.TextBox();
            this.CreateAccountAccountType = new System.Windows.Forms.ComboBox();
            this.CreateAccountButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TransactionsAccountNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TransactionsAmount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.AccountInfoAccountNumber = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TransactionsWithdrawButton = new System.Windows.Forms.Button();
            this.AccountInfoShowAccountInfoButton = new System.Windows.Forms.Button();
            this.TransactionsDepositButton = new System.Windows.Forms.Button();
            this.TransactionHistoryShowButton = new System.Windows.Forms.Button();
            this.TransactionHistoryAccountNumber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TransactionHistoryTransactionHistoryListBox = new System.Windows.Forms.ListBox();
            this.CreateUserAccountButton = new System.Windows.Forms.Button();
            this.CreateUserAccountUserName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.CreateAccountAmountTextBox = new System.Windows.Forms.TextBox();
            this.CreateAccountAmountLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create Account";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "User ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Select Account Type";
            // 
            // CreateAccountUserID
            // 
            this.CreateAccountUserID.Location = new System.Drawing.Point(130, 160);
            this.CreateAccountUserID.Name = "CreateAccountUserID";
            this.CreateAccountUserID.Size = new System.Drawing.Size(100, 20);
            this.CreateAccountUserID.TabIndex = 3;
            // 
            // CreateAccountAccountType
            // 
            this.CreateAccountAccountType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CreateAccountAccountType.FormattingEnabled = true;
            this.CreateAccountAccountType.Items.AddRange(new object[] {
            "Current Account",
            "Savings Account",
            "Loan Account"});
            this.CreateAccountAccountType.Location = new System.Drawing.Point(130, 201);
            this.CreateAccountAccountType.Name = "CreateAccountAccountType";
            this.CreateAccountAccountType.Size = new System.Drawing.Size(121, 21);
            this.CreateAccountAccountType.TabIndex = 4;
            // 
            // CreateAccountButton
            // 
            this.CreateAccountButton.Location = new System.Drawing.Point(33, 276);
            this.CreateAccountButton.Name = "CreateAccountButton";
            this.CreateAccountButton.Size = new System.Drawing.Size(161, 23);
            this.CreateAccountButton.TabIndex = 5;
            this.CreateAccountButton.Text = "Create Acount";
            this.CreateAccountButton.UseVisualStyleBackColor = true;
            this.CreateAccountButton.Click += new System.EventHandler(this.CreateAccountButtonClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Transactions";
            // 
            // TransactionsAccountNumber
            // 
            this.TransactionsAccountNumber.Location = new System.Drawing.Point(115, 361);
            this.TransactionsAccountNumber.Name = "TransactionsAccountNumber";
            this.TransactionsAccountNumber.Size = new System.Drawing.Size(100, 20);
            this.TransactionsAccountNumber.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 361);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Account Number";
            // 
            // TransactionsAmount
            // 
            this.TransactionsAmount.Location = new System.Drawing.Point(115, 396);
            this.TransactionsAmount.Name = "TransactionsAmount";
            this.TransactionsAmount.Size = new System.Drawing.Size(100, 20);
            this.TransactionsAmount.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 396);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Amount";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(366, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Account Info";
            // 
            // AccountInfoAccountNumber
            // 
            this.AccountInfoAccountNumber.Location = new System.Drawing.Point(479, 38);
            this.AccountInfoAccountNumber.Name = "AccountInfoAccountNumber";
            this.AccountInfoAccountNumber.Size = new System.Drawing.Size(100, 20);
            this.AccountInfoAccountNumber.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(366, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Account Number";
            // 
            // TransactionsWithdrawButton
            // 
            this.TransactionsWithdrawButton.Location = new System.Drawing.Point(19, 439);
            this.TransactionsWithdrawButton.Name = "TransactionsWithdrawButton";
            this.TransactionsWithdrawButton.Size = new System.Drawing.Size(75, 23);
            this.TransactionsWithdrawButton.TabIndex = 15;
            this.TransactionsWithdrawButton.Text = "Withdraw";
            this.TransactionsWithdrawButton.UseVisualStyleBackColor = true;
            this.TransactionsWithdrawButton.Click += new System.EventHandler(this.TransactionsWithdrawButton_Click);
            // 
            // AccountInfoShowAccountInfoButton
            // 
            this.AccountInfoShowAccountInfoButton.Location = new System.Drawing.Point(400, 81);
            this.AccountInfoShowAccountInfoButton.Name = "AccountInfoShowAccountInfoButton";
            this.AccountInfoShowAccountInfoButton.Size = new System.Drawing.Size(151, 23);
            this.AccountInfoShowAccountInfoButton.TabIndex = 17;
            this.AccountInfoShowAccountInfoButton.Text = "Show Account Info";
            this.AccountInfoShowAccountInfoButton.UseVisualStyleBackColor = true;
            this.AccountInfoShowAccountInfoButton.Click += new System.EventHandler(this.AccountInfoShowAccountInfoButtonClick);
            // 
            // TransactionsDepositButton
            // 
            this.TransactionsDepositButton.Location = new System.Drawing.Point(140, 439);
            this.TransactionsDepositButton.Name = "TransactionsDepositButton";
            this.TransactionsDepositButton.Size = new System.Drawing.Size(75, 23);
            this.TransactionsDepositButton.TabIndex = 18;
            this.TransactionsDepositButton.Text = "Deposit";
            this.TransactionsDepositButton.UseVisualStyleBackColor = true;
            this.TransactionsDepositButton.Click += new System.EventHandler(this.TransactionsDepositButtonClick);
            // 
            // TransactionHistoryShowButton
            // 
            this.TransactionHistoryShowButton.Location = new System.Drawing.Point(446, 228);
            this.TransactionHistoryShowButton.Name = "TransactionHistoryShowButton";
            this.TransactionHistoryShowButton.Size = new System.Drawing.Size(151, 23);
            this.TransactionHistoryShowButton.TabIndex = 22;
            this.TransactionHistoryShowButton.Text = "Show Transaction History";
            this.TransactionHistoryShowButton.UseVisualStyleBackColor = true;
            this.TransactionHistoryShowButton.Click += new System.EventHandler(this.TransactionHistoryShowTransactionHistoryButtonOnClick);
            // 
            // TransactionHistoryAccountNumber
            // 
            this.TransactionHistoryAccountNumber.Location = new System.Drawing.Point(479, 175);
            this.TransactionHistoryAccountNumber.Name = "TransactionHistoryAccountNumber";
            this.TransactionHistoryAccountNumber.Size = new System.Drawing.Size(100, 20);
            this.TransactionHistoryAccountNumber.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(366, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Account Number";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(366, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "TransactionHistory";
            // 
            // TransactionHistoryTransactionHistoryListBox
            // 
            this.TransactionHistoryTransactionHistoryListBox.FormattingEnabled = true;
            this.TransactionHistoryTransactionHistoryListBox.Location = new System.Drawing.Point(338, 295);
            this.TransactionHistoryTransactionHistoryListBox.Name = "TransactionHistoryTransactionHistoryListBox";
            this.TransactionHistoryTransactionHistoryListBox.Size = new System.Drawing.Size(370, 160);
            this.TransactionHistoryTransactionHistoryListBox.TabIndex = 23;
            // 
            // CreateUserAccountButton
            // 
            this.CreateUserAccountButton.Location = new System.Drawing.Point(23, 81);
            this.CreateUserAccountButton.Name = "CreateUserAccountButton";
            this.CreateUserAccountButton.Size = new System.Drawing.Size(161, 23);
            this.CreateUserAccountButton.TabIndex = 27;
            this.CreateUserAccountButton.Text = "Create User Account";
            this.CreateUserAccountButton.UseVisualStyleBackColor = true;
            this.CreateUserAccountButton.Click += new System.EventHandler(this.CreateUserAccountButtonClick);
            // 
            // CreateUserAccountUserName
            // 
            this.CreateUserAccountUserName.Location = new System.Drawing.Point(94, 38);
            this.CreateUserAccountUserName.Name = "CreateUserAccountUserName";
            this.CreateUserAccountUserName.Size = new System.Drawing.Size(100, 20);
            this.CreateUserAccountUserName.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Name";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Create User Profile";
            // 
            // CreateAccountAmountTextBox
            // 
            this.CreateAccountAmountTextBox.Location = new System.Drawing.Point(130, 238);
            this.CreateAccountAmountTextBox.Name = "CreateAccountAmountTextBox";
            this.CreateAccountAmountTextBox.Size = new System.Drawing.Size(100, 20);
            this.CreateAccountAmountTextBox.TabIndex = 29;
            // 
            // CreateAccountAmountLabel
            // 
            this.CreateAccountAmountLabel.AutoSize = true;
            this.CreateAccountAmountLabel.Location = new System.Drawing.Point(16, 238);
            this.CreateAccountAmountLabel.Name = "CreateAccountAmountLabel";
            this.CreateAccountAmountLabel.Size = new System.Drawing.Size(43, 13);
            this.CreateAccountAmountLabel.TabIndex = 28;
            this.CreateAccountAmountLabel.Text = "Amount";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 494);
            this.Controls.Add(this.CreateAccountAmountTextBox);
            this.Controls.Add(this.CreateAccountAmountLabel);
            this.Controls.Add(this.CreateUserAccountButton);
            this.Controls.Add(this.CreateUserAccountUserName);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.TransactionHistoryTransactionHistoryListBox);
            this.Controls.Add(this.TransactionHistoryShowButton);
            this.Controls.Add(this.TransactionHistoryAccountNumber);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TransactionsDepositButton);
            this.Controls.Add(this.AccountInfoShowAccountInfoButton);
            this.Controls.Add(this.TransactionsWithdrawButton);
            this.Controls.Add(this.AccountInfoAccountNumber);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TransactionsAmount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TransactionsAccountNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CreateAccountButton);
            this.Controls.Add(this.CreateAccountAccountType);
            this.Controls.Add(this.CreateAccountUserID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Banking System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CreateAccountUserID;
        private System.Windows.Forms.ComboBox CreateAccountAccountType;
        private System.Windows.Forms.Button CreateAccountButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TransactionsAccountNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TransactionsAmount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox AccountInfoAccountNumber;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button TransactionsWithdrawButton;
        private System.Windows.Forms.Button AccountInfoShowAccountInfoButton;
        private System.Windows.Forms.Button TransactionsDepositButton;
        private System.Windows.Forms.Button TransactionHistoryShowButton;
        private System.Windows.Forms.TextBox TransactionHistoryAccountNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox TransactionHistoryTransactionHistoryListBox;
        private System.Windows.Forms.Button CreateUserAccountButton;
        private System.Windows.Forms.TextBox CreateUserAccountUserName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox CreateAccountAmountTextBox;
        private System.Windows.Forms.Label CreateAccountAmountLabel;
    }
}

