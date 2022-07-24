namespace HackerRankSolutions;

public static class VeryBigSum
{
    public static long Result(List<long> ar)
    {
        long sum = 0;
        if (ar.Count is >= 1 and <= 10)
        {
            for (int i = 0; i < ar.Count; i++)
            {
                if (ar[i] >= 0 && ar[i] <= (long)Math.Pow(10.0, 10.0))
                {
                    sum += ar[i];
                }
            }
        }

        return sum;
    }
}