namespace KeyWords;

public class VehicleRegistration
{
    // Static variable
    public static int registrationFee = 1000;

    // Instance Variable
    public string ownerName;
    public string vehicleType;

    // Readonly Variable
    public readonly int registrationNumber;

    // Constructor using this
    public VehicleRegistration(string ownername,  string vehicleType, int registrationNumber)
    {
        this.ownerName = ownername;
        this.vehicleType = vehicleType;
        this.registrationNumber = registrationNumber;
    }

    // static method
    public static void UpdateRegistrationFee(int newRegistrationFee)
    {
        registrationFee = newRegistrationFee;
        Console.WriteLine("New RegistrationFee: " + newRegistrationFee);
    }

    // display Shopping details
    public void DisplayDetails(object obj)
    {
        // Using is operator
        if (obj is VehicleRegistration)
        {
            Console.WriteLine("Vehicle Registration System: ");
            Console.WriteLine("Owner Name: " + ownerName);
            Console.WriteLine("Vehicle Type: " + vehicleType);
            Console.WriteLine("Registration Number: " + registrationNumber);
        }
        else
        {
            Console.WriteLine("Object is not a Vehicle Registration System");
        }
    }
}
