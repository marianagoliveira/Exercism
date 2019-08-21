using System;
using System.Collections.Generic;
using System.Linq;

public static class Acronym
{
    public static string Abbreviate(string phrase) =>
        string.Join(string.Empty, phrase.Split(new[] { ' ' , '-' , '_' }, StringSplitOptions.RemoveEmptyEntries).Select(s => char.ToUpper(s[0])));
}