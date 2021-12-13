namespace lab01_Assignment
{
    partial class GradesApp
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
            this.labelStudentInfo = new System.Windows.Forms.Label();
            this.labelStudentName = new System.Windows.Forms.Label();
            this.labelStudentId = new System.Windows.Forms.Label();
            this.labelSemester = new System.Windows.Forms.Label();
            this.labelCourseName = new System.Windows.Forms.Label();
            this.labelAttendedClassesOutOf28 = new System.Windows.Forms.Label();
            this.labelMidMarks = new System.Windows.Forms.Label();
            this.labelFinalMarks = new System.Windows.Forms.Label();
            this.labelQuiz1Marks = new System.Windows.Forms.Label();
            this.labelQuiz2Marks = new System.Windows.Forms.Label();
            this.labelQuiz3Marks = new System.Windows.Forms.Label();
            this.labelQuiz4Marks = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelObtainedMarks = new System.Windows.Forms.Label();
            this.labelAttendance = new System.Windows.Forms.Label();
            this.labelMidMarksOutOf75 = new System.Windows.Forms.Label();
            this.labelTotalMarksOutOf45 = new System.Windows.Forms.Label();
            this.labelEnterFinalMarksOutOf150 = new System.Windows.Forms.Label();
            this.labelEnterTotalMarksOutOf300 = new System.Windows.Forms.Label();
            this.labelGradeLetter = new System.Windows.Forms.Label();
            this.DisplayAttendanceMarks = new System.Windows.Forms.Label();
            this.DisplayMidMarks = new System.Windows.Forms.Label();
            this.DisplayTotalQuizMarks = new System.Windows.Forms.Label();
            this.DisplayFinalMarks = new System.Windows.Forms.Label();
            this.DisplayTotalMarks = new System.Windows.Forms.Label();
            this.DisplayGrades = new System.Windows.Forms.Label();
            this.DisplayNameAndPercentage = new System.Windows.Forms.Label();
            this.EnterQuiz1Marks = new System.Windows.Forms.TextBox();
            this.EnterQuiz2Marks = new System.Windows.Forms.TextBox();
            this.EnterQuiz3Marks = new System.Windows.Forms.TextBox();
            this.EnterQuiz4Marks = new System.Windows.Forms.TextBox();
            this.EnterAttendedClassesOutOf28 = new System.Windows.Forms.TextBox();
            this.EnterMidMarks = new System.Windows.Forms.TextBox();
            this.EnterFinalMarks = new System.Windows.Forms.TextBox();
            this.EnterStudentName = new System.Windows.Forms.TextBox();
            this.EnterStudentID = new System.Windows.Forms.TextBox();
            this.EnterSemester = new System.Windows.Forms.TextBox();
            this.DisplayResultWhenCLicked = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // labelStudentInfo
            // 
            this.labelStudentInfo.AutoSize = true;
            this.labelStudentInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStudentInfo.Location = new System.Drawing.Point(12, 22);
            this.labelStudentInfo.Name = "labelStudentInfo";
            this.labelStudentInfo.Size = new System.Drawing.Size(170, 20);
            this.labelStudentInfo.TabIndex = 0;
            this.labelStudentInfo.Text = "Student Information";
            // 
            // labelStudentName
            // 
            this.labelStudentName.AutoSize = true;
            this.labelStudentName.Location = new System.Drawing.Point(40, 64);
            this.labelStudentName.Name = "labelStudentName";
            this.labelStudentName.Size = new System.Drawing.Size(35, 13);
            this.labelStudentName.TabIndex = 1;
            this.labelStudentName.Text = "Name";
            // 
            // labelStudentId
            // 
            this.labelStudentId.AutoSize = true;
            this.labelStudentId.Location = new System.Drawing.Point(17, 95);
            this.labelStudentId.Name = "labelStudentId";
            this.labelStudentId.Size = new System.Drawing.Size(58, 13);
            this.labelStudentId.TabIndex = 2;
            this.labelStudentId.Text = "Student ID";
            // 
            // labelSemester
            // 
            this.labelSemester.AutoSize = true;
            this.labelSemester.Location = new System.Drawing.Point(24, 127);
            this.labelSemester.Name = "labelSemester";
            this.labelSemester.Size = new System.Drawing.Size(51, 13);
            this.labelSemester.TabIndex = 3;
            this.labelSemester.Text = "Semester";
            // 
            // labelCourseName
            // 
            this.labelCourseName.AutoSize = true;
            this.labelCourseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCourseName.Location = new System.Drawing.Point(16, 174);
            this.labelCourseName.Name = "labelCourseName";
            this.labelCourseName.Size = new System.Drawing.Size(201, 20);
            this.labelCourseName.TabIndex = 4;
            this.labelCourseName.Text = "SWE 4201 OOC I Marks";
            // 
            // labelAttendedClassesOutOf28
            // 
            this.labelAttendedClassesOutOf28.AutoSize = true;
            this.labelAttendedClassesOutOf28.Location = new System.Drawing.Point(13, 210);
            this.labelAttendedClassesOutOf28.Name = "labelAttendedClassesOutOf28";
            this.labelAttendedClassesOutOf28.Size = new System.Drawing.Size(96, 26);
            this.labelAttendedClassesOutOf28.TabIndex = 5;
            this.labelAttendedClassesOutOf28.Text = "    No. of attended \r\nclasses (Out of 28)";
            // 
            // labelMidMarks
            // 
            this.labelMidMarks.AutoSize = true;
            this.labelMidMarks.Location = new System.Drawing.Point(32, 252);
            this.labelMidMarks.Name = "labelMidMarks";
            this.labelMidMarks.Size = new System.Drawing.Size(77, 13);
            this.labelMidMarks.TabIndex = 6;
            this.labelMidMarks.Text = "Mid (Out of 75)";
            // 
            // labelFinalMarks
            // 
            this.labelFinalMarks.AutoSize = true;
            this.labelFinalMarks.Location = new System.Drawing.Point(21, 287);
            this.labelFinalMarks.Name = "labelFinalMarks";
            this.labelFinalMarks.Size = new System.Drawing.Size(88, 13);
            this.labelFinalMarks.TabIndex = 7;
            this.labelFinalMarks.Text = "Final (Out of 150)";
            // 
            // labelQuiz1Marks
            // 
            this.labelQuiz1Marks.AutoSize = true;
            this.labelQuiz1Marks.Location = new System.Drawing.Point(245, 216);
            this.labelQuiz1Marks.Name = "labelQuiz1Marks";
            this.labelQuiz1Marks.Size = new System.Drawing.Size(87, 13);
            this.labelQuiz1Marks.TabIndex = 8;
            this.labelQuiz1Marks.Text = "Quiz I (Out of 15)";
            // 
            // labelQuiz2Marks
            // 
            this.labelQuiz2Marks.AutoSize = true;
            this.labelQuiz2Marks.Location = new System.Drawing.Point(242, 245);
            this.labelQuiz2Marks.Name = "labelQuiz2Marks";
            this.labelQuiz2Marks.Size = new System.Drawing.Size(90, 13);
            this.labelQuiz2Marks.TabIndex = 9;
            this.labelQuiz2Marks.Text = "Quiz II (Out of 15)";
            // 
            // labelQuiz3Marks
            // 
            this.labelQuiz3Marks.AutoSize = true;
            this.labelQuiz3Marks.Location = new System.Drawing.Point(239, 280);
            this.labelQuiz3Marks.Name = "labelQuiz3Marks";
            this.labelQuiz3Marks.Size = new System.Drawing.Size(93, 13);
            this.labelQuiz3Marks.TabIndex = 10;
            this.labelQuiz3Marks.Text = "Quiz III (Out of 15)";
            // 
            // labelQuiz4Marks
            // 
            this.labelQuiz4Marks.AutoSize = true;
            this.labelQuiz4Marks.Location = new System.Drawing.Point(238, 311);
            this.labelQuiz4Marks.Name = "labelQuiz4Marks";
            this.labelQuiz4Marks.Size = new System.Drawing.Size(94, 13);
            this.labelQuiz4Marks.TabIndex = 11;
            this.labelQuiz4Marks.Text = "Quiz IV (Out of 15)";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(492, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(7, 325);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox2.Location = new System.Drawing.Point(509, 190);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(229, 4);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // labelObtainedMarks
            // 
            this.labelObtainedMarks.AutoSize = true;
            this.labelObtainedMarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelObtainedMarks.Location = new System.Drawing.Point(505, 22);
            this.labelObtainedMarks.Name = "labelObtainedMarks";
            this.labelObtainedMarks.Size = new System.Drawing.Size(135, 20);
            this.labelObtainedMarks.TabIndex = 14;
            this.labelObtainedMarks.Text = "Obtained Marks";
            // 
            // labelAttendance
            // 
            this.labelAttendance.AutoSize = true;
            this.labelAttendance.Location = new System.Drawing.Point(506, 64);
            this.labelAttendance.Name = "labelAttendance";
            this.labelAttendance.Size = new System.Drawing.Size(65, 13);
            this.labelAttendance.TabIndex = 15;
            this.labelAttendance.Text = "Attendance:";
            // 
            // labelMidMarksOutOf75
            // 
            this.labelMidMarksOutOf75.AutoSize = true;
            this.labelMidMarksOutOf75.Location = new System.Drawing.Point(544, 95);
            this.labelMidMarksOutOf75.Name = "labelMidMarksOutOf75";
            this.labelMidMarksOutOf75.Size = new System.Drawing.Size(27, 13);
            this.labelMidMarksOutOf75.TabIndex = 16;
            this.labelMidMarksOutOf75.Text = "Mid:";
            // 
            // labelTotalMarksOutOf45
            // 
            this.labelTotalMarksOutOf45.AutoSize = true;
            this.labelTotalMarksOutOf45.Location = new System.Drawing.Point(540, 127);
            this.labelTotalMarksOutOf45.Name = "labelTotalMarksOutOf45";
            this.labelTotalMarksOutOf45.Size = new System.Drawing.Size(31, 13);
            this.labelTotalMarksOutOf45.TabIndex = 17;
            this.labelTotalMarksOutOf45.Text = "Quiz:";
            // 
            // labelEnterFinalMarksOutOf150
            // 
            this.labelEnterFinalMarksOutOf150.AutoSize = true;
            this.labelEnterFinalMarksOutOf150.Location = new System.Drawing.Point(539, 162);
            this.labelEnterFinalMarksOutOf150.Name = "labelEnterFinalMarksOutOf150";
            this.labelEnterFinalMarksOutOf150.Size = new System.Drawing.Size(32, 13);
            this.labelEnterFinalMarksOutOf150.TabIndex = 18;
            this.labelEnterFinalMarksOutOf150.Text = "Final:";
            // 
            // labelEnterTotalMarksOutOf300
            // 
            this.labelEnterTotalMarksOutOf300.AutoSize = true;
            this.labelEnterTotalMarksOutOf300.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnterTotalMarksOutOf300.Location = new System.Drawing.Point(531, 210);
            this.labelEnterTotalMarksOutOf300.Name = "labelEnterTotalMarksOutOf300";
            this.labelEnterTotalMarksOutOf300.Size = new System.Drawing.Size(40, 13);
            this.labelEnterTotalMarksOutOf300.TabIndex = 19;
            this.labelEnterTotalMarksOutOf300.Text = "Total:";
            // 
            // labelGradeLetter
            // 
            this.labelGradeLetter.AutoSize = true;
            this.labelGradeLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGradeLetter.ForeColor = System.Drawing.Color.Red;
            this.labelGradeLetter.Location = new System.Drawing.Point(513, 241);
            this.labelGradeLetter.Name = "labelGradeLetter";
            this.labelGradeLetter.Size = new System.Drawing.Size(58, 17);
            this.labelGradeLetter.TabIndex = 20;
            this.labelGradeLetter.Text = "Grade:";
            // 
            // DisplayAttendanceMarks
            // 
            this.DisplayAttendanceMarks.AutoSize = true;
            this.DisplayAttendanceMarks.Location = new System.Drawing.Point(590, 64);
            this.DisplayAttendanceMarks.Name = "DisplayAttendanceMarks";
            this.DisplayAttendanceMarks.Size = new System.Drawing.Size(10, 13);
            this.DisplayAttendanceMarks.TabIndex = 21;
            this.DisplayAttendanceMarks.Text = " ";
            // 
            // DisplayMidMarks
            // 
            this.DisplayMidMarks.AutoSize = true;
            this.DisplayMidMarks.Location = new System.Drawing.Point(590, 95);
            this.DisplayMidMarks.Name = "DisplayMidMarks";
            this.DisplayMidMarks.Size = new System.Drawing.Size(10, 13);
            this.DisplayMidMarks.TabIndex = 22;
            this.DisplayMidMarks.Text = " ";
            this.DisplayMidMarks.Click += new System.EventHandler(this.DisplayMidMarks_Click);
            // 
            // DisplayTotalQuizMarks
            // 
            this.DisplayTotalQuizMarks.AutoSize = true;
            this.DisplayTotalQuizMarks.Location = new System.Drawing.Point(590, 127);
            this.DisplayTotalQuizMarks.Name = "DisplayTotalQuizMarks";
            this.DisplayTotalQuizMarks.Size = new System.Drawing.Size(10, 13);
            this.DisplayTotalQuizMarks.TabIndex = 23;
            this.DisplayTotalQuizMarks.Text = " ";
            // 
            // DisplayFinalMarks
            // 
            this.DisplayFinalMarks.AutoSize = true;
            this.DisplayFinalMarks.Location = new System.Drawing.Point(590, 162);
            this.DisplayFinalMarks.Name = "DisplayFinalMarks";
            this.DisplayFinalMarks.Size = new System.Drawing.Size(10, 13);
            this.DisplayFinalMarks.TabIndex = 24;
            this.DisplayFinalMarks.Text = " ";
            // 
            // DisplayTotalMarks
            // 
            this.DisplayTotalMarks.AutoSize = true;
            this.DisplayTotalMarks.Location = new System.Drawing.Point(590, 210);
            this.DisplayTotalMarks.Name = "DisplayTotalMarks";
            this.DisplayTotalMarks.Size = new System.Drawing.Size(10, 13);
            this.DisplayTotalMarks.TabIndex = 25;
            this.DisplayTotalMarks.Text = " ";
            // 
            // DisplayGrades
            // 
            this.DisplayGrades.AutoSize = true;
            this.DisplayGrades.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayGrades.ForeColor = System.Drawing.Color.Red;
            this.DisplayGrades.Location = new System.Drawing.Point(590, 241);
            this.DisplayGrades.Name = "DisplayGrades";
            this.DisplayGrades.Size = new System.Drawing.Size(13, 17);
            this.DisplayGrades.TabIndex = 26;
            this.DisplayGrades.Text = " ";
            // 
            // DisplayNameAndPercentage
            // 
            this.DisplayNameAndPercentage.AutoSize = true;
            this.DisplayNameAndPercentage.Location = new System.Drawing.Point(513, 280);
            this.DisplayNameAndPercentage.Name = "DisplayNameAndPercentage";
            this.DisplayNameAndPercentage.Size = new System.Drawing.Size(10, 13);
            this.DisplayNameAndPercentage.TabIndex = 27;
            this.DisplayNameAndPercentage.Text = " ";
            // 
            // EnterQuiz1Marks
            // 
            this.EnterQuiz1Marks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EnterQuiz1Marks.Location = new System.Drawing.Point(352, 216);
            this.EnterQuiz1Marks.Name = "EnterQuiz1Marks";
            this.EnterQuiz1Marks.Size = new System.Drawing.Size(125, 13);
            this.EnterQuiz1Marks.TabIndex = 28;
            // 
            // EnterQuiz2Marks
            // 
            this.EnterQuiz2Marks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EnterQuiz2Marks.Location = new System.Drawing.Point(352, 245);
            this.EnterQuiz2Marks.Name = "EnterQuiz2Marks";
            this.EnterQuiz2Marks.Size = new System.Drawing.Size(125, 13);
            this.EnterQuiz2Marks.TabIndex = 29;
            // 
            // EnterQuiz3Marks
            // 
            this.EnterQuiz3Marks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EnterQuiz3Marks.Location = new System.Drawing.Point(352, 280);
            this.EnterQuiz3Marks.Name = "EnterQuiz3Marks";
            this.EnterQuiz3Marks.Size = new System.Drawing.Size(125, 13);
            this.EnterQuiz3Marks.TabIndex = 30;
            // 
            // EnterQuiz4Marks
            // 
            this.EnterQuiz4Marks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EnterQuiz4Marks.Location = new System.Drawing.Point(352, 311);
            this.EnterQuiz4Marks.Name = "EnterQuiz4Marks";
            this.EnterQuiz4Marks.Size = new System.Drawing.Size(125, 13);
            this.EnterQuiz4Marks.TabIndex = 31;
            // 
            // EnterAttendedClassesOutOf28
            // 
            this.EnterAttendedClassesOutOf28.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EnterAttendedClassesOutOf28.Location = new System.Drawing.Point(117, 216);
            this.EnterAttendedClassesOutOf28.Name = "EnterAttendedClassesOutOf28";
            this.EnterAttendedClassesOutOf28.Size = new System.Drawing.Size(108, 13);
            this.EnterAttendedClassesOutOf28.TabIndex = 32;
            // 
            // EnterMidMarks
            // 
            this.EnterMidMarks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EnterMidMarks.Location = new System.Drawing.Point(117, 249);
            this.EnterMidMarks.Name = "EnterMidMarks";
            this.EnterMidMarks.Size = new System.Drawing.Size(108, 13);
            this.EnterMidMarks.TabIndex = 33;
            // 
            // EnterFinalMarks
            // 
            this.EnterFinalMarks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EnterFinalMarks.Location = new System.Drawing.Point(117, 284);
            this.EnterFinalMarks.Name = "EnterFinalMarks";
            this.EnterFinalMarks.Size = new System.Drawing.Size(108, 13);
            this.EnterFinalMarks.TabIndex = 34;
            // 
            // EnterStudentName
            // 
            this.EnterStudentName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EnterStudentName.Location = new System.Drawing.Point(117, 56);
            this.EnterStudentName.Name = "EnterStudentName";
            this.EnterStudentName.Size = new System.Drawing.Size(163, 13);
            this.EnterStudentName.TabIndex = 35;
            // 
            // EnterStudentID
            // 
            this.EnterStudentID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EnterStudentID.Location = new System.Drawing.Point(117, 87);
            this.EnterStudentID.Name = "EnterStudentID";
            this.EnterStudentID.Size = new System.Drawing.Size(163, 13);
            this.EnterStudentID.TabIndex = 36;
            // 
            // EnterSemester
            // 
            this.EnterSemester.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EnterSemester.Location = new System.Drawing.Point(117, 119);
            this.EnterSemester.Name = "EnterSemester";
            this.EnterSemester.Size = new System.Drawing.Size(163, 13);
            this.EnterSemester.TabIndex = 37;
            // 
            // DisplayResultWhenCLicked
            // 
            this.DisplayResultWhenCLicked.BackColor = System.Drawing.SystemColors.Highlight;
            this.DisplayResultWhenCLicked.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayResultWhenCLicked.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DisplayResultWhenCLicked.Location = new System.Drawing.Point(362, 95);
            this.DisplayResultWhenCLicked.Name = "DisplayResultWhenCLicked";
            this.DisplayResultWhenCLicked.Size = new System.Drawing.Size(115, 62);
            this.DisplayResultWhenCLicked.TabIndex = 38;
            this.DisplayResultWhenCLicked.Text = "Calculate\r\nGrade";
            this.DisplayResultWhenCLicked.UseVisualStyleBackColor = false;
            this.DisplayResultWhenCLicked.Click += new System.EventHandler(this.DisplayResultWhenCLicked_Click);
            // 
            // GradesApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DisplayResultWhenCLicked);
            this.Controls.Add(this.EnterSemester);
            this.Controls.Add(this.EnterStudentID);
            this.Controls.Add(this.EnterStudentName);
            this.Controls.Add(this.EnterFinalMarks);
            this.Controls.Add(this.EnterMidMarks);
            this.Controls.Add(this.EnterAttendedClassesOutOf28);
            this.Controls.Add(this.EnterQuiz4Marks);
            this.Controls.Add(this.EnterQuiz3Marks);
            this.Controls.Add(this.EnterQuiz2Marks);
            this.Controls.Add(this.EnterQuiz1Marks);
            this.Controls.Add(this.DisplayNameAndPercentage);
            this.Controls.Add(this.DisplayGrades);
            this.Controls.Add(this.DisplayTotalMarks);
            this.Controls.Add(this.DisplayFinalMarks);
            this.Controls.Add(this.DisplayTotalQuizMarks);
            this.Controls.Add(this.DisplayMidMarks);
            this.Controls.Add(this.DisplayAttendanceMarks);
            this.Controls.Add(this.labelGradeLetter);
            this.Controls.Add(this.labelEnterTotalMarksOutOf300);
            this.Controls.Add(this.labelEnterFinalMarksOutOf150);
            this.Controls.Add(this.labelTotalMarksOutOf45);
            this.Controls.Add(this.labelMidMarksOutOf75);
            this.Controls.Add(this.labelAttendance);
            this.Controls.Add(this.labelObtainedMarks);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelQuiz4Marks);
            this.Controls.Add(this.labelQuiz3Marks);
            this.Controls.Add(this.labelQuiz2Marks);
            this.Controls.Add(this.labelQuiz1Marks);
            this.Controls.Add(this.labelFinalMarks);
            this.Controls.Add(this.labelMidMarks);
            this.Controls.Add(this.labelAttendedClassesOutOf28);
            this.Controls.Add(this.labelCourseName);
            this.Controls.Add(this.labelSemester);
            this.Controls.Add(this.labelStudentId);
            this.Controls.Add(this.labelStudentName);
            this.Controls.Add(this.labelStudentInfo);
            this.Name = "GradesApp";
            this.Text = "GradesApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label labelStudentInfo;
        public System.Windows.Forms.Label labelStudentName;
        public System.Windows.Forms.Label labelStudentId;
        public System.Windows.Forms.Label labelSemester;
        public System.Windows.Forms.Label labelCourseName;
        public System.Windows.Forms.Label labelAttendedClassesOutOf28;
        public System.Windows.Forms.Label labelMidMarks;
        public System.Windows.Forms.Label labelFinalMarks;
        public System.Windows.Forms.Label labelQuiz1Marks;
        public System.Windows.Forms.Label labelQuiz2Marks;
        public System.Windows.Forms.Label labelQuiz3Marks;
        public System.Windows.Forms.Label labelQuiz4Marks;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Label labelObtainedMarks;
        public System.Windows.Forms.Label labelAttendance;
        public System.Windows.Forms.Label labelMidMarksOutOf75;
        public System.Windows.Forms.Label labelTotalMarksOutOf45;
        public System.Windows.Forms.Label labelEnterFinalMarksOutOf150;
        public System.Windows.Forms.Label labelEnterTotalMarksOutOf300;
        public System.Windows.Forms.Label labelGradeLetter;
        public System.Windows.Forms.Label DisplayAttendanceMarks;
        public System.Windows.Forms.Label DisplayMidMarks;
        public System.Windows.Forms.Label DisplayTotalQuizMarks;
        public System.Windows.Forms.Label DisplayFinalMarks;
        public System.Windows.Forms.Label DisplayTotalMarks;
        public System.Windows.Forms.Label DisplayGrades;
        public System.Windows.Forms.Label DisplayNameAndPercentage;
        private System.Windows.Forms.TextBox EnterQuiz1Marks;
        private System.Windows.Forms.TextBox EnterQuiz2Marks;
        private System.Windows.Forms.TextBox EnterQuiz3Marks;
        private System.Windows.Forms.TextBox EnterQuiz4Marks;
        private System.Windows.Forms.TextBox EnterAttendedClassesOutOf28;
        private System.Windows.Forms.TextBox EnterMidMarks;
        private System.Windows.Forms.TextBox EnterFinalMarks;
        private System.Windows.Forms.TextBox EnterStudentName;
        private System.Windows.Forms.TextBox EnterStudentID;
        private System.Windows.Forms.TextBox EnterSemester;
        public System.Windows.Forms.Button DisplayResultWhenCLicked;
    }
}

