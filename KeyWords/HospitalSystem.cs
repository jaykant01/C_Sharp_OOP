namespace KeyWords;

public class HospitalSystem
{
    // Static variable
    public static string hospitalName = "Galaxy";
    private static int totalPatients = 0;

    // Instance Variable
    public string name;
    public int age;
    public string ailment;


    // Readonly Variable
    public readonly int patientId;

    // Constructor using this
    public HospitalSystem(string name, int age, string ailment, int patientId)
    {
        this.name = name;
        this.age = age;
        this.ailment = ailment;
        this.patientId = patientId;
        totalPatients++;
    }

    // static method
    public static void GetTotalPatients()
    {
        Console.WriteLine("Total Patients: " + totalPatients);
    }

    // display Employee details
    public void DisplayDetails(object obj)
    {
        // Using is operator
        if (obj is HospitalSystem)
        {
            Console.WriteLine("Hospital Mangement System: ");
            Console.WriteLine("patient Name: " + name);
            Console.WriteLine("Patient Age: " + age);
            Console.WriteLine("Patient Ailment: " + ailment);
            Console.WriteLine("Hospital Name: " + hospitalName);
        }
        else
        {
            Console.WriteLine("Object is not a Hospital Management System");
        }
    }
}
