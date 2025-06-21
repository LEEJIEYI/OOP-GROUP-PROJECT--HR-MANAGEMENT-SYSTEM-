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
    public partial class AdminPanelForm : Form
    {
        public AdminPanelForm()
        {
            InitializeComponent();

            // Attach Click Event Handlers
            btnEmployeeManagement.Click += btnEmployeeManagement_Click;
            btnDepartmentPosition.Click += btnDepartmentPosition_Click;
            btnLeaveSystem.Click += btnLeaveSystem_Click;
            btnAttendanceTracking.Click += btnAttendanceTracking_Click;
            btnPayrollSystem.Click += btnPayrollSystem_Click;
            btnLogout.Click += btnLogout_Click;
        }

        private void AdminPanelForm_Load(object sender, EventArgs e)
        {
            // You can add any initialization code here if needed.
        }

        private void btnEmployeeManagement_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Employee Management is not implemented yet.");
            // TODO: Open Employee Management Form
        }

        private void btnDepartmentPosition_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Department & Position is not implemented yet.");
            // TODO: Open Department & Position Form
        }

        private void btnLeaveSystem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Leave System is not implemented yet.");
            // TODO: Open Leave System Form
        }

        private void btnAttendanceTracking_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Attendance Tracking is not implemented yet.");
            // TODO: Open Attendance Tracking Form
        }

        private void btnPayrollSystem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Payroll System is not implemented yet.");
            // TODO: Open Payroll System Form
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Logout
            UserLoginForm loginForm = new UserLoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}
