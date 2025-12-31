namespace ObjectModeling;

class Program
{
    static void Main(string[] args)
    {
        // Aggregation
        //Book book1 = new Book("Dune", "Frank Herbert");
        //Book book2 = new Book("1984", "George Orwell");
        //Book book3 = new Book("Clean Code", "Robert C. Martin");

        //Library cityLibrary = new Library("City Central Library");
        //Library universityLibrary = new Library("University Main Library");

        //cityLibrary.AddBook(book1);
        //cityLibrary.AddBook(book2);
        //// Same book in another library (Aggretion)
        //universityLibrary.AddBook(book2); 
        //universityLibrary.AddBook(book3);

        //cityLibrary.DisplayBooks();
        //universityLibrary.DisplayBooks();


        // Association
        Bank sbi = new Bank("State Bank of India");
        Customer customer1 = new Customer("Jaykant");

        Account acc1 = sbi.OpenAccount(customer1, 1001);
        acc1.Deposit(5000);

        Account acc2 = sbi.OpenAccount(customer1, 1002);
        acc2.Deposit(12000);

        customer1.ViewBalance();

        Console.ReadKey();
    }
}
