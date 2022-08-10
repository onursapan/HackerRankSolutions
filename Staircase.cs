namespace HackerRankSolutions;

public class Staircase
{
    public static void Result(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            var space = new string(' ', n - i);
            var sharp = new string('#', i);
            Console.WriteLine(space + sharp);
        }
    
    }
}