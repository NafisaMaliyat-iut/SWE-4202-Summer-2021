namespace LibraryManagementSystem
{
    partial class LibraryManagementSystem
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
            this.EnterUserIDToAdd = new System.Windows.Forms.TextBox();
            this.EnterUserNameToAdd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EnterUserAddressToAdd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AddUserInfoWhenClicked = new System.Windows.Forms.Button();
            this.AddBookInfoWhenClicked = new System.Windows.Forms.Button();
            this.EnterBookAuthorToAdd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.EnterBookNameToAdd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.EnterBookIDToAdd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.EnterBookPublisherToAdd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.EnterBookQuantityToAdd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.EnterUserIDBorrow = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.EnterBookIDBorrow = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.EnterUserIDToSearch = new System.Windows.Forms.TextBox();
            this.ListBoxUserHistory = new System.Windows.Forms.ListBox();
            this.EnterBookIDToSearch = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.ShowUserHistory = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.ShowBookID = new System.Windows.Forms.Label();
            this.ShowBookTitle = new System.Windows.Forms.Label();
            this.ShowBookAuthor = new System.Windows.Forms.Label();
            this.ShowBookPublisher = new System.Windows.Forms.Label();
            this.ShowBookQuantity = new System.Windows.Forms.Label();
            this.showHistoryBookID = new System.Windows.Forms.Label();
            this.showHistoryBookTitle = new System.Windows.Forms.Label();
            this.showHistoryBookAuthor = new System.Windows.Forms.Label();
            this.showHistoryBookPublisher = new System.Windows.Forms.Label();
            this.showHistoryBookQuantity = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "User ID";
            // 
            // EnterUserIDToAdd
            // 
            this.EnterUserIDToAdd.Location = new System.Drawing.Point(63, 21);
            this.EnterUserIDToAdd.Name = "EnterUserIDToAdd";
            this.EnterUserIDToAdd.Size = new System.Drawing.Size(100, 20);
            this.EnterUserIDToAdd.TabIndex = 1;
            // 
            // EnterUserNameToAdd
            // 
            this.EnterUserNameToAdd.Location = new System.Drawing.Point(63, 47);
            this.EnterUserNameToAdd.Name = "EnterUserNameToAdd";
            this.EnterUserNameToAdd.Size = new System.Drawing.Size(100, 20);
            this.EnterUserNameToAdd.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // EnterUserAddressToAdd
            // 
            this.EnterUserAddressToAdd.Location = new System.Drawing.Point(63, 73);
            this.EnterUserAddressToAdd.Name = "EnterUserAddressToAdd";
            this.EnterUserAddressToAdd.Size = new System.Drawing.Size(100, 20);
            this.EnterUserAddressToAdd.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Address";
            // 
            // AddUserInfoWhenClicked
            // 
            this.AddUserInfoWhenClicked.Location = new System.Drawing.Point(46, 125);
            this.AddUserInfoWhenClicked.Name = "AddUserInfoWhenClicked";
            this.AddUserInfoWhenClicked.Size = new System.Drawing.Size(75, 23);
            this.AddUserInfoWhenClicked.TabIndex = 6;
            this.AddUserInfoWhenClicked.Text = "Add User";
            this.AddUserInfoWhenClicked.UseVisualStyleBackColor = true;
            this.AddUserInfoWhenClicked.Click += new System.EventHandler(this.SaveUserInfoOnClick);
            // 
            // AddBookInfoWhenClicked
            // 
            this.AddBookInfoWhenClicked.Location = new System.Drawing.Point(243, 171);
            this.AddBookInfoWhenClicked.Name = "AddBookInfoWhenClicked";
            this.AddBookInfoWhenClicked.Size = new System.Drawing.Size(75, 23);
            this.AddBookInfoWhenClicked.TabIndex = 13;
            this.AddBookInfoWhenClicked.Text = "Add Book";
            this.AddBookInfoWhenClicked.UseVisualStyleBackColor = true;
            this.AddBookInfoWhenClicked.Click += new System.EventHandler(this.AddBookInfoOnClick);
            // 
            // EnterBookAuthorToAdd
            // 
            this.EnterBookAuthorToAdd.Location = new System.Drawing.Point(269, 70);
            this.EnterBookAuthorToAdd.Name = "EnterBookAuthorToAdd";
            this.EnterBookAuthorToAdd.Size = new System.Drawing.Size(100, 20);
            this.EnterBookAuthorToAdd.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(191, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Author";
            // 
            // EnterBookNameToAdd
            // 
            this.EnterBookNameToAdd.Location = new System.Drawing.Point(269, 44);
            this.EnterBookNameToAdd.Name = "EnterBookNameToAdd";
            this.EnterBookNameToAdd.Size = new System.Drawing.Size(100, 20);
            this.EnterBookNameToAdd.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(191, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Book name";
            // 
            // EnterBookIDToAdd
            // 
            this.EnterBookIDToAdd.Location = new System.Drawing.Point(269, 18);
            this.EnterBookIDToAdd.Name = "EnterBookIDToAdd";
            this.EnterBookIDToAdd.Size = new System.Drawing.Size(100, 20);
            this.EnterBookIDToAdd.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(191, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Book ID";
            // 
            // EnterBookPublisherToAdd
            // 
            this.EnterBookPublisherToAdd.Location = new System.Drawing.Point(269, 96);
            this.EnterBookPublisherToAdd.Name = "EnterBookPublisherToAdd";
            this.EnterBookPublisherToAdd.Size = new System.Drawing.Size(100, 20);
            this.EnterBookPublisherToAdd.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(191, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Publisher";
            // 
            // EnterBookQuantityToAdd
            // 
            this.EnterBookQuantityToAdd.Location = new System.Drawing.Point(269, 122);
            this.EnterBookQuantityToAdd.Name = "EnterBookQuantityToAdd";
            this.EnterBookQuantityToAdd.Size = new System.Drawing.Size(100, 20);
            this.EnterBookQuantityToAdd.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(191, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Quantity";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(15, 245);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(357, 5);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox2.Location = new System.Drawing.Point(378, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(5, 427);
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // EnterUserIDBorrow
            // 
            this.EnterUserIDBorrow.Location = new System.Drawing.Point(61, 274);
            this.EnterUserIDBorrow.Name = "EnterUserIDBorrow";
            this.EnterUserIDBorrow.Size = new System.Drawing.Size(100, 20);
            this.EnterUserIDBorrow.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 277);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "User ID";
            // 
            // EnterBookIDBorrow
            // 
            this.EnterBookIDBorrow.Location = new System.Drawing.Point(243, 274);
            this.EnterBookIDBorrow.Name = "EnterBookIDBorrow";
            this.EnterBookIDBorrow.Size = new System.Drawing.Size(100, 20);
            this.EnterBookIDBorrow.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(188, 277);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = " Book ID";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(113, 332);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 23);
            this.button3.TabIndex = 24;
            this.button3.Text = "Borrow Book";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.BorrowBookButtonOnClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(410, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 20);
            this.label11.TabIndex = 25;
            this.label11.Text = "User History";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(413, 39);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "User ID";
            // 
            // EnterUserIDToSearch
            // 
            this.EnterUserIDToSearch.Location = new System.Drawing.Point(495, 39);
            this.EnterUserIDToSearch.Name = "EnterUserIDToSearch";
            this.EnterUserIDToSearch.Size = new System.Drawing.Size(100, 20);
            this.EnterUserIDToSearch.TabIndex = 27;
            // 
            // ListBoxUserHistory
            // 
            this.ListBoxUserHistory.FormattingEnabled = true;
            this.ListBoxUserHistory.Location = new System.Drawing.Point(416, 99);
            this.ListBoxUserHistory.Name = "ListBoxUserHistory";
            this.ListBoxUserHistory.Size = new System.Drawing.Size(309, 95);
            this.ListBoxUserHistory.TabIndex = 28;
            // 
            // EnterBookIDToSearch
            // 
            this.EnterBookIDToSearch.Location = new System.Drawing.Point(485, 270);
            this.EnterBookIDToSearch.Name = "EnterBookIDToSearch";
            this.EnterBookIDToSearch.Size = new System.Drawing.Size(100, 20);
            this.EnterBookIDToSearch.TabIndex = 30;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(410, 277);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Book ID";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(410, 230);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(111, 20);
            this.label14.TabIndex = 31;
            this.label14.Text = "Book History";
            // 
            // ShowUserHistory
            // 
            this.ShowUserHistory.Location = new System.Drawing.Point(650, 36);
            this.ShowUserHistory.Name = "ShowUserHistory";
            this.ShowUserHistory.Size = new System.Drawing.Size(75, 23);
            this.ShowUserHistory.TabIndex = 33;
            this.ShowUserHistory.Text = "Show";
            this.ShowUserHistory.UseVisualStyleBackColor = true;
            this.ShowUserHistory.Click += new System.EventHandler(this.ShowUserHistoryOnClick);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(640, 274);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 34;
            this.button5.Text = "Show";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.ShowBookHistoryOnClick);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox3.Location = new System.Drawing.Point(180, 13);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(5, 200);
            this.pictureBox3.TabIndex = 35;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox4.Location = new System.Drawing.Point(402, 217);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(357, 5);
            this.pictureBox4.TabIndex = 36;
            this.pictureBox4.TabStop = false;
            // 
            // ShowBookID
            // 
            this.ShowBookID.AutoSize = true;
            this.ShowBookID.Location = new System.Drawing.Point(411, 318);
            this.ShowBookID.Name = "ShowBookID";
            this.ShowBookID.Size = new System.Drawing.Size(49, 13);
            this.ShowBookID.TabIndex = 37;
            this.ShowBookID.Text = "Book ID:";
            // 
            // ShowBookTitle
            // 
            this.ShowBookTitle.AutoSize = true;
            this.ShowBookTitle.Location = new System.Drawing.Point(411, 342);
            this.ShowBookTitle.Name = "ShowBookTitle";
            this.ShowBookTitle.Size = new System.Drawing.Size(58, 13);
            this.ShowBookTitle.TabIndex = 38;
            this.ShowBookTitle.Text = "Book Title:";
            // 
            // ShowBookAuthor
            // 
            this.ShowBookAuthor.AutoSize = true;
            this.ShowBookAuthor.Location = new System.Drawing.Point(413, 366);
            this.ShowBookAuthor.Name = "ShowBookAuthor";
            this.ShowBookAuthor.Size = new System.Drawing.Size(41, 13);
            this.ShowBookAuthor.TabIndex = 39;
            this.ShowBookAuthor.Text = "Author:";
            // 
            // ShowBookPublisher
            // 
            this.ShowBookPublisher.AutoSize = true;
            this.ShowBookPublisher.Location = new System.Drawing.Point(413, 390);
            this.ShowBookPublisher.Name = "ShowBookPublisher";
            this.ShowBookPublisher.Size = new System.Drawing.Size(53, 13);
            this.ShowBookPublisher.TabIndex = 40;
            this.ShowBookPublisher.Text = "Publisher:";
            // 
            // ShowBookQuantity
            // 
            this.ShowBookQuantity.AutoSize = true;
            this.ShowBookQuantity.Location = new System.Drawing.Point(413, 415);
            this.ShowBookQuantity.Name = "ShowBookQuantity";
            this.ShowBookQuantity.Size = new System.Drawing.Size(49, 13);
            this.ShowBookQuantity.TabIndex = 41;
            this.ShowBookQuantity.Text = "Quantity:";
            // 
            // showHistoryBookID
            // 
            this.showHistoryBookID.AutoSize = true;
            this.showHistoryBookID.Location = new System.Drawing.Point(482, 318);
            this.showHistoryBookID.Name = "showHistoryBookID";
            this.showHistoryBookID.Size = new System.Drawing.Size(10, 13);
            this.showHistoryBookID.TabIndex = 42;
            this.showHistoryBookID.Text = " ";
            // 
            // showHistoryBookTitle
            // 
            this.showHistoryBookTitle.AutoSize = true;
            this.showHistoryBookTitle.Location = new System.Drawing.Point(482, 342);
            this.showHistoryBookTitle.Name = "showHistoryBookTitle";
            this.showHistoryBookTitle.Size = new System.Drawing.Size(10, 13);
            this.showHistoryBookTitle.TabIndex = 43;
            this.showHistoryBookTitle.Text = " ";
            // 
            // showHistoryBookAuthor
            // 
            this.showHistoryBookAuthor.AutoSize = true;
            this.showHistoryBookAuthor.Location = new System.Drawing.Point(482, 366);
            this.showHistoryBookAuthor.Name = "showHistoryBookAuthor";
            this.showHistoryBookAuthor.Size = new System.Drawing.Size(10, 13);
            this.showHistoryBookAuthor.TabIndex = 44;
            this.showHistoryBookAuthor.Text = " ";
            // 
            // showHistoryBookPublisher
            // 
            this.showHistoryBookPublisher.AutoSize = true;
            this.showHistoryBookPublisher.Location = new System.Drawing.Point(482, 390);
            this.showHistoryBookPublisher.Name = "showHistoryBookPublisher";
            this.showHistoryBookPublisher.Size = new System.Drawing.Size(10, 13);
            this.showHistoryBookPublisher.TabIndex = 45;
            this.showHistoryBookPublisher.Text = " ";
            // 
            // showHistoryBookQuantity
            // 
            this.showHistoryBookQuantity.AutoSize = true;
            this.showHistoryBookQuantity.Location = new System.Drawing.Point(482, 415);
            this.showHistoryBookQuantity.Name = "showHistoryBookQuantity";
            this.showHistoryBookQuantity.Size = new System.Drawing.Size(10, 13);
            this.showHistoryBookQuantity.TabIndex = 46;
            this.showHistoryBookQuantity.Text = " ";
            // 
            // LibraryManagementSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showHistoryBookQuantity);
            this.Controls.Add(this.showHistoryBookPublisher);
            this.Controls.Add(this.showHistoryBookAuthor);
            this.Controls.Add(this.showHistoryBookTitle);
            this.Controls.Add(this.showHistoryBookID);
            this.Controls.Add(this.ShowBookQuantity);
            this.Controls.Add(this.ShowBookPublisher);
            this.Controls.Add(this.ShowBookAuthor);
            this.Controls.Add(this.ShowBookTitle);
            this.Controls.Add(this.ShowBookID);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.ShowUserHistory);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.EnterBookIDToSearch);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.ListBoxUserHistory);
            this.Controls.Add(this.EnterUserIDToSearch);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.EnterBookIDBorrow);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.EnterUserIDBorrow);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.EnterBookQuantityToAdd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.EnterBookPublisherToAdd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.AddBookInfoWhenClicked);
            this.Controls.Add(this.EnterBookAuthorToAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EnterBookNameToAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.EnterBookIDToAdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AddUserInfoWhenClicked);
            this.Controls.Add(this.EnterUserAddressToAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EnterUserNameToAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EnterUserIDToAdd);
            this.Controls.Add(this.label1);
            this.Name = "LibraryManagementSystem";
            this.Text = "Library Management System";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EnterUserIDToAdd;
        private System.Windows.Forms.TextBox EnterUserNameToAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EnterUserAddressToAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddUserInfoWhenClicked;
        private System.Windows.Forms.Button AddBookInfoWhenClicked;
        private System.Windows.Forms.TextBox EnterBookAuthorToAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox EnterBookNameToAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox EnterBookIDToAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox EnterBookPublisherToAdd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox EnterBookQuantityToAdd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox EnterUserIDBorrow;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox EnterBookIDBorrow;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox EnterUserIDToSearch;
        private System.Windows.Forms.ListBox ListBoxUserHistory;
        private System.Windows.Forms.TextBox EnterBookIDToSearch;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button ShowUserHistory;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label ShowBookID;
        private System.Windows.Forms.Label ShowBookTitle;
        private System.Windows.Forms.Label ShowBookAuthor;
        private System.Windows.Forms.Label ShowBookPublisher;
        private System.Windows.Forms.Label ShowBookQuantity;
        private System.Windows.Forms.Label showHistoryBookID;
        private System.Windows.Forms.Label showHistoryBookTitle;
        private System.Windows.Forms.Label showHistoryBookAuthor;
        private System.Windows.Forms.Label showHistoryBookPublisher;
        private System.Windows.Forms.Label showHistoryBookQuantity;
    }
}

