namespace OOP_Pillars_Practice;

abstract class BankAccount
{
    // Encapsulated fields
    private int accountNumber;
    private string holderName;
    protected double balance;

    public int AccountNumber
    {
        get { return accountNumber; }
        set { accountNumber = value; }
    }

    public string HolderName
    {
        get { return holderName; }
        set { holderName = value; }
    }

    public double Balance
    {
        get { return balance; }
        set { balance = value; }
    }

    public BankAccount(int accountNumber, string name, double initialBalance)
    {
        AccountNumber = accountNumber;
        HolderName = name;
        Balance = initialBalance;
    }

    public void Deposit(double amount)
    {
        if (amount > 0)
            balance += amount;
    }

    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= balance)
            balance -= amount;
        else
            Console.WriteLine("Insufficient balance!");
    }

    // Abstract method
    public abstract double CalculateInterest();
}

interface ILoanable
{
    void ApplyForLoan();
    double CalculateLoanEligibility();
}

class SavingsAccount : BankAccount, ILoanable
{
    public SavingsAccount(int accountNumber, string name, double balance)
        : base(accountNumber, name, balance)
    {
    }

    public override double CalculateInterest()
    {
        return balance * 0.04; 
    }

    public void ApplyForLoan()
    {
        Console.WriteLine("Loan applied under Savings Account");
    }

    public double CalculateLoanEligibility()
    {
        return balance * 5; 
    }
}

class CurrentAccount : BankAccount
{
    public CurrentAccount(int accountNumber, string name, double balance)
        : base(accountNumber, name, balance)
    {
    }

    public override double CalculateInterest()
    {
        return balance * 0.01; 
    }
}