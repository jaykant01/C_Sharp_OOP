namespace ObjectModeling;

public class Faculty
{
    public string name { get; }

    public Faculty(string name)
    {
        this.name = name;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"  Faculty: {name}");
    }
}

public class Department1
{
    public string name { get; }

    private readonly List<Faculty> facultyMembers = new List<Faculty>();


    public Department1(string name)
    {
        this.name = name;
    }


    public void AddFaculty(Faculty faculty)
    {
        facultyMembers.Add(faculty);
    }


    public void ShowInfo()
    {
        Console.WriteLine($"Department: {name}");
        foreach (var faculty in facultyMembers)
        {
            faculty.ShowInfo();
        }
    }
}

public class University
{
    public string name { get; }

    private readonly List<Department1> departments = new List<Department1>();

    public University(string name)
    {
        this.name = name;
    }

    public Department1 CreateDepartment(string deptName)
    {
        var department = new Department1(deptName);
        departments.Add(department);
        return department;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"\nUniversity: {name}");
        foreach (var dept in departments)
        {
            dept.ShowInfo();
        }
    }
}
