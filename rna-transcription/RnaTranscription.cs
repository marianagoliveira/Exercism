using System;
using System.Collections.Generic;
using System.Linq;

public static class RnaTranscription
{
    public static string ToRna(string nucleotide)
    {
        var dict = new Dictionary<char, char>
        {
            { 'G', 'C' },
            { 'C', 'G' },
            { 'T', 'A' },
            { 'A', 'U' }
        };

        return nucleotide.Aggregate("", (k, v) => k + dict[v]);
    }
}