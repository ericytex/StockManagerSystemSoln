using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace StockManagerSystem
{

    public partial class Dashboard :MetroFramework.Forms.MetroForm
    {
        private int childFormNumber = 0;
        bool _logOut;
        
       

        public Dashboard(string loginstate)
        {
            InitializeComponent();
            //LoginStatus.Text = loginstate;
            

        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

       
        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void viewAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            ViewPatients vp = new ViewPatients();

            vp.MdiParent = this;
            vp.Dock = DockStyle.Fill;
            vp.Show();
        }

        private void registerPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterPatient rp = new RegisterPatient();
            rp.MdiParent = this;
            //rp.Dock = DockStyle.Fill;
            rp.Show();
        }

        private void createInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateInvoice cn = new CreateInvoice();
            cn.MdiParent = this;
            cn.Dock = DockStyle.Fill;
            cn.Show();
        }

        private void logBankingDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BankingLog lb = new BankingLog();
            lb.MdiParent = this;
            //lb.Dock = DockStyle.Fill;
            lb.Show();
        }

        private void logStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ///TODO crate proper interface for log stock
            ///
            //StockLog sl = new StockLog();
            //sl.MdiParent = this;
           // sl.Dock = DockStyle.Fill;
           // sl.Show();
        }

        private void stockOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ///TODO create proper form for placing order
            //PlaceOrder po = new PlaceOrder();
            //po.MdiParent = this;
            //po.Dock = DockStyle.Fill;
           // po.Show();
        }

        private void dailyExpensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ///TODO Create proper form for expenses 
            //ExpensesLog el = new ExpensesLog();
            //el.MdiParent = this;
           // el.Dock = DockStyle.Fill;
           // el.Show();
        }

        private void billPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PatientBilling pb = new PatientBilling();
            pb.MdiParent = this;
            pb.Dock = DockStyle.Fill;
            pb.Show();
        }

        private void createNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateNewUser cnu = new CreateNewUser();
            cnu.MdiParent = this;
           // cnu.Dock = DockStyle.Fill;
            cnu.Show();
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Dashboard closure
            if (!_logOut)
                Application.Exit();
        }

        private void logout_Click(object sender, EventArgs e)
        {

            if(MetroFramework.MetroMessageBox.Show(this, "Are you sue you want to log out of Stock System Manager ? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            { 
            _logOut = true;
            this.Close();
            LoginMain.Instance.Show();
            }
        }

        private void pictureBoxBackButton_Click(object sender, EventArgs e)
        {
            if(sidePanel.Width == 230)
            {
                pictureBoxBackButton.Hide();
                sidePanel.Width = 34;
                pictureBoxBackButton.Hide();
                sidePanel.BackColor = Color.DarkOrange;
                pictureBoxMenubutton.Show();

                ///Disabling AutoScroll horizontal
                sidePanel.HorizontalScroll.Enabled = false;
                //sidePanel.HorizontalScroll.Maximum = 0;
                sidePanel.AutoScroll = false;
            }
           
            

            
        }

        private void pictureBoxMenubutton_Click(object sender, EventArgs e)
        {
            if (sidePanel.Width == 34)
            {
                sidePanel.Width = 230;
                pictureBoxMenubutton.Hide();
                sidePanel.BackColor = Color.DarkSlateGray;
                pictureBoxBackButton.Show();
                
                ///Enabling Autoscroll vertical
                sidePanel.HorizontalScroll.Enabled = false;
                sidePanel.HorizontalScroll.Maximum = 0;
                sidePanel.AutoScroll = true;
            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            if (sidePanel.Width != 34)
            {
                //sidePanel.AutoScroll = false;
                sidePanel.HorizontalScroll.Enabled = false;
                sidePanel.HorizontalScroll.Maximum = 0;
                sidePanel.AutoScroll = true;
            }
            
        }

        private void Patient_MouseDown(object sender, MouseEventArgs e)
        {
            Patient_Inquiries pi =  Patient_Inquiries.getInstance();
            pi.MdiParent = this;
            pi.Dock = DockStyle.Fill;
            pi.Show();
            inquiry.Visible = false;
        }

        private void labelInformanagement_MouseDown(object sender, MouseEventArgs e)
        {
            informationManagementForm pi = informationManagementForm.getInstance();
            pi.MdiParent = this;
            pi.Dock = DockStyle.Fill;
            pi.Show();
        }

        private void labeloutpatientManagement_MouseDown(object sender, MouseEventArgs e)
        {
            OutPatientManagementForm pi = OutPatientManagementForm.getInstance();
            pi.MdiParent = this;
            pi.Dock = DockStyle.Fill;
            pi.Show();
        }

        private void labelinpatientmanagement_MouseDown(object sender, MouseEventArgs e)
        {
            InpatientManagementForm pi = InpatientManagementForm.getInstance();
            pi.MdiParent = this;
            pi.Dock = DockStyle.Fill;
            pi.Show();
        }

        private void labelPharmacyManagement_MouseDown(object sender, MouseEventArgs e)
        {
            PharmacyManagementForm pi = PharmacyManagementForm.getInstance();
            pi.MdiParent = this;
            pi.Dock = DockStyle.Fill;
            pi.Show();
        }

        private void labelNursemanagement_MouseDown(object sender, MouseEventArgs e)
        {
            NurseManagementForm pi = NurseManagementForm.getInstance();
            pi.MdiParent = this;
            pi.Dock = DockStyle.Fill;
            pi.Show();
        }

        private void labelAdminission_MouseDown(object sender, MouseEventArgs e)
        {
            AdmissionTranfersandDischargeForm pi = AdmissionTranfersandDischargeForm.getInstance();
            pi.MdiParent = this;
            pi.Dock = DockStyle.Fill;
            pi.Show();
        }

        private void labelPatientcare_MouseDown(object sender, MouseEventArgs e)
        {
            PatientCareManagementForm pi = PatientCareManagementForm.getInstance();
            pi.MdiParent = this;
            pi.Dock = DockStyle.Fill;
            pi.Show();
        }

        private void labelIncidentReports_MouseDown(object sender, MouseEventArgs e)
        {
            IncidentReportsForm pi = IncidentReportsForm.getInstance();
            pi.MdiParent = this;
            pi.Dock = DockStyle.Fill;
            pi.Show();
        }

        private void labelHelpDesk_MouseDown(object sender, MouseEventArgs e)
        {
            HelpDeskForm pi = HelpDeskForm.getInstance();
            pi.MdiParent = this;
            pi.Dock = DockStyle.Fill;
            pi.Show();
        }

        private void labelQueueManagement_MouseDown(object sender, MouseEventArgs e)
        {
            QueueManagement pi = QueueManagement.getInstance();
            pi.MdiParent = this;
            pi.Dock = DockStyle.Fill;
            pi.Show();
        }

        private void labelConsultingAppointment_MouseDown(object sender, MouseEventArgs e)
        {
            ConsultingAppointmentForm pi = ConsultingAppointmentForm.getInstance();
            pi.MdiParent = this;
            pi.Dock = DockStyle.Fill;
            pi.Show();
        }

        private void labelServiceOrderProcessing_MouseDown(object sender, MouseEventArgs e)
        {
            ServiceOrderProcessingForm pi = ServiceOrderProcessingForm.getInstance();
            pi.MdiParent = this;
            pi.Dock = DockStyle.Fill;
            pi.Show();
        }

        private void labelLaboratory_MouseDown(object sender, MouseEventArgs e)
        {
            LaboratoryManagementForm pi = LaboratoryManagementForm.getInstance();
            pi.MdiParent = this;
            pi.Dock = DockStyle.Fill;
            pi.Show();
        }

        private void labelMaterial_MouseDown(object sender, MouseEventArgs e)
        {
            MaterialManagementForm pi = MaterialManagementForm.getInstance();
            pi.MdiParent = this;
            pi.Dock = DockStyle.Fill;
            pi.Show();
        }

        private void labelRadiology_MouseDown(object sender, MouseEventArgs e)
        {
            RadiologyManagementForm pi = RadiologyManagementForm.getInstance();
            pi.MdiParent = this;
            pi.Dock = DockStyle.Fill;
            pi.Show();
        }

        private void labelStatistics_MouseDown(object sender, MouseEventArgs e)
        {
            StatisticsandReportingForm pi = StatisticsandReportingForm.getInstance();
            pi.MdiParent = this;
            pi.Dock = DockStyle.Fill;
            pi.Show();
        }

        private void labelCashier_MouseDown(object sender, MouseEventArgs e)
        {
            CashierManagementForm pi = CashierManagementForm.getInstance();
            pi.MdiParent = this;
            pi.Dock = DockStyle.Fill;
            pi.Show();
        }
        
        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            if(sidePanel.Width == 34 & inquiry.Visible == false)
            {
                inquiry.Visible = true;
            }
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            if (sidePanel.Width == 34 & inquiry.Visible == true)
            {
                inquiry.Visible = false;
            }
        }
        private void pictureBoxInformationManagement_MouseHover(object sender, EventArgs e)
        {
            if (sidePanel.Width == 34 & informationManagementPopup.Visible == false)
            {
                informationManagementPopup.Visible = true;
            }
        }


        private void pictureBoxInformationManagement_MouseLeave(object sender, EventArgs e)
        {
            if (sidePanel.Width == 34 & informationManagementPopup.Visible == true)
            {
                informationManagementPopup.Visible = false;
            }
        }

        private void outpatientpicturebxinformationmangt_MouseHover(object sender, EventArgs e)
        {
            if (sidePanel.Width == 34 & OutpatientManagementPopup.Visible == false)
            {
                OutpatientManagementPopup.Visible = true;
            }
        }

        private void outpatientpicturebxinformationmangt_MouseLeave(object sender, EventArgs e)
        {
            if (sidePanel.Width == 34 & OutpatientManagementPopup.Visible == true)
            {
                OutpatientManagementPopup.Visible = false;
            }
        }

        private void inpatientpicturebox_MouseHover(object sender, EventArgs e)
        {
            if (sidePanel.Width == 34 & InpatientManagementPopup.Visible == false)
            {
                InpatientManagementPopup.Visible = true;
            }
        }

        private void inpatientpicturebox_MouseLeave(object sender, EventArgs e)
        {
            if (sidePanel.Width == 34 & InpatientManagementPopup.Visible == true)
            {
                InpatientManagementPopup.Visible = false;
            }
        }

        private void pictureBoxpharmacy_MouseHover(object sender, EventArgs e)
        {
            if (sidePanel.Width == 34 & PharmacyManagementPopup.Visible == false)
            {
                PharmacyManagementPopup.Visible = true;
            }
        }

        private void pictureBoxpharmacy_MouseLeave(object sender, EventArgs e)
        {
            if (sidePanel.Width == 34 & PharmacyManagementPopup.Visible == true)
            {
                PharmacyManagementPopup.Visible = false;
            }
        }

        private void pictureBoxNursemanagement_MouseHover(object sender, EventArgs e)
        {
            if (sidePanel.Width == 34 & NursingManagementPopup.Visible == false)
            {
                NursingManagementPopup.Visible = true;
            }
        }

        private void pictureBoxNursemanagement_MouseLeave(object sender, EventArgs e)
        {
            if (sidePanel.Width == 34 & NursingManagementPopup.Visible == true)
            {
                NursingManagementPopup.Visible = false;
            }
        }

        private void pictureBoxAdmissions_MouseHover(object sender, EventArgs e)
        {
            if (sidePanel.Width == 34 & AdmissionTransfersandDischargesPopup.Visible == false)
            {
                AdmissionTransfersandDischargesPopup.Visible = true;
            }
        }

        private void pictureBoxAdmissions_MouseLeave(object sender, EventArgs e)
        {
            if (sidePanel.Width == 34 & AdmissionTransfersandDischargesPopup.Visible == true)
            {
                AdmissionTransfersandDischargesPopup.Visible = false;
            }
        }

        private void pictureBoxPatientCare_MouseHover(object sender, EventArgs e)
        {
            if (sidePanel.Width == 34 & PatientCarePopup.Visible == false)
            {
                PatientCarePopup.Visible = true;
            }
        }

        private void pictureBoxPatientCare_MouseLeave(object sender, EventArgs e)
        {
            if (sidePanel.Width == 34 & PatientCarePopup.Visible == true)
            {
                PatientCarePopup.Visible = false;
            }
        }

        private void pictureBoxIncidentReports_MouseHover(object sender, EventArgs e)
        {
            if (sidePanel.Width == 34 & IncidentReportsPopup.Visible == false)
            {
                IncidentReportsPopup.Visible = true;
            }
        }

        private void pictureBoxIncidentReports_MouseLeave(object sender, EventArgs e)
        {
            if (sidePanel.Width == 34 & IncidentReportsPopup.Visible == true)
            {
                IncidentReportsPopup.Visible = false;
            }
        }

        private void pictureBoxHelpDesk_MouseHover(object sender, EventArgs e)
        {
            if (sidePanel.Width == 34 & HelpDeskPopup.Visible == false)
            {
                HelpDeskPopup.Visible = true;
            }
        }

        private void pictureBoxHelpDesk_MouseLeave(object sender, EventArgs e)
        {
            if (sidePanel.Width == 34 & HelpDeskPopup.Visible == true)
            {
                HelpDeskPopup.Visible = false;
            }
        }

        private void pictureBoxQueueManagement_MouseHover(object sender, EventArgs e)
        {
            if (sidePanel.Width == 34 & QueueManagementPopup.Visible == false)
            {
                QueueManagementPopup.Visible = true;
            }
        }

        private void pictureBoxQueueManagement_MouseLeave(object sender, EventArgs e)
        {
            if (sidePanel.Width == 34 & QueueManagementPopup.Visible == true)
            {
                QueueManagementPopup.Visible = false;
            }
        }

        private void pictureBoxConsultAppointment_MouseHover(object sender, EventArgs e)
        {
            if (sidePanel.Width == 34 & ConsultingAppointmentPopup.Visible == false)
            {
                ConsultingAppointmentPopup.Visible = true;
            }
        }

        private void pictureBoxConsultAppointment_MouseLeave(object sender, EventArgs e)
        {
            if (sidePanel.Width == 34 & ConsultingAppointmentPopup.Visible == true)
            {
                ConsultingAppointmentPopup.Visible = false;
            }
        }

        private void pictureBoxServiceOrderProcessing_MouseHover(object sender, EventArgs e)
        {
            if (sidePanel.Width == 34 & ServiceOrderProcessingPopup.Visible == false)
            {
                ServiceOrderProcessingPopup.Visible = true;
            }
        }

        private void pictureBoxServiceOrderProcessing_MouseLeave(object sender, EventArgs e)
        {
            if (sidePanel.Width == 34 & ServiceOrderProcessingPopup.Visible == true)
            {
                ServiceOrderProcessingPopup.Visible = false;
            }
        }

        private void pictureBoxLaboratory_MouseHover(object sender, EventArgs e)
        {
            if (sidePanel.Width == 34 & LaboratoryManagementPopup.Visible == false)
            {
                LaboratoryManagementPopup.Visible = true;
            }
        }

        private void pictureBoxLaboratory_MouseLeave(object sender, EventArgs e)
        {
            if (sidePanel.Width == 34 & LaboratoryManagementPopup.Visible == true)
            {
                LaboratoryManagementPopup.Visible = false;
            }
        }

        private void pictureBoxMaterial_MouseHover(object sender, EventArgs e)
        {
            if (sidePanel.Width == 34 & MaterialManagementPopup.Visible == false)
            {
                MaterialManagementPopup.Visible = true;
            }
        }

        private void pictureBoxMaterial_MouseLeave(object sender, EventArgs e)
        {
            if (sidePanel.Width == 34 & MaterialManagementPopup.Visible == true)
            {
                MaterialManagementPopup.Visible = false;
            }
        }

        private void pictureBoxRadiology_MouseHover(object sender, EventArgs e)
        {
            if (sidePanel.Width == 34 & RadiologyManagementPopup.Visible == false)
            {
                RadiologyManagementPopup.Visible = true;
            }
        }

        private void pictureBoxRadiology_MouseLeave(object sender, EventArgs e)
        {
            if (sidePanel.Width == 34 & RadiologyManagementPopup.Visible == true)
            {
                RadiologyManagementPopup.Visible = false;
            }
        }

        private void pictureBoxStatistics_MouseHover(object sender, EventArgs e)
        {
            if (sidePanel.Width == 34 & StatisticsandReportingPopup.Visible == false)
            {
                StatisticsandReportingPopup.Visible = true;
            }
        }

        private void pictureBoxStatistics_MouseLeave(object sender, EventArgs e)
        {
            if (sidePanel.Width == 34 & StatisticsandReportingPopup.Visible == true)
            {
                StatisticsandReportingPopup.Visible = false;
            }
        }

        private void pictureBoxCashier_MouseHover(object sender, EventArgs e)
        {
            if (sidePanel.Width == 34 & CashierManagementPopup.Visible == false)
            {
                CashierManagementPopup.Visible = true;
            }
        }

        private void pictureBoxCashier_MouseLeave(object sender, EventArgs e)
        {
            if (sidePanel.Width == 34 & CashierManagementPopup.Visible == true)
            {
                CashierManagementPopup.Visible = false;
            }
        }

    }
}
