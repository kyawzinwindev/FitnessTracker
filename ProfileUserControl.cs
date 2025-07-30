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
    public partial class ProfileUserControl : UserControl
    {
        Fitness_Tracker_DataSetTableAdapters.UsersTableAdapter uds = new Fitness_Tracker_DataSetTableAdapters.UsersTableAdapter();

        public ProfileUserControl()
        {
            InitializeComponent();
        }

        private void ProfileUserControl_Load(object sender, EventArgs e)
        {
        }

        private void updateProfileBtn_Click(object sender, EventArgs e)
        {
            if (txtFullname.Text == "")
            {
                MessageBox.Show("Please Enter Your Full Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtUsername.Text == "")
            {
                MessageBox.Show("Please Enter Username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (!dateOfBirth.Checked)
            {
                MessageBox.Show("Please Enter Your Date of Birth", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!radioMale.Checked && !radioFemale.Checked && !radioOther.Checked)
            {
                MessageBox.Show("Please Select a Gender", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtWeight.Text == "")
            {
                MessageBox.Show("Please Enter Your Weight", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtHeight.Text == "")
            {
                MessageBox.Show("Please Enter Your Height", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (!this.checkUsernameAndPassword())
                {
                    return;
                }

                if (!this.checkHeightAndWeightIsNumber())
                {
                    return;
                }


                var table = uds.GetData();
                var row = table.FirstOrDefault(r => r.userID == Session.UserID);

                if (row != null)
                {
                    row["name"] = txtFullname.Text.Trim();
                    row["username"] = txtUsername.Text.Trim();
                    row["dateOfBirth"] = dateOfBirth.Value;
                    row["gender"] = this.getSelectedGender();
                    row["weight"] = decimal.Parse(txtWeight.Text);
                    row["height"] = decimal.Parse(txtHeight.Text);
                    row["password"] = txtNewPassword.Text == "" ? row["password"] : txtNewPassword.Text;

                    int data = uds.Update(row);
                    if(data > 0)
                    {
                        MessageBox.Show("Profile Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.LoadUserProfile();
                        txtOldPassword.Text = "";
                        txtNewPassword.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Something Went Wrong! Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private bool checkUsernameAndPassword()
        {
            var user = uds.SearchByUsername(txtUsername.Text);

            var validUsername = Regex.IsMatch(txtUsername.Text, @"^[a-zA-Z0-9]+$");

            if (!validUsername)
            {
                MessageBox.Show("Username can only contain letters and numbers.", "Invalid Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
                return false;
            }

            if(txtOldPassword.Text != "")
            {
                var password = user.Rows[0]["password"].ToString();

                if (password != txtOldPassword.Text)
                {
                    MessageBox.Show("Incorrect  password. Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                   var validPassword = Regex.IsMatch(txtNewPassword.Text, @"^(?=.*[a-z])(?=.*[A-Z]).{12}$");

                if (!validPassword)
                {
                    MessageBox.Show("Password must be 12 characters long and contain at least one uppercase letter and one lowercase letter.", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNewPassword.Focus();
                    return false;
                }

            }

            return true;
        }

        //Check if height and weight are valid numbers
        private bool checkHeightAndWeightIsNumber()
        {
            if (!decimal.TryParse(txtWeight.Text, out decimal weight) || weight <= 0)
            {
                MessageBox.Show("Please enter a valid weight.", "Invalid Weight", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtWeight.Focus();
                return false;
            }

            if (!decimal.TryParse(txtHeight.Text, out decimal height) || height <= 0)
            {
                MessageBox.Show("Please enter a valid height.", "Invalid Height", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHeight.Focus();
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

        public void LoadUserProfile()
        {
            var table = uds.GetData();
            var row = table.FirstOrDefault(r => r.userID == Session.UserID);

            txtFullname.Text = row.name;
            txtUsername.Text = row.username;
            dateOfBirth.Value = row.dateOfBirth;

            this.LoadOldGender(row.gender);
            txtWeight.Text = row.weight.ToString();
            txtHeight.Text = row.height.ToString(); ;
        }

        public bool LoadOldGender(string gender)
        {
            if(gender == Gender.Male.ToString())
            {
                return radioMale.Checked = true;
            } else if(gender == Gender.Female.ToString())
            {
                return radioFemale.Checked = true;
            }
            else
            {
                return radioOther.Checked = true;
            }
        }

    }
}
