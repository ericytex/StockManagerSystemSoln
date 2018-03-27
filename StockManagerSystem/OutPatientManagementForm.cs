using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagerSystem
{
    public partial class OutPatientManagementForm :MetroFramework.Forms.MetroForm
    {
        SqlConnection connecttodb = new SqlConnection(@"Data Source=DESKTOP-JBPJ74V\SQLSERVERJAN2018;Initial Catalog = StkManagementSystem; Integrated Security = True");
        private string selectquerry;
        SqlCommand com;
        public OutPatientManagementForm()
        {
            InitializeComponent();
            metroPanelOutPatientManagementDashboard m = new metroPanelOutPatientManagementDashboard();
            metroPanelPatientRegistration.Visible = false;
            metroPanelViewAllPatientsPanel.Visible = false;
            metroPanelProcessPatient.Visible = false;
           
        }

     public static OutPatientManagementForm instance;
        
        public static OutPatientManagementForm getInstance()
        {

            if (instance == null || instance.IsDisposed)
                instance = new OutPatientManagementForm();
            else
                instance.BringToFront();
            return instance;
        }

        

        private void metroRadioButtonPatientRegistration_CheckedChanged(object sender, EventArgs e)
        {
            
            if(metroPanelOutPatientManagementDashboard.Visible == true || metroPanelViewAllPatientsPanel.Visible == true || metroPanelPatientRegistration.Visible == true || metroPanelProcessPatient.Visible == true)
            {
                metroPanelOutPatientManagementDashboard.Visible = false;
                metroPanelViewAllPatientsPanel.Visible = false;
                metroRadioButtonPatientRegistration.ForeColor = Color.DodgerBlue;
                metroRadioButtonViewAllPatients.ForeColor = Color.DarkCyan;
                metroRadioButtonProcessPatient.ForeColor = Color.DarkCyan;
                metroPanelProcessPatient.Visible = false;
                metroPanelPatientRegistration.Visible = true;
                
            }
            
            
        }

        private void metroRadioButtonViewAllPatients_CheckedChanged(object sender, EventArgs e)
        {

            if (metroPanelOutPatientManagementDashboard.Visible == true || metroPanelViewAllPatientsPanel.Visible == true || metroPanelPatientRegistration.Visible == true || metroPanelProcessPatient.Visible == true)
            {
                metroRadioButtonPatientRegistration.ForeColor = Color.DarkCyan;
                metroRadioButtonProcessPatient.ForeColor = Color.DarkCyan;
                metroRadioButtonViewAllPatients.ForeColor = Color.DodgerBlue;
                metroPanelPatientRegistration.Visible = false;
                metroPanelOutPatientManagementDashboard.Visible = false;
                metroPanelProcessPatient.Visible = false;
                metroPanelViewAllPatientsPanel.Visible = true;


            }
        }

        private void metroRadioButtonProcessPatient_CheckedChanged(object sender, EventArgs e)
        {
            if (metroPanelOutPatientManagementDashboard.Visible == true || metroPanelViewAllPatientsPanel.Visible == true || metroPanelPatientRegistration.Visible == true || metroPanelProcessPatient.Visible == true)
            {
                metroRadioButtonPatientRegistration.ForeColor = Color.DarkCyan;
                metroRadioButtonViewAllPatients.ForeColor = Color.DarkCyan;
                metroRadioButtonProcessPatient.ForeColor = Color.DodgerBlue;
                metroPanelPatientRegistration.Visible = false;
                metroPanelOutPatientManagementDashboard.Visible = false;
                metroPanelViewAllPatientsPanel.Visible = false;
                metroPanelProcessPatient.Visible = true;

            }
        }

        private void metroTextBoxPatientFileNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {

                    connecttodb.Open();
                    selectquerry = string.Format("SELECT * from patients WHERE [uniqueid] = '" + metroTextBoxPatientFileNumber.Text.Trim() + "'");
                    com = new SqlCommand(selectquerry, connecttodb);
                    SqlDataReader reader = com.ExecuteReader();

                    if (reader.Read())
                    {
                        textBoxFirstName.Text = reader["firstname"].ToString();
                        textBoxMiddleName.Text = reader["middlename"].ToString();
                        textBoxLastName.Text = reader["lastname"].ToString();

                    }




                    connecttodb.Close();
                }
                catch (Exception ex)
                {
                    // handle exception
                }
            }
        }
    }

}
