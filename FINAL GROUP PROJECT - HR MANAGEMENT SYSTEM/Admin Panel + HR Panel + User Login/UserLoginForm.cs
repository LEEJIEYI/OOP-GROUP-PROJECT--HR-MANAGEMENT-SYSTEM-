using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HRManagementSystem
{
    public partial class UserLoginForm : Form
    {
        public UserLoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text.Trim();
            var password = txtPassword.Text;

            if (username == "admin" && password == "admin123")
            {
                AdminPanelForm adminPanel = new AdminPanelForm();
                adminPanel.Show();
                this.Hide();
            }
            else if (username == "hr" && password == "hr123")
            {
                HRPanel hrPanel = new HRPanel();
                hrPanel.Show();
                this.Hide();
            }
            else
            {
                lblError.Text = "Invalid username or password.";
            }
        }

        private void UserLoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
