namespace HackerRankSolutions;

public static class DiagonalDifference
{
    public static int Result(List<List<int>> arr)
    {
        int left = 0;
        int right = 0;
        int y = arr.Count-1;
        for (int i = 0; i < arr[0].Count; i++)
        {
            left += arr[i][i];
            right += arr[y][i];
            y--;
        }
        
        return Math.Abs(left - right);
    }
}