namespace HackerRankSolutions;

public class IterateIt
{
    public static int Result(List<int> a)
    {
        var rep = 0;
        if ( a.Count >= 1 && a.Count <= Math.Pow(10.0,5.0))
        {
            while (a.Count > 0)
            {
                var b = new List<int>();
                foreach (var x in a)
                {
                    if (x >= 1 && x <= 5*(int)Math.Pow(10.0,4.0))
                    {
                        foreach (var y in a)
                        {
                            if (x != y)
                            {
                                b.Add((int)Math.Abs((decimal)(x - y)));
                            }
                        }
                        
                    }
                    
                }

                a = b;
                rep++;
                
            }
            
        }

        return rep;
    }
}