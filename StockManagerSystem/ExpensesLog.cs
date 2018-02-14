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
    public partial class ExpensesLog : Form
    {
        public ExpensesLog()
        {
            InitializeComponent();
        }

        private void closeExpensesLogForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
