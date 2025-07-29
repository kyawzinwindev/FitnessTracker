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
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            var username = Session.UserFullName;
            welcomeNameLabel.Text = "Welcome, " + username + "!";
            todayDateLabel.Text = "Today is: " + DateTime.Now.ToString("D");

            this.goalPageBtn_Click(sender, e);
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Session.Logout();
            MessageBox.Show("You have successfully logged out.", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Information);

            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();

            this.Close();
        }

        private void goalPageBtn_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            GoalUserControl goalUserControl = new GoalUserControl();
            goalUserControl.Dock = DockStyle.Fill;
            panelMain.Controls.Add(goalUserControl);
            goalUserControl.LoadGoals();
        }
    }
}
