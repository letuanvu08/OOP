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
            this.panellistvehilce = new System.Windows.Forms.Panel();
            this.listResult = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.panelstatusview = new System.Windows.Forms.Panel();
            this.maintainvehicleview = new System.Windows.Forms.CheckBox();
            this.statusvehicleview = new System.Windows.Forms.CheckBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.Kilometer = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.registration = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.paneltypevehicle = new System.Windows.Forms.Panel();
            this.typeVehicledetail = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.BranchVehicle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.paneltypevehicleview = new System.Windows.Forms.Panel();
            this.RadioCarDetail = new System.Windows.Forms.RadioButton();
            this.RadioTruckDetail = new System.Windows.Forms.RadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.NameVehicle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtChange = new System.Windows.Forms.Button();
            this.btAddVehicle = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.Cancelview = new System.Windows.Forms.Button();
            this.panellistvehilce.SuspendLayout();
            this.panel3.SuspendLayout();
            this.PanelDetail.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panelstatusview.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.paneltypevehicle.SuspendLayout();
            this.panel6.SuspendLayout();
            this.paneltypevehicleview.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Home
            // 
            this.Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home.Location = new System.Drawing.Point(576, 798);
            this.Home.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(112, 35);
            this.Home.TabIndex = 0;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // panellistvehilce
            // 
            this.panellistvehilce.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panellistvehilce.Controls.Add(this.listResult);
            this.panellistvehilce.Controls.Add(this.panel3);
            this.panellistvehilce.Location = new System.Drawing.Point(18, 108);
            this.panellistvehilce.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panellistvehilce.Name = "panellistvehilce";
            this.panellistvehilce.Size = new System.Drawing.Size(582, 602);
            this.panellistvehilce.TabIndex = 1;
            this.panellistvehilce.Paint += new System.Windows.Forms.PaintEventHandler(this.panellistvehilce_Paint);
            // 
            // listResult
            // 
            this.listResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.NameColumn,
            this.Branch,
            this.type});
            this.listResult.GridLines = true;
            this.listResult.HideSelection = false;
            this.listResult.Location = new System.Drawing.Point(21, 60);
            this.listResult.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listResult.Name = "listResult";
            this.listResult.Size = new System.Drawing.Size(536, 522);
            this.listResult.TabIndex = 5;
            this.listResult.UseCompatibleStateImageBehavior = false;
            this.listResult.View = System.Windows.Forms.View.Details;
            this.listResult.SelectedIndexChanged += new System.EventHandler(this.listResult_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 73;
            // 
            // NameColumn
            // 
            this.NameColumn.Text = "Name";
            this.NameColumn.Width = 116;
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
            this.panel3.Location = new System.Drawing.Point(21, 5);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(538, 44);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // RadioTruckview
            // 
            this.RadioTruckview.AutoSize = true;
            this.RadioTruckview.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioTruckview.Location = new System.Drawing.Point(324, 5);
            this.RadioTruckview.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RadioTruckview.Name = "RadioTruckview";
            this.RadioTruckview.Size = new System.Drawing.Size(87, 29);
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
            this.RadioCarview.Location = new System.Drawing.Point(44, 5);
            this.RadioCarview.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RadioCarview.Name = "RadioCarview";
            this.RadioCarview.Size = new System.Drawing.Size(69, 29);
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
            this.PanelDetail.Controls.Add(this.panelstatusview);
            this.PanelDetail.Controls.Add(this.panel9);
            this.PanelDetail.Controls.Add(this.panel8);
            this.PanelDetail.Controls.Add(this.paneltypevehicle);
            this.PanelDetail.Controls.Add(this.panel6);
            this.PanelDetail.Controls.Add(this.paneltypevehicleview);
            this.PanelDetail.Controls.Add(this.panel4);
            this.PanelDetail.Location = new System.Drawing.Point(662, 108);
            this.PanelDetail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PanelDetail.Name = "PanelDetail";
            this.PanelDetail.Size = new System.Drawing.Size(622, 597);
            this.PanelDetail.TabIndex = 2;
            // 
            // panel12
            // 
            this.panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel12.Controls.Add(this.costperdatetext);
            this.panel12.Controls.Add(this.label9);
            this.panel12.Location = new System.Drawing.Point(24, 400);
            this.panel12.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(586, 80);
            this.panel12.TabIndex = 15;
            // 
            // costperdatetext
            // 
            this.costperdatetext.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.costperdatetext.Location = new System.Drawing.Point(18, 46);
            this.costperdatetext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.costperdatetext.Name = "costperdatetext";
            this.costperdatetext.ReadOnly = true;
            this.costperdatetext.Size = new System.Drawing.Size(556, 26);
            this.costperdatetext.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(18, 14);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(170, 27);
            this.label9.TabIndex = 9;
            this.label9.Text = "Cost Rent per day";
            // 
            // panel11
            // 
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel11.Controls.Add(this.descriptiontext);
            this.panel11.Controls.Add(this.label8);
            this.panel11.Location = new System.Drawing.Point(24, 491);
            this.panel11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(586, 87);
            this.panel11.TabIndex = 14;
            // 
            // descriptiontext
            // 
            this.descriptiontext.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.descriptiontext.Location = new System.Drawing.Point(18, 46);
            this.descriptiontext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.descriptiontext.Name = "descriptiontext";
            this.descriptiontext.ReadOnly = true;
            this.descriptiontext.Size = new System.Drawing.Size(556, 26);
            this.descriptiontext.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 14);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(181, 27);
            this.label8.TabIndex = 9;
            this.label8.Text = "Description Vehicle";
            // 
            // panelstatusview
            // 
            this.panelstatusview.Controls.Add(this.maintainvehicleview);
            this.panelstatusview.Controls.Add(this.statusvehicleview);
            this.panelstatusview.Enabled = false;
            this.panelstatusview.Location = new System.Drawing.Point(444, 303);
            this.panelstatusview.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelstatusview.Name = "panelstatusview";
            this.panelstatusview.Size = new System.Drawing.Size(166, 88);
            this.panelstatusview.TabIndex = 14;
            // 
            // maintainvehicleview
            // 
            this.maintainvehicleview.AutoSize = true;
            this.maintainvehicleview.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maintainvehicleview.Location = new System.Drawing.Point(16, 48);
            this.maintainvehicleview.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.maintainvehicleview.Name = "maintainvehicleview";
            this.maintainvehicleview.Size = new System.Drawing.Size(112, 29);
            this.maintainvehicleview.TabIndex = 1;
            this.maintainvehicleview.Text = "Maintain";
            this.maintainvehicleview.UseVisualStyleBackColor = true;
            // 
            // statusvehicleview
            // 
            this.statusvehicleview.AutoSize = true;
            this.statusvehicleview.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusvehicleview.Location = new System.Drawing.Point(16, 11);
            this.statusvehicleview.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.statusvehicleview.Name = "statusvehicleview";
            this.statusvehicleview.Size = new System.Drawing.Size(140, 29);
            this.statusvehicleview.TabIndex = 0;
            this.statusvehicleview.Text = "StatusUsed";
            this.statusvehicleview.UseVisualStyleBackColor = true;
            // 
            // panel9
            // 
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.Kilometer);
            this.panel9.Controls.Add(this.label7);
            this.panel9.Location = new System.Drawing.Point(24, 303);
            this.panel9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(400, 87);
            this.panel9.TabIndex = 13;
            // 
            // Kilometer
            // 
            this.Kilometer.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Kilometer.Location = new System.Drawing.Point(18, 46);
            this.Kilometer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Kilometer.Name = "Kilometer";
            this.Kilometer.ReadOnly = true;
            this.Kilometer.Size = new System.Drawing.Size(556, 26);
            this.Kilometer.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 14);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 27);
            this.label7.TabIndex = 9;
            this.label7.Text = "NumberKilometer";
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.registration);
            this.panel8.Controls.Add(this.label6);
            this.panel8.Location = new System.Drawing.Point(24, 206);
            this.panel8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(586, 87);
            this.panel8.TabIndex = 12;
            // 
            // registration
            // 
            this.registration.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.registration.Location = new System.Drawing.Point(18, 46);
            this.registration.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.registration.Name = "registration";
            this.registration.ReadOnly = true;
            this.registration.Size = new System.Drawing.Size(538, 26);
            this.registration.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 14);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(212, 27);
            this.label6.TabIndex = 9;
            this.label6.Text = "car registration number";
            // 
            // paneltypevehicle
            // 
            this.paneltypevehicle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneltypevehicle.Controls.Add(this.typeVehicledetail);
            this.paneltypevehicle.Controls.Add(this.label5);
            this.paneltypevehicle.Enabled = false;
            this.paneltypevehicle.Location = new System.Drawing.Point(374, 109);
            this.paneltypevehicle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.paneltypevehicle.Name = "paneltypevehicle";
            this.paneltypevehicle.Size = new System.Drawing.Size(236, 87);
            this.paneltypevehicle.TabIndex = 12;
            // 
            // typeVehicledetail
            // 
            this.typeVehicledetail.FormattingEnabled = true;
            this.typeVehicledetail.Location = new System.Drawing.Point(18, 45);
            this.typeVehicledetail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.typeVehicledetail.Name = "typeVehicledetail";
            this.typeVehicledetail.Size = new System.Drawing.Size(206, 28);
            this.typeVehicledetail.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 14);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 27);
            this.label5.TabIndex = 9;
            this.label5.Text = "Type Vehicle";
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.BranchVehicle);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Location = new System.Drawing.Point(24, 109);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(340, 87);
            this.panel6.TabIndex = 11;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // BranchVehicle
            // 
            this.BranchVehicle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BranchVehicle.Location = new System.Drawing.Point(18, 46);
            this.BranchVehicle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BranchVehicle.Name = "BranchVehicle";
            this.BranchVehicle.ReadOnly = true;
            this.BranchVehicle.Size = new System.Drawing.Size(276, 26);
            this.BranchVehicle.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 14);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 27);
            this.label4.TabIndex = 9;
            this.label4.Text = "Branch Vehicle";
            // 
            // paneltypevehicleview
            // 
            this.paneltypevehicleview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneltypevehicleview.Controls.Add(this.RadioCarDetail);
            this.paneltypevehicleview.Controls.Add(this.RadioTruckDetail);
            this.paneltypevehicleview.Enabled = false;
            this.paneltypevehicleview.Location = new System.Drawing.Point(483, 6);
            this.paneltypevehicleview.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.paneltypevehicleview.Name = "paneltypevehicleview";
            this.paneltypevehicleview.Size = new System.Drawing.Size(126, 82);
            this.paneltypevehicleview.TabIndex = 3;
            // 
            // RadioCarDetail
            // 
            this.RadioCarDetail.AutoSize = true;
            this.RadioCarDetail.Location = new System.Drawing.Point(38, 5);
            this.RadioCarDetail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RadioCarDetail.Name = "RadioCarDetail";
            this.RadioCarDetail.Size = new System.Drawing.Size(59, 24);
            this.RadioCarDetail.TabIndex = 1;
            this.RadioCarDetail.Text = "Car";
            this.RadioCarDetail.UseVisualStyleBackColor = true;
            this.RadioCarDetail.CheckedChanged += new System.EventHandler(this.RadioCarDetail_CheckedChanged);
            // 
            // RadioTruckDetail
            // 
            this.RadioTruckDetail.AutoSize = true;
            this.RadioTruckDetail.Checked = true;
            this.RadioTruckDetail.Location = new System.Drawing.Point(38, 40);
            this.RadioTruckDetail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RadioTruckDetail.Name = "RadioTruckDetail";
            this.RadioTruckDetail.Size = new System.Drawing.Size(73, 24);
            this.RadioTruckDetail.TabIndex = 0;
            this.RadioTruckDetail.TabStop = true;
            this.RadioTruckDetail.Text = "Truck";
            this.RadioTruckDetail.UseVisualStyleBackColor = true;
            this.RadioTruckDetail.CheckedChanged += new System.EventHandler(this.RadioTruckDetail_CheckedChanged);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.NameVehicle);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(24, 12);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(449, 87);
            this.panel4.TabIndex = 10;
            // 
            // NameVehicle
            // 
            this.NameVehicle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NameVehicle.Location = new System.Drawing.Point(18, 46);
            this.NameVehicle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NameVehicle.Name = "NameVehicle";
            this.NameVehicle.ReadOnly = true;
            this.NameVehicle.Size = new System.Drawing.Size(426, 26);
            this.NameVehicle.TabIndex = 10;
            this.NameVehicle.TextChanged += new System.EventHandler(this.NameVehicle_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 27);
            this.label3.TabIndex = 9;
            this.label3.Text = "Name Vehicle";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(180, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "List Vehicle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(894, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 39);
            this.label2.TabIndex = 4;
            this.label2.Text = "Vehicle Detail";
            // 
            // BtChange
            // 
            this.BtChange.Enabled = false;
            this.BtChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtChange.Location = new System.Drawing.Point(858, 720);
            this.BtChange.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtChange.Name = "BtChange";
            this.BtChange.Size = new System.Drawing.Size(144, 48);
            this.BtChange.TabIndex = 6;
            this.BtChange.Text = "Change";
            this.BtChange.UseVisualStyleBackColor = true;
            this.BtChange.Click += new System.EventHandler(this.BtChange_Click);
            // 
            // btAddVehicle
            // 
            this.btAddVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddVehicle.Location = new System.Drawing.Point(658, 720);
            this.btAddVehicle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btAddVehicle.Name = "btAddVehicle";
            this.btAddVehicle.Size = new System.Drawing.Size(190, 48);
            this.btAddVehicle.TabIndex = 7;
            this.btAddVehicle.Text = "Add New Vehicle";
            this.btAddVehicle.UseVisualStyleBackColor = true;
            this.btAddVehicle.Click += new System.EventHandler(this.btAddVehicle_Click);
            // 
            // btSave
            // 
            this.btSave.Enabled = false;
            this.btSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSave.Location = new System.Drawing.Point(1011, 720);
            this.btSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(144, 48);
            this.btSave.TabIndex = 8;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // Cancelview
            // 
            this.Cancelview.Location = new System.Drawing.Point(1172, 720);
            this.Cancelview.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Cancelview.Name = "Cancelview";
            this.Cancelview.Size = new System.Drawing.Size(112, 48);
            this.Cancelview.TabIndex = 9;
            this.Cancelview.Text = "Cancel";
            this.Cancelview.UseVisualStyleBackColor = true;
            this.Cancelview.Click += new System.EventHandler(this.Cancelview_Click);
            // 
            // FormManageVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 852);
            this.Controls.Add(this.Cancelview);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btAddVehicle);
            this.Controls.Add(this.BtChange);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PanelDetail);
            this.Controls.Add(this.panellistvehilce);
            this.Controls.Add(this.Home);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormManageVehicle";
            this.Text = "FormManageVehicle";
            this.Load += new System.EventHandler(this.FormManageVehicle_Load);
            this.panellistvehilce.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.PanelDetail.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panelstatusview.ResumeLayout(false);
            this.panelstatusview.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.paneltypevehicle.ResumeLayout(false);
            this.paneltypevehicle.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.paneltypevehicleview.ResumeLayout(false);
            this.paneltypevehicleview.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.Panel panellistvehilce;
        private System.Windows.Forms.Panel PanelDetail;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton RadioTruckview;
        private System.Windows.Forms.RadioButton RadioCarview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtChange;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox registration;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel paneltypevehicle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox BranchVehicle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel paneltypevehicleview;
        private System.Windows.Forms.RadioButton RadioCarDetail;
        private System.Windows.Forms.RadioButton RadioTruckDetail;
        private System.Windows.Forms.TextBox NameVehicle;
        private System.Windows.Forms.ComboBox typeVehicledetail;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox Kilometer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.TextBox costperdatetext;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.TextBox descriptiontext;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panelstatusview;
        private System.Windows.Forms.CheckBox maintainvehicleview;
        private System.Windows.Forms.CheckBox statusvehicleview;
        private System.Windows.Forms.ListView listResult;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader NameColumn;
        private System.Windows.Forms.ColumnHeader Branch;
        private System.Windows.Forms.ColumnHeader type;
        private System.Windows.Forms.Button btAddVehicle;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button Cancelview;
    }
}