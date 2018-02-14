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
    public partial class Dashboard : Form
    {
        private int childFormNumber = 0;

        public Dashboard()
        {
            InitializeComponent();
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
            StockLog sl = new StockLog();
            sl.MdiParent = this;
           // sl.Dock = DockStyle.Fill;
            sl.Show();
        }

        private void stockOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlaceOrder po = new PlaceOrder();
            po.MdiParent = this;
            //po.Dock = DockStyle.Fill;
            po.Show();
        }

        private void dailyExpensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExpensesLog el = new ExpensesLog();
            el.MdiParent = this;
           // el.Dock = DockStyle.Fill;
            el.Show();
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
            Application.Exit();
        }
    }
}
