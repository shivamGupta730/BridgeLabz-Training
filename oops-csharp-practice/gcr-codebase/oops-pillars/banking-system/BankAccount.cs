abstract class BankAccount
{
    private double balance;

    public void Deposit(double amt)
    {
        balance += amt;
    }

    public void Withdraw(double amt)
    {
        balance -= amt;
    }

    public double GetBalance()
    {
        return balance;
    }

    public abstract double CalculateInterest();
}
