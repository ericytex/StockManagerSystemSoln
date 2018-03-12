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
    public partial class RadiologyManagementForm : MetroFramework.Forms.MetroForm
    {
        public RadiologyManagementForm()
        {
            InitializeComponent();
        }
        public static RadiologyManagementForm instance;
        public static RadiologyManagementForm getInstance()
        {
            if (instance == null || instance.IsDisposed)
                instance = new RadiologyManagementForm();
            else
                instance.BringToFront();
            return instance;
        }

    }
}
