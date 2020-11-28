using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    partial class FormService : Form
    {
        CarRentalManagement manage;
        public FormService(CarRentalManagement manage)
        {
            InitializeComponent();
            this.manage = manage;
        }

        private void Home_Click(object sender, EventArgs e)
        {
            Form formManage = new Form1(this.manage);
            var thread = new Thread(() => Program.Start(formManage));
            thread.Start();
            this.Close();
        }
    }
}
