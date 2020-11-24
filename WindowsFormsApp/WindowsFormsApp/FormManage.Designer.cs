namespace WindowsFormsApp
{
    partial class FormManage
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ManageCarRadioButton = new System.Windows.Forms.RadioButton();
            this.ManageTruckRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ContractList = new System.Windows.Forms.ListView();
            this.ContractIDColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.VehicleIDColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Home
            // 
            this.Home.Location = new System.Drawing.Point(530, 569);
            this.Home.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(112, 35);
            this.Home.TabIndex = 0;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.ManageCarRadioButton);
            this.flowLayoutPanel1.Controls.Add(this.ManageTruckRadioButton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(24, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(137, 67);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // ManageCarRadioButton
            // 
            this.ManageCarRadioButton.AutoSize = true;
            this.ManageCarRadioButton.Location = new System.Drawing.Point(3, 3);
            this.ManageCarRadioButton.Name = "ManageCarRadioButton";
            this.ManageCarRadioButton.Size = new System.Drawing.Size(99, 24);
            this.ManageCarRadioButton.TabIndex = 0;
            this.ManageCarRadioButton.TabStop = true;
            this.ManageCarRadioButton.Text = "Car Fleet";
            this.ManageCarRadioButton.UseVisualStyleBackColor = true;
            this.ManageCarRadioButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // ManageTruckRadioButton
            // 
            this.ManageTruckRadioButton.AutoSize = true;
            this.ManageTruckRadioButton.Location = new System.Drawing.Point(3, 33);
            this.ManageTruckRadioButton.Name = "ManageTruckRadioButton";
            this.ManageTruckRadioButton.Size = new System.Drawing.Size(113, 24);
            this.ManageTruckRadioButton.TabIndex = 2;
            this.ManageTruckRadioButton.TabStop = true;
            this.ManageTruckRadioButton.Text = "Truck Fleet";
            this.ManageTruckRadioButton.UseVisualStyleBackColor = true;
            this.ManageTruckRadioButton.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(623, 123);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(565, 420);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "List Of Vehicle";
            // 
            // ContractList
            // 
            this.ContractList.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ContractList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ContractIDColumn,
            this.VehicleIDColumn});
            this.ContractList.HideSelection = false;
            this.ContractList.Location = new System.Drawing.Point(24, 123);
            this.ContractList.Name = "ContractList";
            this.ContractList.Size = new System.Drawing.Size(578, 420);
            this.ContractList.TabIndex = 4;
            this.ContractList.UseCompatibleStateImageBehavior = false;
            this.ContractList.View = System.Windows.Forms.View.Details;
            this.ContractList.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // ContractIDColumn
            // 
            this.ContractIDColumn.Text = "Contract ID:";
            this.ContractIDColumn.Width = 290;
            // 
            // VehicleIDColumn
            // 
            this.VehicleIDColumn.Text = "VehicleID:";
            this.VehicleIDColumn.Width = 373;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "List Of Contract:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(618, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "List Of Approved Contracts:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // FormManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ContractList);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.Home);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormManage";
            this.Text = "FormManage";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RadioButton ManageCarRadioButton;
        private System.Windows.Forms.RadioButton ManageTruckRadioButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView ContractList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader ContractIDColumn;
        private System.Windows.Forms.ColumnHeader VehicleIDColumn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}