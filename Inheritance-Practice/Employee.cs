namespace Inheritance_Practice;

public class Employee
{
    public string Name;
    public int Id;
    public double Salary;

    public Employee(string name, int id, double salary)
    {
        Name = name;
        Id = id;
        Salary = salary;
    }

    public virtual void DisplayDetails()
    {
        Console.WriteLine("Employee Details:");
        Console.WriteLine($"Name   : {Name}");
        Console.WriteLine($"ID     : {Id}");
        Console.WriteLine($"Salary : {Salary}");
    }
}

class Manager : Employee
{
    public int TeamSize;

    public Manager(string name, int id, double salary, int teamSie) : base(name, id, salary)
    {
        TeamSize = teamSie;
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Team Size : {TeamSize}");
    }
}

class Developer : Employee
{
    public string ProgrammingLanguage;

    public Developer(string name, int id, double salary, string programmingLanguage)
        : base(name, id, salary)
    {
        ProgrammingLanguage = programmingLanguage;
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Programming Language : {ProgrammingLanguage}");
    }
}

class Intern : Employee
{
    public string InternshipDuration;

    public Intern(string name, int id, double salary, string internshipDuration)
        : base(name, id, salary)
    {
        InternshipDuration = internshipDuration;
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Internship Duration : {InternshipDuration}");
    }
}

