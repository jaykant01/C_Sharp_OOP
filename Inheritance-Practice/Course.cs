namespace Inheritance_Practice;

public class Course
{
    public string CourseName;
    public int Duration;

    public Course(string courseName,  int duration)
    {
        CourseName = courseName;
        Duration = duration;
    }

    public virtual void DisplayCourseInfo()
    {
        Console.WriteLine("Course Information:");
        Console.WriteLine($"Course Name : {CourseName}");
        Console.WriteLine($"Duration    : {Duration} hours");
    }
}

public class OnlineCourse : Course
{
    public string Platform;
    public bool IsRecorded;

    public OnlineCourse(string courseName, int duration, string platform, bool isRecorded) : base(courseName, duration)
    {
        Platform = platform;
        IsRecorded = isRecorded;
    }

    public override void DisplayCourseInfo()
    {
        base.DisplayCourseInfo();
        Console.WriteLine("Online Course Details:");
        Console.WriteLine($"Platform    : {Platform}");
        Console.WriteLine($"Is Recorded : {IsRecorded}");
    }

}

public class PaidOnlineCourse : OnlineCourse
{
    public int Fee;
    public int Discount;

    public PaidOnlineCourse(string courseName, int duration, string platform, bool isRecorded, int fee, int discount) : base(courseName, duration, platform, isRecorded)
    {
        Fee = fee;
        Discount = discount;
    }

    public override void DisplayCourseInfo()
    {
        base.DisplayCourseInfo();
        Console.WriteLine("Payment Details:");
        Console.WriteLine($"Course Fee : {Fee}");
        Console.WriteLine($"Discount   : {Discount}%");
    }
}
