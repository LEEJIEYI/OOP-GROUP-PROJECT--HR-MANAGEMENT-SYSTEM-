using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using HRManagementSystem;

namespace HRManagementSystem
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // This now works because HRPanel is in HRManagementSystem
            Application.Run(new HRPanel());
        }
    }
}
