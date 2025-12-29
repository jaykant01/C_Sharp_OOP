namespace Constructors_Level2;

class Program
{
    static void Main(string[] args)
    {
        // Problem 1
        //ProductInventory p = new ProductInventory("IPhone 17", 120000);
        //p.DisplayProductDetails();
        //ProductInventory.DisplayTotalProducts();



        // Problem 2
        OnlineCourse o = new OnlineCourse("C#", 3, 0);
        o.DisplayCourseDetails();
        Console.WriteLine();
        OnlineCourse.UpdateInstituteName("GLA");
        o.DisplayCourseDetails();



        Console.ReadKey();
    }
}
