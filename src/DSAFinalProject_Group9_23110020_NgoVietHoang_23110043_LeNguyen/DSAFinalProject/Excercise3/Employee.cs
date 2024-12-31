public class Employee
{
    public string Name;
    public string EmployeeID;
    public string PhoneNumber;
    public string Email;
    public string Address;
    public int YearsWorked;
    public string Position;
    public double Salary;

    public Employee(string name, string employeeID, string phoneNumber, string email, string address, int yearsWorked, string position, double salary)
    {
        Name = name;
        EmployeeID = employeeID;
        PhoneNumber = phoneNumber;
        Email = email;
        Address = address;
        YearsWorked = yearsWorked;
        Position = position;
        Salary = salary;
    }
    public override string ToString()
    {
        return $"Name: {Name}, ID: {EmployeeID}, Phone: {PhoneNumber}, Email: {Email}, Address: {Address}, Years Worked: {YearsWorked}, Position: {Position}, Salary: {Salary}";
    }
}
