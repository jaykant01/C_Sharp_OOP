namespace AccessModifiers;

class Program
{
    static void Main(string[] args)
    {
        // Problem 1
        //UniversityManagement um = new UniversityManagement(101, "Max", 8.5);
        //um.SetCGPA(9.2);
        //um.DisplayInfo();

        //Console.WriteLine();

        //PostgraduateStudent pg = new PostgraduateStudent(102, "Dustin", 8.5);
        //pg.SetCGPA(9.1);
        //pg.DisplayInfo();


        // Problem 2
        //BookLibrary bk = new BookLibrary(4242, "Stranger Things", "Brothers");
        //bk.SetAuthor("Duffer Brothers");
        //bk.Display();

        //EBook eb = new EBook(4343, "ST Chapter 5", "Vecna");
        //eb.SetAuthor("Millie Bobbi Brown");
        //eb.Display();



        // Problem 3
        BankAccount b = new BankAccount();
        //b.SetBalance(1000);
        b.Display();

        Console.WriteLine();

        SavingsAccount s = new SavingsAccount();
        //s.SetBalance(1800);
        s.Display();



        Console.ReadKey();
        
    }
}
