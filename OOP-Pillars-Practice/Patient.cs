namespace OOP_Pillars_Practice;
/* Description: Design a system to manage patients in a hospital.
 */
abstract class Patient
{
    // Encapsulated fields
    private int patientId;
    private string name;
    private int age;

    protected double billAmount;

    // Properties
    public int PatientId
    {
        get { return patientId; }
        protected set { patientId = value; }
    }

    public string Name
    {
        get { return name; }
        protected set { name = value; }
    }

    public int Age
    {
        get { return age; }
        protected set { age = value; }
    }

    // Constructor
    public Patient(int id, string name, int age)
    {
        PatientId = id;
        Name = name;
        Age = age;
    }

    // Abstract method
    public abstract double CalculateBill();

    // Concrete method
    public void GetPatientDetails()
    {
        Console.WriteLine("Patient ID : " + PatientId);
        Console.WriteLine("Name       : " + Name);
        Console.WriteLine("Age        : " + Age);
    }
}

interface IMedicalRecord
{
    void AddRecord(string diagnosis);
    void ViewRecords();
}


class InPatient : Patient, IMedicalRecord
{
    private int daysAdmitted;
    private string diagnosis; 

    public InPatient(int id, string name, int age, int days)
        : base(id, name, age)
    {
        daysAdmitted = days;
    }

    public override double CalculateBill()
    {
        double dailyCharge = 2000;
        billAmount = daysAdmitted * dailyCharge;
        return billAmount;
    }

    public void AddRecord(string diagnosis)
    {
        this.diagnosis = diagnosis;
    }

    public void ViewRecords()
    {
        Console.WriteLine("Diagnosis  : " + diagnosis);
    }
}

class OutPatient : Patient, IMedicalRecord
{
    private string diagnosis; 

    public OutPatient(int id, string name, int age)
        : base(id, name, age)
    {
    }

    public override double CalculateBill()
    {
        return billAmount = 500; 
    }

    public void AddRecord(string diagnosis)
    {
        this.diagnosis = diagnosis;
    }

    public void ViewRecords()
    {
        Console.WriteLine("Diagnosis  : " + diagnosis);
    }
}

