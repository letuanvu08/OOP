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
            this.ContractList = new System.Windows.Forms.ListView();
            this.approvalCheckBox = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ContractIDColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.VehicleIDColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CustomerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DriverLicense = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.InsuranceType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ApproveButton = new System.Windows.Forms.Button();
            this.ApprovedContractList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.PreviewModeRadio = new System.Windows.Forms.RadioButton();
            this.UpdateModeRadio = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.contractStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Home
            // 
            this.Home.Location = new System.Drawing.Point(548, 625);
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
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
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
            // ContractList
            // 
            this.ContractList.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ContractList.CheckBoxes = true;
            this.ContractList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.approvalCheckBox,
            this.ContractIDColumn,
            this.VehicleIDColumn,
            this.CustomerName,
            this.DriverLicense,
            this.InsuranceType,
            this.contractStatus});
            this.ContractList.GridLines = true;
            this.ContractList.HideSelection = false;
            this.ContractList.Location = new System.Drawing.Point(12, 123);
            this.ContractList.Name = "ContractList";
            this.ContractList.Size = new System.Drawing.Size(579, 420);
            this.ContractList.TabIndex = 4;
            this.ContractList.UseCompatibleStateImageBehavior = false;
            this.ContractList.View = System.Windows.Forms.View.Details;
            this.ContractList.SelectedIndexChanged += new System.EventHandler(this.ContractList_SelectedIndexChanged);
            // 
            // approvalCheckBox
            // 
            this.approvalCheckBox.Text = "Approve";
            this.approvalCheckBox.Width = 30;
            // 
            // ContractIDColumn
            // 
            this.ContractIDColumn.Text = "ID:";
            this.ContractIDColumn.Width = 40;
            // 
            // VehicleIDColumn
            // 
            this.VehicleIDColumn.Text = "VehicleID:";
            this.VehicleIDColumn.Width = 100;
            // 
            // CustomerName
            // 
            this.CustomerName.Text = "Customer Name:";
            this.CustomerName.Width = 140;
            // 
            // DriverLicense
            // 
            this.DriverLicense.Text = "DriverLicense";
            this.DriverLicense.Width = 100;
            // 
            // InsuranceType
            // 
            this.InsuranceType.Text = "Insurance Type:";
            this.InsuranceType.Width = 100;
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
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(618, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "List Of Finished Contracts:";
            // 
            // ApproveButton
            // 
            this.ApproveButton.Location = new System.Drawing.Point(359, 562);
            this.ApproveButton.Name = "ApproveButton";
            this.ApproveButton.Size = new System.Drawing.Size(108, 35);
            this.ApproveButton.TabIndex = 7;
            this.ApproveButton.Text = "Approve Selected Item";
            this.ApproveButton.UseVisualStyleBackColor = true;
            this.ApproveButton.Click += new System.EventHandler(this.ApproveButton_Click);
            // 
            // ApprovedContractList
            // 
            this.ApprovedContractList.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ApprovedContractList.CheckBoxes = true;
            this.ApprovedContractList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.ApprovedContractList.GridLines = true;
            this.ApprovedContractList.HideSelection = false;
            this.ApprovedContractList.Location = new System.Drawing.Point(623, 123);
            this.ApprovedContractList.Name = "ApprovedContractList";
            this.ApprovedContractList.Size = new System.Drawing.Size(579, 420);
            this.ApprovedContractList.TabIndex = 8;
            this.ApprovedContractList.UseCompatibleStateImageBehavior = false;
            this.ApprovedContractList.View = System.Windows.Forms.View.Details;
            this.ApprovedContractList.SelectedIndexChanged += new System.EventHandler(this.ApprovedContractList_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.DisplayIndex = 5;
            this.columnHeader1.Text = "DisplayDetail";
            // 
            // columnHeader2
            // 
            this.columnHeader2.DisplayIndex = 0;
            this.columnHeader2.Text = "ID:";
            this.columnHeader2.Width = 39;
            // 
            // columnHeader3
            // 
            this.columnHeader3.DisplayIndex = 1;
            this.columnHeader3.Text = "VehicleID:";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.DisplayIndex = 2;
            this.columnHeader4.Text = "Customer Name:";
            this.columnHeader4.Width = 140;
            // 
            // columnHeader5
            // 
            this.columnHeader5.DisplayIndex = 3;
            this.columnHeader5.Text = "DriverLicense";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.DisplayIndex = 4;
            this.columnHeader6.Text = "Insurance Type:";
            this.columnHeader6.Width = 100;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PreviewModeRadio);
            this.panel1.Controls.Add(this.UpdateModeRadio);
            this.panel1.Location = new System.Drawing.Point(221, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 36);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // PreviewModeRadio
            // 
            this.PreviewModeRadio.AutoSize = true;
            this.PreviewModeRadio.Location = new System.Drawing.Point(194, 4);
            this.PreviewModeRadio.Name = "PreviewModeRadio";
            this.PreviewModeRadio.Size = new System.Drawing.Size(132, 24);
            this.PreviewModeRadio.TabIndex = 1;
            this.PreviewModeRadio.TabStop = true;
            this.PreviewModeRadio.Text = "Preview Mode";
            this.PreviewModeRadio.UseVisualStyleBackColor = true;
            // 
            // UpdateModeRadio
            // 
            this.UpdateModeRadio.AutoSize = true;
            this.UpdateModeRadio.Location = new System.Drawing.Point(15, 4);
            this.UpdateModeRadio.Name = "UpdateModeRadio";
            this.UpdateModeRadio.Size = new System.Drawing.Size(131, 24);
            this.UpdateModeRadio.TabIndex = 0;
            this.UpdateModeRadio.TabStop = true;
            this.UpdateModeRadio.Text = "Update Mode";
            this.UpdateModeRadio.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(486, 561);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 36);
            this.button1.TabIndex = 10;
            this.button1.Text = "Pay";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // contractStatus
            // 
            this.contractStatus.Text = "Status";
            // 
            // FormManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ApprovedContractList);
            this.Controls.Add(this.ApproveButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ContractList);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.Home);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormManage";
            this.Text = "FormManage";
            this.Load += new System.EventHandler(this.FormManage_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RadioButton ManageCarRadioButton;
        private System.Windows.Forms.RadioButton ManageTruckRadioButton;
        private System.Windows.Forms.ListView ContractList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader ContractIDColumn;
        private System.Windows.Forms.ColumnHeader VehicleIDColumn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ColumnHeader CustomerName;
        private System.Windows.Forms.ColumnHeader DriverLicense;
        private System.Windows.Forms.ColumnHeader InsuranceType;
        private System.Windows.Forms.ColumnHeader approvalCheckBox;
        private System.Windows.Forms.Button ApproveButton;
        private System.Windows.Forms.ListView ApprovedContractList;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton PreviewModeRadio;
        private System.Windows.Forms.RadioButton UpdateModeRadio;
        private System.Windows.Forms.ColumnHeader contractStatus;
        private System.Windows.Forms.Button button1;
    }
}