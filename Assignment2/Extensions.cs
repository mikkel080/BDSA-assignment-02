namespace Assignment2;

using System.Text.RegularExpressions;

public static class Extensions
{
    public static bool IsSecure(this Uri uri) => 
        uri.Scheme == "https"? true: false;

    public static int WordCount(this string stream) => 
        Regex.Matches(stream, @"\p{L}+").Count;
}
