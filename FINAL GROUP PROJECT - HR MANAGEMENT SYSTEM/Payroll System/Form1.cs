using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollSystem_
{
    public partial class groupBoxEmployee : Form
    {
        public groupBoxEmployee()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var slip = new PaySlip
                {
                    Name = txtName.Text,
                    Position = txtPosition.Text,
                    BasicSalary = decimal.Parse(txtBasicSalary.Text),
                    Bonus = decimal.Parse(txtBonus.Text),
                    Allowance = decimal.Parse(txtAllowance.Text),
                    OvertimeHours = decimal.Parse(txtOvertimeHours.Text),
                    TaxDeduction = decimal.Parse(txtTaxDeduction.Text),
                    LateDeduction = decimal.Parse(txtLateDeduction.Text)
                };

                txtOutput.Text = slip.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numbers in the salary fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAllowance_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelOTRate_Click(object sender, EventArgs e)
        {

        }

        private void labelOT_Click(object sender, EventArgs e)
        {

        }

        private void labelAllowance_Click(object sender, EventArgs e)
        {

        }

        private void labelBonus_Click(object sender, EventArgs e)
        {

        }

        private void txtBonus_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
