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
    public partial class SplashMain : MetroFramework.Forms.MetroForm
    {

        public SplashMain()
        {
            InitializeComponent();
        }

        private void stkpatientMngtlabel_Click(object sender, EventArgs e)
        {
            LoginMain lgmain = new LoginMain();
            lgmain.Show();
            this.Hide();
        }
    }
}
