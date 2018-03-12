using System;
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
    public partial class NurseManagementForm : MetroFramework.Forms.MetroForm
    {
        public NurseManagementForm()
        {
            InitializeComponent();
        }

        public static NurseManagementForm instance;
        public static NurseManagementForm getInstance()
        {
            if (instance == null || instance.IsDisposed)
                instance = new NurseManagementForm();
            else
                instance.BringToFront();
            return instance;
        }
    }
}

