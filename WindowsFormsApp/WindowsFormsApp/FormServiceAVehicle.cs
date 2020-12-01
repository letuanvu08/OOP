using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading; 


namespace WindowsFormsApp
{    
    partial class FormServiceAVehicle : Form
    {
        private CarRentalManagement manager;
        private Vehicle vehicleNeedServicing;
        public FormServiceAVehicle(CarRentalManagement mangerInstance, Vehicle vehicleInstance)
        {
            InitializeComponent();
            this.manager = mangerInstance;
            this.vehicleNeedServicing = vehicleInstance;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Form formManage = new FormVehicleListService(this.manager);
            var thread = new Thread(() => Program.Start(formManage));
            thread.Start();
            this.Close();
        }
    }
}
