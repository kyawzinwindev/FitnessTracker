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
        private Register registerComponent;
        private Login loginComponent;
        public MainForm()
        {
            InitializeComponent();

            loginComponent = new Login();
            loginComponent.Anchor = AnchorStyles.None;
            loginComponent.Left = (this.ClientSize.Width - loginComponent.Width) / 2;
            loginComponent.Top = (this.ClientSize.Height - loginComponent.Height) / 2;
            loginComponent.SignUpLinkClicked += ShowRegisterComponent;

           
            this.Controls.Add(loginComponent);

            registerComponent = new Register();
            registerComponent.Anchor = AnchorStyles.None;
            registerComponent.Left = (this.ClientSize.Width - registerComponent.Width) / 2;
            registerComponent.Top = (this.ClientSize.Height - registerComponent.Height) / 2;
            registerComponent.BackToLoginClicked += ShowLoginComponent;

        }

        private void ShowRegisterComponent(object sender, EventArgs e)
        {
            this.Controls.Remove(loginComponent);
            this.Controls.Add(registerComponent);
        }

        private void ShowLoginComponent(object sender, EventArgs e)
        {
            this.Controls.Remove(registerComponent);
            this.Controls.Add(loginComponent);
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

    }
}
