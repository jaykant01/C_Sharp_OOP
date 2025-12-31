namespace ObjectModeling;

class Program
{
    static void Main(string[] args)
    {
        // Aggregation
        Book book1 = new Book("The Hitchhiker's Guide to the Galaxy", "Douglas Adams");
        Book book2 = new Book("Dune", "Frank Herbert");
        Book book3 = new Book("1984", "George Orwell");

        Library cityLibrary = new Library("City Central Library");
        Library universityLibrary = new Library("University Main Library");

        cityLibrary.AddBook(book1);
        cityLibrary.AddBook(book2);

        universityLibrary.AddBook(book2);
        universityLibrary.AddBook(book3);

        cityLibrary.DisplayBooks();
        universityLibrary.DisplayBooks();

        Console.ReadKey();
    }
}
