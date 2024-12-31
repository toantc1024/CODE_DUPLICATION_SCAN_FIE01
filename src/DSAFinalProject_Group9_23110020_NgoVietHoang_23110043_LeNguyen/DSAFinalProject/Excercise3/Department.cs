using static Program;

public class Department
{
    public string DepartmentName;
    public EmployeeBST Employees;

    public Department(string departmentName)
    {
        DepartmentName = departmentName;
        Employees = new EmployeeBST();
    }
    public void PrintEmployees()
    {
        Employees.PrintTree();
    }
}