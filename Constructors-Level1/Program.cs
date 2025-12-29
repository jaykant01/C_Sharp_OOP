using System.Reflection.Metadata;

namespace Constructors_Level1;

class Program
{
    static void Main(string[] args)
    {
        // Problem 1
        //BookClass bk = new BookClass();
        //bk.Display();

        //Console.WriteLine();

        //BookClass bk1 = new BookClass("Five Points Someone", "Chetan bhagat", 280);
        //bk1.Display();


        // Problem 2
        CircleClass c = new CircleClass();
        c.Display();

        CircleClass c1 = new CircleClass(8);
        Console.WriteLine();
        c1.Display();
        Console.ReadKey();
    }
}
