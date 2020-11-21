﻿namespace WindowsFormsApp
{
    partial class FormRentContract
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
            this.Cancel = new System.Windows.Forms.Button();
            this.Confirm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.Email = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.TotalBill = new System.Windows.Forms.TextBox();
            this.radioFemale = new System.Windows.Forms.RadioButton();
            this.radioMale = new System.Windows.Forms.RadioButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.BirthDay = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Address = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.TypeVehicle = new System.Windows.Forms.TextBox();
            this.BranchVehicle = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.NameVehicle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.endRent = new System.Windows.Forms.DateTimePicker();
            this.startRent = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Description = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CustormerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Cancel.Cursor = System.Windows.Forms.Cursors.Default;
            this.Cancel.Location = new System.Drawing.Point(135, 535);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(99, 33);
            this.Cancel.TabIndex = 0;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Confirm
            // 
            this.Confirm.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Confirm.Location = new System.Drawing.Point(339, 535);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(95, 33);
            this.Confirm.TabIndex = 1;
            this.Confirm.Text = "Confirm";
            this.Confirm.UseVisualStyleBackColor = false;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.ImageKey = "(none)";
            this.label1.Location = new System.Drawing.Point(195, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Rent  Contract";
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.radioFemale);
            this.panel1.Controls.Add(this.radioMale);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(50, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(492, 461);
            this.panel1.TabIndex = 3;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.Email);
            this.panel9.Controls.Add(this.label11);
            this.panel9.Location = new System.Drawing.Point(18, 179);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(457, 47);
            this.panel9.TabIndex = 4;
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(22, 16);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(423, 20);
            this.Email.TabIndex = 3;
            this.Email.TextChanged += new System.EventHandler(this.Email_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Email";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.label12);
            this.panel8.Controls.Add(this.TotalBill);
            this.panel8.Enabled = false;
            this.panel8.Location = new System.Drawing.Point(18, 413);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(457, 41);
            this.panel8.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "Total bill";
            // 
            // TotalBill
            // 
            this.TotalBill.Location = new System.Drawing.Point(83, 13);
            this.TotalBill.Name = "TotalBill";
            this.TotalBill.ReadOnly = true;
            this.TotalBill.Size = new System.Drawing.Size(362, 20);
            this.TotalBill.TabIndex = 12;
            // 
            // radioFemale
            // 
            this.radioFemale.AutoSize = true;
            this.radioFemale.Location = new System.Drawing.Point(377, 47);
            this.radioFemale.Name = "radioFemale";
            this.radioFemale.Size = new System.Drawing.Size(59, 17);
            this.radioFemale.TabIndex = 3;
            this.radioFemale.TabStop = true;
            this.radioFemale.Text = "Female";
            this.radioFemale.UseVisualStyleBackColor = true;
            this.radioFemale.CheckedChanged += new System.EventHandler(this.radioFemale_CheckedChanged);
            // 
            // radioMale
            // 
            this.radioMale.AutoSize = true;
            this.radioMale.Location = new System.Drawing.Point(377, 17);
            this.radioMale.Name = "radioMale";
            this.radioMale.Size = new System.Drawing.Size(48, 17);
            this.radioMale.TabIndex = 2;
            this.radioMale.TabStop = true;
            this.radioMale.Text = "Male";
            this.radioMale.UseVisualStyleBackColor = true;
            this.radioMale.CheckedChanged += new System.EventHandler(this.radioMale_CheckedChanged);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.BirthDay);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(18, 70);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(306, 50);
            this.panel5.TabIndex = 1;
            // 
            // BirthDay
            // 
            this.BirthDay.Location = new System.Drawing.Point(22, 19);
            this.BirthDay.Name = "BirthDay";
            this.BirthDay.Size = new System.Drawing.Size(200, 20);
            this.BirthDay.TabIndex = 2;
            this.BirthDay.ValueChanged += new System.EventHandler(this.BirthDay_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "BirthDay";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.Address);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(18, 126);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(457, 47);
            this.panel3.TabIndex = 1;
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(22, 16);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(423, 20);
            this.Address.TabIndex = 3;
            this.Address.TextChanged += new System.EventHandler(this.Address_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Address";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.TypeVehicle);
            this.panel4.Controls.Add(this.BranchVehicle);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.NameVehicle);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Location = new System.Drawing.Point(18, 232);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(457, 53);
            this.panel4.TabIndex = 1;
            // 
            // TypeVehicle
            // 
            this.TypeVehicle.Location = new System.Drawing.Point(358, 25);
            this.TypeVehicle.Name = "TypeVehicle";
            this.TypeVehicle.ReadOnly = true;
            this.TypeVehicle.Size = new System.Drawing.Size(87, 20);
            this.TypeVehicle.TabIndex = 8;
            // 
            // BranchVehicle
            // 
            this.BranchVehicle.Location = new System.Drawing.Point(196, 25);
            this.BranchVehicle.Name = "BranchVehicle";
            this.BranchVehicle.ReadOnly = true;
            this.BranchVehicle.Size = new System.Drawing.Size(142, 20);
            this.BranchVehicle.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(355, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Type";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(193, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Branch";
            // 
            // NameVehicle
            // 
            this.NameVehicle.Location = new System.Drawing.Point(22, 25);
            this.NameVehicle.Name = "NameVehicle";
            this.NameVehicle.ReadOnly = true;
            this.NameVehicle.Size = new System.Drawing.Size(167, 20);
            this.NameVehicle.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Vehicle Rented";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.endRent);
            this.panel7.Controls.Add(this.startRent);
            this.panel7.Controls.Add(this.label9);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Location = new System.Drawing.Point(18, 295);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(457, 51);
            this.panel7.TabIndex = 1;
            // 
            // endRent
            // 
            this.endRent.Location = new System.Drawing.Point(253, 26);
            this.endRent.Name = "endRent";
            this.endRent.Size = new System.Drawing.Size(189, 20);
            this.endRent.TabIndex = 13;
            this.endRent.ValueChanged += new System.EventHandler(this.endRent_ValueChanged);
            // 
            // startRent
            // 
            this.startRent.Location = new System.Drawing.Point(22, 25);
            this.startRent.Name = "startRent";
            this.startRent.Size = new System.Drawing.Size(189, 20);
            this.startRent.TabIndex = 12;
            this.startRent.ValueChanged += new System.EventHandler(this.startRent_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(250, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "End Rent";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Start Rent";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.Description);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Location = new System.Drawing.Point(18, 352);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(457, 55);
            this.panel6.TabIndex = 1;
            // 
            // Description
            // 
            this.Description.Location = new System.Drawing.Point(22, 16);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(423, 20);
            this.Description.TabIndex = 12;
            this.Description.TextChanged += new System.EventHandler(this.Description_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Description";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.CustormerName);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(18, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(306, 48);
            this.panel2.TabIndex = 0;
            // 
            // CustormerName
            // 
            this.CustormerName.Location = new System.Drawing.Point(22, 20);
            this.CustormerName.Name = "CustormerName";
            this.CustormerName.Size = new System.Drawing.Size(279, 20);
            this.CustormerName.TabIndex = 2;
            this.CustormerName.TextChanged += new System.EventHandler(this.CostormerName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name Custormer";
            // 
            // FormRentContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 594);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.Cancel);
            this.Name = "FormRentContract";
            this.Text = "FormRentContract";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioFemale;
        private System.Windows.Forms.RadioButton radioMale;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox CustormerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker BirthDay;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox NameVehicle;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TotalBill;
        private System.Windows.Forms.TextBox TypeVehicle;
        private System.Windows.Forms.TextBox BranchVehicle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Description;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker endRent;
        private System.Windows.Forms.DateTimePicker startRent;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Label label11;
    }
}