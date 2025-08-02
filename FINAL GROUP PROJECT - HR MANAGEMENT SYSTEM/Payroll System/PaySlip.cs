using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystem_
{
    public class PaySlip
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public decimal BasicSalary { get; set; }
        public decimal Bonus { get; set; }
        public decimal Allowance { get; set; }
        public decimal OvertimeHours { get; set; }
        public decimal TaxDeduction { get; set; }
        public decimal LateDeduction { get; set; }

        public decimal OvertimeRate => 20m;
        public decimal OvertimePay => OvertimeHours * OvertimeRate;
        public decimal EPF => BasicSalary * 0.11m;
        public decimal SOCSO => BasicSalary * 0.005m;
        public decimal TotalEarnings => BasicSalary + Bonus + Allowance + OvertimePay;
        public decimal TotalDeductions => TaxDeduction + LateDeduction + EPF + SOCSO;
        public decimal NetSalary => TotalEarnings - TotalDeductions;

        public override string ToString()
        {
            return
                $"Name: {Name}\n" +
                $"Position: {Position}\n" +
                $"Basic Salary: RM{BasicSalary:0.00}\n" +
                $"Bonus: RM{Bonus:0.00}\n" +
                $"Allowance: RM{Allowance:0.00}\n" +
                $"Overtime Pay ({OvertimeHours} hrs @ RM{OvertimeRate}): RM{OvertimePay:0.00}\n" +
                $"EPF Deduction (11%): RM{EPF:0.00}\n" +
                $"SOCSO Deduction (0.5%): RM{SOCSO:0.00}\n" +
                $"Tax Deduction: RM{TaxDeduction:0.00}\n" +
                $"Late Deduction: RM{LateDeduction:0.00}\n" +
                $"--------------------------------------\n" +
                $"Total Earnings: RM{TotalEarnings:0.00}\n" +
                $"Total Deductions: RM{TotalDeductions:0.00}\n" +
                $"Net Salary: RM{NetSalary:0.00}";
        }
    }
}