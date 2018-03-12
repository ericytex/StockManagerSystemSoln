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
    public partial class InpatientManagementForm : MetroFramework.Forms.MetroForm
    {
        public InpatientManagementForm()
        {
            InitializeComponent();
        }

        public static InpatientManagementForm instance;
        public static InpatientManagementForm getInstance()
        {
            if (instance == null || instance.IsDisposed)
                instance = new InpatientManagementForm();
            else
                instance.BringToFront();
            return instance;
        }
    }
}
