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
     partial class Form1 : Form
    {
        CarRentalManagement manage;
        public Form1(CarRentalManagement manage)
        {
            InitializeComponent();
            this.manage = manage;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form = new FormBookAndRent(manage);
            var thread = new Thread(() => Program.start(form));
            thread.Start();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            Form form = new FormManage(manage);
            var thread = new Thread(() => Program.start(form));
            thread.Start();
            this.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            

            Form form = new FormService(manage);
            var thread = new Thread(() => Program.start(form));
            thread.Start();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManageVehicle_Click(object sender, EventArgs e)
        {
            

            Form form = new FormManageVehicle(manage);
            var thread = new Thread(() => Program.start(form));
            thread.Start();
            this.Close();
        }
    }
}