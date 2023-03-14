using System;

public static class Fibonacci
{
    public static int[] FibonacciArray(int n)
    {
        int[] fib = new int[] { 0, 1 };
        while (fib[fib.Length - 1] < n)
        {
            Array.Resize(ref fib, fib.Length + 1);
            fib[fib.Length - 1] = fib[fib.Length - 2] + fib[fib.Length - 3];
        }
        return fib;
    }

    public static bool PertenceFibonacci(int n)
    {
        int[] fib = FibonacciArray(n);
        return Array.IndexOf(fib, n) >= 0;
    }
}