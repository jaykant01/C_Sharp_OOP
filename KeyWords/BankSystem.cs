namespace KeyWords;

public class BankSystem
{
    // static variable
    public static string bankName = "State Bank of India";
    private static int totalAccounts = 0;

    // readonly variable
    public readonly int accountNumber;

    public string accountHolderName;
    public double balance;

    // Constructor using this keyword
    public BankSystem(int accountNumber, string accountHolderName, double balance)
    {
        this.accountNumber = accountNumber;
        this.accountHolderName = accountHolderName;
        this.balance = balance;

        totalAccounts++;
    }

    // static method
    public static void GetTotalAccounts()
    {
        Console.WriteLine("Total Accounts: " + totalAccounts);
    }

    // display account details
    public void DisplayDetails(object obj)
    {
        // Using is operator
        if (obj is BankSystem)
        {
            Console.WriteLine(" Account Details ");
            Console.WriteLine("Bank Name: " + bankName);
            Console.WriteLine("Account Number: " + accountNumber);
            Console.WriteLine("Account Holder: " + accountHolderName);
            Console.WriteLine("Balance: " + balance);
        }
        else
        {
            Console.WriteLine("Object is not a BankAccount");
        }
    }
}
