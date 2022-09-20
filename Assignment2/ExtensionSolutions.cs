namespace Assignment2;

class ExtensionSolutions
{
    public static void extensionSolutions()
    {
        IEnumerable<int>[] xs = new[]
        {
            new List<int>{1,2,3},
            new List<int>{4,5,6}
        };
        int[] ys = { 200, 123, 123, 4, 15, 12, 4123, 53, 4, 23, 4, 32542, 35, 70, 82, 235, 23, 4, 234, 23, 43 };


        //flatten
        IEnumerable<int> flattened = xs.SelectMany(x => x);

        //divisible by 7 and greater than 42
        IEnumerable<int> divisible = ys.Where(x => x % 7 == 0 && x > 42);

        //leap years 
        IEnumerable<int> leapYears = ys.Where(x => x % 4 == 0 && (!(x % 100 == 0) || x % 400 == 0));
    }

}