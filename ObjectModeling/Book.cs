namespace ObjectModeling;
/* Description: Create a Library class that contains multiple Book objects. Model the
relationship such that a library can have many books, but a book can exist independently
(outside of a specific library).
 */
public class Book
{
    // Attributes & Fields
    public string title {  get; set; }
    public string author { get; set; }

    // Constructor
    public Book(string title, string author)
    {
        this.title = title;
        this.author = author;
    }
    
    // Method
    public void BookInfo()
    {
        Console.WriteLine($"Title of the book is {title} and Author is {author}");
    }

}

public class Library
{
    // Attributes
    public string name {  get; set; }
    private List<Book> books = new List<Book>();

    // Constructor
    public Library(string name)
    {
        this.name = name;
    }

    // Methods
    public void AddBook(Book book)
    {
        if(book != null && !books.Contains(book))
        {
            books.Add(book);
            Console.WriteLine($"Added {book.title} to {name}.");
        }
    }

    public void DisplayBooks()
    {
        Console.WriteLine($"Books Avialable at {name}");
        if (books.Any())
        {
            foreach (Book book in books)
            {
                book.BookInfo();
            }
        }
        else
        {
            Console.WriteLine("The Library Currently has no books.");
        }
    }
}
