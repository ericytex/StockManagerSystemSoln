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
    public partial class PatientCareManagementForm : MetroFramework.Forms.MetroForm
    {
        public PatientCareManagementForm()
        {
            InitializeComponent();
        }
        public static PatientCareManagementForm instance;
        public static PatientCareManagementForm getInstance()
        {
            if (instance == null || instance.IsDisposed)
                instance = new PatientCareManagementForm();
            else
                instance.BringToFront();
            return instance;
        }
    }
}
