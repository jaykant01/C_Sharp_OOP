namespace Constructors_Level1;

public class PersonClass
{
    // Attributes
    public string name;
    public int age;
    public string profession;

    // Parametrized Constructor
    public PersonClass(string Name, int Age, string Profession)
    {
        name = Name;
        age = Age;
        profession = Profession;
    }

    // Copy Constructor
    public PersonClass(PersonClass copyPerson)
    {
        name = copyPerson.name;
        age = copyPerson.age;
        profession=copyPerson.profession;
    }

    // Display
    public void Display()
    {
        Console.WriteLine("Person Details");
        Console.WriteLine("Person Name: " + name);
        Console.WriteLine("Person Age: " + age);
        Console.WriteLine("Person Profession: " + profession);

    }
}
