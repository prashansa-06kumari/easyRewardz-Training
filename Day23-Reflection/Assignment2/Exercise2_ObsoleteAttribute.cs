using System;

public class LegacyAPI
{
    [Obsolete("OldFeature is deprecated. Use NewFeature instead.")]
    public void OldFeature()
    {
        Console.WriteLine("Old feature executed.");
    }

    public void NewFeature()
    {
        Console.WriteLine("New feature executed.");
    }
}

public class Exercise2
{
    public static void Run()
    {
        Console.WriteLine("===== Exercise 2: Obsolete Attribute =====");

        LegacyAPI api = new LegacyAPI();

#pragma warning disable CS0618

        api.OldFeature();

#pragma warning restore CS0618

        api.NewFeature();
    }
}