namespace Inheritance_Practice;
/* ○ Description: Model a vehicle system where Vehicle is the superclass and
ElectricVehicle and PetrolVehicle are subclasses. Additionally, create a
Refuelable interface implemented by PetrolVehicle.
 */
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
