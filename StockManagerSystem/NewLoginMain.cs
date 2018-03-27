using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace StockManagerSystem
{
    public partial class NewLoginMain : Form
    {
        static NewLoginMain _instance;
        public static NewLoginMain Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new NewLoginMain();
                return _instance;
            }
        }
        public NewLoginMain()
        {
            Thread t = new Thread(new ThreadStart(NewSplashScreenStart));
            t.Start();
            
            Thread.Sleep(5000);

            InitializeComponent();

            t.Abort();
        }

        //creating function for splash start

        public void NewSplashScreenStart()
        {
            Application.Run(new NewSplashScreen());

        }


        private void NewLoginMain_Load(object sender, EventArgs e)
        {
            _instance = this;
           textBoxUsername.Focus();
        }

        private void buttonSignin_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(textBoxUsername.Text))
                MetroFramework.MetroMessageBox.Show(this, "Please Enter your Username", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBoxUsername.Focus();


            try
            {
                using (StkManagementSystemEntitiesUsers skme = new StkManagementSystemEntitiesUsers())
                {
                    var query = from u in skme.users
                                where u.Username == textBoxUsername.Text && u.Password == textBoxPassword.Text
                                select u;
                    if (query.SingleOrDefault() != null)
                    {
                        textBoxPassword.Clear();
                        textBoxUsername.Clear();
                        this.Hide();
                        Dashboard dashfrm = new Dashboard(string.Format("Logged in as :{0}", textBoxUsername.Text));
                        dashfrm.ShowDialog();
                    }
                    else
                        MetroFramework.MetroMessageBox.Show(this, "Your Username or Password is Incorrect", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxPassword.Clear();
                    textBoxUsername.Clear();
                }
            }
            catch (Exception exe)
            {
                MetroFramework.MetroMessageBox.Show(this, exe.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return;
        }

        private void CLOSE_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
