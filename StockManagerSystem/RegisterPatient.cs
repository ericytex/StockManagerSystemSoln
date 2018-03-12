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
    public partial class RegisterPatient : MetroFramework.Forms.MetroForm
    {
        SqlConnection connecttodb = new SqlConnection(@"Data Source=DESKTOP-JBPJ74V\SQLSERVERJAN2018;Initial Catalog = StkManagementSystem; Integrated Security = True");
        public RegisterPatient()
        {
            InitializeComponent();
            Edit(false);
        }

        private void Edit (bool value)
        {
            /**
            textBoxFirstName.Enabled = value;
            textBoxMiddleName.Enabled = value;
            textBoxLastName.Enabled = value;
            comboBoxGender.Enabled = value;
            textBoxAddress.Enabled = value;
            textBoxPhoneNumber.Enabled = value;
            textBoxNextOfKeen.Enabled = value;
            textBoxNationalId.Enabled = value;
    **/
        }
        private void labelCloseRegisterPatientForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegisterPatient_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stkManagementSystemDataSet.patients' table. You can move, or remove it, as needed.
           this.patientsTableAdapter.Fill(this.stkManagementSystemDataSet.patients);

        }

        private void buttonSubmitPatient_Click(object sender, EventArgs e)
        {
            try
            {

                // using (StkManagementSystemDataSet stkPE = new StkManagementSystemDataSet())//create instance of data context
                {
                    connecttodb.Open();
                    SqlCommand cmd = connecttodb.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT INTO[dbo].[patients]([firstname], [middlename], [lastname], [gender], [dob], [address], [phonenr], [nok], [idnr], [nokPhoneNr], [billier]) VALUES('"+ textBoxFirstName.Text +"', '"+ textBoxMiddleName.Text +"', '"+ textBoxLastName.Text +"', '"+ comboBoxGender.Text +"', '"+ dateDateOfBirth.Text.ToString() +"', '"+ textBoxAddress.Text +"', '"+ textBoxPhoneNumber.Text +"', '"+ textBoxNextOfKeen.Text +"', '"+ textBoxNationalId.Text +"', '"+ textBoxNOKPhoneNr.Text +"', '"+ comboBoxBiller.Text +"')";
                    cmd.ExecuteNonQuery();
                    
                    


                    MessageBox.Show("New patient added successfully", "Message", MessageBoxButtons.OK,MessageBoxIcon.Information);

                    textBoxFirstName.Clear();
                    textBoxMiddleName.Clear();
                    textBoxLastName.Clear();
                    comboBoxGender.ResetText();
                    dateDateOfBirth.ResetText();
                    textBoxAddress.Clear();
                    textBoxPhoneNumber.Clear();
                    textBoxNextOfKeen.Clear();
                    textBoxNationalId.Clear();
                    textBoxNOKPhoneNr.Clear();
                    comboBoxBiller.ResetText();
                }   

            }
            catch (Exception exe)
            {
                MetroFramework.MetroMessageBox.Show(this, exe.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                stkManagementSystemDataSet.patients.RejectChanges();
                connecttodb.Close();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
