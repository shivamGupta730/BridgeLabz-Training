using NUnit.Framework;
using System;

[TestFixture]
public class MathUtilsTests
{
    MathUtils math;

    [SetUp]
    public void Setup()
    {
        math = new MathUtils();
    }

    [Test]
    public void Divide_ValidValues_Test()
    {
        int result = math.Divide(10, 2);
        Assert.AreEqual(5, result);
    }

    [Test]
    public void Divide_ByZero_ThrowsException()
    {
        Assert.Throws<ArithmeticException>(() =>
        {
            math.Divide(10, 0);
        });
    }
}
