﻿using System;
using System.Collections.Generic;
using System.Linq;

public enum Classification
{
    Perfect,
    Abundant,
    Deficient
}

public static class PerfectNumbers
{
    public static Classification Classify(int number)
    {
        if(number <= 0)
        {
            throw new ArgumentOutOfRangeException(number.ToString());
        }

        var sum = Enumerable.Range(1, number / 2).Where(x => number % x == 0).Sum();

        if (sum == number)
            return Classification.Perfect;

        return sum > number ? Classification.Abundant : Classification.Deficient;
    }
}
