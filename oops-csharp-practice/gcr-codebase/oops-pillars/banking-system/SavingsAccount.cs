class SavingsAccount : BankAccount, ILoanable
{
    public override double CalculateInterest()
    {
        return GetBalance() * 0.04;
    }

    public void ApplyForLoan()
    {
        Console.WriteLine("Loan Applied");
    }

    public double CalculateLoanEligibility()
    {
        return GetBalance() * 5;
    }
}
