namespace File_Handling
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
            this.SearchEmployeeTxtbox = new System.Windows.Forms.TextBox();
            this.SearchEmployeeButton = new System.Windows.Forms.Button();
            this.SearchEmployeeListBox = new System.Windows.Forms.ListBox();
            this.DisplayAllEmployeeListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(427, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search Employee";
            // 
            // SearchEmployeeTxtbox
            // 
            this.SearchEmployeeTxtbox.Location = new System.Drawing.Point(431, 88);
            this.SearchEmployeeTxtbox.Name = "SearchEmployeeTxtbox";
            this.SearchEmployeeTxtbox.Size = new System.Drawing.Size(119, 20);
            this.SearchEmployeeTxtbox.TabIndex = 1;
            // 
            // SearchEmployeeButton
            // 
            this.SearchEmployeeButton.Location = new System.Drawing.Point(614, 86);
            this.SearchEmployeeButton.Name = "SearchEmployeeButton";
            this.SearchEmployeeButton.Size = new System.Drawing.Size(75, 23);
            this.SearchEmployeeButton.TabIndex = 2;
            this.SearchEmployeeButton.Text = "Search";
            this.SearchEmployeeButton.UseVisualStyleBackColor = true;
            this.SearchEmployeeButton.Click += new System.EventHandler(this.SearchEmployeeButtonClick);
            // 
            // SearchEmployeeListBox
            // 
            this.SearchEmployeeListBox.FormattingEnabled = true;
            this.SearchEmployeeListBox.Location = new System.Drawing.Point(323, 140);
            this.SearchEmployeeListBox.Name = "SearchEmployeeListBox";
            this.SearchEmployeeListBox.Size = new System.Drawing.Size(465, 238);
            this.SearchEmployeeListBox.TabIndex = 3;
            // 
            // DisplayAllEmployeeListBox
            // 
            this.DisplayAllEmployeeListBox.FormattingEnabled = true;
            this.DisplayAllEmployeeListBox.Location = new System.Drawing.Point(24, 13);
            this.DisplayAllEmployeeListBox.Name = "DisplayAllEmployeeListBox";
            this.DisplayAllEmployeeListBox.Size = new System.Drawing.Size(281, 368);
            this.DisplayAllEmployeeListBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DisplayAllEmployeeListBox);
            this.Controls.Add(this.SearchEmployeeListBox);
            this.Controls.Add(this.SearchEmployeeButton);
            this.Controls.Add(this.SearchEmployeeTxtbox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SearchEmployeeTxtbox;
        private System.Windows.Forms.Button SearchEmployeeButton;
        private System.Windows.Forms.ListBox SearchEmployeeListBox;
        private System.Windows.Forms.ListBox DisplayAllEmployeeListBox;
    }
}

