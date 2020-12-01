using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;
using System.Threading;

namespace WindowsFormsApp
{
    partial class FormVehicleListService : Form
    {
        CarRentalManagement manager;
        public FormVehicleListService(CarRentalManagement managerInstance)
        {   
            InitializeComponent();
            this.manager = managerInstance;
        }

        private void ServiceAll_Click(object sender, EventArgs e)
        {
            // This button will iterate throught all vehicle and aplly the needed services on each vehicle.
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            Form formManage = new FormMainMenu(this.manager);
            var thread = new Thread(() => Program.Start(formManage));
            thread.Start();
            this.Close();
        }
    }
}
