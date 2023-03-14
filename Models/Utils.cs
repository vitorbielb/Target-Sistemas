using System;

public static class Utils
{
    public static int ReadInt(string message)
    {
        Console.Write(message);
        return int.Parse(Console.ReadLine());
    }
}
