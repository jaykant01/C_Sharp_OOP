namespace AccessModifiers;

public class BookLibrary
{
    // Attributes
    public int ISBN;
    protected string title;
    private string author;

    // Parametrized Constructors
    public BookLibrary(int ISBN, string title, string author)
    {
        this.ISBN = ISBN;
        this.title = title;
        this.author = author;
    }


    // Get
    public string GetAuthor()
    {
        return author;
    }

    // Set 
    public void SetAuthor(string newAuthor)
    {
        this.author = newAuthor;
    }

    // Display
    public void Display()
    {
        Console.WriteLine("Book Details");
        Console.WriteLine("ISBN: " + ISBN);
        Console.WriteLine("Book Title: " + title);
        Console.WriteLine("Book Author: " + author);    
    }

}

class EBook : BookLibrary
{
    public EBook(int ISBN, string title, string author) 
        : base(ISBN, title, author) { }

}
