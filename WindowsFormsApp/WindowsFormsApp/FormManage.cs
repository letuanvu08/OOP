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
using MySql.Data.MySqlClient;
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
            ContractList.MouseDoubleClick += new MouseEventHandler(contractList_MouseDoubleClick);
            ApprovedContractList.MouseDoubleClick += new MouseEventHandler(approvedContractList_MouseDoubleClick);
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
                string[] briefContractInfo = new string[6];
                (briefContractInfo[0], briefContractInfo[1], briefContractInfo[2], briefContractInfo[3], briefContractInfo[4],briefContractInfo[5]) = getContractInfomation(contract);
                if (!contract.IsApproved) ContractList.Items.Add(new ListViewItem(briefContractInfo));
                else ApprovedContractList.Items.Add(new ListViewItem(briefContractInfo));
            }
       
        }

        private void DisplayTruckContracts()
        {
            foreach (RentContract contract in listTruckContracts)
            {
                string[] briefContractInfo = new string[6];
                (briefContractInfo[0], briefContractInfo[1], briefContractInfo[2], briefContractInfo[3], briefContractInfo[4],briefContractInfo[5]) = getContractInfomation(contract);
                ContractList.Items.Add(new ListViewItem(briefContractInfo));
                if (!contract.IsApproved) ContractList.Items.Add(new ListViewItem(briefContractInfo));
                else ApprovedContractList.Items.Add(new ListViewItem(briefContractInfo));
            }
        }
        // This function find needed information of a contract and return its infomation in a tuple of string: 
        private (string empty,string contract_id, string vehicle_id, string customer_name, string customer_license, string insurance_type) getContractInfomation(RentContract contract)
        {
            string empty = "";   
            string contractID = contract.Id.ToString();
            string vehicleID = contract.VehicleRented.idVehicle.ToString();
            string customerName = contract.CustormerRentCar.Name;
            string customerLicense = contract.CustormerRentCar.Driver_license;
            string insuranceType = contract.InsuranceUsed.Type.ToString();
            return (empty,contractID, vehicleID, customerName, customerLicense, insuranceType);
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
            ApprovedContractList.Items.Clear();
            DisplayCarContracts();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            ContractList.Items.Clear();
            ApprovedContractList.Items.Clear();
            DisplayTruckContracts();
        }
        /*       private void Listview1_ItemChecked(object sender, ItemCheckedEventArgs e)
               {
                   foreach (ListViewItem Item in ListView1.Items)
                   {
                       if (Item != null)
                       {
                           if (Item.Checked == true) N++;
                       }
                   }
                   Textbox1.Text = N.ToString();
               }


               ListView.CheckedListViewItemCollection checkedItems = 
                   ListView1.CheckedItems;

               foreach ( ListViewItem item in checkedItems )
               {
                   value = item.SubItems[1].Text;
               }
        */
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ApproveButton_Click(object sender, EventArgs e)
        {
            // Get selected row
            ListView.CheckedListViewItemCollection checkedItems = ContractList.CheckedItems;
            foreach(ListViewItem item in checkedItems)
            {
                ListViewItem.ListViewSubItemCollection listSubItem = item.SubItems;
                listSubItem.RemoveAt(0);
                int contractID = int.Parse(listSubItem[0].Text);
                updateApprovalStatusInDatabase(contractID);
                ListViewItem approvedItem = new ListViewItem();
                foreach (ListViewItem.ListViewSubItem subItem in listSubItem)
                {
                    approvedItem.SubItems.Add(subItem);
                }

                // remove it from the left listview
                ContractList.Items.Remove(item);

                // Add it to the right listview
                ApprovedContractList.Items.Add(item);

                // Get the removed item id and change the APPROVED to TRUE in the database:    
            }
            
        }
        private void updateApprovalStatusInDatabase(int contractID)
        {
            try
            {
                MySqlConnection conn = Program.connectDatabase();
                string Query = $"update rentcontract set approved = TRUE where idcontract ={contractID};";
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = Query;
                cmd.ExecuteNonQuery();                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        // The nexxt 2 method open the correspoding Contract Detail Form for user to view the full contract again.
        private void contractList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo listViewHitTestInfo = ContractList.HitTest(e.X, e.Y);
            ListViewItem ClickedItem = listViewHitTestInfo.Item;
            if (ClickedItem != null)
            {
                int contractID = int.Parse(ClickedItem.SubItems[0].Text);
                RentContract contract_to_show = manage.getContracts()[0];
                foreach (RentContract contract in manage.getContracts())
                {
                    if (contract.Id == contractID)
                    {
                        contract_to_show = contract;
                        break;
                    }
                }
                ContractDetailForm contractDetailForm = new ContractDetailForm(this.manage,contract_to_show);
                var thread = new Thread(() => Program.start(contractDetailForm));
                thread.Start();
                this.Close();
            }
        }
        private void approvedContractList_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
    }
}
