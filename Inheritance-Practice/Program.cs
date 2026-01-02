using System.Data.Common;

namespace Inheritance_Practice;

class Program
{
    static void Main(string[] args)
    {
        // Assisted Problems

        // Problem 1
        //Animal animal = new Animal();
        //animal.MakeSound();
        //Dog dog = new Dog();
        //dog.MakeSound();
        //Cat cat = new Cat();
        //cat.MakeSound();
        //Bird bird = new Bird();
        //bird.MakeSound();


        // Problem 2
        //Employee manager = new Manager("Alice", 101, 80000, 10);
        //manager.DisplayDetails();
        //Console.WriteLine();

        //Employee developer = new Developer("Bob", 102, 60000, "C#");
        //developer.DisplayDetails();
        //Console.WriteLine();

        //Employee intern = new Intern("Charlie", 103, 15000, "6 Months");
        //developer.DisplayDetails();
        //Console.WriteLine();


        // Problem 3
        //Vehicle[] vehicles =
        //{
        //    new Car(180, "Petrol", 5),
        //    new Truck(120, "Diesel", 5000),
        //    new Motorcycle(150, "Petrol", false)
        //};

        //foreach (Vehicle vehicle in vehicles)
        //{
        //    vehicle.DisplayInfo();
        //    Console.WriteLine();
        //}




        // Single Inheritance

        //Problem 1
        //Author auth = new Author("C# Programming", 2024, "John Doe",
        //    "Software developer and technical writer");
        //auth.DisplayInfo();


        // Problem 2
        //Thermostat thermostat = new Thermostat(101, "ON", 22.5);
        //thermostat.DisplayStatus();




        // Multilevel Inheritance

        // Problem 1
        //Order order = new Order(1, DateTime.Now);
        //Order shipped = new ShippedOrder(2, DateTime.Now, "RGHJFJ123");
        //Order delivered = new DeliveredOrder(3, DateTime.Now, "RGHJFJ123", DateTime.Now.AddDays(3));

        //Console.WriteLine(order.GetOrderStatus());
        //Console.WriteLine(shipped.GetOrderStatus());
        //Console.WriteLine(delivered.GetOrderStatus());


        // Propblem 2
        Course basic = new Course("OOP Concepts", 40);
        basic.DisplayCourseInfo();
        Console.WriteLine();

        Course onlineCourse = new OnlineCourse("C# Online Course", 60, "Udemy", true);
        onlineCourse.DisplayCourseInfo();
        Console.WriteLine();

        Course paidCourse = new PaidOnlineCourse("Advanced C#", 80, "Coursera", true, 5000, 20);
        paidCourse.DisplayCourseInfo();

        Console.ReadKey();
    }
}
