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
    public partial class LoginMain : MetroFramework.Forms.MetroForm
    {
        static LoginMain _instance;
        public static LoginMain Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new LoginMain();
                return _instance;
            }
        }
        public LoginMain()
        {
            InitializeComponent();
        }

        private void LoginMain_Load(object sender, EventArgs e)
        {
            _instance = this;
            metroTextUsername.Focus();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(metroTextUsername.Text))
                MetroFramework.MetroMessageBox.Show(this, "Please Enter your Username", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            metroTextUsername.Focus();
            

            try
            {
                using (StkManagementSystemEntities skme = new StkManagementSystemEntities())
                {
                    var query = from u in skme.users where u.Username == metroTextUsername.Text && u.Password == metroTextPassword.Text
                                select u;
                    if (query.SingleOrDefault() != null)
                    {
                        metroTextPassword.Clear();
                        metroTextUsername.Clear();
                        this.Hide();
                        Dashboard dashfrm = new Dashboard(string.Format("Logged in as :{0}", metroTextUsername.Text));
                        dashfrm.ShowDialog();
                    }
                    else
                        MetroFramework.MetroMessageBox.Show(this, "Your Username or Password is Incorrect", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception exe)
            {
                MetroFramework.MetroMessageBox.Show(this, exe.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return;
        }
    }
}
