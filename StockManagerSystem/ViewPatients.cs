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
    public partial class ViewPatients : Form
    {
        public ViewPatients()
        {
            InitializeComponent();
        }



        private void labelCloseViewPatientsForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
