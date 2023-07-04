// JUMPING ON THE CLOUDS

public class JumpingOnTheCloudsSolution
{
    // ---------- MY SOLUTION ----------
    public static int jumpingOnClouds(List<int> c)
    {
        //0 is good
        //1 is bad
        
        var jumps = 0;
        
        if (c.Count == 2)
        {
            return 1;
        }
        
        for (int i = 1; i < c.Count; i++)
        {
            if ((i < c.Count - 1) 
                && ((c[i] == 1 && c[i + 1] == 0) || (c [i] == 0 && c[i + 1] == 0)))
            {
                jumps++;
                i++;
            }
            else if ((i < c.Count - 1) 
                && (c [i] == 0 && c[i + 1] == 1))
            {
                jumps++;
            }
            else if (c[i] == 0)
            {
                jumps++;
            }
        }
        
        return jumps;
    }

    // ---------- OTHER SOLUTION ----------
}


// ---------- NOTES/THOUGHTS -----------