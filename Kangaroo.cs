namespace HackerRankSolutions;

public class Kangaroo
{
    public static string Result(int x1, int v1, int x2, int v2)
    {
        double value;
        value = (double)(x1 - x2) / (v2 - v1);
        
        if (value is > 0)
        {
            if (value % 1 == 0)
            {
                return "YES";
            }
        }

        return "NO";
    }
}