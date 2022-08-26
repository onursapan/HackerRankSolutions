namespace HackerRankSolutions;

public class GradingStudents
{
    public static List<int> Result(List<int> grades)
    {
        var newGrades = new List<int>();
        foreach (var point in grades)
        {
            if (point > 37)
            {
                int a = point % 5;
                if (a > 2)
                {
                    newGrades.Add(point + (5 - a));
                }
                else
                {
                    newGrades.Add(point);
                }

            }
            else
            {
                newGrades.Add(point);
            }
            

        } 
            return newGrades;
    }
}