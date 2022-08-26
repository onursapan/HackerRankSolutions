namespace HackerRankSolutions;

public class BirthdayCakeCandles
{
    public static int Result(List<int> candles)
    {
        int maxCandle = candles.Max();
        int sumCandle = 0;

        for (int i = 0; i < candles.Count; i++)
        {
            if (maxCandle == candles[i])
            {
                sumCandle++;
            }
        }

        return sumCandle;
    }
}