public class Company
{
    public string CompanyName;
    public Dictionary<string, Department> Departments;

    public Company(string companyName)
    {
        CompanyName = companyName;
        Departments = new Dictionary<string, Department>();
    }

    public void AddDepartment(Department department)
    {
        if (!Departments.ContainsKey(department.DepartmentName))
        {
            Departments.Add(department.DepartmentName, department);
        }
    }

    public Department GetDepartment(string departmentName)
    {
        if (Departments.ContainsKey(departmentName))
        {
            return Departments[departmentName];
        }
        return null;
    }
}
