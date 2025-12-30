namespace KeyWords;

public class EmployeeSystem
{
    // Static variable
    public static string companyName = "Google";
    private static int totalEmployees = 0;

    // Instance Variable
    public string name;
    public string designation;

    // Readonly Variable
    public readonly int employeeId;

    // Constructor using this
    public EmployeeSystem(string name, string  designation,  int employeeId)
    {
        this.name = name;
        this.designation = designation;
        this.employeeId = employeeId;
        totalEmployees++;
    }

    // static method
    public static void DisplayTotalEmployees()
    {
        Console.WriteLine("Total Employees: " + totalEmployees);
    }

    // display Employee details
    public void DisplayDetails(object obj)
    {
        // Using is operator
        if (obj is EmployeeSystem)
        {
            Console.WriteLine("Employee Mangement System: ");
            Console.WriteLine("Employee Name: " + name);
            Console.WriteLine("Employee Designation: " + designation);
            Console.WriteLine("Employee ID: " + employeeId);
            Console.WriteLine("Company Name: " + companyName);
        }
        else
        {
            Console.WriteLine("Object is not a Employee System");
        }
    }
}
