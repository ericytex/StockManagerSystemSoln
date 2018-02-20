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
    public partial class CreateNewUser :MetroFramework.Forms.MetroForm
    {
        public CreateNewUser()
        {
            InitializeComponent();
        }



        private void labelCloseCreateNewUserForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
