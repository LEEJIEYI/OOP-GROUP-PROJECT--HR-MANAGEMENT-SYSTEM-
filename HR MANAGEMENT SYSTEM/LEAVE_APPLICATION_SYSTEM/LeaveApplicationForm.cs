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
    public partial class LeaveApplicationForm : Form
    {
        public LeaveApplicationForm()
        {
            InitializeComponent();

            // Configure ListView columns
            lvLeaveHistory.Columns.Add("Employee Name", 120);
            lvLeaveHistory.Columns.Add("Leave Type", 100);
            lvLeaveHistory.Columns.Add("Start Date", 100);
            lvLeaveHistory.Columns.Add("End Date", 100);
            lvLeaveHistory.Columns.Add("Status", 80);

            // Event Handlers
            btnApply.Click += btnApply_Click;
            btnApprove.Click += btnApprove_Click;
            btnReject.Click += btnReject_Click;
            btnViewHistory.Click += btnViewHistory_Click;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmployeeName.Text) || cmbLeaveType.SelectedItem == null)
            {
                MessageBox.Show("Please fill in Employee Name and Leave Type.");
                return;
            }

            var item = new ListViewItem(txtEmployeeName.Text);
            item.SubItems.Add(cmbLeaveType.SelectedItem.ToString());
            item.SubItems.Add(dtpStartDate.Value.ToShortDateString());
            item.SubItems.Add(dtpEndDate.Value.ToShortDateString());
            item.SubItems.Add("Pending");

            lvLeaveHistory.Items.Add(item);
            MessageBox.Show($"Leave applied for {txtEmployeeName.Text}. Status: Pending");
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            if (lvLeaveHistory.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select an item to approve.");
                return;
            }
            lvLeaveHistory.SelectedItems[0].SubItems[4].Text = "Approved";
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            if (lvLeaveHistory.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select an item to reject.");
                return;
            }
            lvLeaveHistory.SelectedItems[0].SubItems[4].Text = "Rejected";
        }

        private void btnViewHistory_Click(object sender, EventArgs e)
        {
            if (lvLeaveHistory.Items.Count == 0)
            {
                MessageBox.Show("No leave history available.");
            }
            else
            {
                MessageBox.Show($"Viewing {lvLeaveHistory.Items.Count} leave record(s).");
            }
        }
    }
}
