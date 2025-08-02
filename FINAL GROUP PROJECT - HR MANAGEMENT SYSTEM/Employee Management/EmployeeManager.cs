using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementWinForms
{
    internal class EmployeeManager
    {
        List<Employee> list = new List<Employee>();

        public void AddEmployee(Employee employee)
        {
            list.Add(employee);
        }

        public void RemoveEmployee(int id)
        {
            var employee = list.FirstOrDefault(e => e.Id == id);
            if (employee != null)
            {
                list.Remove(employee);
            }
        }
        public void UpdateEmployee(int id, Employee updatedEmployee)
        {
            var employee = list.FirstOrDefault(e => e.Id == id);
            if (employee != null)
            {
                employee.Name = updatedEmployee.Name;
                employee.JobTitle = updatedEmployee.JobTitle;
                employee.Department = updatedEmployee.Department;
            }
        }

        public List<Employee> GetAllEmployees()
        {
            return list;
        }
    }
}
