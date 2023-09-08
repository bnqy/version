using System.Text.RegularExpressions;

namespace BnqLib;

public static class StringExpresions
{
    public static bool IsValidEmail(this string input)
    {
        return Regex.IsMatch(input, @"[a-zA-Z0-9\.-_]+@[a-zA-Z0-9\.-_]+");
    }
}
