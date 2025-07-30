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
    public partial class Login : UserControl
    {
        Fitness_Tracker_DataSetTableAdapters.UsersTableAdapter uds = new Fitness_Tracker_DataSetTableAdapters.UsersTableAdapter();

        public event EventHandler SignUpLinkClicked;
        public event EventHandler LoginSuccessful;

        int failedAttempts = 0;
        int maxAttempts = 5;
        DateTime lockoutEndTime;
        bool isLockedOut = false;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        //Login Function and handle the failed attempts and lockout
        private void loginSummitBtn_Click(object sender, EventArgs e)
        {
            if (isLockedOut)
            {
                if (DateTime.Now < lockoutEndTime)
                {
                    MessageBox.Show($"Too many failed attempts. Please try again at {lockoutEndTime:T}", "Locked Out", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    isLockedOut = false;
                    failedAttempts = 0;
                }
            }

            var user = uds.SearchByUsername(txtUsername.Text);

            if (user.Rows.Count > 0)
            {
                var fullname = user.Rows[0]["name"].ToString();
                var password = user.Rows[0]["password"].ToString();

                if (password == txtPassword.Text)
                {
                    Session.Login(Convert.ToInt32(user.Rows[0]["userID"]), txtUsername.Text, fullname);
                    MessageBox.Show("You have been logged in successfully.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    failedAttempts = 0; 

                    LoginSuccessful?.Invoke(this, EventArgs.Empty);
                }
                else
                {
                    failedAttempts++;
                    if (failedAttempts >= maxAttempts)
                    {
                        isLockedOut = true;
                        lockoutEndTime = DateTime.Now.AddMinutes(1); 
                        MessageBox.Show("Too many failed attempts. You are locked out for 1 minute.", "Locked Out", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        int remaining = maxAttempts - failedAttempts;
                        MessageBox.Show($"Incorrect password. {remaining} attempt(s) remaining.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Something went wrong! Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void linkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUpLinkClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
