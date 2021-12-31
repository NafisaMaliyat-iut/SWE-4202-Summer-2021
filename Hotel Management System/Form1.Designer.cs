namespace Hotel_Management_System
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
            System.Windows.Forms.Button SeeOrderDetailsButton;
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OwnerSectionBookingID = new System.Windows.Forms.TextBox();
            this.OwnerSectionStatusDropDown = new System.Windows.Forms.ComboBox();
            this.OwnerSectionSetStatusButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.OwnerSectionShowCurrentBalance = new System.Windows.Forms.Label();
            this.OwnerSectionListBox = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CreateAccountUserID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CreateAccountName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CreateAccountContactNo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CreateAccountAddress = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.PlaceBookingUserID = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.UserSectionCreateAccountButton = new System.Windows.Forms.Button();
            this.UserSectionPlaceBookingButton = new System.Windows.Forms.Button();
            this.PlaceBookingRoomChoice = new System.Windows.Forms.ComboBox();
            this.SeeOrderDetailsBookingID = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.SeeOrderDetailsStatus = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.SeeOrderDetailsRoomNumber1 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.SeeOrderDetailsAmount = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.SeeOrderDetailsUserName = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.SeeOrderDetailsAddress = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.OwnerSectionShowRoomDetails = new System.Windows.Forms.Button();
            this.PlaceBookingRoomQuantity = new System.Windows.Forms.ComboBox();
            this.OwnerSectionRoomNumber1 = new System.Windows.Forms.TextBox();
            this.OwnerSectionRoomNumberLabel = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.OwnerSectionRoomNumber2 = new System.Windows.Forms.TextBox();
            this.OwnerSectionRoomNumber3 = new System.Windows.Forms.TextBox();
            this.UserSectionEntryDate = new System.Windows.Forms.DateTimePicker();
            this.UserSectionDepartureDate = new System.Windows.Forms.DateTimePicker();
            this.SeeOrderDetailsRoomNumber2 = new System.Windows.Forms.Label();
            this.SeeOrderDetailsRoomNumber3 = new System.Windows.Forms.Label();
            SeeOrderDetailsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SeeOrderDetailsButton
            // 
            SeeOrderDetailsButton.Location = new System.Drawing.Point(523, 368);
            SeeOrderDetailsButton.Name = "SeeOrderDetailsButton";
            SeeOrderDetailsButton.Size = new System.Drawing.Size(153, 23);
            SeeOrderDetailsButton.TabIndex = 43;
            SeeOrderDetailsButton.Text = "Show Order Details";
            SeeOrderDetailsButton.UseVisualStyleBackColor = true;
            SeeOrderDetailsButton.Click += new System.EventHandler(this.SeeOrderDetailsOnClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Owner Section";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Booking ID";
            // 
            // OwnerSectionBookingID
            // 
            this.OwnerSectionBookingID.Location = new System.Drawing.Point(112, 41);
            this.OwnerSectionBookingID.Name = "OwnerSectionBookingID";
            this.OwnerSectionBookingID.Size = new System.Drawing.Size(132, 20);
            this.OwnerSectionBookingID.TabIndex = 2;
            // 
            // OwnerSectionStatusDropDown
            // 
            this.OwnerSectionStatusDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OwnerSectionStatusDropDown.FormattingEnabled = true;
            this.OwnerSectionStatusDropDown.Items.AddRange(new object[] {
            "Pending",
            "Confirmed"});
            this.OwnerSectionStatusDropDown.Location = new System.Drawing.Point(112, 69);
            this.OwnerSectionStatusDropDown.Name = "OwnerSectionStatusDropDown";
            this.OwnerSectionStatusDropDown.Size = new System.Drawing.Size(132, 21);
            this.OwnerSectionStatusDropDown.TabIndex = 3;
            this.OwnerSectionStatusDropDown.SelectedIndexChanged += new System.EventHandler(this.OwnerSectionStatusDropDownEvent);
            // 
            // OwnerSectionSetStatusButton
            // 
            this.OwnerSectionSetStatusButton.Location = new System.Drawing.Point(72, 139);
            this.OwnerSectionSetStatusButton.Name = "OwnerSectionSetStatusButton";
            this.OwnerSectionSetStatusButton.Size = new System.Drawing.Size(153, 23);
            this.OwnerSectionSetStatusButton.TabIndex = 4;
            this.OwnerSectionSetStatusButton.Text = "Set Status";
            this.OwnerSectionSetStatusButton.UseVisualStyleBackColor = true;
            this.OwnerSectionSetStatusButton.Click += new System.EventHandler(this.OwnerSectionSetStatusButtonOnClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(12, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Current Balance :";
            // 
            // OwnerSectionShowCurrentBalance
            // 
            this.OwnerSectionShowCurrentBalance.AutoSize = true;
            this.OwnerSectionShowCurrentBalance.Location = new System.Drawing.Point(124, 174);
            this.OwnerSectionShowCurrentBalance.Name = "OwnerSectionShowCurrentBalance";
            this.OwnerSectionShowCurrentBalance.Size = new System.Drawing.Size(19, 13);
            this.OwnerSectionShowCurrentBalance.TabIndex = 6;
            this.OwnerSectionShowCurrentBalance.Text = "----";
            this.OwnerSectionShowCurrentBalance.UseMnemonic = false;
            // 
            // OwnerSectionListBox
            // 
            this.OwnerSectionListBox.FormattingEnabled = true;
            this.OwnerSectionListBox.Location = new System.Drawing.Point(15, 204);
            this.OwnerSectionListBox.Name = "OwnerSectionListBox";
            this.OwnerSectionListBox.Size = new System.Drawing.Size(305, 147);
            this.OwnerSectionListBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(549, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "User Section";
            // 
            // CreateAccountUserID
            // 
            this.CreateAccountUserID.Location = new System.Drawing.Point(477, 37);
            this.CreateAccountUserID.Name = "CreateAccountUserID";
            this.CreateAccountUserID.Size = new System.Drawing.Size(106, 20);
            this.CreateAccountUserID.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(391, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Customer ID";
            // 
            // CreateAccountName
            // 
            this.CreateAccountName.Location = new System.Drawing.Point(477, 66);
            this.CreateAccountName.Name = "CreateAccountName";
            this.CreateAccountName.Size = new System.Drawing.Size(106, 20);
            this.CreateAccountName.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(391, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Name";
            // 
            // CreateAccountContactNo
            // 
            this.CreateAccountContactNo.Location = new System.Drawing.Point(477, 97);
            this.CreateAccountContactNo.Name = "CreateAccountContactNo";
            this.CreateAccountContactNo.Size = new System.Drawing.Size(106, 20);
            this.CreateAccountContactNo.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(391, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Contact No.";
            // 
            // CreateAccountAddress
            // 
            this.CreateAccountAddress.Location = new System.Drawing.Point(477, 129);
            this.CreateAccountAddress.Name = "CreateAccountAddress";
            this.CreateAccountAddress.Size = new System.Drawing.Size(106, 20);
            this.CreateAccountAddress.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(391, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Address";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(605, 133);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Departure Date";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(605, 101);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Entry Date";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(605, 70);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Room Choice";
            // 
            // PlaceBookingUserID
            // 
            this.PlaceBookingUserID.Location = new System.Drawing.Point(688, 38);
            this.PlaceBookingUserID.Name = "PlaceBookingUserID";
            this.PlaceBookingUserID.Size = new System.Drawing.Size(100, 20);
            this.PlaceBookingUserID.TabIndex = 18;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(605, 41);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "Customer ID";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(805, 70);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 13);
            this.label14.TabIndex = 25;
            this.label14.Text = "Quantity";
            // 
            // UserSectionCreateAccountButton
            // 
            this.UserSectionCreateAccountButton.Location = new System.Drawing.Point(400, 164);
            this.UserSectionCreateAccountButton.Name = "UserSectionCreateAccountButton";
            this.UserSectionCreateAccountButton.Size = new System.Drawing.Size(153, 23);
            this.UserSectionCreateAccountButton.TabIndex = 27;
            this.UserSectionCreateAccountButton.Text = "Create Account";
            this.UserSectionCreateAccountButton.UseVisualStyleBackColor = true;
            this.UserSectionCreateAccountButton.Click += new System.EventHandler(this.UserSectionCreateAccountButtonOnClick);
            // 
            // UserSectionPlaceBookingButton
            // 
            this.UserSectionPlaceBookingButton.Location = new System.Drawing.Point(688, 164);
            this.UserSectionPlaceBookingButton.Name = "UserSectionPlaceBookingButton";
            this.UserSectionPlaceBookingButton.Size = new System.Drawing.Size(153, 23);
            this.UserSectionPlaceBookingButton.TabIndex = 28;
            this.UserSectionPlaceBookingButton.Text = "Place Booking";
            this.UserSectionPlaceBookingButton.UseVisualStyleBackColor = true;
            this.UserSectionPlaceBookingButton.Click += new System.EventHandler(this.UserSectionPlaceBookingButtonOnClick);
            // 
            // PlaceBookingRoomChoice
            // 
            this.PlaceBookingRoomChoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PlaceBookingRoomChoice.FormattingEnabled = true;
            this.PlaceBookingRoomChoice.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Suite",
            "Deluxe"});
            this.PlaceBookingRoomChoice.Location = new System.Drawing.Point(688, 64);
            this.PlaceBookingRoomChoice.Name = "PlaceBookingRoomChoice";
            this.PlaceBookingRoomChoice.Size = new System.Drawing.Size(100, 21);
            this.PlaceBookingRoomChoice.TabIndex = 29;
            // 
            // SeeOrderDetailsBookingID
            // 
            this.SeeOrderDetailsBookingID.Location = new System.Drawing.Point(463, 233);
            this.SeeOrderDetailsBookingID.Name = "SeeOrderDetailsBookingID";
            this.SeeOrderDetailsBookingID.Size = new System.Drawing.Size(100, 20);
            this.SeeOrderDetailsBookingID.TabIndex = 31;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(397, 236);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 13);
            this.label15.TabIndex = 30;
            this.label15.Text = "Booking ID";
            // 
            // SeeOrderDetailsStatus
            // 
            this.SeeOrderDetailsStatus.AutoSize = true;
            this.SeeOrderDetailsStatus.Location = new System.Drawing.Point(493, 282);
            this.SeeOrderDetailsStatus.Name = "SeeOrderDetailsStatus";
            this.SeeOrderDetailsStatus.Size = new System.Drawing.Size(0, 13);
            this.SeeOrderDetailsStatus.TabIndex = 33;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(397, 282);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(37, 13);
            this.label17.TabIndex = 32;
            this.label17.Text = "Status";
            // 
            // SeeOrderDetailsRoomNumber1
            // 
            this.SeeOrderDetailsRoomNumber1.AutoSize = true;
            this.SeeOrderDetailsRoomNumber1.Location = new System.Drawing.Point(493, 310);
            this.SeeOrderDetailsRoomNumber1.Name = "SeeOrderDetailsRoomNumber1";
            this.SeeOrderDetailsRoomNumber1.Size = new System.Drawing.Size(0, 13);
            this.SeeOrderDetailsRoomNumber1.TabIndex = 35;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(397, 310);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(52, 13);
            this.label19.TabIndex = 34;
            this.label19.Text = "Room No";
            // 
            // SeeOrderDetailsAmount
            // 
            this.SeeOrderDetailsAmount.AutoSize = true;
            this.SeeOrderDetailsAmount.Location = new System.Drawing.Point(493, 338);
            this.SeeOrderDetailsAmount.Name = "SeeOrderDetailsAmount";
            this.SeeOrderDetailsAmount.Size = new System.Drawing.Size(0, 13);
            this.SeeOrderDetailsAmount.TabIndex = 37;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(397, 338);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(43, 13);
            this.label21.TabIndex = 36;
            this.label21.Text = "Amount";
            // 
            // SeeOrderDetailsUserName
            // 
            this.SeeOrderDetailsUserName.AutoSize = true;
            this.SeeOrderDetailsUserName.Location = new System.Drawing.Point(759, 282);
            this.SeeOrderDetailsUserName.Name = "SeeOrderDetailsUserName";
            this.SeeOrderDetailsUserName.Size = new System.Drawing.Size(0, 13);
            this.SeeOrderDetailsUserName.TabIndex = 39;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(654, 282);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(60, 13);
            this.label23.TabIndex = 38;
            this.label23.Text = "User Name";
            // 
            // SeeOrderDetailsAddress
            // 
            this.SeeOrderDetailsAddress.AutoSize = true;
            this.SeeOrderDetailsAddress.Location = new System.Drawing.Point(759, 308);
            this.SeeOrderDetailsAddress.Name = "SeeOrderDetailsAddress";
            this.SeeOrderDetailsAddress.Size = new System.Drawing.Size(0, 13);
            this.SeeOrderDetailsAddress.TabIndex = 41;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(669, 308);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(45, 13);
            this.label25.TabIndex = 40;
            this.label25.Text = "Address";
            // 
            // OwnerSectionShowRoomDetails
            // 
            this.OwnerSectionShowRoomDetails.Location = new System.Drawing.Point(91, 368);
            this.OwnerSectionShowRoomDetails.Name = "OwnerSectionShowRoomDetails";
            this.OwnerSectionShowRoomDetails.Size = new System.Drawing.Size(153, 23);
            this.OwnerSectionShowRoomDetails.TabIndex = 42;
            this.OwnerSectionShowRoomDetails.Text = "Show Room Details";
            this.OwnerSectionShowRoomDetails.UseVisualStyleBackColor = true;
            this.OwnerSectionShowRoomDetails.Click += new System.EventHandler(this.OwnerSectionShowRoomDetailsOnClick);
            // 
            // PlaceBookingRoomQuantity
            // 
            this.PlaceBookingRoomQuantity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PlaceBookingRoomQuantity.FormattingEnabled = true;
            this.PlaceBookingRoomQuantity.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.PlaceBookingRoomQuantity.Location = new System.Drawing.Point(857, 67);
            this.PlaceBookingRoomQuantity.Name = "PlaceBookingRoomQuantity";
            this.PlaceBookingRoomQuantity.Size = new System.Drawing.Size(100, 21);
            this.PlaceBookingRoomQuantity.TabIndex = 44;
            // 
            // OwnerSectionRoomNumber1
            // 
            this.OwnerSectionRoomNumber1.Location = new System.Drawing.Point(112, 101);
            this.OwnerSectionRoomNumber1.Name = "OwnerSectionRoomNumber1";
            this.OwnerSectionRoomNumber1.Size = new System.Drawing.Size(40, 20);
            this.OwnerSectionRoomNumber1.TabIndex = 46;
            this.OwnerSectionRoomNumber1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.OwnerSectionRoomNumber1.Visible = false;
            // 
            // OwnerSectionRoomNumberLabel
            // 
            this.OwnerSectionRoomNumberLabel.AutoSize = true;
            this.OwnerSectionRoomNumberLabel.Location = new System.Drawing.Point(51, 104);
            this.OwnerSectionRoomNumberLabel.Name = "OwnerSectionRoomNumberLabel";
            this.OwnerSectionRoomNumberLabel.Size = new System.Drawing.Size(55, 13);
            this.OwnerSectionRoomNumberLabel.TabIndex = 45;
            this.OwnerSectionRoomNumberLabel.Text = "Room No.";
            this.OwnerSectionRoomNumberLabel.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(69, 74);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(37, 13);
            this.label16.TabIndex = 47;
            this.label16.Text = "Status";
            // 
            // OwnerSectionRoomNumber2
            // 
            this.OwnerSectionRoomNumber2.Location = new System.Drawing.Point(158, 101);
            this.OwnerSectionRoomNumber2.Name = "OwnerSectionRoomNumber2";
            this.OwnerSectionRoomNumber2.Size = new System.Drawing.Size(40, 20);
            this.OwnerSectionRoomNumber2.TabIndex = 48;
            this.OwnerSectionRoomNumber2.Visible = false;
            // 
            // OwnerSectionRoomNumber3
            // 
            this.OwnerSectionRoomNumber3.Location = new System.Drawing.Point(204, 101);
            this.OwnerSectionRoomNumber3.Name = "OwnerSectionRoomNumber3";
            this.OwnerSectionRoomNumber3.Size = new System.Drawing.Size(40, 20);
            this.OwnerSectionRoomNumber3.TabIndex = 49;
            this.OwnerSectionRoomNumber3.Visible = false;
            // 
            // UserSectionEntryDate
            // 
            this.UserSectionEntryDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.UserSectionEntryDate.Location = new System.Drawing.Point(688, 101);
            this.UserSectionEntryDate.Name = "UserSectionEntryDate";
            this.UserSectionEntryDate.Size = new System.Drawing.Size(200, 20);
            this.UserSectionEntryDate.TabIndex = 50;
            // 
            // UserSectionDepartureDate
            // 
            this.UserSectionDepartureDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.UserSectionDepartureDate.Location = new System.Drawing.Point(688, 130);
            this.UserSectionDepartureDate.Name = "UserSectionDepartureDate";
            this.UserSectionDepartureDate.Size = new System.Drawing.Size(200, 20);
            this.UserSectionDepartureDate.TabIndex = 51;
            // 
            // SeeOrderDetailsRoomNumber2
            // 
            this.SeeOrderDetailsRoomNumber2.AutoSize = true;
            this.SeeOrderDetailsRoomNumber2.Location = new System.Drawing.Point(526, 310);
            this.SeeOrderDetailsRoomNumber2.Name = "SeeOrderDetailsRoomNumber2";
            this.SeeOrderDetailsRoomNumber2.Size = new System.Drawing.Size(0, 13);
            this.SeeOrderDetailsRoomNumber2.TabIndex = 52;
            // 
            // SeeOrderDetailsRoomNumber3
            // 
            this.SeeOrderDetailsRoomNumber3.AutoSize = true;
            this.SeeOrderDetailsRoomNumber3.Location = new System.Drawing.Point(562, 310);
            this.SeeOrderDetailsRoomNumber3.Name = "SeeOrderDetailsRoomNumber3";
            this.SeeOrderDetailsRoomNumber3.Size = new System.Drawing.Size(0, 13);
            this.SeeOrderDetailsRoomNumber3.TabIndex = 53;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 450);
            this.Controls.Add(this.SeeOrderDetailsRoomNumber3);
            this.Controls.Add(this.SeeOrderDetailsRoomNumber2);
            this.Controls.Add(this.UserSectionDepartureDate);
            this.Controls.Add(this.UserSectionEntryDate);
            this.Controls.Add(this.OwnerSectionRoomNumber3);
            this.Controls.Add(this.OwnerSectionRoomNumber2);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.OwnerSectionRoomNumber1);
            this.Controls.Add(this.OwnerSectionRoomNumberLabel);
            this.Controls.Add(this.PlaceBookingRoomQuantity);
            this.Controls.Add(SeeOrderDetailsButton);
            this.Controls.Add(this.OwnerSectionShowRoomDetails);
            this.Controls.Add(this.SeeOrderDetailsAddress);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.SeeOrderDetailsUserName);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.SeeOrderDetailsAmount);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.SeeOrderDetailsRoomNumber1);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.SeeOrderDetailsStatus);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.SeeOrderDetailsBookingID);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.PlaceBookingRoomChoice);
            this.Controls.Add(this.UserSectionPlaceBookingButton);
            this.Controls.Add(this.UserSectionCreateAccountButton);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.PlaceBookingUserID);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.CreateAccountAddress);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CreateAccountContactNo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CreateAccountName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CreateAccountUserID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.OwnerSectionListBox);
            this.Controls.Add(this.OwnerSectionShowCurrentBalance);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OwnerSectionSetStatusButton);
            this.Controls.Add(this.OwnerSectionStatusDropDown);
            this.Controls.Add(this.OwnerSectionBookingID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Hotel Management System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox OwnerSectionBookingID;
        private System.Windows.Forms.ComboBox OwnerSectionStatusDropDown;
        private System.Windows.Forms.Button OwnerSectionSetStatusButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label OwnerSectionShowCurrentBalance;
        private System.Windows.Forms.ListBox OwnerSectionListBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CreateAccountUserID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CreateAccountName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox CreateAccountContactNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox CreateAccountAddress;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox PlaceBookingUserID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button UserSectionCreateAccountButton;
        private System.Windows.Forms.Button UserSectionPlaceBookingButton;
        private System.Windows.Forms.ComboBox PlaceBookingRoomChoice;
        private System.Windows.Forms.TextBox SeeOrderDetailsBookingID;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label SeeOrderDetailsStatus;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label SeeOrderDetailsRoomNumber1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label SeeOrderDetailsAmount;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label SeeOrderDetailsUserName;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label SeeOrderDetailsAddress;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button OwnerSectionShowRoomDetails;
        private System.Windows.Forms.ComboBox PlaceBookingRoomQuantity;
        private System.Windows.Forms.TextBox OwnerSectionRoomNumber1;
        private System.Windows.Forms.Label OwnerSectionRoomNumberLabel;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox OwnerSectionRoomNumber2;
        private System.Windows.Forms.TextBox OwnerSectionRoomNumber3;
        private System.Windows.Forms.DateTimePicker UserSectionEntryDate;
        private System.Windows.Forms.DateTimePicker UserSectionDepartureDate;
        private System.Windows.Forms.Label SeeOrderDetailsRoomNumber2;
        private System.Windows.Forms.Label SeeOrderDetailsRoomNumber3;
    }
}

