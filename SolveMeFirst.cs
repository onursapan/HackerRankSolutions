namespace HackerRankSolutions;

public static class SolveMeFirst
{
    public static int Sum(int a, int b)
    {
        int sum = 0;
        if (a is >= 1 and <= 1000 && b is >= 1 and <= 1000)
        {
            sum = a + b;
        }

        return sum;
    }
    

}