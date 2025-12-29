namespace Constructors_Level2;

public class ProductInventory
{
    // Instance Variables
    public string productName;
    public int price;

    // Class Variable
    public static int totalProducts;

    // Parametrized Constructors
    public ProductInventory(string productName, int price)
    {
        this.productName = productName;
        this.price = price;
        totalProducts++;
    }

    // Display Product Details
    public void DisplayProductDetails()
    {
        Console.WriteLine("Products Details");
        Console.WriteLine("Product Name: " + productName);
        Console.WriteLine("Product Price: " +  price);
    }

    // Display Total Products
    public static void DisplayTotalProducts()
    {
        Console.WriteLine("Total products created: " + totalProducts);
    }
}
