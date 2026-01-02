namespace Inheritance_Practice;
/* ○ Description: Model a banking system with different account types using
hierarchical inheritance. BankAccount is the superclass, with
SavingsAccount, CheckingAccount, and FixedDepositAccount as
subclasses.
 */
public class BankAccount
{
    public int AccountNumber;
    public int Balance;

    public BankAccount(int  accountNumber, int balance)
    {
        this.AccountNumber = accountNumber;
        this.Balance = balance;
    }

    public virtual void DisplayAccountType()
    {
        Console.WriteLine("Information about Account");
        Console.WriteLine($"Account Number: {AccountNumber}");
        Console.WriteLine($"Account Balance: {Balance} Rs");

    }

}

public class SavingsAccount : BankAccount
{
    public int InterestRate;

    public SavingsAccount(int accountNumber, int balance, int interestRate) : base(accountNumber, balance)
    {
        InterestRate = interestRate;
    }

    public override void DisplayAccountType()
    {
        base.DisplayAccountType();

        Console.WriteLine("Account Type is Savings Account");
        Console.WriteLine($"Interest Rate is {InterestRate}%");
    }
}

public class CheckingAccount : BankAccount
{
    public int WithdrawalLimit;

    public CheckingAccount(int accountNumber, int balance, int withdrawalLimit) : base(accountNumber, balance)
    {
        WithdrawalLimit = withdrawalLimit;
    }

    public override void DisplayAccountType()
    {
        base.DisplayAccountType();
        Console.WriteLine("Account Type is Checking Account");
        Console.WriteLine($"Withdrawal Limit is {WithdrawalLimit}");
    }
}


public class FixedDepositAccount : BankAccount
{
    public int FixedRate;

    public FixedDepositAccount(int accountNumber, int balance, int fixedRate) : base(accountNumber, balance)
    {
        FixedRate = fixedRate;
    }

    public override void DisplayAccountType()
    {
        base.DisplayAccountType();
        Console.WriteLine("Account Type is FixedDeposit Account");
        Console.WriteLine($"FixedDeposit rate is {FixedRate}%");
    }
}

