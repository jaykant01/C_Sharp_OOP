namespace Inheritance_Practice;
/* 1. Animal Hierarchy
Description:
Create a hierarchy where Animal is the superclass, and Dog, Cat, and Bird are subclasses.
Each subclass has a unique behavior.
 */
public class Animal
{
    public string Name;
    public int Age;

    public virtual void MakeSound()
    {
        Console.WriteLine("Animal makes a Sound");
    }

}

public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Dog barks");
    }
}

public class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Cat meows");
    }
}

public class Bird : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Bird chirps");
    }
}





