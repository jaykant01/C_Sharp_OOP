namespace OOP_Pillars_Practice;

abstract class Employee
{
    // Encapsulated fields
    private int employeeId;
    private string name;
    private double baseSalary;
    private string department;

    // Access Through Getters and setters
    public int EmployeeId
    {
        get {  return employeeId; }
        set { employeeId = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public double BaseSalary
    {
        get { return baseSalary; }
        set { baseSalary = value; }
    }

    // Constructor
    public Employee(int employeeId, string name, double baseSalary)
    {
        this.employeeId = employeeId;
        this.name = name;
        this.baseSalary = baseSalary;
    }

    // Anstract Method
    public abstract double CalculateSalary();

    // Concrete Methods
    public void DisplayDetails()
    {
        Console.WriteLine($"--- Employee Details ---");
        Console.WriteLine("Employee ID   : " + EmployeeId);
        Console.WriteLine("Name          : " + Name);
        Console.WriteLine("Department    : " + department);
        Console.WriteLine("Salary        : " + CalculateSalary());
    }

    // Interface Methods Override
    public void AssignDepartment(string departmentName)
    {
        department = departmentName;
    }

    public string GetDepartmentDetails()
    {
        return department;
    }
}
// Interface Class
interface IDepartment
{
    void AssignDepartment();

    string GetDepartmentDetails();
}

// Subclass
class FullTimeEmployee : Employee
{
    public FullTimeEmployee(int employeeId, string name, double baseSalary) : base(employeeId, name, baseSalary)
    {
    }

    public override double CalculateSalary()
    {
        return BaseSalary;
    }
}

// Subclass
class PartTimeEmployee : Employee
{
    private int hoursWorked;
    private double hourlyRate;

    public PartTimeEmployee(int employeeId, string name, double baseSalary, int hoursWorked, double hourlyRate) :base(employeeId, name, baseSalary)
    {
        this.hoursWorked = hoursWorked;
        this.hourlyRate = hourlyRate;
    }

    public override double CalculateSalary()
    {
        Console.WriteLine($"Partime Bonus : {hoursWorked * hourlyRate}");
        return BaseSalary + (hoursWorked * hourlyRate);
    }

}