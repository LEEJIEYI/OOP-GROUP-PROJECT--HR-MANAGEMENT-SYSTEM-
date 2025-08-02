using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AttendanceApp
{
    public partial class Form1 : Form
    {
        private List<AttendanceRecord> records = new List<AttendanceRecord>();

        public Form1()
        {
            InitializeComponent();

            // Set up DataGridView columns
            dgvRecords.Columns.Add("EmployeeId", "Employee ID");
            dgvRecords.Columns.Add("CheckInTime", "Check-In Time");
            dgvRecords.Columns.Add("CheckOutTime", "Check-Out Time");
            dgvRecords.Columns.Add("WorkedTime", "Worked Hours");
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtEmployeeId.Text, out int id))
            {
                MessageBox.Show("Invalid Employee ID");
                return;
            }

            if (records.Any(r => r.EmployeeId == id && !r.CheckOutTime.HasValue))
            {
                MessageBox.Show("Already checked in");
                return;
            }

            records.Add(new AttendanceRecord
            {
                EmployeeId = id,
                CheckInTime = DateTime.Now
            });

            MessageBox.Show($"Employee {id} checked in.");
            txtEmployeeId.Clear();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtEmployeeId.Text, out int id))
            {
                MessageBox.Show("Invalid Employee ID");
                return;
            }

            var rec = records.LastOrDefault(r => r.EmployeeId == id && !r.CheckOutTime.HasValue);
            if (rec == null)
            {
                MessageBox.Show("No active check-in found.");
                return;
            }

            rec.CheckOutTime = DateTime.Now;
            MessageBox.Show($"Employee {id} checked out.\nWorked: {rec.TotalHoursWorked?.ToString(@"hh\:mm")}");
            txtEmployeeId.Clear();
        }

        private void btnShowRecords_Click(object sender, EventArgs e)
        {
            dgvRecords.Rows.Clear();

            foreach (var rec in records)
            {
                string checkIn = rec.CheckInTime.ToString("hh:mm tt");
                string checkOut = rec.CheckOutTime.HasValue ? rec.CheckOutTime.Value.ToString("hh:mm tt") : "N/A";
                string worked = rec.TotalHoursWorked.HasValue ? rec.TotalHoursWorked.Value.ToString(@"hh\:mm") : "N/A";

                dgvRecords.Rows.Add(rec.EmployeeId, checkIn, checkOut, worked);
            }
        }
    }
}
