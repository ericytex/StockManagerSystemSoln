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
    public partial class QueueManagement : MetroFramework.Forms.MetroForm
    {
        public QueueManagement()
        {
            InitializeComponent();
        }

        public static QueueManagement instance;
        public static QueueManagement getInstance()
        {
            if (instance == null || instance.IsDisposed)
                instance = new QueueManagement();
            else
                instance.BringToFront();
            return instance;
        }

    }
}
