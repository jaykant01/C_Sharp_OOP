namespace ObjectModeling;

public class Company
{
    public string companyName { get; }
    private List<Department> departments = new List<Department>();

    public Company(string companyName)
    {
        this.companyName = companyName;
    }

    // Add a department to the company
    public void AddDepartment(string deptName)
    {
        Department dept = new Department(deptName);
        departments.Add(dept);
    }

    // Add employee to a specific department
    public void AddEmployeeToDepartment(string deptName, string employeeName)
    {
        foreach (var dept in departments)
        {
            if (dept.deptName == deptName)
            {
                dept.AddEmployee(employeeName);
                return;
            }
        }
        Console.WriteLine($"Department {deptName} not found.");
    }

    // Show full company structure
    public void ShowStructure()
    {
        Console.WriteLine($"Company: {companyName}");
        foreach (var dept in departments)
        {
            dept.Show();
        }
        Console.WriteLine();
    }
}

public class Department
{
    public string deptName { get; }
    private List<Employee> employees = new List<Employee>();

    public class Employee
    {
        public string name { get; }

        public Employee(string name)
        {
            this.name = name;
        }

        public void Show()
        {
            Console.WriteLine($"    Employee: {name}");
        }
    }

    public Department(string deptName)
    {
        this.deptName = deptName;
    }

    // Add an employee to this department
    public void AddEmployee(string employeeName)
    {
        Employee emp = new Employee(employeeName);
        employees.Add(emp);
    }

    // Show department and all its employees
    public void Show()
    {
        Console.WriteLine($"  Department: {deptName}");
        foreach (var emp in employees)
        {
            emp.Show();
        }
    }
}
