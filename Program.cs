using HackerRankSolutions;

#region SolveMeFirst

// int val1 = Convert.ToInt32(Console.ReadLine());
// int val2 = Convert.ToInt32(Console.ReadLine());
// int sum = SolveMeFirst.Sum(val1,val2);
// Console.WriteLine(sum);

#endregion

#region SimpleArraySum

// Convert.ToInt32(Console.ReadLine()?.Trim());
//
// List<int> ar = Console.ReadLine()?.TrimEnd().Split(',').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();
//
// int result = SimpleArraySum.ArraySum(ar);
//
// Console.WriteLine(result);

#endregion

#region CompareTriplets
// List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();
//
// List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();
//
// List<int> result = CompareTriplets.Tara(a, b);
//
// Console.WriteLine(String.Join(" ", result));
#endregion

#region VeryBigSum
// int arCount = Convert.ToInt32(Console.ReadLine().Trim());
// List<long> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt64(arTemp)).ToList();
// long result = VeryBigSum.Result(ar);
// Console.WriteLine(result);
#endregion

#region diagonalDifference
int n = Convert.ToInt32(Console.ReadLine().Trim());

List<List<int>> arr = new List<List<int>>();

for (int i = 0; i < n; i++)
{
    arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
}

int result = DiagonalDifference.Result(arr);

Console.WriteLine(result);

#endregion

#region MyRegion

#endregion