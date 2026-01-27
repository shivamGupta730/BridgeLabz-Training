using NUnit.Framework;
using System;

[TestFixture]
public class UserRegistrationTests
{
    UserRegistration user;

    [SetUp]
    public void Setup()
    {
        user = new UserRegistration();
    }

    [Test]
    public void ValidUserRegistration_Test()
    {
        Assert.DoesNotThrow(() =>
        {
            user.RegisterUser("shivam", "shivam@gmail.com", "Pass1234");
        });
    }

    [Test]
    public void EmptyUsername_ShouldThrowException()
    {
        Assert.Throws<ArgumentException>(() =>
        {
            user.RegisterUser("", "test@gmail.com", "Pass1234");
        });
    }

    [Test]
    public void EmptyEmail_ShouldThrowException()
    {
        Assert.Throws<ArgumentException>(() =>
        {
            user.RegisterUser("shivam", "", "Pass1234");
        });
    }

    [Test]
    public void EmptyPassword_ShouldThrowException()
    {
        Assert.Throws<ArgumentException>(() =>
        {
            user.RegisterUser("shivam", "test@gmail.com", "");
        });
    }
}
