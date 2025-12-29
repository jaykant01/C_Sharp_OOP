namespace Constructors_Level1;
/* Circle Class
o Write a Circle class with a radius attribute.
o Use constructor chaining to initialize radius with both default and
user-provided values.
 */
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
