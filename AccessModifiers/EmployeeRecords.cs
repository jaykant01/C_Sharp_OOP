namespace AccessModifiers;

public class EmployeeRecords
{
    // Attributes
    public int employeeId;
    protected string department;
    private int salary;

    // Default Constructors
    public EmployeeRecords()
    {
        employeeId = 1;
        department = "DOT NET";
        salary = 30000;
    }

    // Get
    public int GetSalary()
    {
        return salary;
    }

    // Set
    public void SetSalary(int newSalary) {
        this.salary = newSalary;
    }

    // Display
    public void Display()
    {
        Console.WriteLine("Employee Records");
        Console.WriteLine("EmployeeId: " + employeeId);
        Console.WriteLine("Department: " + department);
        Console.WriteLine("Salary: " + salary);
    }
}

class Manager : EmployeeRecords
{
    public Manager()
        : base() { }
}
