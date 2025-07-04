using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessTracker
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void registerFormBtn_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();

            registerForm.Show();
        }

        private void loginFormBtn_Click(object sender, EventArgs e)
        {
            using (var dlg = new LoginForm())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    this.RefreshUI();
                }
            }

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.RefreshUI();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Session.Logout();

            MessageBox.Show("You have been logged out successfully.", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.RefreshUI();
        }

        public void RefreshUI()
        {
            bool logged = Session.IsLoggedIn;

            registerFormBtn.Visible = !logged;
            loginFormBtn.Visible = !logged;

            logoutBtn.Visible = logged;
            goalMenuBtn.Visible = logged;
            activityMenuBtn.Visible = logged;

            //TO DO: add welcome text or something eg, Welcome User!
        }
    }
}
