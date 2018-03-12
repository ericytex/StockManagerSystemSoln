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
    public partial class LaboratoryManagementForm : MetroFramework.Forms.MetroForm
    {
        public LaboratoryManagementForm()
        {
            InitializeComponent();
        }
        public static LaboratoryManagementForm instance;
        public static LaboratoryManagementForm getInstance()
        {
            if (instance == null || instance.IsDisposed)
                instance = new LaboratoryManagementForm();
            else
                instance.BringToFront();
            return instance;
        }

    }
}
