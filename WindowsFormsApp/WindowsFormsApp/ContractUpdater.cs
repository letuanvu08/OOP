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
using MySql.Data.MySqlClient;

namespace WindowsFormsApp
{
    partial class ContractUpdater : Form
    {
        CarRentalManagement manager;
        RentContract contract;
        Customer customer;
        Vehicle vehicle;
        Insurance insurance; 
        public ContractUpdater(CarRentalManagement _manager, RentContract _contract)
        {
            InitializeComponent();
            // Initialize the Form Object for cleaner code:
            this.manager = _manager;
            this.contract = _contract;
            this.customer = contract.CustomerRentCar;
            this.vehicle = contract.VehicleRented;
            this.insurance = contract.InsuranceUsed;
            // Initialize the Contract into its current state:
            
            // + Customer Info
            if (customer.Sex == "M")
            {
                this.GenderMaleRadio.Checked = true;
            }
            else this.GenderFemaleRadio.Checked = true;
            this.CustomerNameTextBox.Text = customer.Name;
            this.AddressTextBox.Text = customer.Address;
            this.PhoneNumberTextBox.Text = customer.PhoneNumber;
            this.CareerTextBox.Text = customer.Career;
            this.EmailTextBox.Text = customer.Email;
            this.DriverLicenseTextBox.Text = customer.Driver_license;

            // + Vehicle Info
            if (vehicle.GetType() == typeof(Car))
            {
                this.TypeCarRadio.Checked = true;
                populateBranchTypeComboBoxWithCarOption();
                
            }
            else
            {
                this.TypeTruckRadio.Checked = true;
                populateBranchTypeComboBoxWithTruckOption();
            }
            this.VehicleNameTextBox.Text = vehicle.Name;
            this.RegistrationTextBox.Text = vehicle.IdVehicle.ToString();
            this.CostPerDayTextBox.Text = vehicle.CostPerDay.ToString();
            this.KilometerTextBox.Text = vehicle.NumberKilometers.ToString();
            this.VehicleDescriptionTextBox.Text = vehicle.Description;

            // + Contract Info (Description):
            this.ContractDescriptionTextBox.Text = contract.Description;
            this.StartDate.Value = contract.DateStartRent;
            this.EndDate.Value = contract.DateEndRent;
            this.TotalCost.Text = contract.TotalCost.ToString();

            // + Insurance Info:
            this.InsuranceIdTextBox.Text = insurance.InsuranceId.ToString();
            this.InsuranceTypeSpinBox.Text = insurance.Type.ToString();
            addInsuranceTypeOption();
            

        }
        private void populateBranchTypeComboBoxWithCarOption(){
            BranchComboBox.Items.Clear();
            TypeComboBox.Items.Clear();
            List<string> listbranch = manager.GetlistBranch("car");
            List<string> listtype = manager.GetlistType("car");
            foreach (var i in listbranch)
            {
                BranchComboBox.Items.Add(i);
            }
            foreach (var i in listtype)
            {
                TypeComboBox.Items.Add(i);
            }
            this.BranchComboBox.Text = vehicle.Branch;
            Car car = vehicle as Car;
            this.TypeComboBox.Text = car.TypeCar.ToString();
        }
        private void populateBranchTypeComboBoxWithTruckOption()
        {
            BranchComboBox.Items.Clear();
            TypeComboBox.Items.Clear();
            List<string> listbranch = manager.GetlistBranch("truck");
            List<string> listtype = manager.GetlistType("truck");
            foreach (var i in listbranch)
            {
                BranchComboBox.Items.Add(i);
            }
            foreach (var i in listtype)
            {
                TypeComboBox.Items.Add(i);
            }
            this.BranchComboBox.Text = vehicle.Branch;
            Truck truck = vehicle as Truck;
            this.TypeComboBox.Text = truck.TypeTruck.ToString();
        }
        
        private void addInsuranceTypeOption()
        {
            foreach (var item in Enum.GetValues(typeof(TypeInsurance)))
            {
                this.InsuranceTypeSpinBox.Items.Add(item);
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // This is the button to travel back to the watch the list of contract again:
            Form manageContracts = new FormManage(this.manager);
            var thread = new Thread(() => Program.Start(manageContracts));
            thread.Start();
            this.Close();

        }


        // This is where the real update happens when the user confirm the update.
        private void UpdateAndGoBackButton_Click(object sender, EventArgs e)
        {
            updateContractInfoInDatabase();
            Form manageContracts = new FormManage(this.manager);
            var thread = new Thread(() => Program.Start(manageContracts));
            thread.Start();
            this.Close();
        }
        private void updateContractInfoInDatabase()
        {   


            try
            {
                MySqlConnection conn = Program.ConnectDatabase();
                // Update the rentcontract table (include infomation related to customer and the contract)
                string Query = $@"update rentcontract
                                  set IDVEHICLE = '{RegistrationTextBox.Text}', NAMECUSTORMER = '{CustomerNameTextBox.Text}',PHONENUMBER = '{PhoneNumberTextBox.Text}', EMAIL = '{EmailTextBox.Text}', ADDRESS = '{AddressTextBox.Text}', CAREER = '{CareerTextBox.Text}', STARTDATE = '{StartDate.Value.ToString("dd/MM/yyyy")}', ENDDATE = '{EndDate.Value.ToString("dd/MM/yyyy")}', TOTALBILL = '{TotalCost.Text}', DESCRIPTION = '{ContractDescriptionTextBox.Text}', APPROVED = FALSE, DRIVERLICENSE = '{DriverLicenseTextBox.Text}'
                                  where IDCONTRACT = '{contract.Id.ToString()}';";
                // Update the vehicle table:   May use the following to update the availability of the Vehicle: ==== , /*stateUsed = '0', maintain = '0'*/ =========
                Query += $@"update vehicle 
                            set Name = '{VehicleNameTextBox.Text}', branch = '{BranchComboBox.Text}', costperday = '{CostPerDayTextBox.Text}', numberOilNow = '{OilTextBox.Text}', sizeOil = '{vehicle.SizeOil.ToString()}', numberKilometers = '{KilometerTextBox.Text}', Description ='{VehicleDescriptionTextBox.Text}'
                            where ID = '{vehicle.IdVehicle.ToString()}';";
                // Update the state of the Car or Truck related:
                if (TypeCarRadio.Checked) {
                    Query += $@"update car
                            set TYPECAR = '{TypeComboBox.Text}'
                            where ID = '{RegistrationTextBox.Text}';";
                }
                else
                {
                    Query += $@"update truck
                            set TYPETRUCK = '{TypeComboBox.Text}
                            where ID = '{RegistrationTextBox.Text}';";
                }
                // Update the insurance Type:
                Query += $@"update insurance
                            set TYPEINSURANCE ='{InsuranceTypeSpinBox.Text}'
                            where IDCONTRACT = '{contract.Id.ToString()}';";   // Could have used the insuranceIDTextBox value. should be modified according to the teacher instruction.
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
    }
}
