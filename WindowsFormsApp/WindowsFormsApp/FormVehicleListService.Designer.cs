
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.ServiceAll = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.CarCheckBox = new System.Windows.Forms.CheckBox();
            this.TruckCheckBox = new System.Windows.Forms.CheckBox();
            this.AllCheckBox = new System.Windows.Forms.CheckBox();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.VehicleName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.VehicleName});
            this.listView1.Enabled = false;
            this.listView1.ForeColor = System.Drawing.Color.Wheat;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(29, 143);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(548, 478);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // ServiceAll
            // 
            this.ServiceAll.Location = new System.Drawing.Point(440, 83);
            this.ServiceAll.Name = "ServiceAll";
            this.ServiceAll.Size = new System.Drawing.Size(137, 38);
            this.ServiceAll.TabIndex = 3;
            this.ServiceAll.Text = "Service All";
            this.ServiceAll.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.CarCheckBox);
            this.flowLayoutPanel1.Controls.Add(this.TruckCheckBox);
            this.flowLayoutPanel1.Controls.Add(this.AllCheckBox);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(29, 27);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(197, 94);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // CarCheckBox
            // 
            this.CarCheckBox.AutoSize = true;
            this.CarCheckBox.Location = new System.Drawing.Point(3, 3);
            this.CarCheckBox.Name = "CarCheckBox";
            this.CarCheckBox.Size = new System.Drawing.Size(168, 24);
            this.CarCheckBox.TabIndex = 0;
            this.CarCheckBox.Text = "Show Car Vehicles";
            this.CarCheckBox.UseVisualStyleBackColor = true;
            // 
            // TruckCheckBox
            // 
            this.TruckCheckBox.AutoSize = true;
            this.TruckCheckBox.Location = new System.Drawing.Point(3, 33);
            this.TruckCheckBox.Name = "TruckCheckBox";
            this.TruckCheckBox.Size = new System.Drawing.Size(174, 24);
            this.TruckCheckBox.TabIndex = 1;
            this.TruckCheckBox.Text = "Show Truck Vehicle";
            this.TruckCheckBox.UseVisualStyleBackColor = true;
            // 
            // AllCheckBox
            // 
            this.AllCheckBox.AutoSize = true;
            this.AllCheckBox.Location = new System.Drawing.Point(3, 63);
            this.AllCheckBox.Name = "AllCheckBox";
            this.AllCheckBox.Size = new System.Drawing.Size(160, 24);
            this.AllCheckBox.TabIndex = 2;
            this.AllCheckBox.Text = "Show All Vehicles";
            this.AllCheckBox.UseVisualStyleBackColor = true;
            // 
            // ID
            // 
            this.ID.Text = "Vehicle ID";
            // 
            // VehicleName
            // 
            this.VehicleName.Text = "Vehicle Name";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 748);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.ServiceAll);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.GoBackButton);
            this.Name = "Form2";
            this.Text = "Form2";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GoBackButton;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader VehicleName;
        private System.Windows.Forms.Button ServiceAll;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.CheckBox CarCheckBox;
        private System.Windows.Forms.CheckBox TruckCheckBox;
        private System.Windows.Forms.CheckBox AllCheckBox;
    }
}