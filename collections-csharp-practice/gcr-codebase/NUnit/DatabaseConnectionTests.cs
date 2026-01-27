using NUnit.Framework;

[TestFixture]
public class DatabaseConnectionTests
{
    DatabaseConnection db;

    [SetUp]
    public void Setup()
    {
        db = new DatabaseConnection();
        db.Connect();
    }

    [TearDown]
    public void TearDown()
    {
        db.Disconnect();
    }

    [Test]
    public void Database_ShouldBeConnected()
    {
        Assert.IsTrue(db.IsConnected);
    }
}
