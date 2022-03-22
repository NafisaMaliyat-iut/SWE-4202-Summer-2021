namespace IUT_Result_Processing_System
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ShowAttendance = new System.Windows.Forms.Label();
            this.ShowQuiz1Mark = new System.Windows.Forms.Label();
            this.ShowQuiz2Mark = new System.Windows.Forms.Label();
            this.ShowQuiz3Mark = new System.Windows.Forms.Label();
            this.ShowQuiz4Mark = new System.Windows.Forms.Label();
            this.ShowQuizTotal = new System.Windows.Forms.Label();
            this.ShowMid = new System.Windows.Forms.Label();
            this.ShowFinal = new System.Windows.Forms.Label();
            this.ShowVivaMark = new System.Windows.Forms.Label();
            this.ShowTotalOutOf300 = new System.Windows.Forms.Label();
            this.ShowPercentage = new System.Windows.Forms.Label();
            this.ShowGrade = new System.Windows.Forms.Label();
            this.DisplayStudentMarks = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.SearchStudentComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(248, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "IUT Result Processing System";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(27, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(442, 481);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(397, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Course Name: Object Oriented Concepts I";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(619, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 26);
            this.button1.TabIndex = 4;
            this.button1.Text = "Search By ID";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SearchByIDButton);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(524, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 253);
            this.label3.TabIndex = 5;
            this.label3.Text = "Attendance: \r\n\r\nQuiz 1: \r\n\r\nQuiz 2:\r\n\r\nQuiz 3:\r\n\r\nQuiz 4: \r\n\r\nQuiz Total (Best 3)" +
    ":\r\n\r\nMid: \r\n\r\nFinal: \r\n\r\nViva: \r\n\r\nTotal (Out of 300): \r\n\r\nPercentage: \r\n\r\nGrade" +
    ": \r\n";
            // 
            // ShowAttendance
            // 
            this.ShowAttendance.AutoSize = true;
            this.ShowAttendance.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowAttendance.Location = new System.Drawing.Point(617, 185);
            this.ShowAttendance.Name = "ShowAttendance";
            this.ShowAttendance.Size = new System.Drawing.Size(12, 11);
            this.ShowAttendance.TabIndex = 6;
            this.ShowAttendance.Text = "-";
            // 
            // ShowQuiz1Mark
            // 
            this.ShowQuiz1Mark.AutoSize = true;
            this.ShowQuiz1Mark.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowQuiz1Mark.Location = new System.Drawing.Point(586, 206);
            this.ShowQuiz1Mark.Name = "ShowQuiz1Mark";
            this.ShowQuiz1Mark.Size = new System.Drawing.Size(12, 11);
            this.ShowQuiz1Mark.TabIndex = 7;
            this.ShowQuiz1Mark.Text = "-";
            // 
            // ShowQuiz2Mark
            // 
            this.ShowQuiz2Mark.AutoSize = true;
            this.ShowQuiz2Mark.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowQuiz2Mark.Location = new System.Drawing.Point(586, 230);
            this.ShowQuiz2Mark.Name = "ShowQuiz2Mark";
            this.ShowQuiz2Mark.Size = new System.Drawing.Size(12, 11);
            this.ShowQuiz2Mark.TabIndex = 8;
            this.ShowQuiz2Mark.Text = "-";
            // 
            // ShowQuiz3Mark
            // 
            this.ShowQuiz3Mark.AutoSize = true;
            this.ShowQuiz3Mark.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowQuiz3Mark.Location = new System.Drawing.Point(586, 250);
            this.ShowQuiz3Mark.Name = "ShowQuiz3Mark";
            this.ShowQuiz3Mark.Size = new System.Drawing.Size(12, 11);
            this.ShowQuiz3Mark.TabIndex = 9;
            this.ShowQuiz3Mark.Text = "-";
            // 
            // ShowQuiz4Mark
            // 
            this.ShowQuiz4Mark.AutoSize = true;
            this.ShowQuiz4Mark.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowQuiz4Mark.Location = new System.Drawing.Point(586, 273);
            this.ShowQuiz4Mark.Name = "ShowQuiz4Mark";
            this.ShowQuiz4Mark.Size = new System.Drawing.Size(12, 11);
            this.ShowQuiz4Mark.TabIndex = 10;
            this.ShowQuiz4Mark.Text = "-";
            // 
            // ShowQuizTotal
            // 
            this.ShowQuizTotal.AutoSize = true;
            this.ShowQuizTotal.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowQuizTotal.Location = new System.Drawing.Point(675, 294);
            this.ShowQuizTotal.Name = "ShowQuizTotal";
            this.ShowQuizTotal.Size = new System.Drawing.Size(12, 11);
            this.ShowQuizTotal.TabIndex = 11;
            this.ShowQuizTotal.Text = "-";
            // 
            // ShowMid
            // 
            this.ShowMid.AutoSize = true;
            this.ShowMid.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowMid.Location = new System.Drawing.Point(563, 317);
            this.ShowMid.Name = "ShowMid";
            this.ShowMid.Size = new System.Drawing.Size(12, 11);
            this.ShowMid.TabIndex = 12;
            this.ShowMid.Text = "-";
            // 
            // ShowFinal
            // 
            this.ShowFinal.AutoSize = true;
            this.ShowFinal.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowFinal.Location = new System.Drawing.Point(584, 338);
            this.ShowFinal.Name = "ShowFinal";
            this.ShowFinal.Size = new System.Drawing.Size(12, 11);
            this.ShowFinal.TabIndex = 13;
            this.ShowFinal.Text = "-";
            // 
            // ShowVivaMark
            // 
            this.ShowVivaMark.AutoSize = true;
            this.ShowVivaMark.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowVivaMark.Location = new System.Drawing.Point(568, 361);
            this.ShowVivaMark.Name = "ShowVivaMark";
            this.ShowVivaMark.Size = new System.Drawing.Size(12, 11);
            this.ShowVivaMark.TabIndex = 14;
            this.ShowVivaMark.Text = "-";
            // 
            // ShowTotalOutOf300
            // 
            this.ShowTotalOutOf300.AutoSize = true;
            this.ShowTotalOutOf300.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowTotalOutOf300.Location = new System.Drawing.Point(669, 383);
            this.ShowTotalOutOf300.Name = "ShowTotalOutOf300";
            this.ShowTotalOutOf300.Size = new System.Drawing.Size(12, 11);
            this.ShowTotalOutOf300.TabIndex = 15;
            this.ShowTotalOutOf300.Text = "-";
            // 
            // ShowPercentage
            // 
            this.ShowPercentage.AutoSize = true;
            this.ShowPercentage.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowPercentage.Location = new System.Drawing.Point(617, 406);
            this.ShowPercentage.Name = "ShowPercentage";
            this.ShowPercentage.Size = new System.Drawing.Size(12, 11);
            this.ShowPercentage.TabIndex = 16;
            this.ShowPercentage.Text = "-";
            // 
            // ShowGrade
            // 
            this.ShowGrade.AutoSize = true;
            this.ShowGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowGrade.Location = new System.Drawing.Point(585, 425);
            this.ShowGrade.Name = "ShowGrade";
            this.ShowGrade.Size = new System.Drawing.Size(11, 13);
            this.ShowGrade.TabIndex = 17;
            this.ShowGrade.Text = "-";
            // 
            // DisplayStudentMarks
            // 
            this.DisplayStudentMarks.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayStudentMarks.FormattingEnabled = true;
            this.DisplayStudentMarks.ItemHeight = 11;
            this.DisplayStudentMarks.Location = new System.Drawing.Point(27, 128);
            this.DisplayStudentMarks.Name = "DisplayStudentMarks";
            this.DisplayStudentMarks.Size = new System.Drawing.Size(442, 389);
            this.DisplayStudentMarks.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(585, 570);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Developed By:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(668, 570);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "200042133";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox2.Location = new System.Drawing.Point(30, 128);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(439, 2);
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // SearchStudentComboBox
            // 
            this.SearchStudentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SearchStudentComboBox.FormattingEnabled = true;
            this.SearchStudentComboBox.Location = new System.Drawing.Point(526, 74);
            this.SearchStudentComboBox.Name = "SearchStudentComboBox";
            this.SearchStudentComboBox.Size = new System.Drawing.Size(161, 21);
            this.SearchStudentComboBox.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 601);
            this.Controls.Add(this.SearchStudentComboBox);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DisplayStudentMarks);
            this.Controls.Add(this.ShowGrade);
            this.Controls.Add(this.ShowPercentage);
            this.Controls.Add(this.ShowTotalOutOf300);
            this.Controls.Add(this.ShowVivaMark);
            this.Controls.Add(this.ShowFinal);
            this.Controls.Add(this.ShowMid);
            this.Controls.Add(this.ShowQuizTotal);
            this.Controls.Add(this.ShowQuiz4Mark);
            this.Controls.Add(this.ShowQuiz3Mark);
            this.Controls.Add(this.ShowQuiz2Mark);
            this.Controls.Add(this.ShowQuiz1Mark);
            this.Controls.Add(this.ShowAttendance);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "IUT Result Processing System";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ShowAttendance;
        private System.Windows.Forms.Label ShowQuiz1Mark;
        private System.Windows.Forms.Label ShowQuiz2Mark;
        private System.Windows.Forms.Label ShowQuiz3Mark;
        private System.Windows.Forms.Label ShowQuiz4Mark;
        private System.Windows.Forms.Label ShowQuizTotal;
        private System.Windows.Forms.Label ShowMid;
        private System.Windows.Forms.Label ShowFinal;
        private System.Windows.Forms.Label ShowVivaMark;
        private System.Windows.Forms.Label ShowTotalOutOf300;
        private System.Windows.Forms.Label ShowPercentage;
        private System.Windows.Forms.Label ShowGrade;
        private System.Windows.Forms.ListBox DisplayStudentMarks;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox SearchStudentComboBox;
    }
}

