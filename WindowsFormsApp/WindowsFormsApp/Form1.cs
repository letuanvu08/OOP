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
            FormBookAndRent formbook = new FormBookAndRent(manage);
            var thread = new Thread(()=>Program.Start( formbook));
            thread.Start();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormManage formManage = new FormManage(manage);
            var thread = new Thread(() => Program.Start(formManage));
            thread.Start();
            this.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormService formManage = new FormService(manage);
            var thread = new Thread(() => Program.Start(formManage));
            thread.Start();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManageVehicle_Click(object sender, EventArgs e)
        {
            Form formManage = new FormManageVehicle(manage);
            var thread = new Thread(() => Program.Start(formManage));
            thread.Start();
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}