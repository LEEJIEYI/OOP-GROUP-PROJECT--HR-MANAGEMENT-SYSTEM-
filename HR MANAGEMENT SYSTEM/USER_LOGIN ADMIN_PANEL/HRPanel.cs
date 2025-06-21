using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRManagementSystem
{
    public partial class HRPanel : Form
    {
        public HRPanel()
        {
            InitializeComponent();
        }

        private void btnEmployeeManagement_Click(object sender, EventArgs e)
        {
            // Here you can open the Employee Management Form
            // For now, just a placeholder
            MessageBox.Show("Employee Management is not implemented yet.");
        }

        private void btnLeaveSystem_Click(object sender, EventArgs e)
        {
            // Here you can open the Leave System Form
            MessageBox.Show("Leave System is not implemented yet.");
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            // Here you can open the Attendance Tracking Form
            MessageBox.Show("Attendance Tracking is not implemented yet.");
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Logout back to the LoginForm
            UserLoginForm login = new UserLoginForm();
            login.Show();
            this.Hide();
        }

        private void HRPanel_Load(object sender, EventArgs e)
        {

        }
    }
}


