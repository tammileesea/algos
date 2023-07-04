// LeetCode: LONGEST SUBSTRING WITHOUT REPEATING CHARACTERS

public class LengthOfLongestSubstringSolution {
    // ---------- MY SOLUTION ----------
    // Runtime: 120ms
    // Memory: 39.5MB
    public int LengthOfLongestSubstring(string s) {
        if (s.Length == 0) return 0;
        if (s.Length == 1) return 1;

        int longestSubstring = 0;
        int count = 0;
        Dictionary<char, int> uniqueChars = new Dictionary<char, int>();

        for (int i = 0; i < s.Length; i++)
        {
            if (!uniqueChars.ContainsKey(s[i]))
            {
                uniqueChars.Add(s[i], 1);
                count++;
            }
            else if (uniqueChars.ContainsKey(s[i]))
            {
                uniqueChars.Clear();

                if (count > longestSubstring) longestSubstring = count;

                if (s[i] != s[i - 1])
                {
                    i = i - count;
                }
                else
                {
                    i--;
                }

                count = 0;
            }
        }

        if (longestSubstring < count)
        {
            return count;
        }
        
        return longestSubstring;
    }


    // ---------- OTHER SOLUTION ----------
    public int LengthOfLongestSubstring_2(string s) {
        Dictionary<char,int> set = new Dictionary<char,int>();
        int maxSub = 0;
        
        for (int i = 0; i < s.Length; i++)
        {
            char c = s[i]; //the char

            if (!set.ContainsKey(c))
            {
                set.Add(c, i); // add the char and index if it doesnt exist in the set 
                maxSub = Math.Max(set.Count, maxSub); //maxSub value is either the count of the set or the maxSub
            }
            else
            {
                i = set[c]; //go to the index of this char, wouldnt it be the first occurence of this char?
                set.Clear();
            }
        }

        return maxSub;      
    }

    // #2
    // Time Complexity: O(n)
    // Space Complexity: O(min(n, m))

    public int LengthOfLongestSubstring_3(string s) {
        var charSet = new HashSet<char>();
        int left = 0, right = 0, maxLength = 0;

        while(right < s.Length)
        {
            if (!charSet.Contains(s[right]))
            {
                charSet.Add(s[right]);
                right++;
                maxLength = Math.Max(maxLength, charSet.Count);
            }
            else
            {
                charSet.Remove(s[left]);
                left++;
            }
        }

        return maxLength;
    }
}

// "dvdf"
// left = 0, 0, 0, 1, 1, 1
// right = 0, 1, 2, 2, 3, 4
// maxLength = 0, 1, 2, 1, 2, 3
// set = ['v', 'd', 'f']

// ---------- NOTES/THOUGHTS -----------
// Other solution #2 uses sliding window which is 
// a computational technique to reduce the use of nested for loops for just a single for loop.
// A reduction in time complexity