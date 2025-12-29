namespace ClassObject_Level1;
/* Problem Statement: Write a program to create a Book class with attributes title, author, and
price. Add a method to display the book details.
 */
public class BookDetails
{
    // Attributes
    private string name;
    private string author;
    private int price;

    // Constructor
    public BookDetails(string name, string author, int price)
    {
        this.name = name;
        this.author = author;
        this.price = price;
    }

    // Display
    public void Display()
    {
        Console.WriteLine("Book Details: ");
        Console.WriteLine("Book Name: " + name);
        Console.WriteLine("Author Name: " + author);
        Console.WriteLine("Book Price: " + price + " Rs");

    }
}
