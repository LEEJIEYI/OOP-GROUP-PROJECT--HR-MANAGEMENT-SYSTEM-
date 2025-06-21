using Payroll_System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll_System
{
    public class PaySlipList
    {
        private List<PaySlip> paySlips = new List<PaySlip>();

        public void Add(PaySlip slip)
        {
            paySlips.Add(slip);
        }

        public List<PaySlip> GetAll()
        {
            return paySlips;
        }
    }
}