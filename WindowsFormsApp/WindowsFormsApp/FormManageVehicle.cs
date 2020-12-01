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
    partial class FormManageVehicle : Form
    {
        CarRentalManagement manage;
        string nameVehicleSelected;
        bool change = false;
        bool addnew = false;
        public FormManageVehicle(CarRentalManagement manage)
        {
            InitializeComponent();
            this.manage = manage;
        }

        private void Home_Click(object sender, EventArgs e)
        {
            Form formManage = new FormMainMenu(this.manage);
            var thread = new Thread(() => Program.Start(formManage));
            thread.Start();
            this.Close();
        }

        private void RadioCarview_CheckedChanged(object sender, EventArgs e)
        {
            loadcar();
        }
        private void loadcar()
        {
            listResult.Items.Clear();
            List<Vehicle> listcar = manage.GetListVehicle("car");
            List<ListViewItem> listitem = new List<ListViewItem>();
            foreach (Car vehicle in listcar)
            {
                listResult.ResetText();
                listitem.Add(new ListViewItem(vehicle.Name));
                listitem[listitem.Count - 1].SubItems.Add(new ListViewItem.ListViewSubItem() { Text = vehicle.IdVehicle.ToString() });
                listitem[listitem.Count - 1].SubItems.Add(new ListViewItem.ListViewSubItem() { Text = (vehicle.Name) });
                listitem[listitem.Count - 1].SubItems.Add(new ListViewItem.ListViewSubItem() { Text = (vehicle.Branch) });
                listitem[listitem.Count - 1].SubItems.Add(new ListViewItem.ListViewSubItem() { Text = (vehicle.TypeCar.ToString()) });



                listResult.Items.Add(listitem[listitem.Count - 1]);
            }
        }

        private void RadioTruckview_CheckedChanged(object sender, EventArgs e)
        {
            loadTruck();
        }

        private void loadTruck()
        {

            listResult.Items.Clear();
            List<Vehicle> listcar = manage.GetListVehicle("truck");
            List<ListViewItem> listitem = new List<ListViewItem>();
            foreach (Truck vehicle in listcar)
            {
                listResult.ResetText();
                listitem.Add(new ListViewItem(vehicle.Name));
                listitem[listitem.Count - 1].SubItems.Add(new ListViewItem.ListViewSubItem() { Text = vehicle.IdVehicle.ToString() });
                listitem[listitem.Count - 1].SubItems.Add(new ListViewItem.ListViewSubItem() { Text = (vehicle.Name) });
                listitem[listitem.Count - 1].SubItems.Add(new ListViewItem.ListViewSubItem() { Text = (vehicle.Branch) });
                listitem[listitem.Count - 1].SubItems.Add(new ListViewItem.ListViewSubItem() { Text = (vehicle.TypeTruck.ToString()) });



                listResult.Items.Add(listitem[listitem.Count - 1]);
            }
        }

        private void viewdetail() 
        {
            Vehicle vehicleSelected = manage.FindVehicle(this.nameVehicleSelected);
            NameVehicle.Text = vehicleSelected.Name;
            BranchVehicle.Text = vehicleSelected.Branch;
            if (RadioCarview.Checked == true) {
                
                  Car car=  (vehicleSelected as Car);
                typeVehicledetail.Text = car.TypeCar.ToString();
                RadioCarDetail.Checked = true;
                    }

            else
            {
                RadioTruckDetail.Checked = true;
                Truck truck = (vehicleSelected as Truck);
                typeVehicledetail.Text = truck.TypeTruck.ToString();
            }
            registration.Text = vehicleSelected.IdVehicle.ToString();
            costperdatetext.Text = vehicleSelected.CostPerDay.ToString();
            descriptiontext.Text = vehicleSelected.Description;
            Kilometer.Text = vehicleSelected.NumberKilometers.ToString();
            statusvehicleview.Checked = vehicleSelected.StateUsed;
            maintainvehicleview.Checked = vehicleSelected.Maintain;
            BtChange.Enabled = true;

        }

        private void listResult_SelectedIndexChanged(object sender, EventArgs e)
        {

           
                ListView lsv = sender as ListView;
                if (lsv.SelectedItems.Count > 0)
                {
                    ListViewItem item = lsv.SelectedItems[0];
                    nameVehicleSelected = item.Text;
                viewdetail();
            }
            
        }

        private void BtChange_Click(object sender, EventArgs e)
        {
            BtChange.Enabled = false;
            btAddVehicle.Enabled = false;
            btSave.Enabled = true;
            setchange();
            registration.ReadOnly = true;
            change = true;
            BtChange.Enabled = false;

        }
        private void setchange()
        {
            panellistvehilce.Enabled = false;
            paneltypevehicle.Enabled = true;
            NameVehicle.ReadOnly = false;
            BranchVehicle.ReadOnly = false;
            paneltypevehicle.Enabled = true;
            registration.ReadOnly = false;
            costperdatetext.ReadOnly = false;
            descriptiontext.ReadOnly = false;
            Kilometer.ReadOnly = false;
            panelstatusview.Enabled = true;
            paneltypevehicleview.Enabled = true;
           
        }
        private void setunchange()
        {
            BtChange.Enabled = true;
            btSave.Enabled = false;
            btAddVehicle.Enabled = true;
            btAddVehicle.Enabled = true;
            panellistvehilce.Enabled = true;
            paneltypevehicle.Enabled = true;

            NameVehicle.ReadOnly = true;
            BranchVehicle.ReadOnly = true;
            registration.ReadOnly = false;
            costperdatetext.ReadOnly = true;
            descriptiontext.ReadOnly = true;
            Kilometer.ReadOnly = true;
            panelstatusview.Enabled = false;
            paneltypevehicleview.Enabled =false;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            try
            {
                Int32.Parse(registration.Text);
                Int32.Parse(Kilometer.Text);
                Int32.Parse(costperdatetext.Text);
                if (checkedNotNull())
                {
                    if (change)
                    {
                        UpdateVehicle();
                        MessageBox.Show("Update successly!");
                        change = false;
                        manage = Program.LoadData();
                    }
                    else
                    {
                        if (checkid(Int32.Parse(registration.Text)))
                        {
                            InsertVehicle();
                            MessageBox.Show("Add Successly!");
                            addnew = false;
                            manage = Program.LoadData();
                        }
                    }

                    setclear();
                    setunchange();
                    if (RadioCarview.Checked) loadcar();
                    else loadTruck();
                }
            }
            catch(Exception error)
            {
                MessageBox.Show("Please fill correct!");
            }
            
            
            

        }
        
        private bool checkedNotNull()
        {
            if (String.IsNullOrWhiteSpace(NameVehicle.Text) || String.IsNullOrWhiteSpace(BranchVehicle.Text) || String.IsNullOrWhiteSpace(registration.Text) || String.IsNullOrWhiteSpace(typeVehicledetail.Text))
            {
                MessageBox.Show("Please fill full form");
                return false;
            }
            
                return true;
        }
        private bool checkid(int id)
        {
            if (manage.FindVehiclebyId(Int32.Parse(registration.Text)) != null)
            {
                MessageBox.Show("Id Registration is Exists");
                return false;
            }
            return true;
        }
       
        private void UpdateVehicle()
        {
            MySqlConnection conn = Program.ConnectDatabase();
            string sql = "Update vehicle set Name=@NAME,branch=@Branch,costperday=@costperday,numberKilometers=@kilometer,vehicle.Description=@Description,stateUsed=@statususe, maintain = @maintain where ID = @ID; ";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            
           
            cmd.Parameters.AddWithValue("@NAME",NameVehicle.Text);
            cmd.Parameters.AddWithValue("@Branch", BranchVehicle.Text);
            cmd.Parameters.AddWithValue("@costperday",costperdatetext.Text);
            cmd.Parameters.AddWithValue("@kilometer", (Kilometer.Text));
            cmd.Parameters.AddWithValue("@Description",descriptiontext.Text);
            cmd.Parameters.AddWithValue("@statususe",statusvehicleview.Checked);
            cmd.Parameters.AddWithValue("@maintain", maintainvehicleview.Checked);
            cmd.Parameters.AddWithValue("@ID", registration.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        private void InsertVehicle()
        {
            MySqlConnection conn = Program.ConnectDatabase();
            string sql = "INSERT INTO vehicle(Name, ID, branch, costperday, numberKilometers, stateUsed, maintain, Description)VALUES(@NAME, @ID, @branch, @costperday, @kilometer, @statususe, @maintain, @Description); ";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd = conn.CreateCommand();
            cmd.CommandText = sql;


            cmd.Parameters.AddWithValue("@NAME", NameVehicle.Text);
            cmd.Parameters.AddWithValue("@Branch", BranchVehicle.Text);
            cmd.Parameters.AddWithValue("@costperday", costperdatetext.Text);
            cmd.Parameters.AddWithValue("@kilometer", Kilometer.Text);
            cmd.Parameters.AddWithValue("@Description", descriptiontext.Text);
            cmd.Parameters.AddWithValue("@statususe", statusvehicleview.Checked);
            cmd.Parameters.AddWithValue("@maintain", maintainvehicleview.Checked);
            cmd.Parameters.AddWithValue("@ID", Int32.Parse(registration.Text));
            cmd.ExecuteNonQuery();
            conn.Close();
            InsertVehicletype();
        }
        private void InsertVehicletype()
        {
            MySqlConnection conn = Program.ConnectDatabase();
            string sql = "";
            if (RadioCarDetail.Checked)
               sql = "INSERT INTO Car(ID, TYPECAR) VALUES (@ID,@Type);";
            else
                sql = "INSERT INTO truck(ID, TYPETRUCK) VALUES (@ID,@Type);";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd = conn.CreateCommand();
            cmd.CommandText = sql;


            cmd.Parameters.AddWithValue("@ID", Int32.Parse(registration.Text));
            cmd.Parameters.AddWithValue("@Type",typeVehicledetail.SelectedItem.ToString() );
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void btAddVehicle_Click(object sender, EventArgs e)
        {
            BtChange.Enabled = false;
            btSave.Enabled = true;
            btAddVehicle.Enabled = false;
            panellistvehilce.Enabled = false;
            setclear();
            setchange();

        }
        private void setclear()
        {
            NameVehicle.Clear();
            BranchVehicle.Clear();
            typeVehicledetail.ResetText();
            registration.Clear();
            costperdatetext.Clear();
            descriptiontext.Clear();
            Kilometer.Clear();
        }
        private void settype(string type){
            if (type == "car")
            {
               
                typeVehicledetail.Items.Clear();
                
                
                foreach (var i in Enum.GetValues(typeof(TypeCar)))
                {
                    typeVehicledetail.Items.Add(i);
                }
            }
            else
            {
                typeVehicledetail.Items.Clear();


                foreach (var i in Enum.GetValues(typeof(TypeTruck)))
                {
                    typeVehicledetail.Items.Add(i);
                }
            }
        }

        private void Cancelview_Click(object sender, EventArgs e)
        {
            setclear();
            setunchange();
        }

        private void RadioCarDetail_CheckedChanged(object sender, EventArgs e)
        {
            settype("car");
        }

        private void RadioTruckDetail_CheckedChanged(object sender, EventArgs e)
        {
            settype("tr");
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panellistvehilce_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormManageVehicle_Load(object sender, EventArgs e)
        {

        }

        private void NameVehicle_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
