namespace KeyWords;
/* Create a Book class to manage library books with the following features:
 */
public class LibrarySystem
{
    // Static variable
    public static string libraryName = "GLA Main Library";

    // Instance Variable
    public string title;
    public string author;

    // Readonly Variable
    public readonly int ISBN;

    // Constructor using this
    public LibrarySystem(string title, string author, int ISBN)
    {
        this.title = title;
        this.author = author;
        this.ISBN = ISBN;
    }

    // static Method to Display Library Name
    public static void DisplayLibraryName()
    {    
        Console.WriteLine("Library Name " + libraryName);  
    }

    // Display Details
    public void Display(object obj)
    {
        if (obj is LibrarySystem)
        {
            Console.WriteLine("Library Management System: ");
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Author: " + author);
            Console.WriteLine("ISBN : " + ISBN);
        }
        else
        {
            Console.WriteLine("Object is not a Library Mangement System");
        }
    }
}
