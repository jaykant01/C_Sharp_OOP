using System.Reflection.Metadata;

namespace Constructors_Level1;

class Program
{
    static void Main(string[] args)
    {
        // Problem 1
        BookClass bk = new BookClass();
        bk.Display();

        Console.WriteLine();

        BookClass bk1 = new BookClass("Five Points Someone", "Chetan bhagat", 280);
        bk1.Display();

        Console.ReadKey();
    }
}
