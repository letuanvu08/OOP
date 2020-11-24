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
     partial class FormManage : Form
    {
        CarRentalManagement manage;
        List<RentContract> listCarContracts;
        List<RentContract> listTruckContracts;
        public FormManage(CarRentalManagement manage)
        {
            InitializeComponent();
            this.manage = manage;
            this.listCarContracts= manage.GetCarRelatedConTracts();
            this.listTruckContracts= manage.GetTruckRelatedConTracts();
            setUpGUI();
        }
        // This will populate the box with all the Contracts when the form is first opened
        private void setUpGUI()
        {
            /*
            ContractList.Columns.Add("MyColumn", -2, HorizontalAlignment.Left);
            ContractList.FullRowSelect = true;
            ContractList.GridLines = true;
            ContractList.View = System.Windows.Forms.View.List; */
            // ID NUmber need to be initilaized in constructor. This is just to test the GUI: 
            DisplayCarContracts();
            DisplayTruckContracts();
            
        }

        private void DisplayCarContracts()
        {
            foreach (RentContract contract in listCarContracts)
            {
                // Creat a group box to add to list View 
                //string[] briefContract = { contract.Id.ToString(), contract.VehicleRented.idVehicle.ToString() };
                //var briefContractItem = new ListViewItem(briefContract);
                //ContractList.Items.Add(briefContractItem);

                ListViewItem briefContractItem = new ListViewItem(contract.Id.ToString());
                ListViewItem.ListViewSubItem carId = new ListViewItem.ListViewSubItem(briefContractItem, contract.VehicleRented.idVehicle.ToString());
                briefContractItem.SubItems.Add(carId);
                ContractList.Items.Add(briefContractItem);
            }
        }
        private void DisplayTruckContracts()
        {
            foreach (RentContract contract in listTruckContracts)
            {
                // Creat a group box to add to list View 
                ListViewItem briefContractItem = new ListViewItem(contract.Id.ToString());
                ListViewItem.ListViewSubItem truckId = new ListViewItem.ListViewSubItem(briefContractItem, contract.VehicleRented.idVehicle.ToString());
                briefContractItem.SubItems.Add(truckId);
                ContractList.Items.Add(briefContractItem);
            }
        }
        private void Home_Click(object sender, EventArgs e)
        {
            Form formManage = new Form1(this.manage);
            var thread = new Thread(() => Program.start(formManage));
            thread.Start();
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ContractList.Items.Clear();
            DisplayCarContracts();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            ContractList.Items.Clear();
            DisplayTruckContracts();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void FormManage_Load(object sender, EventArgs e)
        {

        }
    }
}
