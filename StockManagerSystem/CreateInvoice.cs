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
    public partial class CreateInvoice :MetroFramework.Forms.MetroForm
    {
        public CreateInvoice()
        {
            InitializeComponent();
        }



        private void labelCloseCreateInvoiceForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
