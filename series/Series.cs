using System;
using System.Collections.Generic;

public static class Series
{
    public static string[] Slices(string numbers, int sliceLength)
    {
        if (sliceLength > numbers.Length || numbers.Length == 0 || sliceLength <= 0)
        {
            throw new ArgumentException("Invalid input");
        }

        string[] slices = new string[numbers.Length - sliceLength + 1];
        for (int i = 0; i <= numbers.Length - sliceLength; i++)
        {
            slices[i] = numbers.Substring(i, sliceLength);
        }

        return slices;
    }
}