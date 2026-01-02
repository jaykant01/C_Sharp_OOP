namespace OOP_Pillars_Practice;

public abstract class Vehicle
{
    private string vehicleNumber;
    private string type;
    protected double rentalRate;

    public string VehicleNumber
    {
        get { return vehicleNumber; }
        set { vehicleNumber = value; }
    }

    public string Type
    {
        get { return type; }
        set { type = value; }
    }

    public double RentalRate
    {
        get { return rentalRate; }
        set { rentalRate = value; }

    }

    public Vehicle(string vehicleNumber, string type, double rentalRate)
    {
        this.vehicleNumber = vehicleNumber;
        this.type = type;
        this.rentalRate= rentalRate;
    }

    // Abstract method
    public abstract double CalculateRentalCost(int days);
}


public interface IInsurable
{
    double CalculateInsurance();
    string GetInsuranceDetails();
}


class Car : Vehicle, IInsurable
{
    private string insurancePolicyNumber; 

    public Car(string number, double rate, string policyNo)
        : base(number, "Car", rate)
    {
        insurancePolicyNumber = policyNo;
    }

    public override double CalculateRentalCost(int days)
    {
        return rentalRate * days;
    }

    public double CalculateInsurance()
    {
        return rentalRate * 0.10; 
    }

    public string GetInsuranceDetails()
    {
        return "Car Insurance (Policy Hidden)";
    }
}

class Bike : Vehicle, IInsurable
{
    private string insurancePolicyNumber;

    public Bike(string number, double rate, string policyNo)
        : base(number, "Bike", rate)
    {
        insurancePolicyNumber = policyNo;
    }

    public override double CalculateRentalCost(int days)
    {
        return (rentalRate * days) * 0.9; 
    }

    public double CalculateInsurance()
    {
        return rentalRate * 0.05; 
    }

    public string GetInsuranceDetails()
    {
        return "Bike Insurance (Policy Hidden)";
    }
}

class Truck : Vehicle, IInsurable
{
    private string insurancePolicyNumber;

    public Truck(string number, double rate, string policyNo)
        : base(number, "Truck", rate)
    {
        insurancePolicyNumber = policyNo;
    }

    public override double CalculateRentalCost(int days)
    {
        return (rentalRate * days) + 500;
    }

    public double CalculateInsurance()
    {
        return rentalRate * 0.15; 
    }

    public string GetInsuranceDetails()
    {
        return "Truck Insurance (Policy Hidden)";
    }
}