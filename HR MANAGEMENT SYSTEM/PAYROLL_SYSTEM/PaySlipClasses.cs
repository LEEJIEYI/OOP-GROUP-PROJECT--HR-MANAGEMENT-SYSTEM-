using System;
using System.Collections.Generic;

namespace Payroll_System
{
    public class PaySlip
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public decimal BasicSalary { get; set; }
        public decimal Bonus { get; set; }
        public decimal Deductions { get; set; }

        public decimal NetSalary
        {
            get
            {
                return BasicSalary + Bonus - Deductions;
            }
        }

        public override string ToString()
        {
            return $"Name: {Name}\n" +
                   $"Position: {Position}\n" +
                   $"Basic Salary: {BasicSalary:C}\n" +
                   $"Bonus: {Bonus:C}\n" +
                   $"Deductions: {Deductions:C}\n" +
                   $"Net Salary: {NetSalary:C}";
        }
    }

    public class PaySlipList
    {
        private List<PaySlip> paySlips;

        public PaySlipList()
        {
            paySlips = new List<PaySlip>();
        }

        public void Add(PaySlip paySlip)
        {
            paySlips.Add(paySlip);
        }

        public List<PaySlip> GetAll()
        {
            return paySlips;
        }
    }
}
