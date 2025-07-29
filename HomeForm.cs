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
        Fitness_Tracker_DataSetTableAdapters.UsersTableAdapter uta = new Fitness_Tracker_DataSetTableAdapters.UsersTableAdapter();
        public HomeForm()
        {
            InitializeComponent();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            var username = Session.UserFullName;
            welcomeNameLabel.Text = "Welcome, " + username + "!";
            todayDateLabel.Text = "Today is: " + DateTime.Now.ToString("D");
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Session.Logout();
            MessageBox.Show("You have successfully logged out.", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Information);

            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();

            this.Close();
        }
    }
}
