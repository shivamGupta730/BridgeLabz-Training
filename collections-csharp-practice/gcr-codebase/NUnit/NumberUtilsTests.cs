using NUnit.Framework;

[TestFixture]
public class NumberUtilsTests
{
    NumberUtils utils;

    [SetUp]
    public void Setup()
    {
        utils = new NumberUtils();
    }

    [TestCase(2, true)]
    [TestCase(4, true)]
    [TestCase(6, true)]
    [TestCase(7, false)]
    [TestCase(9, false)]
    public void IsEven_TestCases(int number, bool expected)
    {
        bool result = utils.IsEven(number);
        Assert.AreEqual(expected, result);
    }
}
