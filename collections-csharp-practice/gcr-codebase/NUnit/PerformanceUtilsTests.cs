using NUnit.Framework;

[TestFixture]
public class PerformanceUtilsTests
{
    PerformanceUtils utils;

    [SetUp]
    public void Setup()
    {
        utils = new PerformanceUtils();
    }

    [Test]
    [Timeout(2000)]
    public void LongRunningTask_ShouldFail_IfTooSlow()
    {
        utils.LongRunningTask();
    }
}
