using System;

class LegacyAPI
{
    [Obsolete("This method is outdated. Use NewFeature instead.")]
    public void OldFeature()
    {
        Console.WriteLine("Old Feature");
    }

    public void NewFeature()
    {
        Console.WriteLine("New Feature");
    }
}

class Program
{
    static void Main()
    {
        LegacyAPI api = new LegacyAPI();
        api.OldFeature();   // warning
        api.NewFeature();
    }
}
