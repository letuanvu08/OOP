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
    partial class ContractDetailForm : Form
    {
        VehicleRentalManagement manage;
        RentContract contract;
         public ContractDetailForm(VehicleRentalManagement manage,RentContract contractToShow)
        {
            InitializeComponent();
            this.manage = manage;
            this.contract = contractToShow;
            this.DateCreated.Text = DateTime.Now.ToString();
            this.contractNumber.Text = this.manage.GetContracts().Count().ToString();
            this.CustomerName.Text = this.contract.CustomerRentCar.Name;
            this.DriverLicense.Text = this.contract.CustomerRentCar.Driver_license;
            this.Address.Text = this.contract.CustomerRentCar.Address;
            this.PhoneNum.Text = this.contract.CustomerRentCar.PhoneNumber;
            this.RegistrationNum.Text = this.contract.VehicleRented.IdVehicle.ToString();
            this.OilCap.Text = this.contract.VehicleRented.SizeOil.ToString();
            this.FluidStatus.Text = this.contract.VehicleRented.SizeFluid.ToString();
            this.KilometerRun.Text = this.contract.VehicleRented.NumberKilometers.ToString();
            this.CostPerDay.Text = this.contract.VehicleRented.CostPerDay.ToString();
            this.FromStartToEnd.Text = this.FromStartToEnd.Text + $"from {this.contract.DateStartRent.ToString()} to {this.contract.DateEndRent.ToString()}";
            this.Model.Text = this.contract.VehicleRented.Branch.ToString();
            this.TotalCost.Text = this.TotalCost.Text + this.contract.TotalCost.ToString();
            this.VehicleDescription.Text = this.contract.VehicleRented.Description;
            this.AdditionalDescription.Text = this.contract.Description;
            this.InsuranceID.Text = this.contract.InsuranceUsed.InsuranceId.ToString();
            this.InsuranceType.Text = this.contract.InsuranceUsed.Type.ToString();
        }

        private void ContractDetailForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            // This is the button to travel back to the main menu
            Form formManage = new FormManage(this.manage);
            var thread = new Thread(() => Program.Start(formManage));
            thread.Start();
            this.Close();
        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void FromStartToEnd_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CostPerDay_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void RegistrationNum_Click(object sender, EventArgs e)
        {

        }

        private void OilCap_Click(object sender, EventArgs e)
        {

        }

        private void FluidStatus_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void KilometerRun_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Address_Click(object sender, EventArgs e)
        {

        }

        private void PhoneNum_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click_1(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
