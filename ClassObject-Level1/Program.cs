namespace ClassObject_Level1;

class Program
{
    static void Main(string[] args)
    {
        // Problem 1
        EmployeeDetails emp = new EmployeeDetails("Jay", 02, 30000);
        
        // Display Details
        emp.DisplayDetails();

        Console.ReadKey();
    }
}
