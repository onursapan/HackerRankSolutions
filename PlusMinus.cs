namespace HackerRankSolutions;

public class PlusMinus
{
    public static void Result(List<int> arr)
    {
        int posCount = 0;
        int negCount = 0;
        int zeroCount = 0;
        
        for (int i =0; i < arr.Count; i++)
        {
            if (arr[i] > 0)
            {
                posCount++;
            }
            else if (arr[i] < 0)
            {
                negCount++;
            }
            else
            {
                zeroCount++;
            }
        }
        
        double posRatio = (double)posCount/arr.Count;
        double negRatio = (double)negCount/arr.Count;
        double zeroRatio = (double)zeroCount/arr.Count;
        
        Console.WriteLine(posRatio);
        Console.WriteLine(negRatio);
        Console.WriteLine(zeroRatio);
    }
}