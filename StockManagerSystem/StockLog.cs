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
    public partial class StockLog : MetroFramework.Forms.MetroForm
    {
        public StockLog()
        {
            InitializeComponent();
        }

        private void labelCloseLogStockForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
