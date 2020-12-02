
namespace WindowsFormsApp
{
    partial class FormServiceAVehicle
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
<<<<<<< HEAD
            this.listView1 = new System.Windows.Forms.ListView();
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Information = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView2 = new System.Windows.Forms.ListView();
            this.ServiceType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ServiceInfo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
=======
>>>>>>> thinh
            this.BackButton = new System.Windows.Forms.Button();
            this.ServiceCheckedButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
<<<<<<< HEAD
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Type,
            this.Information});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(19, 68);
            this.listView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(373, 272);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Type
            // 
            this.Type.Text = "Service Type";
            this.Type.Width = 100;
            // 
            // Information
            // 
            this.Information.Text = "Additional Information";
            this.Information.Width = 200;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ServiceType,
            this.ServiceInfo});
            this.listView2.FullRowSelect = true;
            this.listView2.GridLines = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(427, 68);
            this.listView2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(383, 272);
            this.listView2.TabIndex = 1;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // ServiceType
            // 
            this.ServiceType.Text = "Service Type";
            // 
            // ServiceInfo
            // 
            this.ServiceInfo.Text = "Service Infomation";
            // 
=======
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.EngineStateComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TranmissionStateComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TiresStateComboBox = new System.Windows.Forms.ComboBox();
            this.ServicesAvailableList = new System.Windows.Forms.ListView();
            this.VehicleIDColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.VehicleNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ServiceHistoryListView = new System.Windows.Forms.ListView();
            this.DateTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button2 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
>>>>>>> thinh
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(19, 380);
            this.BackButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(81, 24);
            this.BackButton.TabIndex = 2;
            this.BackButton.Text = "Go Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ServiceCheckedButton
            // 
<<<<<<< HEAD
            this.ServiceAllBtton.Location = new System.Drawing.Point(249, 342);
            this.ServiceAllBtton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ServiceAllBtton.Name = "ServiceAllBtton";
            this.ServiceAllBtton.Size = new System.Drawing.Size(142, 26);
            this.ServiceAllBtton.TabIndex = 3;
            this.ServiceAllBtton.Text = "Apply  Checked Services";
            this.ServiceAllBtton.UseVisualStyleBackColor = true;
=======
            this.ServiceCheckedButton.Location = new System.Drawing.Point(374, 531);
            this.ServiceCheckedButton.Name = "ServiceCheckedButton";
            this.ServiceCheckedButton.Size = new System.Drawing.Size(213, 40);
            this.ServiceCheckedButton.TabIndex = 3;
            this.ServiceCheckedButton.Text = "Apply  Checked Services";
            this.ServiceCheckedButton.UseVisualStyleBackColor = true;
            this.ServiceCheckedButton.Click += new System.EventHandler(this.ServiceCheckedButton_Click);
>>>>>>> thinh
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "List Of Service Available For This Vehicle:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(431, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Service History:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(301, 39);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 25);
            this.button1.TabIndex = 6;
            this.button1.Text = "Check All";
            this.button1.UseVisualStyleBackColor = true;
            // 
<<<<<<< HEAD
=======
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.EngineStateComboBox);
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Controls.Add(this.TranmissionStateComboBox);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.TiresStateComboBox);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(651, 540);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(372, 124);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Set Engine State:";
            // 
            // EngineStateComboBox
            // 
            this.EngineStateComboBox.FormattingEnabled = true;
            this.EngineStateComboBox.Location = new System.Drawing.Point(144, 3);
            this.EngineStateComboBox.Name = "EngineStateComboBox";
            this.EngineStateComboBox.Size = new System.Drawing.Size(213, 28);
            this.EngineStateComboBox.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Set Tranmission State:";
            // 
            // TranmissionStateComboBox
            // 
            this.TranmissionStateComboBox.FormattingEnabled = true;
            this.TranmissionStateComboBox.Location = new System.Drawing.Point(179, 37);
            this.TranmissionStateComboBox.Name = "TranmissionStateComboBox";
            this.TranmissionStateComboBox.Size = new System.Drawing.Size(178, 28);
            this.TranmissionStateComboBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Set Tires State";
            // 
            // TiresStateComboBox
            // 
            this.TiresStateComboBox.FormattingEnabled = true;
            this.TiresStateComboBox.Location = new System.Drawing.Point(124, 71);
            this.TiresStateComboBox.Name = "TiresStateComboBox";
            this.TiresStateComboBox.Size = new System.Drawing.Size(233, 28);
            this.TiresStateComboBox.TabIndex = 2;
            this.TiresStateComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // ServicesAvailableList
            // 
            this.ServicesAvailableList.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ServicesAvailableList.CheckBoxes = true;
            this.ServicesAvailableList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.VehicleIDColumn,
            this.VehicleNameColumn});
            this.ServicesAvailableList.GridLines = true;
            this.ServicesAvailableList.HideSelection = false;
            this.ServicesAvailableList.Location = new System.Drawing.Point(12, 104);
            this.ServicesAvailableList.Name = "ServicesAvailableList";
            this.ServicesAvailableList.Size = new System.Drawing.Size(575, 416);
            this.ServicesAvailableList.TabIndex = 6;
            this.ServicesAvailableList.UseCompatibleStateImageBehavior = false;
            this.ServicesAvailableList.View = System.Windows.Forms.View.Details;
            // 
            // VehicleIDColumn
            // 
            this.VehicleIDColumn.Text = "Type";
            this.VehicleIDColumn.Width = 100;
            // 
            // VehicleNameColumn
            // 
            this.VehicleNameColumn.Text = "Message";
            this.VehicleNameColumn.Width = 600;
            // 
            // ServiceHistoryListView
            // 
            this.ServiceHistoryListView.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ServiceHistoryListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DateTime,
            this.Type,
            this.columnHeader2});
            this.ServiceHistoryListView.GridLines = true;
            this.ServiceHistoryListView.HideSelection = false;
            this.ServiceHistoryListView.Location = new System.Drawing.Point(634, 104);
            this.ServiceHistoryListView.Name = "ServiceHistoryListView";
            this.ServiceHistoryListView.Size = new System.Drawing.Size(579, 419);
            this.ServiceHistoryListView.TabIndex = 8;
            this.ServiceHistoryListView.UseCompatibleStateImageBehavior = false;
            this.ServiceHistoryListView.View = System.Windows.Forms.View.Details;
            // 
            // DateTime
            // 
            this.DateTime.Text = "DateTime:";
            this.DateTime.Width = 115;
            // 
            // Type
            // 
            this.Type.Text = "Type";
            this.Type.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Message";
            this.columnHeader2.Width = 360;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1029, 588);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 34);
            this.button2.TabIndex = 9;
            this.button2.Text = "Reload";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.reloadButton_Click);
            // 
>>>>>>> thinh
            // FormServiceAVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(817, 518);
=======
            this.ClientSize = new System.Drawing.Size(1225, 667);
            this.Controls.Add(this.ServiceHistoryListView);
            this.Controls.Add(this.flowLayoutPanel1);
>>>>>>> thinh
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ServiceCheckedButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BackButton);
<<<<<<< HEAD
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
=======
            this.Controls.Add(this.ServicesAvailableList);
>>>>>>> thinh
            this.Name = "FormServiceAVehicle";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button ServiceCheckedButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox EngineStateComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox TranmissionStateComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox TiresStateComboBox;
        private System.Windows.Forms.ListView ServicesAvailableList;
        private System.Windows.Forms.ColumnHeader VehicleIDColumn;
        private System.Windows.Forms.ColumnHeader VehicleNameColumn;
        private System.Windows.Forms.ListView ServiceHistoryListView;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader DateTime;
        private System.Windows.Forms.Button button2;
    }
}