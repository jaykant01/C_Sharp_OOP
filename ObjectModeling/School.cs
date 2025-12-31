namespace ObjectModeling;
/* Description: Model a School with multiple Student objects, where each student can enroll in
multiple courses, and each course can have multiple students.
 */
public class School
{
    public string SchoolName { get; set; }
    public List<Student> Students { get; set; }
    public List<Course> Courses { get; set; }

    public School(string name)
    {
        SchoolName = name;
        Students = new List<Student>();
        Courses = new List<Course>();
    }

    public void AddStudent(Student student)
    {
        Students.Add(student);
    }

    public void AddCourse(Course course)
    {
        Courses.Add(course);
    }

    public void DisplaySchoolDetails()
    {
        Console.WriteLine($"Welcome to {SchoolName}");
        Console.WriteLine($"Total Students: {Students.Count}");
        Console.WriteLine($"Total Courses Offered: {Courses.Count}");
    }
}

public class Course
{
    public string Name { get; set; }
    public string CourseCode { get; set; }
    public List<Student> EnrolledStudents { get; set; }

    public Course(string name, string code)
    {
        Name = name;
        CourseCode = code;
        EnrolledStudents = new List<Student>();
    }

    public void AddStudent(Student student)
    {
        if (!EnrolledStudents.Contains(student))
        {
            EnrolledStudents.Add(student);
            student.EnrollInCourse(this);
        }
    }

    public void DisplayEnrolledStudents()
    {
        Console.WriteLine($"\nStudents enrolled in '{Name} ({CourseCode}'):");
        if (EnrolledStudents.Any())
        {
            foreach (var student in EnrolledStudents)
            {
                Console.WriteLine($"- {student.Name} (ID: {student.Id})");
            }
        }
        else
        {
            Console.WriteLine("  No students enrolled yet.");
        }
    }
}

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Course> EnrolledCourses { get; set; }

    public Student(int id, string name)
    {
        Id = id;
        Name = name;
        EnrolledCourses = new List<Course>();
    }

    public void EnrollInCourse(Course course)
    {
        if (!EnrolledCourses.Contains(course))
        {
            EnrolledCourses.Add(course);
            course.AddStudent(this);
        }
    }


    public void ViewEnrolledCourses()
    {
        Console.WriteLine($"\n{Name} (ID: {Id}) is enrolled in the following courses:");
        if (EnrolledCourses.Any())
        {
            foreach (var course in EnrolledCourses)
            {
                Console.WriteLine($"- {course.Name} ({course.CourseCode})");
            }
        }
        else
        {
            Console.WriteLine("  Not enrolled in any courses yet.");
        }
    }
}

