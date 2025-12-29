namespace Constructors_Level1;

public class BookClass
{
    // Attributes
    public string title { get; set; }
    public string author { get; set; }
    public int price { get; set; }

    // Default Constructors
    public BookClass()
    {
        title = "Harry Potter";
        author = "J.K Rowling";
        price = 1000;
    }

    // Parametrized Constructors
    public BookClass(string Title, string Author, int Price)
    {
        title = Title;
        author = Author;
        price = Price;
    }

    // Display
    public void Display()
    {
        Console.WriteLine("Display Book Class");
        Console.WriteLine("Book Title: " + title);
        Console.WriteLine("Author Name: " + author);
        Console.WriteLine("Book Price: " + price + " Rs");
    }

}
