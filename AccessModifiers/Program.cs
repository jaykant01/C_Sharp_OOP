namespace AccessModifiers;

class Program
{
    static void Main(string[] args)
    {
        UniversityManagement um = new UniversityManagement(101, "Max", 8.5);
        um.SetCGPA(9.2);
        um.DisplayInfo();
        Console.WriteLine();
        PostgraduateStudent pg = new PostgraduateStudent(102, "Dustin", 8.5);
        pg.SetCGPA(9.1);
        pg.DisplayInfo();

        Console.ReadKey();
        
    }
}
