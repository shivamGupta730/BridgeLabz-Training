using NUnit.Framework;

[TestFixture]
public class PasswordValidatorTests
{
    PasswordValidator validator;

    [SetUp]
    public void Setup()
    {
        validator = new PasswordValidator();
    }

    [Test]
    public void ValidPassword_Test()
    {
        bool result = validator.IsValid("Test1234");
        Assert.IsTrue(result);
    }

    [Test]
    public void Password_TooShort_Test()
    {
        bool result = validator.IsValid("Ab12");
        Assert.IsFalse(result);
    }

    [Test]
    public void Password_NoUppercase_Test()
    {
        bool result = validator.IsValid("test1234");
        Assert.IsFalse(result);
    }

    [Test]
    public void Password_NoDigit_Test()
    {
        bool result = validator.IsValid("Password");
        Assert.IsFalse(result);
    }
}
