namespace AccessModifiers;

public class UniversityManagement
{
    // Attributes
    public int rollNumber;
    protected string name;
    private double CGPA;

    // Parametized Constructors
    public UniversityManagement(int rollNumber, string name, double CGPA)
    {
        this.rollNumber = rollNumber;
        this.name = name;
        this.CGPA = CGPA;
    }

    // Getter and setter
    public double GetCGPA()
    {
        return CGPA;
    }

    public void SetCGPA(double newCGPA)
    {
        if (newCGPA >= 0 && newCGPA <= 10)
        {
            this.CGPA = newCGPA;
            Console.WriteLine("CGPA Updated Successfully");
        }
        else
        {
            Console.WriteLine("Inavalid CGPA value");
        }
    }

    public void DisplayInfo()
    {
        Console.WriteLine("Student Information");
        Console.WriteLine("Student RollNumber: " + rollNumber);
        Console.WriteLine("Student Name: " + name);
        Console.WriteLine("Student CGPA: " + GetCGPA());
    }

}

class PostgraduateStudent : UniversityManagement
{
    public PostgraduateStudent(int rollNumber, string name, double CGPA)
        : base(rollNumber, name, CGPA)
    { 
    }

    public void DisplyInfo()
    {
        Console.WriteLine("Student Information");
        Console.WriteLine("Student RollNumber: " + rollNumber);
        Console.WriteLine("Student Name: " + name);
        Console.WriteLine("Student CGPA: " + GetCGPA());
    }
}
