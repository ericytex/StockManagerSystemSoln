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
    public partial class ServiceOrderProcessingForm : MetroFramework.Forms.MetroForm
    {
        public ServiceOrderProcessingForm()
        {
            InitializeComponent();
        }

        public static ServiceOrderProcessingForm instance;
        public static ServiceOrderProcessingForm getInstance()
        {
            if (instance == null || instance.IsDisposed)
                instance = new ServiceOrderProcessingForm();
            else
                instance.BringToFront();
            return instance;
        }

    }
}
