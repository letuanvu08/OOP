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
        CarRentalManagement manage;
        RentContract contract;
         public ContractDetailForm(CarRentalManagement manage,RentContract contract_to_show)
        {
            InitializeComponent();
            this.manage = manage;
            this.contract = contract_to_show;
            this.DateCreated.Text = DateTime.Now.ToString();
            this.contractNumber.Text = this.manage.getContracts().Count().ToString();
            this.CustomerName.Text = this.contract.CustormerRentCar.Name;
            this.DriverLicense.Text = this.contract.CustormerRentCar.Driver_license;
            this.Address.Text = this.contract.CustormerRentCar.Address;
            this.PhoneNum.Text = this.contract.CustormerRentCar.PhoneNumber;
            this.RegistrationNum.Text = this.contract.VehicleRented.idVehicle.ToString();
            this.OilCap.Text = this.contract.VehicleRented.SizeOil.ToString();
            this.FluidStatus.Text = this.contract.VehicleRented.SizeFluid.ToString();
            this.KilometerRun.Text = this.contract.VehicleRented.NumberKilometers.ToString();
            this.CostPerDay.Text = this.contract.VehicleRented.costperDay.ToString();
            this.FromStartToEnd.Text = this.FromStartToEnd.Text + $"from {this.contract.DateStartRent.ToString()} to {this.contract.DateEndRent.ToString()}";
            this.Model.Text = this.contract.VehicleRented.Branch.ToString();
            this.TotalCost.Text = this.TotalCost.Text + this.contract.TotalCost.ToString();
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

            Form formManage = new FormManage(this.manage);
            var thread = new Thread(() => Program.start(formManage));
            thread.Start();
            this.Close();
        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }
    }
}
