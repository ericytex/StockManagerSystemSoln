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
    public partial class PharmacyManagementForm : MetroFramework.Forms.MetroForm
    {
        public PharmacyManagementForm()
        {
            InitializeComponent();
        }
        public static PharmacyManagementForm instance;
        public static PharmacyManagementForm getInstance()
        {
            if (instance == null || instance.IsDisposed)
                instance = new PharmacyManagementForm();
            else
                instance.BringToFront();
            return instance;
        }
    }
}
