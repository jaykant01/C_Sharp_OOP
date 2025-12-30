namespace KeyWords;

class Program
{
    static void Main(string[] args)
    {
        // Problem 1
        //BankSystem b1 = new BankSystem(101, "Nancy", 50000);
        //BankSystem b2 = new BankSystem(102, "Jonathan", 30000);

        //b1.DisplayDetails(b1);
        //b2.DisplayDetails(b2);
        //BankSystem.GetTotalAccounts();


        // Problem 2
        LibrarySystem l1 = new LibrarySystem("Knowledge is Power", "Unknown", 4242);
        l1.Display(l1);
        LibrarySystem.DisplayLibraryName();

        Console.ReadKey();
        
    }
}
