using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_System
{
    public partial class Form1 : Form
    {
        private PaySlipList paySlipList = new PaySlipList();

        public Form1()
        {
            InitializeComponent();

            // Set label texts
            label1.Text = "Name";
            label2.Text = "Position";
            label3.Text = "Basic Salary";
            label4.Text = "Bonus";
            label5.Text = "Deductions";
            label6.Text = "Pay Slip Output";
            label7.Text = "Payroll System";

            // Set button text
            button1.Text = "Generate Pay Slip";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                PaySlip slip = new PaySlip()
                {
                    Name = txtName.Text,
                    Position = txtPosition.Text,
                    BasicSalary = decimal.Parse(txtBasicSalary.Text),
                    Bonus = decimal.Parse(txtBonus.Text),
                    Deductions = decimal.Parse(txtDeductions.Text)
                };

                paySlipList.Add(slip);
                txtOutput.Text = slip.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numbers for salary, bonus, and deductions.",
                                "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
