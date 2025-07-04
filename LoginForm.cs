using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessTracker
{
    public partial class LoginForm : Form
    {
        Fitness_Tracker_DataSetTableAdapters.UsersTableAdapter uds = new Fitness_Tracker_DataSetTableAdapters.UsersTableAdapter();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginSummitBtn_Click(object sender, EventArgs e)
        {
            var user = uds.SearchByUsername(txtUsername.Text);

            if (user.Rows.Count > 0)
            {
                var password = user.Rows[0]["Password"].ToString();
                if (password == txtPassword.Text)
                {
                    Session.Login(txtUsername.Text);

                    MessageBox.Show("You have been logged in successfully.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                { 
                    MessageBox.Show("Incorrect username or password. Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Something went wrong!. Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
