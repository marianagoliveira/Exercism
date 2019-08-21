using System;
using System.Linq;

public static class Isogram
{
    public static bool IsIsogram(string word) => word.ToLower().Where(s => char.IsLetter(s)).Distinct().Count() == word.Count(s => char.IsLetter(s));
}
