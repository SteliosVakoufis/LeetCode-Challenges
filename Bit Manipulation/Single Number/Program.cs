using Single_Number;

internal class Program
{
    private static void Main(string[] args)
    {
        Solution solver = new();

        System.Console.WriteLine(solver.SingleNumber(new int[] {4, 1, 2, 1, 2}));
    }
}
