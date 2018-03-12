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
    public partial class IncidentReportsForm : MetroFramework.Forms.MetroForm
    {
        public IncidentReportsForm()
        {
            InitializeComponent();
        }
        public static IncidentReportsForm instance;
        public static IncidentReportsForm getInstance()
        {
            if (instance == null || instance.IsDisposed)
                instance = new IncidentReportsForm();
            else
                instance.BringToFront();
            return instance;
        }

    }
}
