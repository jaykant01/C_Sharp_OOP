namespace Inheritance_Practice;

public class Vehicles
{
    public int MaxSpeed;
    public string Model;

    public Vehicles(int  maxSpeed, string model)
    {
        MaxSpeed = maxSpeed; Model = model;
    }
}

interface IRefuelable
{
    void Refuel();

}

public class ElectricVehicle : Vehicles
{
    public ElectricVehicle(int maxSpeed, string model) : base(maxSpeed, model)
    {

    }
    public void Charge()
    {
        Console.WriteLine($"The Car {Model} is Charged using Battery");
    }
    
}

public class PetrolVehicle : Vehicles, IRefuelable
{
    public PetrolVehicle(int maxSpeed, string model) : base(maxSpeed, model)
    {

    }

    public void Refuel()
    {
        Console.WriteLine($"The Car {Model} is Refuled using Petrol");
    }

}
