﻿using System.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagerSystem
{
    public partial class ViewPatients : MetroFramework.Forms.MetroForm
    {
        public ViewPatients()
        {
            InitializeComponent();
        }

        public static object ConfigurationManager { get; private set; }

        private void labelCloseViewPatientsForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public class connectionClass
        {

        }
    }
}
