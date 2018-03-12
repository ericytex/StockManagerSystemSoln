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
    public partial class ConsultingAppointmentForm : MetroFramework.Forms.MetroForm
    {
        public ConsultingAppointmentForm()
        {
            InitializeComponent();
        }
        public static ConsultingAppointmentForm instance;
        public static ConsultingAppointmentForm getInstance()
        {
            if (instance == null || instance.IsDisposed)
                instance = new ConsultingAppointmentForm();
            else
                instance.BringToFront();
            return instance;
        }

    }
}
