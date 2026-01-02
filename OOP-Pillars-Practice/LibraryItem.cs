namespace OOP_Pillars_Practice;

abstract class LibraryItem
{
    // Encapsulated fields
    private int itemId;
    private string title;
    private string author;

    protected bool isAvailable = true;

    public int ItemId
    {
        get { return itemId; }
        protected set { itemId = value; }
    }

    public string Title
    {
        get { return title; }
        protected set { title = value; }
    }

    public string Author
    {
        get { return author; }
        protected set { author = value; }
    }

    public LibraryItem(int itemId, string title, string author)
    {
        ItemId = itemId;
        Title = title;
        Author = author;
    }

    // Abstract method
    public abstract int GetLoanDuration();

    public void GetItemDetails()
    {
        Console.WriteLine("Item ID  : " + ItemId);
        Console.WriteLine("Title    : " + Title);
        Console.WriteLine("Author   : " + Author);
        Console.WriteLine("Available: " + isAvailable);
    }
}

interface IReservable
{
    void ReserveItem();
    bool CheckAvailability();
}

class Book : LibraryItem, IReservable
{
    private string borrowerName; 

    public Book(int id, string title, string author)
        : base(id, title, author) { }

    public override int GetLoanDuration()
    {
        return 14; 
    }

    public void ReserveItem()
    {
        isAvailable = false;
        borrowerName = "Reserved User";
    }

    public bool CheckAvailability()
    {
        return isAvailable;
    }
}

class Magazine : LibraryItem
{
    public Magazine(int id, string title, string author)
        : base(id, title, author) { }

    public override int GetLoanDuration()
    {
        return 7; 
    }
}

class DVD : LibraryItem, IReservable
{
    private string borrowerName; 

    public DVD(int id, string title, string author)
        : base(id, title, author) { }

    public override int GetLoanDuration()
    {
        return 3; 
    }

    public void ReserveItem()
    {
        isAvailable = false;
        borrowerName = "Reserved User";
    }

    public bool CheckAvailability()
    {
        return isAvailable;
    }
}