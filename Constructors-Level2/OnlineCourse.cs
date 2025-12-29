namespace Constructors_Level2;

public class OnlineCourse
{
    // Instance Variable
    public string courseName;
    public int duration;
    public int fee;

    // Class Variable
    public static string instituteName = "Default Name";

    // Parametarized Constructors
    public OnlineCourse(string courseName, int duration, int fee)
    {
        this.courseName = courseName;
        this.duration = duration;
        this.fee = fee;
    }

    // Display Course Details
    public void DisplayCourseDetails()
    {
        Console.WriteLine("Course Details ");
        Console.WriteLine("Course Name: " + courseName);
        Console.WriteLine("Course Duration: " + duration);
        Console.WriteLine("Institute Name: " + instituteName);
    }

    // Update Institute Name
    public static void UpdateInstituteName(string newName)
    {
        instituteName = newName;
    }
}
