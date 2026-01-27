using NUnit.Framework;

[TestFixture]
public class TemperatureConverterTests
{
    TemperatureConverter converter;

    [SetUp]
    public void Setup()
    {
        converter = new TemperatureConverter();
    }

    [Test]
    public void CelsiusToFahrenheit_Test()
    {
        double result = converter.CelsiusToFahrenheit(0);
        Assert.AreEqual(32, result);
    }

    [Test]
    public void FahrenheitToCelsius_Test()
    {
        double result = converter.FahrenheitToCelsius(32);
        Assert.AreEqual(0, result);
    }
}
