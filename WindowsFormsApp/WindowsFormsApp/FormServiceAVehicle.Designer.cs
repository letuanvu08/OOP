
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.listView2 = new System.Windows.Forms.ListView();
            this.BackButton = new System.Windows.Forms.Button();
            this.ServiceAllBtton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Information = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ServiceType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ServiceInfo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Type,
            this.Information});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(29, 104);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(558, 416);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ServiceType,
            this.ServiceInfo});
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(640, 104);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(573, 416);
            this.listView2.TabIndex = 1;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(29, 585);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(121, 37);
            this.BackButton.TabIndex = 2;
            this.BackButton.Text = "Go Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ServiceAllBtton
            // 
            this.ServiceAllBtton.Location = new System.Drawing.Point(374, 526);
            this.ServiceAllBtton.Name = "ServiceAllBtton";
            this.ServiceAllBtton.Size = new System.Drawing.Size(213, 40);
            this.ServiceAllBtton.TabIndex = 3;
            this.ServiceAllBtton.Text = "Apply  Checked Services";
            this.ServiceAllBtton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "List Of Service Available For This Vehicle:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(647, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Service History:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(452, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 38);
            this.button1.TabIndex = 6;
            this.button1.Text = "Check All";
            this.button1.UseVisualStyleBackColor = true;
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
            // ServiceType
            // 
            this.ServiceType.Text = "Service Type";
            // 
            // ServiceInfo
            // 
            this.ServiceInfo.Text = "Service Infomation";
            // 
            // FormServiceAVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 664);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ServiceAllBtton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Name = "FormServiceAVehicle";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button ServiceAllBtton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader Information;
        private System.Windows.Forms.ColumnHeader ServiceType;
        private System.Windows.Forms.ColumnHeader ServiceInfo;
    }
}