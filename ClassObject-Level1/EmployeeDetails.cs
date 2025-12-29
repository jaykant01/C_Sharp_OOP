namespace ClassObject_Level1;
/* Problem Statement: Write a program to create an Employee class with attributes name, id,
and salary. Add a method to display the details.
 */
public class EmployeeDetails
{
    // Fields
    private string name;
    private int id;
    private int salary;

    // Constructor
    public EmployeeDetails(string name, int id, int salary) { 
        this.name = name;
        this.id = id;
        this.salary = salary;
    }

    // Method to Display Employee Details
    public void DisplayDetails()
    {
        Console.WriteLine("Employee Details:");
        Console.WriteLine("Employee Name: " + name);
        Console.WriteLine("Employee Id: " + id);
        Console.WriteLine("Employee Salary: " + salary);
    }
}
