namespace ObjectModeling;
/* Description: Model a relationship where a Bank has Customer objects associated with it. A
Customer can have multiple bank accounts, and each account is linked to a Bank.
 */
public class Bank
{
    // Attributes 
    public string bankName { get; }
    private List<Account> accounts = new List<Account> ();

    // Constructor
    public Bank(string bankName)
    {
        this.bankName = bankName; 
    }

    // Association Method
    public Account OpenAccount(Customer customer, int accountNumber)
    {
        Account account = new Account(accountNumber, this);
        accounts.Add(account);
        customer.AddAccount(account);

        return account;
    }
}

public class Account
{
    public int accountNumber { get; }
    public double balance { get; private set; }
    public Bank bank { get; }

    // Constructor
    public Account(int accountNumber, Bank bank)
    {
        this.accountNumber = accountNumber;
        this.bank = bank;
        balance = 0;
    }

    // Method
    public void Deposit(double amount)
    {
        balance += amount;
    }
}


public class Customer
{
    // Attributes
    public string name { get; }
    public List<Account> accounts = new List<Account>();

    // Constructor
    public Customer(string name)
    {
        this.name = name; 
    }

    // Method
    public void AddAccount(Account account)
    {
        accounts.Add(account);
    }

    // Method
    public void ViewBalance()
    {
        Console.WriteLine($"Accounts of {name}:");
        foreach(var account in accounts)
        {
            Console.WriteLine(
                $"Bank: {account.bank.bankName}, " +
                $"Account No: {account.accountNumber}, " +
                $"Balance: ₹{account.balance}"
            );
        }
    }
}
