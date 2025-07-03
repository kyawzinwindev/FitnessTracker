using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessTracker
{
    public partial class RegisterForm : Form
    {
        Fitness_Tracker_DataSetTableAdapters.UsersTableAdapter uds = new Fitness_Tracker_DataSetTableAdapters.UsersTableAdapter();
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void registerSummitBtn_Click(object sender, EventArgs e)
        {
            if( txtFullname.Text == "" )
            {
                MessageBox.Show("Please Enter Your Full Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if( txtUsername.Text == "" )
            {
                MessageBox.Show("Please Enter Username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if( txtPassword.Text == "" )
            {
                MessageBox.Show("Please Enter Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if( !dateOfBirth.Checked ) 
            {
                MessageBox.Show("Please Enter Your Date of Birth", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if( !radioMale.Checked && !radioFemale.Checked && !radioOther.Checked )
            {
                MessageBox.Show("Please Select a Gender", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(  txtWeight.Text == "" )
            {
                MessageBox.Show("Please Enter Your Weight", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if( txtHeight.Text == "" )
            {
                MessageBox.Show("Please Enter Your Height", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(!this.checkUsernameAndPassword())
                {
                    return;
                }

                if(!this.checkHeightAndWeightIsNumber())
                {
                    return;
                }


                // Create new user object
                User user = new User();
                user.Name = txtFullname.Text;
                user.Username = txtUsername.Text;
                user.Password = txtPassword.Text;
                user.DateOfBirth = dateOfBirth.Value;
                user.Gender = this.getSelectedGender();
                user.Weight = decimal.Parse(txtWeight.Text);
                user.Height = decimal.Parse(txtHeight.Text);

                try
                {
                    int data = uds.Insert(user.Name, user.Username, user.Password, user.DateOfBirth, user.Gender, user.Weight, user.Height);

                    if (data > 0)
                    {
                        MessageBox.Show("Registration Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();

                        LoginForm loginForm = new LoginForm();
                        loginForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Registration Failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627 || ex.Number == 2601)
                    {
                        MessageBox.Show("That username is already taken.\nPlease choose another one.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something Went Wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool checkUsernameAndPassword()
        {
            var validUsername = Regex.IsMatch(txtUsername.Text, @"^[a-zA-Z0-9]+$");

            if(!validUsername)
            {
                MessageBox.Show("Username can only contain letters and numbers.", "Invalid Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
                return false;
            }

            var validPassword = Regex.IsMatch(txtPassword.Text, @"^(?=.*[a-z])(?=.*[A-Z]).{12}$");

            if (!validPassword)
            {
                MessageBox.Show("Password must be 12 characters long and contain at least one uppercase letter and one lowercase letter.", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
                return false;
            }

            return true;
        }

        private bool checkHeightAndWeightIsNumber()
        {
            if(!decimal.TryParse(txtHeight.Text, out decimal height) || height <= 0)
            {
                MessageBox.Show("Please enter a valid height.", "Invalid Height", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHeight.Focus();
                return false;
            }
            if (!decimal.TryParse(txtWeight.Text, out decimal weight) || weight <= 0)
            {
                MessageBox.Show("Please enter a valid weight.", "Invalid Weight", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtWeight.Focus();
                return false;
            }
            return true;
        }

        private string getSelectedGender()
        {
            if (radioMale.Checked)
                return Gender.Male.ToString();
            else if (radioFemale.Checked)
                return Gender.Female.ToString();
            else
                return Gender.Other.ToString();
        }
    }
}
