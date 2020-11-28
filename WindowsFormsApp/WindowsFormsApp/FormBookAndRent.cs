using MySql.Data.MySqlClient;
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
    partial class FormBookAndRent : Form
    {
        
        CarRentalManagement manage;
        string nameVehicleSelected;
        public FormBookAndRent(CarRentalManagement Mamage)
        {
            InitializeComponent();
            panel2.Enabled = false;
            this.manage = Mamage;
            
        }
        
  

      

        private void button2_Click(object sender, EventArgs e)
        {
            if (typeVehicle.SelectedItem != null && branchVehicle.SelectedItem != null)
            {
                panel2.Enabled = true;
                listResult.Items.Clear();
                string Branch = branchVehicle.SelectedItem.ToString();
            
                   string type =  typeVehicle.SelectedItem.ToString();
                    List<Vehicle> listcar = manage.FindCarAvailable(type, Branch);
               
           

                DateTime start = startRent.Value.Date;
                DateTime end = EndRent.Value.Date;
                double days=(end-start).TotalDays;
                List<ListViewItem> listitem = new List<ListViewItem>();
                foreach (Vehicle vehicle in listcar)
                {
                    listResult.ResetText();
                    listitem.Add(new ListViewItem(vehicle.Name));
                    listitem[listitem.Count-1].SubItems.Add(new ListViewItem.ListViewSubItem() { Text = vehicle.StateUsed.ToString() });
                    listitem[listitem.Count - 1].SubItems.Add(new ListViewItem.ListViewSubItem() { Text = (vehicle.CostPerDay*days).ToString() });


                    listResult.Items.Add(listitem[listitem.Count - 1]);
                }
            }
            else
            {
                MessageBox.Show("Fill form before Find");
            }
        }

    

        private void button1_Click(object sender, EventArgs e)
        {
            if (nameVehicleSelected == "")
            { MessageBox.Show("Please, Choose Vehicle Your want Rent."); }
           
            else
            {
                Vehicle vehicleSelected = manage.FindVehicle(this.nameVehicleSelected);
                if (vehicleSelected.StateUsed == true)
                    MessageBox.Show("Vehicle not Available, please choose other vehicle.");
                else if (vehicleSelected.Maintain == true)
                    MessageBox.Show("Vehicle having repair, please choose other vehicle.");
                else
                {
                    DateTime start = startRent.Value.Date;
                    DateTime end = EndRent.Value.Date;
                    double days = (end - start).TotalDays;
                    RentContract contract = new RentContract(vehicle: vehicleSelected, DateStartRent: startRent.Value.Date, DateEndRent: EndRent.Value.Date, totalCost: (vehicleSelected.CostPerDay * (int)days));
                    FormRentContract formManage = new FormRentContract(contract);
                    var thread = new Thread(() => Program.Start(formManage));
                    thread.Start();
                }
            }

            }

        private void Home_Click(object sender, EventArgs e)
        {
            Form formManage = new Form1(this.manage);
            var thread = new Thread(() => Program.Start(formManage));
            thread.Start();
            this.Close();
        }

        private void listResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
            ListView lsv = sender as ListView;
            if (lsv.SelectedItems.Count > 0)
            {
                ListViewItem item = lsv.SelectedItems[0];
                nameVehicleSelected = item.Text;
               
            }
        }

        private void radioCar_CheckedChanged(object sender, EventArgs e)
        {
            branchVehicle.Items.Clear();
            typeVehicle.Items.Clear();
            List<string> listbranch = manage.GetlistBranch("car");
            List<string> listtype = manage.GetlistType("car");
            foreach (var i in listbranch)
            {
                branchVehicle.Items.Add(i);
            }
            foreach (var i in listtype)
            {
                typeVehicle.Items.Add(i);
            }
        }

        private void radioTruck_CheckedChanged(object sender, EventArgs e)
        {
            branchVehicle.Items.Clear();
            typeVehicle.Items.Clear();
            List<string> listbranch = manage.GetlistBranch("truck");
            List<string> listtype = manage.GetlistType("truck");
            foreach (var i in listbranch)
            {
                branchVehicle.Items.Add(i);
            }
            foreach (var i in listtype)
            {
                typeVehicle.Items.Add(i);
            }
        }
    }
}
