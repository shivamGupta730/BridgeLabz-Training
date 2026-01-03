using System;

class BankAccountProgram
{
    static string bankName;
    static int totalAccounts = 0;

    string holderName;
    readonly int accountNumber;

    BankAccountProgram(string holderName, int accountNumber)
    {
        this.holderName = holderName;
        this.accountNumber = accountNumber;
        totalAccounts++;
    }

    static void GetTotalAccounts()
    {
        Console.WriteLine("Total Accounts: " + totalAccounts);
    }

    void ShowDetails(object obj)
    {
        if (obj is BankAccountProgram)
        {
            Console.WriteLine("Account Holder: " + holderName);
            Console.WriteLine("Account Number: " + accountNumber);
        }
    }

    static void Main()
    {
        Console.Write("Enter Bank Name: ");
        bankName = Console.ReadLine();

        Console.Write("Enter Holder Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Account Number: ");
        int accNo = int.Parse(Console.ReadLine());

        BankAccountProgram acc = new BankAccountProgram(name, accNo);

        Console.WriteLine("Bank Name: " + bankName);
        acc.ShowDetails(acc);
        GetTotalAccounts();
    }
}
