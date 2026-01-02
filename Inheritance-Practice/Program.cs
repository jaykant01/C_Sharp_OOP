using System.Data.Common;

namespace Inheritance_Practice;

class Program
{
    static void Main(string[] args)
    {
        // Single Inheritance
        //Animal animal = new Animal();
        //animal.MakeSound();
        //Dog dog = new Dog();
        //dog.MakeSound();
        //Cat cat = new Cat();
        //cat.MakeSound();
        //Bird bird = new Bird();
        //bird.MakeSound();


        Employee manager = new Manager("Alice", 101, 80000, 10);
        manager.DisplayDetails();
        Console.WriteLine();

        Employee developer = new Developer("Bob", 102, 60000, "C#");
        developer.DisplayDetails();
        Console.WriteLine();

        Employee intern = new Intern("Charlie", 103, 15000, "6 Months");
        developer.DisplayDetails();
        Console.WriteLine();

        Console.ReadKey();
    }
}
