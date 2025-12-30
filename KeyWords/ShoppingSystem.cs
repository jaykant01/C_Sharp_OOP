namespace KeyWords;
/* Create a Product class to manage shopping cart items with the following features:
 */
public class ShoppingSystem
{
    // Static variable
    public static int discount = 10;

    // Instance Variable
    public string productName;
    public int price;
    public int quantity;

    // Readonly Variable
    public readonly int productId;

    // Constructor using this
    public ShoppingSystem(string productName, int price, int quantity, int productId)
    {
        this.productName = productName;
        this.price = price;
        this.quantity = quantity;
        this.productId = productId;
    }

    // static method
    public static void UpdateDiscount(int newDiscount)
    {
        discount = newDiscount;
        Console.WriteLine("New Discount: " + newDiscount);
    }

    // display Shopping details
    public void DisplayDetails(object obj)
    {
        // Using is operator
        if (obj is ShoppingSystem)
        {
            Console.WriteLine("Shopping Cart System: ");
            Console.WriteLine("Product Name: " + productName);
            Console.WriteLine("Product Price: " + price + " Rs");
            Console.WriteLine("Product ID: " + productId);
            Console.WriteLine("Product Quantity: " + quantity);
            //Console.WriteLine("Discount Percent: " + UpdateDiscount(discount));
        }
        else
        {
            Console.WriteLine("Object is not a Shopping System");
        }
    }
}
