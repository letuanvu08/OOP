﻿using System;
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
     partial class FormManage : Form
    {
        CarRentalManagement manage;
        public FormManage(CarRentalManagement manage)
        {
            InitializeComponent();
            this.manage = manage;
        }
    }
}
