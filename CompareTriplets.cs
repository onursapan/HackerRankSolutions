namespace HackerRankSolutions;

public static class CompareTriplets
{
    public static List<int> Tara(List<int> a, List<int> b)
    {
        var bob = 0;
        var alice = 0;
        var result = new List<int>();

        for (int i = 0; i < a.Count; i++)
        {
            var itemA = a[i];
            var itemB = b[i];
            
            if (itemA is > 0 and <= 100 && itemB is > 0 and <= 100)
            {
                if (itemA > itemB)
                    alice++;
                else if (itemB > itemA)
                    bob++;
            }
        }

        result.Add(alice);
        result.Add(bob);
        return result;
    }
}