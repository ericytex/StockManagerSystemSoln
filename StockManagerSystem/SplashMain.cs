﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagerSystem
{
    public partial class SplashMain : Form
    {
        public SplashMain()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
            Dashboard dash = new Dashboard();
            dash.Show();
            this.Hide();
           
        }
    }
}