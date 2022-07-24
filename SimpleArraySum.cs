namespace HackerRankSolutions;

public static class SimpleArraySum
{
    public static int ArraySum(List<int> ar)
    {
        int sum = 0;
        if (ar.Count is <= 1000 and > 0)
        {
            foreach (var item in ar)
            {
                if (item is >0 and <=1000)
                {
                    sum += item;
                }
            }
        }
        return sum;
    }
}