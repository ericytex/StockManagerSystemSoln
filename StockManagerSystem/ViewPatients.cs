using System.Configuration;
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
using MetroFramework.Components;

namespace StockManagerSystem
{
    public partial class ViewPatients : MetroFramework.Forms.MetroForm
    {

        SqlConnection connecttodb = new SqlConnection(@"Data Source=DESKTOP-JBPJ74V\SQLSERVERJAN2018;Initial Catalog = StkManagementSystem; Integrated Security = True");
        //private MetroStyleManager metroStyelManager1;

        public ViewPatients()
        {
            InitializeComponent();
            ///Initialize theme, style
            ///
            /*
            this.StyleManager = metroStyelManager1;
            metroStyelManager1.Theme = MetroFramework.MetroThemeStyle.Light;
            metroStyelManager1.Style = MetroFramework.MetroColorStyle.Green;
            */

        }

       // private void ViewPatients_Load(object sender, EventArgs e)
       // {
           
            

      //  }
      /*
        private void buttonSearchForPatient_Click(object sender, EventArgs e)
        {
            try
            {

                using (StkManagementPatientsEntities stkPE = new StkManagementPatientsEntities())//create instance of data context
                {
                   
                }

            }
            catch (Exception exe)
            {
                MetroFramework.MetroMessageBox.Show(this, exe.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        */
     

        private void ViewPatients_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stkManagementSystemDataSet.patients' table. You can move, or remove it, as needed.
            this.patientsTableAdapter.Fill(this.stkManagementSystemDataSet.patients);

        }

        private void metroTextSearchPatients_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                try
                {

                    connecttodb.Open();
                    SqlCommand cmd = connecttodb.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = string.Format("SELECT * from patients WHERE [firstname] LIKE '%{0}%'", metroTextSearchPatients.Text);
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    metroGrid2.DataSource = dt;
                    connecttodb.Close();
                }
                catch (Exception ex)
                {
                    // handle exception
                }
            }
        }

        private void buttonSearchForPatient_Click(object sender, EventArgs e)
        {


           try
            {

                connecttodb.Open();
                SqlCommand cmd = connecttodb.CreateCommand();
                cmd.CommandType = CommandType.Text;
               // cmd.CommandText = "select * from patients where firstname  like  '" + metroTextSearchPatients.Text + "' or middlename like   '" + metroTextSearchPatients.Text + "'";
                cmd.CommandText = string.Format("SELECT * from patients WHERE [firstname] LIKE '%{0}%'",  metroTextSearchPatients.Text) ;
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                metroGrid2.DataSource = dt;
                connecttodb.Close();
            }
            catch(Exception ex)
            {
                // handle exception
            }


            
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                connecttodb.Open();
                SqlCommand cmd = connecttodb.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from patients ";
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                metroGrid2.DataSource = dt;
                connecttodb.Close();
            }
            catch (Exception ex)
            {
                // handle exception
            }
        }
    }
    }


