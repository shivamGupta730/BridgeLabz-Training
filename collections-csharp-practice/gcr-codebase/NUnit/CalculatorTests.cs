using NUnit.Framework;
using System;

[TestFixture]
public class CalculatorTests
{
    Calculator calc;

    [SetUp]
    public void Setup()
    {
        calc = new Calculator();
    }

    [Test]
    public void Add_Test()
    {
        Assert.AreEqual(5, calc.Add(2, 3));
    }

    [Test]
    public void Subtract_Test()
    {
        Assert.AreEqual(3, calc.Subtract(5, 2));
    }

    [Test]
    public void Multiply_Test()
    {
        Assert.AreEqual(12, calc.Multiply(4, 3));
    }

    [Test]
    public void Divide_Test()
    {
        Assert.AreEqual(5, calc.Divide(10, 2));
    }

    [Test]
    public void Divide_ByZero_Test()
    {
        Assert.Throws<DivideByZeroException>(() =>
        {
            calc.Divide(10, 0);
        });
    }
}
