namespace Constructors_Level2;

class Program
{
    static void Main(string[] args)
    {
        ProductInventory p = new ProductInventory("IPhone 17", 120000);
        p.DisplayProductDetails();
        ProductInventory.DisplayTotalProducts();

        Console.ReadKey();
    }
}
