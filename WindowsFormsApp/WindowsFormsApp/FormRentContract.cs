using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    partial class FormRentContract : Form
    {
        RentContract contract;
        Customer customerRent;
        public FormRentContract(RentContract contract)
        {
            InitializeComponent();
            this.contract = contract;
            customerRent = new Customer();
            Setup();
            contract.CustomerRentCar = customerRent;
            Insurance insurance = new Insurance();
            contract.InsuranceUsed = insurance;
        }
        private void Setup()
        {
            NameVehicle.Text = this.contract.VehicleRented.Name;
            if (contract.VehicleRented.GetType() == typeof(Car))
            {
                Car car = (contract.VehicleRented as Car);
                if (car != null) TypeVehicle.Text = car.TypeCar.ToString();
            }
            else
            {
                Truck car = (contract.VehicleRented as Truck);
                if (car != null) TypeVehicle.Text = car.TypeTruck.ToString();
            }
            startRent.Value = this.contract.DateStartRent;
            endRent.Value= this.contract.DateEndRent;
            BranchVehicle.Text = contract.VehicleRented.Branch;
            foreach (var i in Enum.GetValues(typeof(TypeInsurance)))
            {
                insuranceBox.Items.Add(i);
            }
            TotalBill.Text = contract.TotalCost.ToString();
        }



        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            if (CustormerName.Text == "")
            
                MessageBox.Show("Name can't be null");
            
            else if (Address.Text == "")
            
                MessageBox.Show("Address can't be null");
            else if(startRent.Value.Date>=endRent.Value.Date)
                MessageBox.Show("Start Rent not equa less than End Rent");
            else if (DriverLicense.Text == "")
            {
                MessageBox.Show("Driver License can't be null!");
            }
          
           else if (insuranceBox.SelectedItem==null)
            {
                MessageBox.Show("Choose insurance!");
            }
            else
            {
                MessageBox.Show("Confirm Successly!");
                SaveContract();
                this.Close();
            }
        }
        private void SaveContract()
        {
            
            MySqlConnection conn = Program.ConnectDatabase();
           string sql= "select max(IDCONTRACT) from rentcontract;";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;

            int maxid = 0;
            using (MySqlDataReader d = cmd.ExecuteReader())
            {
                while (d.Read())
                    maxid = (int)d[0];

            }
            contract.Id = maxid + 1;
                string sqlcontract = "insert into rentcontract(IDCONTRACT,IDVEHICLE,NAMECUSTORMER,EMAIL,ADDRESS,STARTDATE,ENDDATE,TOTALBILL,BIRTHDAY, DESCRIPTION,DRIVERLICENSE,APPROVED)" +
                "VALUE(@ID,@IDVEHICLE,@NAME,@EMAIL,@ADDRESS,@STARTDATE,@ENDDATE,@TOTALBILL,@BIRTHDAY,@DESCRIPTION,@DRIVERLICENSE,@APPROVED);";
            cmd = conn.CreateCommand();
            cmd.CommandText = sqlcontract;
            cmd.Parameters.Add("@ID", (MySqlDbType)SqlDbType.Int).Value=contract.Id;
            cmd.Parameters.Add("@IDVEHICLE", (MySqlDbType)SqlDbType.Int).Value = contract.VehicleRented.IdVehicle;
            cmd.Parameters.AddWithValue("@NAME",contract.CustomerRentCar.Name);
            cmd.Parameters.AddWithValue("@EMAIL",  contract.CustomerRentCar.Email);
            cmd.Parameters.AddWithValue("@ADDRESS",  contract.CustomerRentCar.Address);
            cmd.Parameters.AddWithValue("@STARTDATE", contract.DateStartRent.Date.ToString());
            cmd.Parameters.AddWithValue("@ENDDATE", contract.DateEndRent.Date.ToString());
            cmd.Parameters.AddWithValue("@TOTALBILL",  contract.TotalCost.ToString());
            cmd.Parameters.AddWithValue("@BIRTHDAY",  contract.CustomerRentCar.birthday.Date.ToString());
            cmd.Parameters.AddWithValue("@DESCRIPTION", contract.Description);
            cmd.Parameters.AddWithValue("@DRIVERLICENSE", contract.CustomerRentCar.Driver_license);
            cmd.Parameters.AddWithValue("@APPROVED", contract.IsApproved);
            /*cmd.Par*//*//**ameters.AddWithValue("@DRIVERLICENSE", contract.CustomerRentCar.);*/
            cmd.ExecuteNonQuery();
           SaveInsurance();
        }
        private void SaveInsurance()
        {
            MySqlConnection conn = Program.ConnectDatabase();
            string sql = "insert into  insurance(IID, TYPEINSURANCE, IDCONTRACT) values (@ID,@TYPE,@IDCONTRACT);";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@ID", contract.Id);
            cmd.Parameters.AddWithValue("@TYPE", contract.InsuranceUsed.Type.ToString());
            cmd.Parameters.AddWithValue("@IDCONTRACT", contract.Id);
            cmd.ExecuteNonQuery();
        }

        private void startRent_ValueChanged(object sender, EventArgs e)
        {
            contract.DateStartRent = startRent.Value.Date;
            double days = (endRent.Value.Date - startRent.Value.Date).TotalDays;
            contract.TotalCost = contract.VehicleRented.CostPerDay * (int)days;
            this.TotalBill.Text = contract.TotalCost.ToString();

        }

        private void endRent_ValueChanged(object sender, EventArgs e)
        {
            contract.DateEndRent = endRent.Value.Date;
            double days = (endRent.Value.Date - startRent.Value.Date).TotalDays;
            contract.TotalCost = contract.VehicleRented.CostPerDay * (int)days;
            this.TotalBill.Text = contract.TotalCost.ToString();
        }

        private void CostormerName_TextChanged(object sender, EventArgs e)
        {
            this.customerRent.Name = CustormerName.Text;
        }

        private void radioMale_CheckedChanged(object sender, EventArgs e)
        {
            this.customerRent.Sex = "Male";
        }

        private void radioFemale_CheckedChanged(object sender, EventArgs e)
        {
            this.customerRent.Sex = "Female";
        }

        private void BirthDay_ValueChanged(object sender, EventArgs e)
        {
            this.customerRent.birthday = BirthDay.Value.Date;
        }

        private void Address_TextChanged(object sender, EventArgs e)
        {
            this.customerRent.Address = Address.Text;
        }

        private void Description_TextChanged(object sender, EventArgs e)
        {
            contract.Description = Description.Text;
        }

        private void Email_TextChanged(object sender, EventArgs e)
        {
            customerRent.Email = Email.Text;
        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormRentContract_Load(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void insuranceBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            contract.InsuranceUsed.Type = (TypeInsurance)Enum.Parse(typeof(TypeInsurance),insuranceBox.SelectedItem.ToString());
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
