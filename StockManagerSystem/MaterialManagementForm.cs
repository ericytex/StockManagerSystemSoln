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
    public partial class MaterialManagementForm : MetroFramework.Forms.MetroForm
    {
        public MaterialManagementForm()
        {
            InitializeComponent();
        }

        public static MaterialManagementForm instance;
        public static MaterialManagementForm getInstance()
        {
            if (instance == null || instance.IsDisposed)
                instance = new MaterialManagementForm();
            else
                instance.BringToFront();
            return instance;
        }

    }
}
