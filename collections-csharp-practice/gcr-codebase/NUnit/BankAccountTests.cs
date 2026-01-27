using NUnit.Framework;
using System;

[TestFixture]
public class BankAccountTests
{
    BankAccount account;

    [SetUp]
    public void Setup()
    {
        account = new BankAccount();
    }

    [Test]
    public void Deposit_Test()
    {
        account.Deposit(100);
        Assert.AreEqual(100, account.GetBalance());
    }

    [Test]
    public void Withdraw_Test()
    {
        account.Deposit(200);
        account.Withdraw(50);
        Assert.AreEqual(150, account.GetBalance());
    }

    [Test]
    public void Withdraw_InsufficientBalance_Test()
    {
        account.Deposit(100);

        Assert.Throws<InvalidOperationException>(() =>
        {
            account.Withdraw(200);
        });
    }
}
