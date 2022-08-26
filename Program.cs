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
// int n = Convert.ToInt32(Console.ReadLine().Trim());
//
// List<List<int>> arr = new List<List<int>>();
//
// for (int i = 0; i < n; i++)
// {
//     arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
// }
//
// int result = DiagonalDifference.Result(arr);
//
// Console.WriteLine(result);

#endregion

#region plusMinus
// int n = Convert.ToInt32(Console.ReadLine().Trim());
//
// List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
//
// PlusMinus.Result(arr);

#endregion

#region Staircase

// int n = Convert.ToInt32(Console.ReadLine().Trim());
//
// Staircase.Result(n);

#endregion

#region MiniMaxSum
// List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
//
// MiniMaxSum.Result(arr);

#endregion

#region BirthdayCakeCandles

// int candlesCount = Convert.ToInt32(Console.ReadLine().Trim());
//
// List<int> candles = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(candlesTemp => Convert.ToInt32(candlesTemp)).ToList();
//
// int result = BirthdayCakeCandles.Result(candles);
//
// Console.WriteLine(result);

#endregion

#region TimeConversion

// string s = Console.ReadLine();
//
// string result = TimeConversion.Result(s);
//
// Console.WriteLine(result);

#endregion

#region ItarateIt

// int aCount = Convert.ToInt32(Console.ReadLine().Trim());
//
// List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();
//
// int result = IterateIt.Result(a);
//
// Console.WriteLine(result);

#endregion

#region GradingStudents
int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

List<int> grades = new List<int>();

for (int i = 0; i < gradesCount; i++)
{
    int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
    grades.Add(gradesItem);
}

List<int> result = GradingStudents.Result(grades);

Console.WriteLine(String.Join("\n", result));
#endregion

#region CountApplesAndOranges
string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

int s = Convert.ToInt32(firstMultipleInput[0]);

int t = Convert.ToInt32(firstMultipleInput[1]);

string[] secondMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

int a = Convert.ToInt32(secondMultipleInput[0]);

int b = Convert.ToInt32(secondMultipleInput[1]);

string[] thirdMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

int m = Convert.ToInt32(thirdMultipleInput[0]);

int n = Convert.ToInt32(thirdMultipleInput[1]);

List<int> apples = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(applesTemp => Convert.ToInt32(applesTemp)).ToList();

List<int> oranges = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(orangesTemp => Convert.ToInt32(orangesTemp)).ToList();

CountApplesAndOranges.Result(s, t, a, b, apples, oranges);


#endregion