using System;
using System.Windows.Forms;

namespace HRManagementSystem
{
    public partial class ViewSelectorForm : Form
    {
        public ViewSelectorForm()
        {
            InitializeComponent();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            AdminPanelForm adminForm = new AdminPanelForm();
            adminForm.Show();
            this.Hide();
        }

        private void btnHR_Click(object sender, EventArgs e)
        {
            HRPanel hrForm = new HRPanel();
            hrForm.Show();
            this.Hide();
        }

        private void ViewSelectorForm_Load(object sender, EventArgs e)
        {
            // Optional: Add logic on form load
        }
    }
}
