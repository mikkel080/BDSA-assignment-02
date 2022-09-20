namespace Assignment2;

using System.Text.RegularExpressions;

public class AnonymousFunctions
{
    public static Action<string> printReverse = s =>
    {
        var array = s.OrderByDescending(s => s).ToArray();
        Console.WriteLine(string.Join("", array));
    };

    public static Func<decimal, decimal, decimal> product = (x, y) =>
        x * y;

    public static Func<string, int, bool> isEqual = (s, x) =>
    {
        var match = Regex.Match(s, @"[1-9]+[0-9]*").ToString();
        return int.Parse(match) == x;
    };

}