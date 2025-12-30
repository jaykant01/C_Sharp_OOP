namespace KeyWords;

public class UniversityStudent
{
    // Static variable
    public static string universityName = "IIT Rorkee";
    private static int totalStudents = 0;

    // Instance Variable
    public string name;
    public char grade;

    // Readonly Variable
    public readonly int rollNumber;

    // Constructor using this
    public UniversityStudent(string name, int rollNumber,  char grade)
    {
        this.name = name;
        this.rollNumber = rollNumber;
        this.grade = grade;
        totalStudents++;
    }

    // static method
    public static void DisplayTotalStudents()
    {
        Console.WriteLine("Total Students: " + totalStudents);
    }

    // display Students details
    public void DisplayDetails(object obj)
    {
        // Using is operator
        if (obj is UniversityStudent)
        {
            Console.WriteLine("University Student System: ");
            Console.WriteLine("Student Name: " + name);
            Console.WriteLine("Student RollNumber: " + rollNumber);
            Console.WriteLine("Student Grade: " + grade);
            Console.WriteLine("University Name: " + universityName);
        }
        else
        {
            Console.WriteLine("Object is not a Student System");
        }
    }
}
