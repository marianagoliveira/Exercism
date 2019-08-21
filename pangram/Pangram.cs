﻿using System;
using System.Linq;

public static class Pangram
{
    public static bool IsPangram(string input) => input.ToLower().Where(s => char.IsLetter(s)).Distinct().Count() == 26;
}
