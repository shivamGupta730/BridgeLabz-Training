using NUnit.Framework;
using System;

[TestFixture]
public class DateFormatterTests
{
    DateFormatter formatter;

    [SetUp]
    public void Setup()
    {
        formatter = new DateFormatter();
    }

    [Test]
    public void ValidDate_Test()
    {
        string result = formatter.FormatDate("2024-05-12");
        Assert.AreEqual("12-05-2024", result);
    }

    [Test]
    public void InvalidDate_ShouldThrowException()
    {
        Assert.Throws<FormatException>(() =>
        {
            formatter.FormatDate("12/05/2024");
        });
    }
}
