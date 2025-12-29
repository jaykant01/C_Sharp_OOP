namespace Constructors_Level1;

public class CircleClass
{
    // Attributes
    public double radius;

    // Default COnstructor
    public CircleClass()
    {
        radius = 5;
    }

    // Parametrized Constructor
    public CircleClass(double Radius)
    {
        radius = Radius;
    }

    // Display 
    public void Display()
    {
        Console.WriteLine("Circle class");
        Console.WriteLine("Radius of a Circle: " + radius);
    }


}
