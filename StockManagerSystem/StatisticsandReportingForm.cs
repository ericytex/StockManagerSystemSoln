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
    public partial class StatisticsandReportingForm : MetroFramework.Forms.MetroForm
    {
        public StatisticsandReportingForm()
        {
            InitializeComponent();
        }
        public static StatisticsandReportingForm instance;
        public static StatisticsandReportingForm getInstance()
        {
            if (instance == null || instance.IsDisposed)
                instance = new StatisticsandReportingForm();
            else
                instance.BringToFront();
            return instance;
        }

    }
}
