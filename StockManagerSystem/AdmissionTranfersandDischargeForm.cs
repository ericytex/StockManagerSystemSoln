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
    public partial class AdmissionTranfersandDischargeForm : MetroFramework.Forms.MetroForm
    {
        public AdmissionTranfersandDischargeForm()
        {
            InitializeComponent();
        }

        public static AdmissionTranfersandDischargeForm instance;
        public static AdmissionTranfersandDischargeForm getInstance()
        {
            if (instance == null || instance.IsDisposed)
                instance = new AdmissionTranfersandDischargeForm();
            else
                instance.BringToFront();
            return instance;
        }
    }
}

