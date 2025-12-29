namespace AccessModifiers;

public class BankAccount
{
    // Attributes
    public int accountNumber;
    protected string accountHolder;
    private int balance;

    // Default Constructors
    public BankAccount()
    {
        accountNumber = 425;
        accountHolder = "Lucas";
        balance = 200;
    }

    // Get
    public int GetBalance()
    {
        return balance;
    }

    // Set
    public void SetBalance(int newBalance)
    {
        this.balance = newBalance;
    }

    // Display
    public void Display()
    {
        Console.WriteLine("Account Details");
        Console.WriteLine("Account Number: " + accountNumber);
        Console.WriteLine("Account Holder: " + accountHolder);
        Console.WriteLine("Account balance: " + balance);
    }
}

class SavingsAccount : BankAccount
{
    public SavingsAccount()
        : base() { }
}
