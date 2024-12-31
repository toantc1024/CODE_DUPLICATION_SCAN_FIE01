public class EmployeeBST
{
    public class Node
    {
        public Employee Employee;
        public Node Left, Right;
        public Node(Employee employee)
        {
            Employee = employee;
            Left = Right = null;
        }
    }
    public Node Root;

    public EmployeeBST()
    {
        Root = null;
    }
    public void Insert(Employee employee)
    {
        Root = InsertRecursive(Root, employee);
    }
    private Node InsertRecursive(Node node, Employee employee)
    {
        if (node == null)
        {
            return new Node(employee);
        }

        int comparison = string.Compare(employee.EmployeeID, node.Employee.EmployeeID);
        if (comparison < 0)
        {
            node.Left = InsertRecursive(node.Left, employee);
        }
        else if (comparison > 0)
        {
            node.Right = InsertRecursive(node.Right, employee);
        }

        return node;
    }
    public bool Update(string employeeID, Employee updatedEmployee)
    {
        return UpdateRecursive(Root, employeeID, updatedEmployee);
    }

    private bool UpdateRecursive(Node node, string employeeID, Employee updatedEmployee)
    {
        if (node == null)
            return false;

        int comparison = string.Compare(employeeID, node.Employee.EmployeeID);
        if (comparison == 0)
        {
            node.Employee = updatedEmployee;
            return true;
        }
        else if (comparison < 0)
        {
            return UpdateRecursive(node.Left, employeeID, updatedEmployee);
        }
        else
        {
            return UpdateRecursive(node.Right, employeeID, updatedEmployee);
        }
    }
    public bool Delete(string employeeID)
    {
        bool deleted;
        Root = DeleteRecursive(Root, employeeID, out deleted);
        return deleted;
    }
    private Node DeleteRecursive(Node node, string employeeID, out bool deleted)
    {
        deleted = false;
        if (node == null)
            return node;

        int comparison = string.Compare(employeeID, node.Employee.EmployeeID);
        if (comparison < 0)
        {
            node.Left = DeleteRecursive(node.Left, employeeID, out deleted);
        }
        else if (comparison > 0)
        {
            node.Right = DeleteRecursive(node.Right, employeeID, out deleted);
        }
        else
        {
            deleted = true;
            if (node.Left == null)
                return node.Right;
            else if (node.Right == null)
                return node.Left;

            node.Employee = FindMin(node.Right).Employee;
            node.Right = DeleteRecursive(node.Right, node.Employee.EmployeeID, out deleted);
        }

        return node;
    }
    private Node FindMin(Node node)
    {
        while (node.Left != null)
            node = node.Left;
        return node;
    }

    public void PrintTree()
    {
        List<Employee> truongPhong = new List<Employee>();
        List<Employee> phoPhong = new List<Employee>();
        List<Employee> nhanVien = new List<Employee>();

        CategorizeEmployees(Root, truongPhong, phoPhong, nhanVien);

        foreach (var employee in truongPhong)
        {
            Console.WriteLine("  -"+employee);
        }
        foreach (var employee in phoPhong)
        {
            Console.WriteLine("    -"+employee);
        }
        foreach (var employee in nhanVien)
        {
            Console.WriteLine("      -"+employee);
        }
    }

    private void CategorizeEmployees(Node node, List<Employee> truongPhong, List<Employee> phoPhong, List<Employee> nhanVien)
    {
        if (node == null)
            return;

        CategorizeEmployees(node.Left, truongPhong, phoPhong, nhanVien);

        // Chuẩn hóa giá trị Position
        string position = node.Employee.Position?.Trim().ToLower();
        if (position == "truong phong")
        {
            truongPhong.Add(node.Employee);
        }
        else if (position == "pho phong")
        {
            phoPhong.Add(node.Employee);
        }
        else if (position == "nhan vien")
        {
            nhanVien.Add(node.Employee);
        }

        CategorizeEmployees(node.Right, truongPhong, phoPhong, nhanVien);
    }
}