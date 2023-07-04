// ROMAN NUMERALS TO INTEGERS

// ---------- MY SOLUTION ----------
public class RomanSolution {
    public int RomanToInt(string s) {
        int totalVal = 0;
        Dictionary<string, int> romanVals = new Dictionary<string, int>
        {
            {"i", 1},
            {"v", 5},
            {"x", 10},
            {"l", 50},
            {"c", 100},
            {"d", 500},
            {"m", 1000},
        };

        for (int i = 0; i < s.Length; i++)
        {
            string currentRomanNum = s[i].ToString().ToLower();
            bool nextRomanNumExists = false;
            string nextRomanNum = "";

            if (i < s.Length - 1) //cannot determine a next roman num when at the end of the string
            {
                nextRomanNum = s[i + 1].ToString().ToLower();
                nextRomanNumExists = true;
            }

            if (nextRomanNumExists)
            {
                //need to increment i by 2 instead of just 1 since we no longer need to look at that follwing char
                if (currentRomanNum == "i" && nextRomanNum == "v")
                {
                    totalVal = totalVal + 4;
                    i = i + 1;
                }
                else if (currentRomanNum == "i" && nextRomanNum == "x")
                {
                    totalVal = totalVal + 9;
                    i = i + 1;
                }
                else if (currentRomanNum == "x" && nextRomanNum == "l")
                {
                    totalVal = totalVal + 40;
                    i = i + 1;
                }
                else if (currentRomanNum == "x" && nextRomanNum == "c")
                {
                    totalVal = totalVal + 90;
                    i = i + 1;
                }
                else if (currentRomanNum == "c" && nextRomanNum == "d")
                {
                    totalVal = totalVal + 400;
                    i = i + 1;
                }
                else if (currentRomanNum == "c" && nextRomanNum == "m")
                {
                    totalVal = totalVal + 900;
                    i = i + 1;
                }
                else 
                {
                    totalVal = totalVal + romanVals[currentRomanNum];
                }
            }
            else 
            {
                totalVal = totalVal + romanVals[currentRomanNum];
            }
        }

        return totalVal;
    }

    // ---------- OTHER SOLUTION ----------
    public int RomanToInt_2(string s) {
        var map = new Dictionary<char, int>();
            map.Add('I', 1);
            map.Add('V', 5);
            map.Add('X', 10);
            map.Add('L', 50);
            map.Add('C', 100);
            map.Add('D', 500);
            map.Add('M', 1000);

        int sum = 0;
        int last = 0;
        
        for (int i = s.Length - 1; i >= 0; i--)
        {
            int current = map[s[i]];

            if ( current < last)
            {
                sum -= current;
            }
            else
            {
                sum += current;
            }

            last = current;
        }

        return sum;
    }
}

// ---------- NOTES/THOUGHTS -----------
// I thought about this in a very human way ie. how I would calculate a roman numeral as a human
// That means reading from L to R, adding and subtracting when necessary
// I did briefly think about the idea of reading it R to L and starting the for loop the other way
// But I wanted to commit to what I was trying
// Maybe I should've given it more thought before going forward with the L to R approach
// But that's iteration no?
// I'm not necessarily happy with my solution
// It's not DRY