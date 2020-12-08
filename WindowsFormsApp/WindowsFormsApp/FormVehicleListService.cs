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
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Converters;
using System.IO;
//using System.Text.Json;
//using System.Text.Json.Serialization;

namespace WindowsFormsApp
{
    partial class FormVehicleListService : Form
    {
        VehicleRentalManagement manager;
        public FormVehicleListService(VehicleRentalManagement managerInstance)
        {   
            InitializeComponent();
            this.manager = managerInstance;
            VehicleListView.MouseDoubleClick += new MouseEventHandler(VehicleListView_MouseDoubleClick);
            DisplayAllVehicle();

        }
        private void DisplayAllVehicle()
        {
            DisplayCarVehicle();
            DisplayTruckVehicle();
        }
        private void DisplayCarVehicle()
        {
            //updateDataChange();
            //foreach (RentContract contract in listCarContracts)
            //{
            //    string[] briefContractInfo = new string[6];
            //    (briefContractInfo[0], briefContractInfo[1], briefContractInfo[2], briefContractInfo[3], briefContractInfo[4], briefContractInfo[5]) = getContractInfomation(contract);
            //    if (!contract.IsApproved) ContractList.Items.Add(new ListViewItem(briefContractInfo));
            //    else ApprovedContractList.Items.Add(new ListViewItem(briefContractInfo));

            //}
            foreach (Vehicle v in manager.GetListVehicle("car"))
            {
                string[] briefVehicleInfo = new string[2];
                briefVehicleInfo[0] = v.IdVehicle.ToString();
                briefVehicleInfo[1] = v.Name;
                VehicleListView.Items.Add(new ListViewItem(briefVehicleInfo));
            }

        }
        private void DisplayTruckVehicle()
        {
            foreach (Vehicle v in manager.GetListVehicle("truck"))
            {
                string[] briefVehicleInfo = new string[2];
                briefVehicleInfo[0] = v.IdVehicle.ToString();
                briefVehicleInfo[1] = v.Name;
                VehicleListView.Items.Add(new ListViewItem(briefVehicleInfo));
            }
        }
        private void ServiceAll_Click(object sender, EventArgs e)
        {
            // This button will iterate throught all vehicle and aplly the needed services on each vehicle.
            this.manager.ServiceFleet();
            MessageBox.Show("All vehicle is now serviced");
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            Form formManage = new FormMainMenu(this.manager);
            var thread = new Thread(() => Program.Start(formManage));
            thread.Start();
            this.Close();
        }


        private void ContractList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ShowCarRadio_CheckedChanged(object sender, EventArgs e)
        {
            VehicleListView.Items.Clear();
            DisplayCarVehicle();
        }

        private void ShowTruckRadio_CheckedChanged(object sender, EventArgs e)
        {
            VehicleListView.Items.Clear();
            DisplayTruckVehicle();
        }

        private void ShowAllRadio_CheckedChanged(object sender, EventArgs e)
        {
            VehicleListView.Items.Clear();
            DisplayAllVehicle();
        }
        private void VehicleListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo listViewHitTestInfo = VehicleListView.HitTest(e.X, e.Y);
            ListViewItem ClickedItem = listViewHitTestInfo.Item;
            if (ClickedItem != null)
            {
                int vehicleID = int.Parse(ClickedItem.SubItems[0].Text);
                Vehicle vehicle = manager.FindVehiclebyId(vehicleID);
                FormServiceAVehicle formServiceAVehicle = new FormServiceAVehicle(this.manager, vehicle);
                var thread = new Thread(() => Program.Start(formServiceAVehicle));
                thread.Start();
                this.Close();
            }
        }

        private void ServiceCheckedVehicleButton_Click(object sender, EventArgs e)
        {
            ListView.CheckedListViewItemCollection checkedItems = VehicleListView.CheckedItems;
            foreach (ListViewItem item in checkedItems)
            {
                ListViewItem.ListViewSubItemCollection listSubItem = item.SubItems;
                int vehicleId = Int32.Parse(listSubItem[0].Text);
                foreach (var v in this.manager.GetListVehicle("car"))
                {
                    if (v.IdVehicle == vehicleId)
                    {
                        v.CheckVehicleCondition();
                        goto OutOfVehicleSearch;
                    }
                }
                foreach (var v in this.manager.GetListVehicle("truck"))
                {
                    if (v.IdVehicle == vehicleId)
                    {
                        v.CheckVehicleCondition();
                        goto OutOfVehicleSearch;
                    }
                }

            OutOfVehicleSearch:;
            }
            MessageBox.Show("All checked vehicle is now serviced");
        }

        private void FormVehicleListService_Load(object sender, EventArgs e)
        {

        }

        private void ServiceCarFleetButton_Click(object sender, EventArgs e)
        {
            this.manager.ServiceCarFleet();
            MessageBox.Show("All Car now is serviced");
        }

        private void ServiceTruckFleetButton_Click(object sender, EventArgs e)
        {
            this.manager.ServiceTruckFleet();
            MessageBox.Show("All Truck now is serviced");
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string serializedString = "";
            ListView.CheckedListViewItemCollection checkedItems = VehicleListView.CheckedItems;
            foreach (ListViewItem item in checkedItems)
            {
                ListViewItem.ListViewSubItemCollection listSubItem = item.SubItems;
                int vehicleId = Int32.Parse(listSubItem[0].Text);
                foreach (var v in this.manager.GetListVehicle("car"))
                {
                    if (v.IdVehicle == vehicleId)
                    {
                        serializedString = JsonConvert.SerializeObject(v.GetServiceHistory, Formatting.Indented,
           new JsonConverter[] { new StringEnumConverter() });
                        goto OutOfVehicleSearch;
                    }
                }
                foreach (var v in this.manager.GetListVehicle("truck"))
                {
                    if (v.IdVehicle == vehicleId)
                    {
                        serializedString = JsonConvert.SerializeObject(v.GetServiceHistory, Formatting.Indented,
           new JsonConverter[] { new StringEnumConverter() });
                        goto OutOfVehicleSearch;
                    }
                }

            OutOfVehicleSearch:
                try
                {
                    System.IO.File.WriteAllText(@"C:\Users\dell\Desktop\VehicleServiceHistory.json", serializedString);
                }
                catch
                {
                    System.IO.File.WriteAllText(@"C:\Users\ren\Desktop\VehicleServiceHistory.json", serializedString);
                }

            }

            MessageBox.Show(serializedString);
        }

        private void JsonToConsoleButton_Click(object sender, EventArgs e)
        {

            string serializedString = "";
            ListView.CheckedListViewItemCollection checkedItems = VehicleListView.CheckedItems;
            foreach (ListViewItem item in checkedItems)
            {
                ListViewItem.ListViewSubItemCollection listSubItem = item.SubItems;
                int vehicleId = Int32.Parse(listSubItem[0].Text);
                foreach (var v in this.manager.GetListVehicle("car"))
                {
                    if (v.IdVehicle == vehicleId)
                    {
                        serializedString = JsonConvert.SerializeObject(v.GetServiceHistory, Formatting.Indented,
           new JsonConverter[] { new StringEnumConverter() });
                        goto OutOfVehicleSearch;
                    }
                }
                foreach (var v in this.manager.GetListVehicle("truck"))
                {
                    if (v.IdVehicle == vehicleId)
                    {
                        serializedString = JsonConvert.SerializeObject(v.GetServiceHistory, Formatting.Indented,
           new JsonConverter[] { new StringEnumConverter() });
                        goto OutOfVehicleSearch;
                    }
                }

            OutOfVehicleSearch:
                Console.WriteLine(serializedString);
            }

            MessageBox.Show(serializedString);
        }
    }
}
