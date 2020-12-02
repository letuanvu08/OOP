﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading; 


namespace WindowsFormsApp
{
    partial class FormServiceAVehicle : Form, IObserver, IDisplayElement
    {
        private CarRentalManagement manager;
        private Vehicle vehicleNeedServicing;
        private ServiceHistory ServiceLog;
        // Implementing the interface IObserver:
        public void Update(ISubject subject)
        {
            ServiceLog = (ServiceHistory)subject;
            Display();
        }
        // Implementing the interface IDisplayElement:
        public void Display()
        {
            ServiceHistoryListView.Items.Clear();
            foreach (var record in ServiceLog.GetListRecord())
            {
                addServiceRecordToListView(record);
            }
        }
        public FormServiceAVehicle(CarRentalManagement mangerInstance, Vehicle vehicleInstance)
        {
            InitializeComponent();
            this.manager = mangerInstance;
            this.vehicleNeedServicing = vehicleInstance;
            this.ServiceLog = vehicleNeedServicing.GetServiceHistory;
            this.ServiceLog.RegisterObserver(this);
            this.EngineStateComboBox.Text = vehicleNeedServicing.EngineState.ToString();
            this.TranmissionStateComboBox.Text = vehicleNeedServicing.TransmissionState.ToString();
            this.TiresStateComboBox.Text = vehicleNeedServicing.TiresState.ToString();
            populateComboboxes();
            displayPossibleServices();
            Display();
            // Load combobox options to manually set the states of the vehicle part:
        }
        private void displayPossibleServices()
        {
            ServicesAvailableList.Items.Clear();
            if ((vehicleNeedServicing.EngineState != TypeState.VeryGood) || (vehicleNeedServicing.EngineState != TypeState.Good)) {
                addServiceItem("engine", vehicleNeedServicing.EngineState.ToString());
            }
            if ((vehicleNeedServicing.TransmissionState != TypeState.VeryGood) || (vehicleNeedServicing.TransmissionState != TypeState.Good))
            {
                addServiceItem("tranmission", vehicleNeedServicing.TransmissionState.ToString());
            }
            if ((vehicleNeedServicing.TiresState != TypeState.VeryGood) || (vehicleNeedServicing.TiresState != TypeState.Good))
            {
                addServiceItem("tires", vehicleNeedServicing.TiresState.ToString());
            }
            MessageBox.Show($"engine:{vehicleNeedServicing.EngineState.ToString()}, tranmission:{vehicleNeedServicing.TransmissionState.ToString()}, tires:{vehicleNeedServicing.TiresState.ToString()}");
        }
        private void addServiceItem(string serviceType, string state)
        {
            if (serviceType == "engine")
            {
                if (state == "VeryBad")
                {
                    string[] serviceItem = new string[2];
                    serviceItem[0] = serviceType;
                    serviceItem[1] = $"The Engine for this {vehicleNeedServicing.Name} is in a Very Bad Situation. Need servicing immediately";
                    ServicesAvailableList.Items.Add(new ListViewItem(serviceItem));
                }
                else if (state == "Bad")
                {
                    string[] serviceItem = new string[2];
                    serviceItem[0] = serviceType;
                    serviceItem[1] = $"The Engine for this {vehicleNeedServicing.Name} is in a Bad Situation. You may choose to service it now or later. But the earlier the better";
                    ServicesAvailableList.Items.Add(new ListViewItem(serviceItem));
                }
            }
            else if (serviceType == "tranmission")
            {
                if (state == "VeryBad")
                {
                    string[] serviceItem = new string[2];
                    serviceItem[0] = serviceType;
                    serviceItem[1] = $"The Tramission for this {vehicleNeedServicing.Name} is in a Very Bad Situation. Need servicing immediately";
                    ServicesAvailableList.Items.Add(new ListViewItem(serviceItem));
                }
                else if (state == "Bad")
                {
                    string[] serviceItem = new string[2];
                    serviceItem[0] = serviceType;
                    serviceItem[1] = $"The Tranmission for this {vehicleNeedServicing.Name} is in a Bad Situation. You may choose to service it now or later. But the earlier the better";
                    ServicesAvailableList.Items.Add(new ListViewItem(serviceItem));
                }
            }
            else if (serviceType == "tires")
            {
                if (state == "VeryBad")
                {
                    string[] serviceItem = new string[2];
                    serviceItem[0] = serviceType;
                    serviceItem[1] = $"The Tires for this {vehicleNeedServicing.Name} is in a Very Bad Situation. Need servicing immediately";
                    ServicesAvailableList.Items.Add(new ListViewItem(serviceItem));
                }
                else if (state == "Bad")
                {
                    string[] serviceItem = new string[2];
                    serviceItem[0] = serviceType;
                    serviceItem[1] = $"The Tires for this {vehicleNeedServicing.Name} is in a Bad Situation. You may choose to service it now or later. But the earlier the better";
                    ServicesAvailableList.Items.Add(new ListViewItem(serviceItem));
                }
            }
        }
        private void addServiceRecordToListView(Record record)
        {
            string[] recordItem = new string[3];
            recordItem[0] = record.DateTime.ToString(CultureInfo.InvariantCulture);
            recordItem[2] = record.Description;

            if (record.GetType() == typeof(EngineRecord))
            {
                recordItem[1] = "Engine Maintenance";
            }
            else if (record.GetType() == typeof(TransmissionRecord))
            {
                recordItem[1] = "Transmission Maintenance";
            }
            else if (record.GetType() == typeof(TiresRecord))
            {
                recordItem[1] = "Tires Maintenance";
            }

            ServiceHistoryListView.Items.Add(new ListViewItem(recordItem));
        }
        private void populateComboboxes()
        {
            foreach (var item in Enum.GetValues(typeof(TypeState)))
            {
                this.EngineStateComboBox.Items.Add(item);
            }
            foreach (var item in Enum.GetValues(typeof(TypeState)))
            {
                this.TranmissionStateComboBox.Items.Add(item);
            }
            foreach (var item in Enum.GetValues(typeof(TypeState)))
            {
                this.TiresStateComboBox.Items.Add(item);
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if (vehicleNeedServicing.GetType() == typeof(Car))
            {
                foreach (var car in this.manager.GetListVehicle("car"))
                {
                    if (car.IdVehicle == vehicleNeedServicing.IdVehicle)
                    {
                        car.GetServiceHistory = this.ServiceLog;
                        break;
                    }
                }
            }
            else if (vehicleNeedServicing.GetType() == typeof(Truck))
            {
                foreach (var truck in this.manager.GetListVehicle("truck"))
                {
                    if (truck.IdVehicle == vehicleNeedServicing.IdVehicle)
                    {
                        truck.GetServiceHistory = this.ServiceLog;
                        break;
                    }
                }
            }
            Form formManage = new FormVehicleListService(this.manager);
            ServiceLog.RemoveObserver(this);
            var thread = new Thread(() => Program.Start(formManage));
            thread.Start();
            this.Close();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void reloadButton_Click(object sender, EventArgs e)
        {
            this.vehicleNeedServicing.EngineState = (TypeState)Enum.Parse(typeof(TypeState), EngineStateComboBox.Text, true);
            this.vehicleNeedServicing.TransmissionState = (TypeState)Enum.Parse(typeof(TypeState), TranmissionStateComboBox.Text, true);
            this.vehicleNeedServicing.TiresState = (TypeState)Enum.Parse(typeof(TypeState), TiresStateComboBox.Text, true);
            displayPossibleServices();
        }

        private void ServiceCheckedButton_Click(object sender, EventArgs e)
        {
            ListView.CheckedListViewItemCollection checkedItems = ServicesAvailableList.CheckedItems;
            foreach (ListViewItem item in checkedItems)
            {
                ListViewItem.ListViewSubItemCollection listSubItem = item.SubItems;
                string serviceType = listSubItem[0].Text;
                if (serviceType == "engine")
                {
                    vehicleNeedServicing.ServiceEngine();
                }
                else if (serviceType == "tranmission")
                {
                    vehicleNeedServicing.ServiceTransmission();
                }
                else if (serviceType == "tires")
                {
                    vehicleNeedServicing.ServiceTires();
                }
                // Update the service in the Form:

                // remove it from the left listview
                ServicesAvailableList.Items.Remove(item);
            }
        }
    }
}
