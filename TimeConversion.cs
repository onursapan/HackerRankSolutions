using System.Globalization;

namespace HackerRankSolutions;

public class TimeConversion
{
    public static string Result(string s)
    {
        DateTime dt = DateTime.ParseExact(
                    s, 
                    "hh:mm:sstt", 
                    CultureInfo.InvariantCulture);   
        return $"{dt:HH:mm:ss}";
    }
}