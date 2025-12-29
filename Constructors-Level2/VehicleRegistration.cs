namespace Constructors_Level2;

public class VehicleRegistration
{
    // Instance Variable
    public string ownerName;
    public string vehiceType;

    // Class Variable
    public static int registrationFee = 5000;

    // Parametrized Constructors
    public VehicleRegistration(string  ownerName, string vehiceType)
    {
        this.ownerName = ownerName;
        this.vehiceType = vehiceType;
    }

    // Display Vehicle
    public void DisplayVehicleDetails()
    {
        Console.WriteLine("Vehicle Details");
        Console.WriteLine("Owner Name: " + ownerName);
        Console.WriteLine("Vehicle Type: " + vehiceType);
        Console.WriteLine("Registration Fee: " + registrationFee);
    }

    // Update Registration fee
    public static void UpdateRegistrationFee(int newFee)
    {
        registrationFee = newFee;
    }

}
