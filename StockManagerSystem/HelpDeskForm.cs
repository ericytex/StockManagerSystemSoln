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
    public partial class HelpDeskForm : MetroFramework.Forms.MetroForm
    {
        public HelpDeskForm()
        {
            InitializeComponent();
        }

        public static HelpDeskForm instance;
        public static HelpDeskForm getInstance()
        {
            if (instance == null || instance.IsDisposed)
                instance = new HelpDeskForm();
            else
                instance.BringToFront();
            return instance;
        }

    }
}
