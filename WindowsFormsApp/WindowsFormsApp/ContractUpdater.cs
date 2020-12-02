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
                Car car = vehicle as Car;
                this.typeTextBox.Text = car.TypeCar.ToString();
            }
            else
            {
                this.TypeTruckRadio.Checked = true;
                populateBranchTypeComboBoxWithTruckOption();
                Truck truck = vehicle as Truck;
                this.typeTextBox.Text = truck.TypeTruck.ToString();
            }
            this.VehicleNameTextBox.Text = vehicle.Name;
            this.CostPerDayTextBox.Text = vehicle.CostPerDay.ToString();
            this.KilometerTextBox.Text = vehicle.NumberKilometers.ToString();
            this.VehicleDescriptionTextBox.Text = vehicle.Description;
            this.branchTextBox.Text = vehicle.Branch;
            // + Contract Info (Description):
            this.ContractDescriptionTextBox.Text = contract.Description;
            this.StartDate.Value = contract.DateStartRent;
            this.EndDate.Value = contract.DateEndRent;
            this.TotalCost.Text = contract.TotalCost.ToString();

            // + Insurance Info:
            this.InsuranceIdTextBox.Text = insurance.InsuranceId.ToString();
            this.InsuranceTypeSpinBox.Text = insurance.Type.ToString();
            addInsuranceTypeOption();

            this.RegistrationNumberComboBox.Text = vehicle.IdVehicle.ToString();

        }
        private void populateBranchTypeComboBoxWithCarOption() {
            //BranchComboBox.Items.Clear();
            //TypeComboBox.Items.Clear();
            //List<string> listbranch = manager.GetlistBranch("car");
            //List<string> listtype = manager.GetlistType("car");
            //foreach (var i in listbranch)
            //{
            //    BranchComboBox.Items.Add(i);
            //}
            //foreach (var i in listtype)
            //{
            //    TypeComboBox.Items.Add(i);
            //}
            foreach (Vehicle v in manager.GetListVehicle("car"))
            {   
                RegistrationNumberComboBox.Items.Add(v.IdVehicle);
            }
            //this.BranchComboBox.Text = vehicle.Branch;
            //Car car = vehicle as Car;
            //this.TypeComboBox.Text = car.TypeCar.ToString();
        }
    
        private void populateBranchTypeComboBoxWithTruckOption()
        {
            //BranchComboBox.Items.Clear();
            //TypeComboBox.Items.Clear();
            //List<string> listbranch = manager.GetlistBranch("truck");
            //List<string> listtype = manager.GetlistType("truck");
            //foreach (var i in listbranch)
            //{
            //    BranchComboBox.Items.Add(i);
            //}
            //foreach (var i in listtype)
            //{
            //    TypeComboBox.Items.Add(i);
            //}
            foreach (Car v in manager.GetListVehicle("car"))
            {
                RegistrationNumberComboBox.Items.Add(v.IdVehicle);
            }
            //this.BranchComboBox.Text = vehicle.Branch;
            //Truck truck = vehicle as Truck;
            //this.TypeComboBox.Text = truck.TypeTruck.ToString();
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
        private void UpdateVehicleInfomation(Vehicle v)
        {
            this.VehicleNameTextBox.Text = v.Name;
            this.CostPerDayTextBox.Text = v.CostPerDay.ToString();
            this.KilometerTextBox.Text = v.NumberKilometers.ToString();
            this.VehicleDescriptionTextBox.Text = v.Description;
            this.branchTextBox.Text = v.Branch;
            if (TypeCarRadio.Checked)
            {
                Car car = v as Car;
                this.typeTextBox.Text = car.TypeCar.ToString();
            }
            else
            {
                Truck truck = v as Truck;
                this.typeTextBox.Text = truck.TypeTruck.ToString();
            }
            this.FluidTextBox.Text = v.SizeFluid.ToString();
            this.OilTextBox.Text = v.SizeOil.ToString();
        }

        private bool CheckContractValidity()
        {
            bool isValid = true;
            if (EndDate.Value < StartDate.Value)
            {
                isValid = false;
                MessageBox.Show("Start Date or End Date is Wrong. Please check again");
            }
            else if (Int32.Parse(TotalCost.Text.ToString()) < 0)
            {
                isValid = false;
                MessageBox.Show("Some Thing is wrong. The total cost is negative. Please check again");
            }
            int vehicleID = Int32.Parse(InsuranceIdTextBox.Text);
            foreach (Insurance insurance in manager.GetInsurances())
            {
                int match = 0;
                if (Int32.Parse(InsuranceIdTextBox.Text) == insurance.InsuranceId)
                {
                    match++;
                }
                if (match >= 2)
                {
                    MessageBox.Show("Invalid Insurance Id. Please use another one");
                    isValid = false;
                }

            }
            // CHeck if the selected vehicle is available: Does it exist, is it being used, is it being maintained
            if (TypeCarRadio.Checked)
            {
                foreach (Car car in manager.GetListVehicle("car")) {
                    if (car.IdVehicle == Int32.Parse(RegistrationNumberComboBox.Text))
                    {
                        if (car.Maintain)
                        {
                            isValid = false;
                            MessageBox.Show("Car selected is being maintained. Please choose another one");
                            goto returnLabel;
                        }
                        else if (car.StateUsed)
                        {
                            isValid = false;
                            MessageBox.Show("Car selected is being used. Please choose anotehr one");
                            goto returnLabel;
                        }
                        else
                        {
                            UpdateVehicleInfomation(car);
                            UpdateCost();
                            goto returnLabel;
                        }
                    }
                }
                // Not found the vehicle (done looping through the vehicle list)
                MessageBox.Show("Car Selected Not Found. Please choose another vehicel and try again");
                isValid = false;
            }
            else if (TypeTruckRadio.Checked){
                foreach (Truck truck in manager.GetListVehicle("truck"))
                {
                    if (truck.IdVehicle == Int32.Parse(RegistrationNumberComboBox.Text))
                    {
                        if (truck.Maintain)
                        {
                            isValid = false;
                            MessageBox.Show("Truck selected is being maintained. Please choose another one");
                            goto returnLabel;
                        }
                        else if (truck.StateUsed)
                        {
                            isValid = false;
                            MessageBox.Show("Truck selected is being used. Please choose anotehr one");
                            goto returnLabel;
                        }
                        {
                            UpdateVehicleInfomation(truck);
                            UpdateCost();
                            goto returnLabel;
                        }
                    }
                }
                // Not found the vehicle (done looping through the vehicle list)
                MessageBox.Show("Truck Selected Not Found. Please choose another vehicel and try again");
                isValid = false;
            }
            returnLabel:
            return isValid;
        }

        // This is where the real update happens when the user confirm the update.
        private void UpdateAndGoBackButton_Click(object sender, EventArgs e)
        {
            if (CheckContractValidity())
            {
                updateContractInfoInDatabase();
                MessageBox.Show("Update Successfully");
                Form manageContracts = new FormManage(this.manager);
                var thread = new Thread(() => Program.Start(manageContracts));
                thread.Start();
                this.Close();
            }
        }
        private void updateContractInfoInDatabase()
        {
            try
            {
                MySqlConnection conn = Program.ConnectDatabase();
                // Update the rentcontract table (include infomation related to customer and the contract)
                string Query = $@"update rentcontract
                                  set IDVEHICLE = '{RegistrationNumberComboBox.Text}', NAMECUSTORMER = '{CustomerNameTextBox.Text}',PHONENUMBER = '{PhoneNumberTextBox.Text}', EMAIL = '{EmailTextBox.Text}', ADDRESS = '{AddressTextBox.Text}', CAREER = '{CareerTextBox.Text}', STARTDATE = '{StartDate.Value.ToString("dd/MM/yyyy")}', ENDDATE = '{EndDate.Value.ToString("dd/MM/yyyy")}', TOTALBILL = '{TotalCost.Text}', DESCRIPTION = '{ContractDescriptionTextBox.Text}', APPROVED = FALSE, DRIVERLICENSE = '{DriverLicenseTextBox.Text}'
                                  where IDCONTRACT = '{contract.Id.ToString()}';";
                // Update the vehicle table:   May use the following to update the availability of the Vehicle: ==== , /*stateUsed = '0', maintain = '0'*/ =========
                Query += $@"update vehicle 
                            set Name = '{VehicleNameTextBox.Text}', branch = '{branchTextBox.Text}', costperday = '{CostPerDayTextBox.Text}', numberOilNow = '{OilTextBox.Text}', sizeOil = '{vehicle.SizeOil.ToString()}', numberKilometers = '{KilometerTextBox.Text}', Description ='{VehicleDescriptionTextBox.Text}'
                            where ID = '{vehicle.IdVehicle.ToString()}';";
                // Update the state of the Car or Truck related:
                //if (TypeCarRadio.Checked) {
                //    Query += $@"update car
                //            set TYPECAR = '{TypeComboBox.Text}'
                //            where ID = '{RegistrationNumberComboBox.Text}';";
                //}
                //else
                //{
                //    Query += $@"update truck
                //            set TYPETRUCK = '{TypeComboBox.Text}
                //            where ID = '{RegistrationNumberComboBox.Text}';";
                //}
                // Update the insurance Type:
                Query += $@"update insurance
                            set TYPEINSURANCE ='{InsuranceTypeSpinBox.Text}'
                            where IID = '{insurance.InsuranceId.ToString()}';";   // Could have used the insuranceIDTextBox value. should be modified according to the teacher instruction.
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

        private void StartDate_ValueChanged(object sender, EventArgs e)
        {
            if (this.StartDate.Value.Date > this.EndDate.Value.Date)
            {
                MessageBox.Show("Invalid Date, Please make sure the start date is smaller than End date");
            }
            UpdateCost();
        }
        private void EndDate_ValueChanged(object sender, EventArgs e)
        {
            if (this.EndDate.Value.Date < this.StartDate.Value.Date)
            {
                MessageBox.Show("Invalid Date, Please make sure the start date is smaller than End Date");
            }
            UpdateCost();
        }
        private void UpdateCost()
        {
            double timeInterval = (EndDate.Value - StartDate.Value).TotalDays;
            int totalCost = (int)timeInterval * Int32.Parse(CostPerDayTextBox.Text);
            this.TotalCost.Text = totalCost.ToString();
        }

        private void RegistrationNumberComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CheckContractValidity())
            {
                // Update the Vehicle information with the new Chosen Registration ID.
                UpdateCost();
            }
            else
            {
                // If not valid. Change back to the old vehicle.
                RegistrationNumberComboBox.Text = vehicle.IdVehicle.ToString();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
