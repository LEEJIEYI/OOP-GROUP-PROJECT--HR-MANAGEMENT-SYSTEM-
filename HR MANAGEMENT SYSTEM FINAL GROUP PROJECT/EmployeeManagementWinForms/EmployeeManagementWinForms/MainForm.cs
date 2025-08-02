using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EmployeeManagementWinForms
{
    public partial class MainForm : Form
    {
        private List<Employee> employees = new List<Employee>();
        private int nextId = 1;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string job = txtJob.Text.Trim();
            string dept = txtDept.Text.Trim();

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Name cannot be empty.");
                return;
            }

            employees.Add(new Employee(nextId++, name, job, dept));

            RefreshGrid();
            ClearInputs();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (gridEmployees.SelectedRows.Count == 0) return;

            int id = (int)gridEmployees.SelectedRows[0].Cells[0].Value;
            var emp = employees.FirstOrDefault(e => e.Id == id);
            if (emp != null)
            {
                emp.Name = txtName.Text.Trim();
                emp.JobTitle = txtJob.Text.Trim();
                emp.Department = txtDept.Text.Trim();
                RefreshGrid();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gridEmployees.SelectedRows.Count == 0) return;

            int id = (int)gridEmployees.SelectedRows[0].Cells[0].Value;
            employees.RemoveAll(e => e.Id == id);
            RefreshGrid();
            ClearInputs();
        }

        private void gridEmployees_SelectionChanged(object sender, EventArgs e)
        {
            if (gridEmployees.SelectedRows.Count == 0) return;

            int id = (int)gridEmployees.SelectedRows[0].Cells[0].Value;
            var emp = employees.FirstOrDefault(e => e.Id == id);
            if (emp != null)
            {
                txtName.Text = emp.Name;
                txtJob.Text = emp.JobTitle;
                txtDept.Text = emp.Department;
            }
        }

        private void RefreshGrid()
        {
            gridEmployees.DataSource = null;
            gridEmployees.DataSource = employees.Select(e => new
            {
                e.Id,
                e.Name,
                e.JobTitle,
                e.Department
            }).ToList();
        }

        private void ClearInputs()
        {
            txtName.Clear();
            txtJob.Clear();
            txtDept.Clear();
        }

        private void txtDept_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
