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
    public partial class CashierManagementForm : MetroFramework.Forms.MetroForm
    {
        public CashierManagementForm()
        {
            InitializeComponent();
        }
        public static CashierManagementForm instance;
        public static CashierManagementForm getInstance()
        {
            if (instance == null || instance.IsDisposed)
                instance = new CashierManagementForm();
            else
                instance.BringToFront();
            return instance;
        }


    }
}
