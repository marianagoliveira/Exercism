using System;

public static class Grains
{
    public static ulong Square(int n)
    {
        if(n <= 0 || n > 64)
        {
            throw new ArgumentOutOfRangeException(n.ToString());
        }
        else return (ulong)Math.Pow(2.0, n - 1);
    }

    public static ulong Total() => (ulong)Math.Pow(2.0, 64) - 1;
}