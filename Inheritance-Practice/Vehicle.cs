namespace Inheritance_Practice;

public class Vehicle
{
    public int MaxSpeed;
    public string FuelType;

    public Vehicle(int maxSpeed, string fuelType)
    {
        MaxSpeed = maxSpeed;
        FuelType = fuelType;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine("Vehicle Information:");
        Console.WriteLine($"Max Speed : {MaxSpeed} km/h");
        Console.WriteLine($"Fuel Type: {FuelType}");
    }
}

public class Car : Vehicle
{
    public int SeatCapacity;

    public Car(int maxSpeed, string fuelType, int seatCapacity) : base(maxSpeed, fuelType)
    {
        SeatCapacity = seatCapacity;

    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Seat Capacity : {SeatCapacity}");
    }
}

class Truck : Vehicle
{
    public int PayloadCapacity;

    public Truck(int maxSpeed, string fuelType, int payloadCapacity)
        : base(maxSpeed, fuelType)
    {
        PayloadCapacity = payloadCapacity;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Payload Capacity : {PayloadCapacity} kg");
    }
}

class Motorcycle : Vehicle
{
    public bool HasSidecar;

    public Motorcycle(int maxSpeed, string fuelType, bool hasSidecar)
        : base(maxSpeed, fuelType)
    {
        HasSidecar = hasSidecar;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Has Sidecar : {HasSidecar}");
    }
}



