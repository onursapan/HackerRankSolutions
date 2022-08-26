namespace HackerRankSolutions;

public class MiniMaxSum
{
    public static void Result(List<int> arr)
    {
        long sum = 0;
        long min = long.MaxValue; 
        long max = long.MinValue;
        List<long> result = new List<long>();

        for (int i = 0; i < 5 ; i++)
        {
            sum += arr[i];
            min = Math.Min(min, arr[i]);
            max = Math.Max(max, arr[i]);
        }

        Console.WriteLine($"{sum-max} {sum-min}");
    }

}