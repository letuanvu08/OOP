
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
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(29, 104);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(558, 416);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // listView2
            // 
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(640, 104);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(573, 416);
            this.listView2.TabIndex = 1;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(29, 572);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(121, 37);
            this.BackButton.TabIndex = 2;
            this.BackButton.Text = "Go Back";
            this.BackButton.UseVisualStyleBackColor = true;
            // 
            // ServiceAllBtton
            // 
            this.ServiceAllBtton.Location = new System.Drawing.Point(456, 47);
            this.ServiceAllBtton.Name = "ServiceAllBtton";
            this.ServiceAllBtton.Size = new System.Drawing.Size(131, 40);
            this.ServiceAllBtton.TabIndex = 3;
            this.ServiceAllBtton.Text = "button1";
            this.ServiceAllBtton.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 664);
            this.Controls.Add(this.ServiceAllBtton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button ServiceAllBtton;
    }
}