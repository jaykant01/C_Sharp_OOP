namespace Constructors_Level1;
/* Library Book System
o Create a Book class with attributes title, author, price, and availability.
o Implement a method BorrowBook() to borrow a book.
 */
public class LibraryBook
{
    // Attributes 
    public string title;
    public string author;
    public int price;
    public bool availability;


    // Parametrized Constructors
    public LibraryBook(string title, string author, int price, bool availability)
    {
        this.title = title;
        this.author = author;
        this.price = price;
        this.availability = availability;
    }

    // Book Borrow Method
    public void BookBorrow()
    {
        if (availability)
        {
            Console.WriteLine($"Sorry, {title} is currently unavialable");
        }
        else
        {
            availability = false;
            Console.WriteLine($"{title} has been successfully borrowed");
        }
    }

    // Display
    public void Display()
    {
        Console.WriteLine("Book Details");
        Console.WriteLine("Book Title: " + title);
        Console.WriteLine("Book Author: " + author);
        Console.WriteLine("Book Price: " + price);
        Console.WriteLine($"Book status : {(availability ? "Available" : "Unavialable")}");

    }
}
