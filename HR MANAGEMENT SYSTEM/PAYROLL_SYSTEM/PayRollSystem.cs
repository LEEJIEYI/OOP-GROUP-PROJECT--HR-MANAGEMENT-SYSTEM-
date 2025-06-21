using Payroll_System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace Payroll_System
{
    public partial class Form1 : Form
    {
        private PaySlipList paySlipList = new PaySlipList();

        public Form1()
        {
            InitializeComponent();

            this.BackColor = Color.FromArgb(245, 245, 245);
            this.Font = new Font("Segoe UI", 10F);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            label1.Text = "Name";
            label2.Text = "Position";
            label3.Text = "Basic Salary";
            label4.Text = "Bonus";
            label5.Text = "Deductions";
            label6.Text = "Pay Slip Output";
            label6.ForeColor = Color.Teal;
            label7.Text = "Payroll System";
            label7.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label7.ForeColor = Color.DarkCyan;

            label1.ForeColor = Color.DarkSlateBlue;
            label2.ForeColor = Color.DarkSlateBlue;
            label3.ForeColor = Color.DarkSlateBlue;
            label4.ForeColor = Color.DarkSlateBlue;
            label5.ForeColor = Color.DarkSlateBlue;

            txtName.BackColor = Color.WhiteSmoke;
            txtPosition.BackColor = Color.WhiteSmoke;
            txtBasicSalary.BackColor = Color.WhiteSmoke;
            txtBonus.BackColor = Color.WhiteSmoke;
            txtDeductions.BackColor = Color.WhiteSmoke;

            txtOutput.BackColor = Color.Azure;
            txtOutput.Font = new Font("Consolas", 10F);

            button1.Text = "Generate Pay Slip";
            button1.BackColor = Color.Teal;
            button1.ForeColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button1.FlatAppearance.BorderSize = 0;

            button1.Click += button1_Click;
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
                MessageBox.Show("Please enter valid numbers for salary, bonus, and deductions.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}