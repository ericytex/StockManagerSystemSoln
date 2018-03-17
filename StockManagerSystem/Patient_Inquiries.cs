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
    public partial class Patient_Inquiries : Form
    {
        public Patient_Inquiries()
        {
            InitializeComponent();
        }
        public static Patient_Inquiries instance;

        public static Patient_Inquiries getInstance()
        {
            if (instance == null || instance.IsDisposed)
                instance = new Patient_Inquiries();
            else
                instance.BringToFront();
            return instance;
        }
    }
}
