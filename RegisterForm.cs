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
    public partial class RegisterForm : Form
    {
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
            else if( txtPhone.Text == "" )
            {
                MessageBox.Show("Please Enter Your PHone Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if( !dateOfBirth.Checked ) 
            {
                MessageBox.Show("Please Enter Your Date of Birth", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //else if( )
        }
    }
}
