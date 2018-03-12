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
    public partial class OutPatientManagementForm :MetroFramework.Forms.MetroForm
    {
        public OutPatientManagementForm()
        {
            InitializeComponent();
        }

     public static OutPatientManagementForm instance;
        public static OutPatientManagementForm getInstance()
        {
            if (instance == null || instance.IsDisposed)
                instance = new OutPatientManagementForm();
            else
                instance.BringToFront();
            return instance;
        }   
    }

}
