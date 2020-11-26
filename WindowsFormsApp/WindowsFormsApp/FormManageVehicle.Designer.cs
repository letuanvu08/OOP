namespace WindowsFormsApp
{
    partial class FormManageVehicle
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
            this.Home = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listResult = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Branch = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.RadioTruckview = new System.Windows.Forms.RadioButton();
            this.RadioCarview = new System.Windows.Forms.RadioButton();
            this.PanelDetail = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.costperdatetext = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.descriptiontext = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.Kilometer = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.registration = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.BranchVehicle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.RadioCarDetail = new System.Windows.Forms.RadioButton();
            this.RadioTruckDetail = new System.Windows.Forms.RadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.NameVehicle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtDetail = new System.Windows.Forms.Button();
            this.BtChange = new System.Windows.Forms.Button();
            this.BtAddVehicle = new System.Windows.Forms.Button();
            this.BtSave = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.PanelDetail.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Home
            // 
            this.Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home.Location = new System.Drawing.Point(384, 519);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(75, 23);
            this.Home.TabIndex = 0;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.listResult);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(12, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(389, 392);
            this.panel1.TabIndex = 1;
            // 
            // listResult
            // 
            this.listResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Name,
            this.Branch,
            this.type});
            this.listResult.GridLines = true;
            this.listResult.HideSelection = false;
            this.listResult.Location = new System.Drawing.Point(14, 39);
            this.listResult.Name = "listResult";
            this.listResult.Size = new System.Drawing.Size(359, 341);
            this.listResult.TabIndex = 5;
            this.listResult.UseCompatibleStateImageBehavior = false;
            this.listResult.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 73;
            // 
            // Name
            // 
            this.Name.Text = "Name";
            this.Name.Width = 116;
            // 
            // Branch
            // 
            this.Branch.Text = "Branch";
            this.Branch.Width = 91;
            // 
            // type
            // 
            this.type.Text = "Type";
            this.type.Width = 81;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.RadioTruckview);
            this.panel3.Controls.Add(this.RadioCarview);
            this.panel3.Location = new System.Drawing.Point(14, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(359, 29);
            this.panel3.TabIndex = 2;
            // 
            // RadioTruckview
            // 
            this.RadioTruckview.AutoSize = true;
            this.RadioTruckview.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioTruckview.Location = new System.Drawing.Point(216, 3);
            this.RadioTruckview.Name = "RadioTruckview";
            this.RadioTruckview.Size = new System.Drawing.Size(60, 20);
            this.RadioTruckview.TabIndex = 1;
            this.RadioTruckview.TabStop = true;
            this.RadioTruckview.Text = "Truck";
            this.RadioTruckview.UseVisualStyleBackColor = true;
            this.RadioTruckview.CheckedChanged += new System.EventHandler(this.RadioTruckview_CheckedChanged);
            // 
            // RadioCarview
            // 
            this.RadioCarview.AutoSize = true;
            this.RadioCarview.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioCarview.Location = new System.Drawing.Point(29, 3);
            this.RadioCarview.Name = "RadioCarview";
            this.RadioCarview.Size = new System.Drawing.Size(47, 20);
            this.RadioCarview.TabIndex = 0;
            this.RadioCarview.TabStop = true;
            this.RadioCarview.Text = "Car";
            this.RadioCarview.UseVisualStyleBackColor = true;
            this.RadioCarview.CheckedChanged += new System.EventHandler(this.RadioCarview_CheckedChanged);
            // 
            // PanelDetail
            // 
            this.PanelDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelDetail.Controls.Add(this.panel12);
            this.PanelDetail.Controls.Add(this.panel11);
            this.PanelDetail.Controls.Add(this.panel10);
            this.PanelDetail.Controls.Add(this.panel9);
            this.PanelDetail.Controls.Add(this.panel8);
            this.PanelDetail.Controls.Add(this.panel7);
            this.PanelDetail.Controls.Add(this.panel6);
            this.PanelDetail.Controls.Add(this.panel5);
            this.PanelDetail.Controls.Add(this.panel4);
            this.PanelDetail.Location = new System.Drawing.Point(441, 70);
            this.PanelDetail.Name = "PanelDetail";
            this.PanelDetail.Size = new System.Drawing.Size(415, 389);
            this.PanelDetail.TabIndex = 2;
            // 
            // panel12
            // 
            this.panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel12.Controls.Add(this.costperdatetext);
            this.panel12.Controls.Add(this.label9);
            this.panel12.Location = new System.Drawing.Point(16, 260);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(391, 53);
            this.panel12.TabIndex = 15;
            // 
            // costperdatetext
            // 
            this.costperdatetext.Location = new System.Drawing.Point(12, 30);
            this.costperdatetext.Name = "costperdatetext";
            this.costperdatetext.Size = new System.Drawing.Size(372, 20);
            this.costperdatetext.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 18);
            this.label9.TabIndex = 9;
            this.label9.Text = "Cost Rent per day";
            // 
            // panel11
            // 
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel11.Controls.Add(this.descriptiontext);
            this.panel11.Controls.Add(this.label8);
            this.panel11.Location = new System.Drawing.Point(16, 319);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(391, 57);
            this.panel11.TabIndex = 14;
            // 
            // descriptiontext
            // 
            this.descriptiontext.Location = new System.Drawing.Point(12, 30);
            this.descriptiontext.Name = "descriptiontext";
            this.descriptiontext.Size = new System.Drawing.Size(372, 20);
            this.descriptiontext.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 18);
            this.label8.TabIndex = 9;
            this.label8.Text = "Description Vehicle";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.checkBox2);
            this.panel10.Controls.Add(this.checkBox1);
            this.panel10.Location = new System.Drawing.Point(296, 197);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(111, 57);
            this.panel10.TabIndex = 14;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(11, 31);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(77, 20);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Maintain";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(11, 7);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(97, 20);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "StatusUsed";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // panel9
            // 
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.Kilometer);
            this.panel9.Controls.Add(this.label7);
            this.panel9.Location = new System.Drawing.Point(16, 197);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(267, 57);
            this.panel9.TabIndex = 13;
            // 
            // Kilometer
            // 
            this.Kilometer.Location = new System.Drawing.Point(12, 30);
            this.Kilometer.Name = "Kilometer";
            this.Kilometer.Size = new System.Drawing.Size(372, 20);
            this.Kilometer.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 18);
            this.label7.TabIndex = 9;
            this.label7.Text = "NumberKilometer";
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.registration);
            this.panel8.Controls.Add(this.label6);
            this.panel8.Location = new System.Drawing.Point(16, 134);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(391, 57);
            this.panel8.TabIndex = 12;
            // 
            // registration
            // 
            this.registration.Location = new System.Drawing.Point(12, 30);
            this.registration.Name = "registration";
            this.registration.Size = new System.Drawing.Size(360, 20);
            this.registration.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "car registration number";
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.comboBox1);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Location = new System.Drawing.Point(249, 71);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(158, 57);
            this.panel7.TabIndex = 12;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(139, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Type Vehicle";
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.BranchVehicle);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Location = new System.Drawing.Point(16, 71);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(227, 57);
            this.panel6.TabIndex = 11;
            // 
            // BranchVehicle
            // 
            this.BranchVehicle.Location = new System.Drawing.Point(12, 30);
            this.BranchVehicle.Name = "BranchVehicle";
            this.BranchVehicle.Size = new System.Drawing.Size(185, 20);
            this.BranchVehicle.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Branch Vehicle";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.RadioCarDetail);
            this.panel5.Controls.Add(this.RadioTruckDetail);
            this.panel5.Location = new System.Drawing.Point(322, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(85, 54);
            this.panel5.TabIndex = 3;
            // 
            // RadioCarDetail
            // 
            this.RadioCarDetail.AutoSize = true;
            this.RadioCarDetail.Location = new System.Drawing.Point(25, 3);
            this.RadioCarDetail.Name = "RadioCarDetail";
            this.RadioCarDetail.Size = new System.Drawing.Size(53, 17);
            this.RadioCarDetail.TabIndex = 1;
            this.RadioCarDetail.TabStop = true;
            this.RadioCarDetail.Text = "Truck";
            this.RadioCarDetail.UseVisualStyleBackColor = true;
            // 
            // RadioTruckDetail
            // 
            this.RadioTruckDetail.AutoSize = true;
            this.RadioTruckDetail.Location = new System.Drawing.Point(25, 26);
            this.RadioTruckDetail.Name = "RadioTruckDetail";
            this.RadioTruckDetail.Size = new System.Drawing.Size(41, 17);
            this.RadioTruckDetail.TabIndex = 0;
            this.RadioTruckDetail.TabStop = true;
            this.RadioTruckDetail.Text = "Car";
            this.RadioTruckDetail.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.NameVehicle);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(16, 8);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(300, 57);
            this.panel4.TabIndex = 10;
            // 
            // NameVehicle
            // 
            this.NameVehicle.Location = new System.Drawing.Point(12, 30);
            this.NameVehicle.Name = "NameVehicle";
            this.NameVehicle.Size = new System.Drawing.Size(285, 20);
            this.NameVehicle.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Name Vehicle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "List Vehicle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(596, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Vehicle Detail";
            // 
            // BtDetail
            // 
            this.BtDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtDetail.Location = new System.Drawing.Point(131, 465);
            this.BtDetail.Name = "BtDetail";
            this.BtDetail.Size = new System.Drawing.Size(88, 31);
            this.BtDetail.TabIndex = 5;
            this.BtDetail.Text = "Detail Vehicle";
            this.BtDetail.UseVisualStyleBackColor = true;
            // 
            // BtChange
            // 
            this.BtChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtChange.Location = new System.Drawing.Point(629, 465);
            this.BtChange.Name = "BtChange";
            this.BtChange.Size = new System.Drawing.Size(96, 31);
            this.BtChange.TabIndex = 6;
            this.BtChange.Text = "Change";
            this.BtChange.UseVisualStyleBackColor = true;
            // 
            // BtAddVehicle
            // 
            this.BtAddVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtAddVehicle.Location = new System.Drawing.Point(471, 465);
            this.BtAddVehicle.Name = "BtAddVehicle";
            this.BtAddVehicle.Size = new System.Drawing.Size(126, 32);
            this.BtAddVehicle.TabIndex = 7;
            this.BtAddVehicle.Text = "Add new Vehicle";
            this.BtAddVehicle.UseVisualStyleBackColor = true;
            // 
            // BtSave
            // 
            this.BtSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtSave.Location = new System.Drawing.Point(749, 465);
            this.BtSave.Name = "BtSave";
            this.BtSave.Size = new System.Drawing.Size(92, 31);
            this.BtSave.TabIndex = 8;
            this.BtSave.Text = "Save";
            this.BtSave.UseVisualStyleBackColor = true;
            // 
            // FormManageVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 554);
            this.Controls.Add(this.BtSave);
            this.Controls.Add(this.BtAddVehicle);
            this.Controls.Add(this.BtChange);
            this.Controls.Add(this.BtDetail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PanelDetail);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Home);
            
            this.Text = "FormManageVehicle";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.PanelDetail.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PanelDetail;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton RadioTruckview;
        private System.Windows.Forms.RadioButton RadioCarview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtDetail;
        private System.Windows.Forms.Button BtChange;
        private System.Windows.Forms.Button BtAddVehicle;
        private System.Windows.Forms.Button BtSave;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox registration;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox BranchVehicle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RadioButton RadioCarDetail;
        private System.Windows.Forms.RadioButton RadioTruckDetail;
        private System.Windows.Forms.TextBox NameVehicle;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox Kilometer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.TextBox costperdatetext;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.TextBox descriptiontext;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ListView listResult;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader Branch;
        private System.Windows.Forms.ColumnHeader type;
    }
}