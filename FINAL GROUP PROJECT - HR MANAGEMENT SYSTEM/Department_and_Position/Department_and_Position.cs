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
    public partial class Department_and_Position : Form
    {
        public Department_and_Position()
        {
            InitializeComponent();
        }

        private void btnAddDepartment_Click(object sender, EventArgs e)
        {
            // TODO: Add your code for adding departments
            MessageBox.Show($"Department '{txtDepartmentName.Text}' added!");
        }

        private void btnAssignPosition_Click(object sender, EventArgs e)
        {
            // TODO: Add your code for assigning positions
            MessageBox.Show($"Position '{txtPositionName.Text}' assigned!");
        }

        private void btnLinkEmployee_Click(object sender, EventArgs e)
        {
            // TODO: Add your code for linking employee
            MessageBox.Show($"Employee ID '{txtEmployeeID.Text}' linked!");
        }
    }
}
