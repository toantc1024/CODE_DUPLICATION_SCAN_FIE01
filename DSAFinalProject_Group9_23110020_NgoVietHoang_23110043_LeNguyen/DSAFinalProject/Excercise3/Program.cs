using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string companyName = File.ReadLines(@"C:\Users\DELL\source\repos\BinarySearch\QuyHoachCongTy.txt").First();
        Company company = new Company(companyName);
        var departmentNames = File.ReadLines(@"C:\Users\DELL\source\repos\BinarySearch\QuyHoachCongTy.txt").Skip(1);
        foreach (var departmentName in departmentNames)
        {
            company.AddDepartment(new Department(departmentName));
        }
        Console.WriteLine(companyName);
        foreach (var line in File.ReadLines(@"C:\Users\DELL\source\repos\BinarySearch\NhanSu.txt"))
        {
            var data = line.Split('|');
            var employee = new Employee(
                data[0],  // Tên
                data[1],  // Mã nhân viên
                data[2],  // SĐT
                data[3],  // Email
                data[4],  // Địa chỉ
                int.Parse(data[5]),  // Số năm làm việc
                data[6],  // Chức vụ
                double.Parse(data[8])  // Lương
            );

            var department = company.GetDepartment(data[7]); // Phòng ban 
            if (department != null)
            {
                department.Employees.Insert(employee);
            }
            Console.WriteLine(companyName);

        }
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Company: " + companyName);
            Console.WriteLine("1. Add Staff");
            Console.WriteLine("2. Update Staff");
            Console.WriteLine("3. Delete Staff");
            Console.WriteLine("4. Print Tree");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddStaff(company);
                    break;
                case "2":
                    UpdateStaff(company);
                    break;
                case "3":
                    DeleteStaff(company);
                    break;
                case "4":
                    PrintTree(company);
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
        }
    }
    static void AddStaff(Company company)
    {
        int k = 1;
        foreach (var depart in company.Departments.Values)
        {
            Console.WriteLine(k+". "+depart.DepartmentName);
            k++;
        }
        Console.Write("Chose 1 department: ");
        k = int.Parse(Console.ReadLine());
        string departmentName="";
        switch (k)
        {
            case 1:
                departmentName = "Tai Chinh";
                break;
            case 2:
                departmentName = "Marketing";
                break;
            case 3:
                departmentName = "Kinh Doanh";
                break;
            case 4:
                departmentName = "Cham soc khach hang";
                break;
            case 5:
                departmentName = "Nghien cuu";
                break;
        }
        var department = company.GetDepartment(departmentName);
        Console.Write("Enter employee name: ");
        string name = Console.ReadLine();
        Console.Write("Enter employee ID: ");
        string employeeID = Console.ReadLine();
        Console.Write("Enter phone number: ");
        string phoneNumber = Console.ReadLine();
        Console.Write("Enter email: ");
        string email = Console.ReadLine();
        Console.Write("Enter address: ");
        string address = Console.ReadLine();
        Console.Write("Enter salary: ");
        double salary = double.Parse(Console.ReadLine());
        var newEmployee = new Employee(name, employeeID, phoneNumber, email, address, 1, "Nhan Vien", salary);
        department.Employees.Insert(newEmployee);
        Console.WriteLine("Employee added successfully.");
        Console.WriteLine("Enter to continue..........");
        Console.ReadLine();
    }
    static void UpdateStaff(Company company)
    {
        Console.WriteLine("Choose a method to find the employee:");
        Console.WriteLine("1. Find by employee name");
        Console.WriteLine("2. Find by employee ID");
        Console.WriteLine("3. Don't remember name or ID, view departments and employees");
        Console.Write("Enter your choice: ");
        string choice = Console.ReadLine();
        Employee employeeToUpdate = null;
        switch (choice)
        {
            case "1":
                Console.Write("Enter employee name to update: ");
                string employeeName = Console.ReadLine();
                employeeToUpdate = FindEmployee(company, employeeName,1);
                break;
            case "2":
                Console.Write("Enter employee ID to update: ");
                string employeeID = Console.ReadLine();
                employeeToUpdate = FindEmployee(company, employeeID,0);
                break;
            case "3":
                Console.WriteLine("Choose a department to view employees:");
                int k = 1;
                foreach (var depart in company.Departments.Values)
                {
                    Console.WriteLine(k + ". " + depart.DepartmentName);
                    k++;
                }
                Console.Write("Chose 1 department: ");
                k = int.Parse(Console.ReadLine());
                string departmentName = "";
                switch (k)
                {
                    case 1:
                        departmentName = "Tai Chinh";
                        break;
                    case 2:
                        departmentName = "Marketing";
                        break;
                    case 3:
                        departmentName = "Kinh Doanh";
                        break;
                    case 4:
                        departmentName = "Cham soc khach hang";
                        break;
                    case 5:
                        departmentName = "Nghien cuu";
                        break;
                }
                var department = company.GetDepartment(departmentName);
                if (department != null)
                {
                    Console.WriteLine("Employees in " + departmentName + " department:");
                    department.Employees.PrintTree();
                    Console.Write("Enter employee ID to update: ");
                    string empID = Console.ReadLine();
                    employeeToUpdate = FindEmployee(department, empID,0);
                }
                break;
            default:
                Console.WriteLine("Invalid choice.");
                return;
        }
        if (employeeToUpdate != null)
        {
            Console.WriteLine("Employee found: " + employeeToUpdate.Name);
            Console.WriteLine("Choose the information to update:");
            Console.WriteLine("1. Update name");
            Console.WriteLine("2. Update phone number");
            Console.WriteLine("3. Update email");
            Console.WriteLine("4. Update address");
            Console.WriteLine("5. Update years worked");
            Console.WriteLine("6. Update position");
            Console.WriteLine("7. Update salary");
            Console.Write("Enter your choice: ");
            string updateChoice = Console.ReadLine();

            switch (updateChoice)
            {
                case "1":
                    Console.Write("Enter new name: ");
                    employeeToUpdate.Name = Console.ReadLine();
                    break;
                case "2":
                    Console.Write("Enter new phone number: ");
                    employeeToUpdate.PhoneNumber = Console.ReadLine();
                    break;
                case "3":
                    Console.Write("Enter new email: ");
                    employeeToUpdate.Email = Console.ReadLine();
                    break;
                case "4":
                    Console.Write("Enter new address: ");
                    employeeToUpdate.Address = Console.ReadLine();
                    break;
                case "5":
                    Console.Write("Enter new years worked: ");
                    employeeToUpdate.YearsWorked = int.Parse(Console.ReadLine());
                    break;
                case "6":
                    Console.Write("Enter new position: ");
                    employeeToUpdate.Position = Console.ReadLine();
                    break;
                case "7":
                    Console.Write("Enter new salary: ");
                    employeeToUpdate.Salary = double.Parse(Console.ReadLine());
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    return;
            }
            Console.WriteLine("Employee updated successfully.");
        }
        else
        {
            Console.WriteLine("Employee not found.");
        }
        Console.WriteLine("Enter to continue..........");
        Console.Read();
    }
    static Employee FindEmployee(Company company, string value, int k)
    {
        foreach (var department in company.Departments.Values)
        {
            var employee = FindEmployee(department, value,k);
            if (employee != null) return employee;
        }
        return null;
    }
    static Employee FindEmployee(Department department, string value, int k)
    {
        return FindEmployeeRecursive(department.Employees.Root, value,k);
    }
    static Employee FindEmployeeRecursive(EmployeeBST.Node node, string value,int k)
    {
        if (node == null) return null;
        if(k==1)
            if (node.Employee.Name.Equals(value, StringComparison.OrdinalIgnoreCase)) return node.Employee;
        if(k==0)
            if (node.Employee.EmployeeID.Equals(value, StringComparison.OrdinalIgnoreCase)) return node.Employee;
        var leftResult = FindEmployeeRecursive(node.Left, value, k);
        if (leftResult != null) return leftResult;

        return FindEmployeeRecursive(node.Right, value,k);
    }
    static void DeleteStaff(Company company)
    {
        Console.Write("Enter department name: ");
        string departmentName = Console.ReadLine();
        var department = company.GetDepartment(departmentName);
        if (department != null)
        {
            Console.Write("Enter employee ID to delete: ");
            string employeeID = Console.ReadLine();
            if (department.Employees.Delete(employeeID))
            {
                Console.WriteLine("Employee deleted successfully.");
            }
            else
            {
                Console.WriteLine("Employee not found.");
            }
        }
        else
        {
            Console.WriteLine("Department not found.");
        }
    }    static void PrintTree(Company company)
    {
        foreach (var department in company.Departments)
        {
            Console.WriteLine("-Department: " + department.Key);
            department.Value.PrintEmployees();
        }
        Console.Read();
    }
}
