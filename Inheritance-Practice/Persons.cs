namespace Inheritance_Practice;

public class Persons
{
    public string Name;
    public int Id;

    public Persons(string name, int id)
    {
        Name = name; 
        Id = id; 
    }

}

interface IWorker
{
    void PerformDuties();
    
}

public class Chef : Persons, IWorker
{
    public Chef(string name, int id) : base(name, id) 
    { 
    }

    public void PerformDuties()
    {
        Console.WriteLine($"{Name} is preparing meals in the kitchen.");
    }
}

public class Waiter : Persons, IWorker
{
    public Waiter(string name, int id) : base(name, id)
    {

    }

    public void PerformDuties()
    {
        Console.WriteLine($"{Name} is serving food to customers.");
    }
}
