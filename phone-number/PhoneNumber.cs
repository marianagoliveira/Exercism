using System;
using System.Linq;
using System.Text.RegularExpressions;

public class PhoneNumber
{
    public static string Clean(string phoneNumber)
    {
        var numberMatch = Regex.Match(string.Concat(phoneNumber.Where(char.IsDigit)), @"^1?([2-9]\d\d[2-9]\d{6})$");
        return numberMatch.Success ? numberMatch.Groups[1].ToString() : throw new ArgumentException();
    }
}