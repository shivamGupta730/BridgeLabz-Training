using System.Threading;

public class PerformanceUtils
{
    public void LongRunningTask()
    {
        // 3 second ka delay
        Thread.Sleep(3000);
    }
}
