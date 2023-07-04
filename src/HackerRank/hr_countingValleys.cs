// COUNTING VALLEYS

public class CountingValleysSolution
{
    // ---------- MY SOLUTION ----------
    // U N F I N I S H E D!!!

    public static int countingValleys(int steps, string path)
        {
            //go thru the string aka hiker's steps and calculate the elevation
            //if elevation remains negative and later becomes positive, that counts as a valley
            //the elevation could be negative and not become positive meaning they never came out of the valley, sounds a little morbid
            
            if (steps == 2)
            {
                return 0;
            }
            
            //starting at sea level
            int elevation = 0;
            // bool inValley = false;
            int valleys = 0;
            
            // int startValley = 0;
            // int endValley = 0;
            
            for (int i = 0; i < path.Length; i++)
            {
                if (path[i].ToString() == "U")
                {
                    elevation++;
                }
                else 
                {
                    elevation--;
                }
                
                // elevationLevels.Add(elevation);
            }
            
            return valleys;
        }

    // ---------- OTHER SOLUTION ----------
    public static int countingValleys_2(int steps, string path) {
        var elevation = 0;
        var result = 0;

        for (int i = 0; i < path.Length; i++){
            if(elevation == 0 && path[i].ToString().ToLower() == "d") //
            {
                elevation--;
                result++;
            } 
            else if (path[i].ToString().ToLower() == "d")
            {
                elevation--;
            } 
            else 
            {
                elevation++;
            }
        }

        return result;
    }
}

// ---------- NOTES/THOUGHTS -----------
// I was right in keeping track of elevation bc that's the only way you can know whether or not you're in a valley.
// But again!! I was overcomplicating it, just needed to figure out the right conditions
// Calculate elevation when going up or down 
// Then count a valley when elevation is at 0 bc you're counting how many valleys you enter,
// doesn't matter when you leave one