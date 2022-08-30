namespace HackerRankSolutions;

public class CountApplesAndOranges
{
    public static void Result(int s, int t, int a, int b, List<int> apples, List<int> oranges)
    {
        int fallenApple = 0;
        int fallenOrange = 0;
        for (int i = 0; i < apples.Count; i++)
        {   
            apples[i] += a;
            if (apples[i] >= s && apples[i] <= t)
            {
                fallenApple++;
            }
        }

        for (int j = 0; j < oranges.Count; j++)
        {   
            oranges[j] += b;
            if (oranges[j] <= t && oranges[j] >= s)
            {
                fallenOrange++;
            }
        }
        
        Console.WriteLine(fallenApple);
        Console.WriteLine(fallenOrange);



    }

}