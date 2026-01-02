namespace OOP_Pillars_Practice;

class Program
{
    static void Main(string[] args)
    {
        // Polymorphism using Employee reference
        List<Employee> employees = new List<Employee>();

        Employee emp1 = new FullTimeEmployee(101, "Will", 50000);
        emp1.AssignDepartment("HR");

        Employee emp2 = new PartTimeEmployee(102, "Henry", 8000, 3, 300);
        emp2.AssignDepartment("IT");

        employees.Add(emp1);
        employees.Add(emp2);

        // Polymorphic behavior
        foreach (Employee emp in employees)
        {
            emp.DisplayDetails();
        }

        Console.ReadKey();
    }
}
