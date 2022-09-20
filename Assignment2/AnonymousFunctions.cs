namespace Assignment2;

using System.Text.RegularExpressions;

public class AnonymousFunctions
{
    public static void printReverse(string s)
    {
        Action<string> printReverse = s =>
        {
            var array = s.OrderByDescending(s => s).ToArray();
            Console.WriteLine(string.Join("", array));
        };
        printReverse(s);
    }

    public static decimal product(decimal x, decimal y)
    {
        Func<decimal, decimal, decimal> product = (x, y) =>
            x * y;
        return product(x, y);
    }

    public static bool isEqual(string s, int x)
    {
        Func<string, int, bool> isEqual = (s, x) =>
        {
            var match = Regex.Match(s, @"[1-9]+[0-9]*").ToString();
            return int.Parse(match) == x;
        };
        return isEqual(s, x);
    }

}