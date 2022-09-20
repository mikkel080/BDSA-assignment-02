namespace Assignment2;

using System.Text.RegularExpressions;

public static class Extensions
{
    public static bool IsSecure(this Uri uri) => 
        uri.Scheme == "https"? true: false;

    public static int WordCount(this string stream) => 
        Regex.Matches(stream, @"\p{L}+").Count;

    public static IEnumerable<T> Flatten<T>(this IEnumerable<IEnumerable<T>> stream) => 
        stream.SelectMany(x => x);

    public static IEnumerable<int> Divisible(this IEnumerable<int> stream) =>
        stream.Where(x => x % 7 == 0 && x > 42);

    public static IEnumerable<int> WhereLeapYears(this IEnumerable<int> stream) => 
        stream.Where(x => x % 4 == 0 && (!(x % 100 == 0) || x % 400 == 0));
}
