using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeaveAppSys
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            cmbType.Items.Add("Sick Leave");
            cmbType.Items.Add("Annual Leave");
            cmbType.Items.Add("Emergency Leave");
            cmbType.SelectedIndex = 0;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string type = cmbType.SelectedItem?.ToString() ?? "N/A";
            string start = dtStart.Value.ToShortDateString();
            string end = dtEnd.Value.ToShortDateString();
            string reason = txtReason.Text;

            lstSummary.Items.Add("=========== Leave Application Summary ===========");
            lstSummary.Items.Add($"👤  Name           : {name}");
            lstSummary.Items.Add($"🗂️  Leave Type : {type}");
            lstSummary.Items.Add($"📅  Start Date    : {start:dddd, dd MMMM yyyy}");
            lstSummary.Items.Add($"📅  End Date     : {end:dddd, dd MMMM yyyy}");
            lstSummary.Items.Add($"📝  Reason        : {reason}");
            lstSummary.Items.Add("=================================================");


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lstSummary_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
