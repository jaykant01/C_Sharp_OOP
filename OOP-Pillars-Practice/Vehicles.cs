namespace OOP_Pillars_Practice;
/* Description: Develop a ride-hailing application.
 */
abstract class Vehicles
{
    private int vehicleId;
    private string driverName;
    protected double ratePerKm;

    public int VehicleId
    {
        get { return vehicleId; }
        protected set { vehicleId = value; }
    }

    public string DriverName
    {
        get { return driverName; }
        protected set { driverName = value; }
    }

    public Vehicles(int id, string driverName, double rate)
    {
        VehicleId = id;
        DriverName = driverName;
        ratePerKm = rate;
    }

    // Abstract method
    public abstract double CalculateFare(double distance);


    public void GetVehicleDetails()
    {
        Console.WriteLine("Vehicle ID : " + VehicleId);
        Console.WriteLine("Driver     : " + DriverName);
        Console.WriteLine("Rate/Km    : " + ratePerKm);
    }
}

interface IGPS
{
    string GetCurrentLocation();
    void UpdateLocation(string newLocation);
}

class Cars : Vehicles, IGPS
{
    private string currentLocation;

    public Cars(int id, string driver, double rate)
        : base(id, driver, rate) { }

    public override double CalculateFare(double distance)
    {
        return ratePerKm * distance; 
    }

    public string GetCurrentLocation()
    {
        return currentLocation;
    }

    public void UpdateLocation(string newLocation)
    {
        currentLocation = newLocation;
    }
}

class Bikes : Vehicles, IGPS
{
    private string currentLocation;

    public Bikes(int id, string driver, double rate)
        : base(id, driver, rate) { }

    public override double CalculateFare(double distance)
    {
        return (ratePerKm * distance) * 0.8; 
    }

    public string GetCurrentLocation()
    {
        return currentLocation;
    }

    public void UpdateLocation(string newLocation)
    {
        currentLocation = newLocation;
    }
}

class Auto : Vehicles, IGPS
{
    private string currentLocation;

    public Auto(int id, string driver, double rate)
        : base(id, driver, rate) { }

    public override double CalculateFare(double distance)
    {
        return (ratePerKm * distance) + 20; 
    }

    public string GetCurrentLocation()
    {
        return currentLocation;
    }

    public void UpdateLocation(string newLocation)
    {
        currentLocation = newLocation;
    }
}