namespace EmployeeManagementWinForms
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string JobTitle { get; set; }
        public string Department { get; set; }

        public Employee(int id)
        {
            Id = id;
        }

        public Employee(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public Employee(int id, string name, string jobTitle, string department)
        {
            Id = id;
            Name = name;
            JobTitle = jobTitle;
            Department = department;
        }
    }
}
