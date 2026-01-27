using NUnit.Framework;
using System.Collections.Generic;

[TestFixture]
public class ListManagerTests
{
    ListManager manager;
    List<int> list;

    [SetUp]
    public void Setup()
    {
        manager = new ListManager();
        list = new List<int>();
    }

    [Test]
    public void AddElement_Test()
    {
        manager.AddElement(list, 10);
        Assert.Contains(10, list);
    }

    [Test]
    public void RemoveElement_Test()
    {
        list.Add(5);
        manager.RemoveElement(list, 5);
        Assert.IsFalse(list.Contains(5));
    }

    [Test]
    public void GetSize_Test()
    {
        list.Add(1);
        list.Add(2);
        Assert.AreEqual(2, manager.GetSize(list));
    }
}
