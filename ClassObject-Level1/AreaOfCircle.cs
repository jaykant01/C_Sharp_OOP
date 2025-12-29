namespace ClassObject_Level1;

public class AreaOfCircle
{
    // Attributes
    private double radius;

    // Constructor
    public AreaOfCircle(double radius)
    {
        this.radius = radius; 
    }

    // Method to Calculate Area
    public double CalculateArea()
    {
        return Math.PI * radius * radius;
    }

    // Method to Calculate circumference
    public double CalculateCircumference()
    {
        return 2 * Math.PI * radius;
    }


    // Display Area Of a Circle
    public void Display()
    {
        Console.WriteLine("Display Circle Details: ");
        Console.WriteLine("Radius:  " + radius);
        Console.WriteLine("Area:  " + CalculateArea());
        Console.WriteLine("Circumference:  " + CalculateCircumference());
        
    }
}
