using System;

class BankAccount
{
    public int AccountNumber;
    public double Balance;
}

class SavingsAccount : BankAccount
{
    public double InterestRate;

    public void DisplayAccountType()
    {
        Console.WriteLine("Savings Account");
    }
}

class Program
{
    static void Main()
    {
        SavingsAccount s = new SavingsAccount();

        Console.Write("Enter account number: ");
        s.AccountNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter balance: ");
        s.Balance = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter interest rate: ");
        s.InterestRate = Convert.ToDouble(Console.ReadLine());

        s.DisplayAccountType();
    }
}
