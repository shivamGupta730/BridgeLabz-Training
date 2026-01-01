using System;

public class BankAccount
{
    public int accountNumber;
    protected string accountHolder;
    private double balance;

    public void SetBalance(double balance)
    {
        this.balance = balance;
    }

    public double GetBalance()
    {
        return balance;
    }

    public void SetHolder(string name)
    {
        accountHolder = name;
    }
}

// Child class
public class SavingsAccount : BankAccount
{
    public void DisplayAccount()
    {
        Console.WriteLine("Account Number: " + accountNumber);
        Console.WriteLine("Account Holder: " + accountHolder);
    }
}

public class Program
{
    public static void Main()
    {
        SavingsAccount acc = new SavingsAccount();

        Console.Write("Enter account number: ");
        acc.accountNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter account holder name: ");
        acc.SetHolder(Console.ReadLine());

        Console.Write("Enter balance: ");
        acc.SetBalance(Convert.ToDouble(Console.ReadLine()));

        acc.DisplayAccount();
        Console.WriteLine("Balance: " + acc.GetBalance());
    }
}
