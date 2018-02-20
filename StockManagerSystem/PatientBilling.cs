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
    public partial class PatientBilling :MetroFramework.Forms.MetroForm
    {
        public PatientBilling()
        {
            InitializeComponent();
        }


        private void labelClosePatientBilling_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
