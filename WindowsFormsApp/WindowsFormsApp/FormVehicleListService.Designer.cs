
namespace WindowsFormsApp
{
    partial class FormVehicleListService
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
            this.GoBackButton = new System.Windows.Forms.Button();
            this.ServiceAll = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ShowCarRadio = new System.Windows.Forms.RadioButton();
            this.ShowTruckRadio = new System.Windows.Forms.RadioButton();
            this.ShowAllRadio = new System.Windows.Forms.RadioButton();
            this.VehicleListView = new System.Windows.Forms.ListView();
            this.VehicleIDColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.VehicleNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ServiceCheckVehicleButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ServiceTruckFleetButton = new System.Windows.Forms.Button();
            this.ServiceCarFleetButton = new System.Windows.Forms.Button();
            this.JsonToConsoleButton = new System.Windows.Forms.Button();
            this.JsonToFileButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GoBackButton
            // 
            this.GoBackButton.Location = new System.Drawing.Point(29, 655);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(153, 41);
            this.GoBackButton.TabIndex = 0;
            this.GoBackButton.Text = "Go Back";
            this.GoBackButton.UseVisualStyleBackColor = true;
            this.GoBackButton.Click += new System.EventHandler(this.GoBackButton_Click);
            // 
            // ServiceAll
            // 
            this.ServiceAll.Location = new System.Drawing.Point(471, 114);
            this.ServiceAll.Name = "ServiceAll";
            this.ServiceAll.Size = new System.Drawing.Size(152, 38);
            this.ServiceAll.TabIndex = 3;
            this.ServiceAll.Text = "Service All";
            this.ServiceAll.UseVisualStyleBackColor = true;
            this.ServiceAll.Click += new System.EventHandler(this.ServiceAll_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.ShowCarRadio);
            this.flowLayoutPanel1.Controls.Add(this.ShowTruckRadio);
            this.flowLayoutPanel1.Controls.Add(this.ShowAllRadio);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(29, 27);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(197, 94);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // ShowCarRadio
            // 
            this.ShowCarRadio.AutoSize = true;
            this.ShowCarRadio.Location = new System.Drawing.Point(3, 3);
            this.ShowCarRadio.Name = "ShowCarRadio";
            this.ShowCarRadio.Size = new System.Drawing.Size(146, 24);
            this.ShowCarRadio.TabIndex = 0;
            this.ShowCarRadio.TabStop = true;
            this.ShowCarRadio.Text = "Show Cars Only";
            this.ShowCarRadio.UseVisualStyleBackColor = true;
            this.ShowCarRadio.CheckedChanged += new System.EventHandler(this.ShowCarRadio_CheckedChanged);
            // 
            // ShowTruckRadio
            // 
            this.ShowTruckRadio.AutoSize = true;
            this.ShowTruckRadio.Location = new System.Drawing.Point(3, 33);
            this.ShowTruckRadio.Name = "ShowTruckRadio";
            this.ShowTruckRadio.Size = new System.Drawing.Size(152, 24);
            this.ShowTruckRadio.TabIndex = 1;
            this.ShowTruckRadio.TabStop = true;
            this.ShowTruckRadio.Text = "Show Truck Only";
            this.ShowTruckRadio.UseVisualStyleBackColor = true;
            this.ShowTruckRadio.CheckedChanged += new System.EventHandler(this.ShowTruckRadio_CheckedChanged);
            // 
            // ShowAllRadio
            // 
            this.ShowAllRadio.AutoSize = true;
            this.ShowAllRadio.Location = new System.Drawing.Point(3, 63);
            this.ShowAllRadio.Name = "ShowAllRadio";
            this.ShowAllRadio.Size = new System.Drawing.Size(151, 24);
            this.ShowAllRadio.TabIndex = 2;
            this.ShowAllRadio.TabStop = true;
            this.ShowAllRadio.Text = "Show All Vehicle";
            this.ShowAllRadio.UseVisualStyleBackColor = true;
            this.ShowAllRadio.CheckedChanged += new System.EventHandler(this.ShowAllRadio_CheckedChanged);
            // 
            // VehicleListView
            // 
            this.VehicleListView.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.VehicleListView.CheckBoxes = true;
            this.VehicleListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.VehicleIDColumn,
            this.VehicleNameColumn});
            this.VehicleListView.GridLines = true;
            this.VehicleListView.HideSelection = false;
            this.VehicleListView.Location = new System.Drawing.Point(29, 173);
            this.VehicleListView.Name = "VehicleListView";
            this.VehicleListView.Size = new System.Drawing.Size(579, 420);
            this.VehicleListView.TabIndex = 5;
            this.VehicleListView.UseCompatibleStateImageBehavior = false;
            this.VehicleListView.View = System.Windows.Forms.View.Details;
            this.VehicleListView.SelectedIndexChanged += new System.EventHandler(this.ContractList_SelectedIndexChanged);
            // 
            // VehicleIDColumn
            // 
            this.VehicleIDColumn.Text = "VehicleID:";
            this.VehicleIDColumn.Width = 100;
            // 
            // VehicleNameColumn
            // 
            this.VehicleNameColumn.Text = "Name";
            this.VehicleNameColumn.Width = 245;
            // 
            // ServiceCheckVehicleButton
            // 
            this.ServiceCheckVehicleButton.Location = new System.Drawing.Point(238, 114);
            this.ServiceCheckVehicleButton.Name = "ServiceCheckVehicleButton";
            this.ServiceCheckVehicleButton.Size = new System.Drawing.Size(211, 38);
            this.ServiceCheckVehicleButton.TabIndex = 6;
            this.ServiceCheckVehicleButton.Text = "Service Checked Vehicle";
            this.ServiceCheckVehicleButton.UseVisualStyleBackColor = true;
            this.ServiceCheckVehicleButton.Click += new System.EventHandler(this.ServiceCheckedVehicleButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 609);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(417, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "double click on the wanted checkbox for more specific info";
            // 
            // ServiceTruckFleetButton
            // 
            this.ServiceTruckFleetButton.Location = new System.Drawing.Point(238, 58);
            this.ServiceTruckFleetButton.Name = "ServiceTruckFleetButton";
            this.ServiceTruckFleetButton.Size = new System.Drawing.Size(211, 38);
            this.ServiceTruckFleetButton.TabIndex = 8;
            this.ServiceTruckFleetButton.Text = "Service Truck Fleet";
            this.ServiceTruckFleetButton.UseVisualStyleBackColor = true;
            this.ServiceTruckFleetButton.Click += new System.EventHandler(this.ServiceTruckFleetButton_Click);
            // 
            // ServiceCarFleetButton
            // 
            this.ServiceCarFleetButton.Location = new System.Drawing.Point(471, 58);
            this.ServiceCarFleetButton.Name = "ServiceCarFleetButton";
            this.ServiceCarFleetButton.Size = new System.Drawing.Size(152, 38);
            this.ServiceCarFleetButton.TabIndex = 9;
            this.ServiceCarFleetButton.Text = "Service Car Fleet";
            this.ServiceCarFleetButton.UseVisualStyleBackColor = true;
            this.ServiceCarFleetButton.Click += new System.EventHandler(this.ServiceCarFleetButton_Click);
            // 
            // JsonToConsoleButton
            // 
            this.JsonToConsoleButton.Location = new System.Drawing.Point(459, 599);
            this.JsonToConsoleButton.Name = "JsonToConsoleButton";
            this.JsonToConsoleButton.Size = new System.Drawing.Size(168, 41);
            this.JsonToConsoleButton.TabIndex = 10;
            this.JsonToConsoleButton.Text = "JSON to Console";
            this.JsonToConsoleButton.UseVisualStyleBackColor = true;
            this.JsonToConsoleButton.Click += new System.EventHandler(this.JsonToConsoleButton_Click);
            // 
            // JsonToFileButton
            // 
            this.JsonToFileButton.Location = new System.Drawing.Point(459, 655);
            this.JsonToFileButton.Name = "JsonToFileButton";
            this.JsonToFileButton.Size = new System.Drawing.Size(168, 41);
            this.JsonToFileButton.TabIndex = 11;
            this.JsonToFileButton.Text = "JSON to File";
            this.JsonToFileButton.UseVisualStyleBackColor = true;
            this.JsonToFileButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormVehicleListService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 748);
            this.Controls.Add(this.JsonToFileButton);
            this.Controls.Add(this.JsonToConsoleButton);
            this.Controls.Add(this.ServiceCarFleetButton);
            this.Controls.Add(this.ServiceTruckFleetButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ServiceCheckVehicleButton);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.ServiceAll);
            this.Controls.Add(this.GoBackButton);
            this.Controls.Add(this.VehicleListView);
            this.Name = "FormVehicleListService";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FormVehicleListService_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GoBackButton;
        private System.Windows.Forms.Button ServiceAll;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RadioButton ShowCarRadio;
        private System.Windows.Forms.RadioButton ShowTruckRadio;
        private System.Windows.Forms.RadioButton ShowAllRadio;
        private System.Windows.Forms.ListView VehicleListView;
        private System.Windows.Forms.ColumnHeader VehicleIDColumn;
        private System.Windows.Forms.ColumnHeader VehicleNameColumn;
        private System.Windows.Forms.Button ServiceCheckVehicleButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ServiceTruckFleetButton;
        private System.Windows.Forms.Button ServiceCarFleetButton;
        private System.Windows.Forms.Button JsonToConsoleButton;
        private System.Windows.Forms.Button JsonToFileButton;
    }
}