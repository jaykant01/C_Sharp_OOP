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
        //CircleClass c = new CircleClass();
        //c.Display();

        //CircleClass c1 = new CircleClass(8);
        //Console.WriteLine();
        //c1.Display();


        // Problem 3
        //PersonClass p = new PersonClass("Steve", 26, "Actor");
        //p.Display();
        //Console.WriteLine();
        //PersonClass p1 = new PersonClass(p);
        //p1.Display();

        // Problem 4
        HotelBooking hb = new HotelBooking();
        hb.Display();

        Console.WriteLine();
        HotelBooking hb1 = new HotelBooking("Eleven", "Double", 6);
        hb1.Display();

        Console.WriteLine();
        HotelBooking hb2 = new HotelBooking(hb1);
        hb2.Display();






        Console.ReadKey();
    }
}
