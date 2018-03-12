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
    public partial class PatientBilling :MetroFramework.Forms.MetroForm
    {

        SqlConnection connecttodb = new SqlConnection(@"Data Source=DESKTOP-JBPJ74V\SQLSERVERJAN2018;Initial Catalog = StkManagementSystem; Integrated Security = True");
        private string selectquerry;
        SqlCommand com;

        public PatientBilling()
        {
            InitializeComponent();

        }


        private void labelClosePatientBilling_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroTextBoxPatientFileNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {

                    connecttodb.Open();
                    selectquerry = string.Format("SELECT * from patients WHERE [uniqueid] = '" + metroTextBoxPatientFileNumber.Text.Trim() +"'");
                    com = new SqlCommand(selectquerry, connecttodb) ;
                    SqlDataReader reader = com.ExecuteReader();

                    if(reader.Read())
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

        private void PatientBilling_Load(object sender, EventArgs e)
        {/*
            //comboBoxDiagnosis.Items.Clear();
            connecttodb.Open();
            SqlCommand cmd = connecttodb.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from diagnosis";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows) 
            {
                comboBoxDiagnosis.Items.Add(dr["diagnosis"].ToString());
            }
            */
        }
    }
}
