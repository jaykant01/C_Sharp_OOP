using System.Data.Common;

namespace Inheritance_Practice;

class Program
{
    static void Main(string[] args)
    {
        // Single Inheritance
        Animal animal = new Animal();
        animal.MakeSound();
        Dog dog = new Dog();
        dog.MakeSound();
        Cat cat = new Cat();
        cat.MakeSound();
        Bird bird = new Bird();
        bird.MakeSound();


        Console.ReadKey();
    }
}
