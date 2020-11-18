namespace WindowsFormsApp
{
    partial class FormBookAndRent
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.radioTruck = new System.Windows.Forms.RadioButton();
            this.radioCar = new System.Windows.Forms.RadioButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.EndRent = new System.Windows.Forms.DateTimePicker();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.startRent = new System.Windows.Forms.DateTimePicker();
            this.panel4 = new System.Windows.Forms.Panel();
            this.branchVehicle = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.typeVehicle = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listResult = new System.Windows.Forms.ListView();
            this.NameVehicle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StatusUse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CostRent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.Home = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Location = new System.Drawing.Point(30, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(361, 281);
            this.panel1.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel7.Controls.Add(this.radioTruck);
            this.panel7.Controls.Add(this.radioCar);
            this.panel7.Location = new System.Drawing.Point(118, 15);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(100, 50);
            this.panel7.TabIndex = 18;
            // 
            // radioTruck
            // 
            this.radioTruck.AutoSize = true;
            this.radioTruck.Location = new System.Drawing.Point(8, 26);
            this.radioTruck.Name = "radioTruck";
            this.radioTruck.Size = new System.Drawing.Size(53, 17);
            this.radioTruck.TabIndex = 1;
            this.radioTruck.TabStop = true;
            this.radioTruck.Text = "Truck";
            this.radioTruck.UseVisualStyleBackColor = true;
            this.radioTruck.CheckedChanged += new System.EventHandler(this.radioTruck_CheckedChanged);
            // 
            // radioCar
            // 
            this.radioCar.AutoSize = true;
            this.radioCar.Location = new System.Drawing.Point(8, 3);
            this.radioCar.Name = "radioCar";
            this.radioCar.Size = new System.Drawing.Size(41, 17);
            this.radioCar.TabIndex = 0;
            this.radioCar.TabStop = true;
            this.radioCar.Text = "Car";
            this.radioCar.UseVisualStyleBackColor = true;
            this.radioCar.CheckedChanged += new System.EventHandler(this.radioCar_CheckedChanged);
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.EndRent);
            this.panel6.Location = new System.Drawing.Point(26, 215);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(318, 55);
            this.panel6.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "End Rent";
            // 
            // EndRent
            // 
            this.EndRent.Location = new System.Drawing.Point(15, 23);
            this.EndRent.Name = "EndRent";
            this.EndRent.Size = new System.Drawing.Size(200, 20);
            this.EndRent.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.startRent);
            this.panel5.Location = new System.Drawing.Point(26, 146);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(318, 63);
            this.panel5.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Start Rent";
            // 
            // startRent
            // 
            this.startRent.Location = new System.Drawing.Point(15, 34);
            this.startRent.Name = "startRent";
            this.startRent.Size = new System.Drawing.Size(200, 20);
            this.startRent.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.branchVehicle);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.typeVehicle);
            this.panel4.Location = new System.Drawing.Point(26, 71);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(318, 64);
            this.panel4.TabIndex = 18;
            // 
            // branchVehicle
            // 
            this.branchVehicle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.branchVehicle.FormattingEnabled = true;
            this.branchVehicle.Location = new System.Drawing.Point(7, 33);
            this.branchVehicle.Name = "branchVehicle";
            this.branchVehicle.Size = new System.Drawing.Size(121, 21);
            this.branchVehicle.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Branch";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(166, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Type Vehicle";
            // 
            // typeVehicle
            // 
            this.typeVehicle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeVehicle.FormattingEnabled = true;
            this.typeVehicle.Location = new System.Drawing.Point(170, 33);
            this.typeVehicle.Name = "typeVehicle";
            this.typeVehicle.Size = new System.Drawing.Size(121, 21);
            this.typeVehicle.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(135, 346);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Find";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "Find";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(567, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 37);
            this.label2.TabIndex = 6;
            this.label2.Text = "Result";
            // 
            // listResult
            // 
            this.listResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameVehicle,
            this.StatusUse,
            this.CostRent});
            this.listResult.GridLines = true;
            this.listResult.HideSelection = false;
            this.listResult.Location = new System.Drawing.Point(16, 3);
            this.listResult.Name = "listResult";
            this.listResult.Size = new System.Drawing.Size(348, 278);
            this.listResult.TabIndex = 4;
            this.listResult.UseCompatibleStateImageBehavior = false;
            this.listResult.View = System.Windows.Forms.View.Details;
            this.listResult.SelectedIndexChanged += new System.EventHandler(this.listResult_SelectedIndexChanged);
            // 
            // NameVehicle
            // 
            this.NameVehicle.Text = "Name Vehicle";
            this.NameVehicle.Width = 150;
            // 
            // StatusUse
            // 
            this.StatusUse.Text = "StatusUse";
            this.StatusUse.Width = 70;
            // 
            // CostRent
            // 
            this.CostRent.Text = "CostRent";
            this.CostRent.Width = 250;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.listResult);
            this.panel2.Location = new System.Drawing.Point(421, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(367, 320);
            this.panel2.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(153, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Book";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Home
            // 
            this.Home.Location = new System.Drawing.Point(355, 346);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(75, 23);
            this.Home.TabIndex = 8;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // FormBookAndRent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 387);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Name = "FormBookAndRent";
            this.Text = "FormBookAndRent";
            this.panel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox typeVehicle;
        private System.Windows.Forms.ComboBox branchVehicle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker EndRent;
        private System.Windows.Forms.DateTimePicker startRent;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView listResult;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader NameVehicle;
        private System.Windows.Forms.ColumnHeader StatusUse;
        private System.Windows.Forms.ColumnHeader CostRent;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.RadioButton radioTruck;
        private System.Windows.Forms.RadioButton radioCar;
    }
}