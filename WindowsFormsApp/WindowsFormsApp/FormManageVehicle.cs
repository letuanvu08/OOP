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
        public FormManageVehicle(CarRentalManagement manage)
        {
            InitializeComponent();
            this.manage = manage;
        }

        private void Home_Click(object sender, EventArgs e)
        {
            Form formManage = new Form1(this.manage);
            var thread = new Thread(() => Program.start(formManage));
            thread.Start();
            this.Close();
        }

        private void RadioCarview_CheckedChanged(object sender, EventArgs e)
        {
            listResult.Items.Clear();
            List<Vehicle> listcar = manage.GetListVehicle("car");
            List<ListViewItem> listitem = new List<ListViewItem>();
            foreach (Vehicle vehicle in listcar)
            {
                listResult.ResetText();
                listitem.Add(new ListViewItem(vehicle.Name));
                listitem[listitem.Count - 1].SubItems.Add(new ListViewItem.ListViewSubItem() { Text = vehicle.idVehicle.ToString() });
                listitem[listitem.Count - 1].SubItems.Add(new ListViewItem.ListViewSubItem() { Text = (vehicle.Name) });
                listitem[listitem.Count - 1].SubItems.Add(new ListViewItem.ListViewSubItem() { Text = (vehicle.Branch) });
                listitem[listitem.Count - 1].SubItems.Add(new ListViewItem.ListViewSubItem() { Text = (vehicle.Type.ToString()) });



                listResult.Items.Add(listitem[listitem.Count - 1]);
            }
        }

        private void RadioTruckview_CheckedChanged(object sender, EventArgs e)
        {
            listResult.Items.Clear();
            List<Vehicle> listcar = manage.GetListVehicle("truck");
            List<ListViewItem> listitem = new List<ListViewItem>();
            foreach (Vehicle vehicle in listcar)
            {
                listResult.ResetText();
                listitem.Add(new ListViewItem(vehicle.Name));
                listitem[listitem.Count - 1].SubItems.Add(new ListViewItem.ListViewSubItem() { Text = vehicle.idVehicle.ToString() });
                listitem[listitem.Count - 1].SubItems.Add(new ListViewItem.ListViewSubItem() { Text = (vehicle.Name) });
                listitem[listitem.Count - 1].SubItems.Add(new ListViewItem.ListViewSubItem() { Text = (vehicle.Branch) });
                listitem[listitem.Count - 1].SubItems.Add(new ListViewItem.ListViewSubItem() { Text = (vehicle.Type.ToString()) });



                listResult.Items.Add(listitem[listitem.Count - 1]);
            }
        }
    }
}
